using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZDL.iKuai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _partner = tb_partner.Text;
            string _gwid = tb_gwid.Text;
            string _server = tb_domain.Text;
            string _port = tb_port.Text;
            string _url = tb_url.Text.Replace("$GWID", _gwid).Replace("$PARTNERID", _partner);
            string _method = comb_method.Text;
            string _body = rtb_body.Text;

            rtb_result.Text = "";
            string _result=string.Empty;

            string url = string.Format("http://{0}:{1}{2}", _server, _port, _url);

            Action<HttpWebRequest> readHeader = req => 
            {
                req.Accept = "application/vnd.ikuai8.remote-access.v1+json";
            };

            Action<HttpWebRequest> writeHeader = req => 
            {
                req.Accept = "application/vnd.ikuai8.remote-access.v1+json";
                req.ContentType = "application/vnd.ikuai8.remote-access.v1+json";
            };

            HttpTools http = new HttpTools(url);

            try
            {
                switch (_method.ToUpper())
                {
                    case "GET":
                        http.SetHeader = readHeader;
                        _result = http.Get();
                        break;
                    case "POST":
                        http.SetHeader = writeHeader;
                        _result = http.Post(_body);
                        break;
                    case "PUT":
                        http.SetHeader = writeHeader;
                        _result = http.PUT(_body);
                        break;
                    case "PATCH":
                        http.SetHeader = writeHeader;
                        _result = http.Patch(_body);
                        break;
                    case "DELETE":
                        http.SetHeader = readHeader;
                        _result = http.DELETE();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                _result = ex.Message;
            }
            rtb_result.Text = _result;
        }
    }
}
