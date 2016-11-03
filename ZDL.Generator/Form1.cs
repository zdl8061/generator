using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZDL.Generator
{
    public partial class Form1 : Form
    {
        string dataBaseName = "";

        public Form1()
        {
            InitializeComponent();

            Txooo.Data.DatabaseConfig dbCfg = Txooo.Data.DatabaseConfig.Instance;

            foreach (var db in dbCfg.DataBaseList)
            {
                toolStripDropDownButton1.DropDownItems.Add(db.Key);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void dbObjList_MouseClick(object sender, MouseEventArgs e)
        {
            if (dbObjList.SelectedItem==null)
            {
                MessageBox.Show("请选择数据库");
                return;
            }
            DataTable dt;
            try
            {
                using (Txooo.TxDataHelper helper = Txooo.TxDataHelper.GetDataHelper(dataBaseName))
                {
                    var tbName = dbObjList.SelectedItem.ToString();
                    if (tbName.ToUpper().IndexOf("VIEW") == -1)
                    {
                        string sql = @"SELECT                    
                        fieldName = a.name,                  
                        fieldSummary =isnull(g.[value],''),
					    fieldType = b.name
                   
                        FROM dbo.syscolumns a  
					    left join dbo.systypes b on a.xusertype=b.xusertype                 
                        inner join dbo.sysobjects d on a.id=d.id and d.xtype='U' and d.name<>'dtproperties'                  
                        left join sys.extended_properties g on a.id=g.major_id and a.colid=g.minor_id                 
                        where d.name ='" + tbName + @"'";

                        dt = helper.SqlGetDataTable(sql);
                        dt.TableName = tbName;                        
                    }
                    else
                    {
                        string sql = @"SELECT                    
                        fieldName = a.name,                  
                        fieldSummary =isnull(g.[value],''),
					    fieldType = b.name
                   
                        FROM dbo.syscolumns a  
					    left join dbo.systypes b on a.xusertype=b.xusertype                 
                        inner join dbo.sysobjects d on a.id=d.id and d.xtype='V' and d.name<>'dtproperties'                  
                        left join sys.extended_properties g on a.id=g.major_id and a.colid=g.minor_id                 
                        where d.name ='" + tbName + @"'";

                        dt = helper.SqlGetDataTable(sql);
                        dt.TableName = tbName;

                        InitViewCode(dt);
                        InitEntityCode(dt);
                    }
                }

                INIT(dt);

            }
            catch
            {
                MessageBox.Show("获取数据错误");
            }
        }

        public void INIT(DataTable dt)
        {
            InitViewCode(dt);
            InitEntityCode(dt);
            InitDBCode(dt);
        }

        private void InitDBCode(DataTable dt)
        {
            StringBuilder _code = new StringBuilder();
            _code.Append("---------应用于添加和更新--------\r\n\r\n");
            _code.Append(string.Format("using (Txooo.TxDataHelper helper = Txooo.TxDataHelper.GetDataHelper(\"{0}\"))\r\n",this.toolStripLabel1.Text));
            _code.Append("{\r\n");

            foreach(DataRow dr in dt.Rows)
            {
                _code.Append(string.Format("\thelper.SpFileValue[\"@{0}\"] = {1};\r\n", dr["fieldName"].ToString(), dt.TableName + "Info." + GetFormatName(dr["fieldName"].ToString())));
            }
            _code.Append("\r\n");

            _code.Append(string.Format("\treturn helper.SpExecute(\"{0}\");\r\n","SP_Insert"+dt.TableName));
            _code.Append("}\r\n");
           

            _code.Append("\r\n\r\n---------添加存储过程--------\r\n\r\n"); 

            _code.Append(string.Format("INSERT INTO [dbo].[{0}]\r\n",dt.TableName));
            _code.Append("(");
            foreach (DataRow dr in dt.Rows)
            {
                _code.Append("[" + dr["fieldName"].ToString() + "] ,");
            }
            _code.Remove(_code.Length-1, 1);
            _code.Append(")\r\n");

            _code.Append(" VALUES(");
            foreach (DataRow dr in dt.Rows)
            {
                _code.Append("@" + dr["fieldName"].ToString() + " ,");
            }
            _code.Remove(_code.Length - 1, 1);
            _code.Append(")\r\n");



            _code.Append("\r\n\r\n---------更新存储过程--------\r\n\r\n");


            _code.Append(string.Format("UPDATE [dbo].[{0}]\r\n", dt.TableName));
            _code.Append(" SET");
            foreach (DataRow dr in dt.Rows)
            {
                _code.Append(" [" + dr["fieldName"].ToString() + "]=@"+dr["fieldName"].ToString()+" ,");
            }
            _code.Remove(_code.Length - 1, 1);
            _code.Append("\r\n");

            _code.Append(" WHERE ");
           
            _code.Append("\r\n");


            this.tbDB.Text=_code.ToString();
        }

        private void InitAjaxCode(DataTable dt)
        { 
            
        }

        //private void InitEntityCode(DataTable dt)
        //{
        //    StringBuilder _privateField = new StringBuilder();
        //    StringBuilder _property = new StringBuilder();

        //    _privateField.Append("#region 字段\r\n\r\n");
        //    _property.Append("#region 属性\r\n\r\n");

        //    int i = 0;
        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        var fieldName = dr["fieldName"].ToString();
        //        char ch = fieldName[0];
        //        if (char.IsLower(ch)) i++;
        //        //if (ch >= 65 && ch <= 90) MessageBox.Show("您输入的是大写字母！");
        //        //else if (ch >= 97 && ch <= 122) MessageBox.Show("您输入的是小写字母！");               
        //    }

        //    string className = "public class " + GetFormatName(dt.TableName) + "\r\n{\r\n";

        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        var fieldName = dr["fieldName"].ToString();
        //        var fieldSummary = dr["fieldSummary"].ToString();
        //        var fieldType = GetNetType(dr["fieldType"].ToString());

        //        string properName = i > 3 ? GetFormatName(fieldName) : fieldName;
        //        string extName = GetExtName(properName);
        //        string privateName = GetPrivateName(extName);

        //        _privateField.Append(string.Format("private {0} {1};\r\n\r\n", fieldType, privateName));

        //        _property.Append("/// <summary>\r\n");
        //        _property.Append("/// " + fieldSummary + "\r\n");
        //        _property.Append("/// </summary>");

        //        _property.Append("\r\n");

        //        //_property.Append(" private "+fieldType+" " + privateName + ";\r\n");

        //        //fieldStr += "[ExtColumnModel(\""+fieldSummary+"\", \"" + extName + "\", true)]\r\n";

        //        _property.Append("public " + fieldType + " " + properName + "\r\n");

        //        _property.Append("{\r\n");

        //        _property.Append("\tget { return " + privateName + "; }\r\n");

        //        _property.Append("\tset { " + privateName + " = value; }\r\n");

        //        _property.Append("}\r\n\r\n");
        //    }
        //    _privateField.Append("#endregion");
        //    _property.Append("#endregion");

        //    tbEntity.Text = className + _privateField + "\r\n\r\n" + _property + "\r\n}";
        //}

        private void InitEntityCode(DataTable dt)
        {
            StringBuilder _privateField = new StringBuilder();
            StringBuilder _property = new StringBuilder();

            _privateField.Append("#region 字段\r\n\r\n");
            _property.Append("#region 属性\r\n\r\n");

            int i = 0;
            foreach (DataRow dr in dt.Rows)
            {
                var fieldName = dr["fieldName"].ToString();
                char ch = fieldName[0];
                if (char.IsLower(ch)) i++;
                //if (ch >= 65 && ch <= 90) MessageBox.Show("您输入的是大写字母！");
                //else if (ch >= 97 && ch <= 122) MessageBox.Show("您输入的是小写字母！");               
            }
            string classAttr = "[TxTable(Name = \"" + dt.TableName + "\", Base = \"" + dataBaseName + "\")]\r\n";
            string className = "public class " + GetFormatName(dt.TableName) + "\r\n{\r\n";

            foreach (DataRow dr in dt.Rows)
            {
                var fieldName = dr["fieldName"].ToString();
                var fieldSummary = dr["fieldSummary"].ToString();
                var fieldType = GetNetType(dr["fieldType"].ToString());

                string properName = i > 3 ? GetFormatName(fieldName) : fieldName;
                string extName = GetExtName(properName);
                string privateName = GetPrivateName(extName);

                _privateField.Append(string.Format("private {0} {1};\r\n\r\n", fieldType, privateName));

                _property.Append("/// <summary>\r\n");
                _property.Append("/// " + fieldSummary + "\r\n");
                _property.Append("/// </summary>");

                _property.Append("\r\n");

                //_property.Append(" private "+fieldType+" " + privateName + ";\r\n");

                //fieldStr += "[ExtColumnModel(\""+fieldSummary+"\", \"" + extName + "\", true)]\r\n";

                _property.Append("[Column(Name = \"" + fieldName + "\")]\r\n");

                _property.Append("public " + fieldType + " " + properName);

                _property.Append("{ ");

                _property.Append(" get;set;");

                _property.Append("}\r\n\r\n");
            }
            _privateField.Append("#endregion");
            _property.Append("#endregion");

            tbEntity.Text =classAttr+ className + "\r\n\r\n" + _property + "\r\n}";
        }

        private void InitViewCode(DataTable dt)
        {
            StringBuilder _code = new StringBuilder();
            _code.Append("SELECT ");

            int i = 0;
            foreach (DataRow dr in dt.Rows)
            {
                var fieldName = dr["fieldName"].ToString();
                char ch = fieldName[0];
                if (char.IsLower(ch)) i++;
                //if (ch >= 65 && ch <= 90) MessageBox.Show("您输入的是大写字母！");
                //else if (ch >= 97 && ch <= 122) MessageBox.Show("您输入的是小写字母！");               
            }

            string fieldStr = "";
            foreach (DataRow dr in dt.Rows)
            {
                var fieldName = dr["fieldName"].ToString();

                fieldStr += i > 3 ? "[" + fieldName + "] as " + GetFormatName(fieldName) + "," : "[" + fieldName + "] ,";
            }
            _code.Append(fieldStr.TrimEnd(','));
            _code.Append("\r\n FROM [dbo].[" + dt.TableName + "]");

            this.tbView.Text = _code.ToString();
        }

        private string GetFormatName(string fieldName)
        {
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo; 
            var split = fieldName.Split('_');
            return myTI.ToTitleCase(fieldName).Replace("_", "");
        }

        private string GetExtName(string properName)
        {
            var s = properName[0].ToString().ToLower() + properName.Substring(1);
            return s;
        }

        private string GetPrivateName(string extName)
        {
            return "m_" + extName;
        }

        private string GetNetType(string p)
        {
            switch (p)
            { 
                case "nvarchar":
                    return "string";
                case "varchar":
                    return "string";
                case "bigint":
                    return "long";
                case "int":
                    return "int";
                case "tinyint":
                    return "int";
                case "smalldatetime":
                    return "DateTime";
                case "money":
                    return "double";
                case "decimal":
                    return "double";       
                case "bit":
                    return "bool";
                case "datetime":
                    return "DateTime";
                case "float":
                    return "double";
                case "numeric":
                    return "int";
                default :
                    return "string";
            }
        }

        private void toolStripDropDownButton1_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            dataBaseName = e.ClickedItem.Text;

            toolStripLabel1.Text = dataBaseName;

            DataTable dt;
            try
            {
                dbObjList.Items.Clear();
                using (Txooo.TxDataHelper helper = Txooo.TxDataHelper.GetDataHelper(dataBaseName))
                {
                    string sql = "Select Name FROM SysObjects Where XType='U' or XType='V' ORDER BY Name;";

                    dt = helper.SqlGetDataTable(sql);
                }
                foreach (DataRow dr in dt.Rows)
                {
                    dbObjList.Items.Add(dr["Name"].ToString());
                }
            }
            catch
            {
                MessageBox.Show("数据连接错误，请检查配置文件");
            }
        }
    }
}
