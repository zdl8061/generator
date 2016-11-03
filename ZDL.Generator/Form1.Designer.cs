namespace ZDL.Generator
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dbObjList = new System.Windows.Forms.ListBox();
            this.tbAjax = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbView = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbEntity = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbDB = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tbAjax.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.toolStripDropDownButton1,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(984, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(81, 22);
            this.toolStripDropDownButton1.Text = "选择数据库";
            this.toolStripDropDownButton1.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripDropDownButton1_DropDownItemClicked);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(5, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dbObjList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbAjax);
            this.splitContainer1.Size = new System.Drawing.Size(979, 534);
            this.splitContainer1.SplitterDistance = 218;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            // 
            // dbObjList
            // 
            this.dbObjList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbObjList.FormattingEnabled = true;
            this.dbObjList.ItemHeight = 12;
            this.dbObjList.Location = new System.Drawing.Point(0, 0);
            this.dbObjList.Name = "dbObjList";
            this.dbObjList.Size = new System.Drawing.Size(218, 534);
            this.dbObjList.TabIndex = 0;
            this.dbObjList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dbObjList_MouseClick);
            // 
            // tbAjax
            // 
            this.tbAjax.Controls.Add(this.tabPage1);
            this.tbAjax.Controls.Add(this.tabPage2);
            this.tbAjax.Controls.Add(this.tabPage3);
            this.tbAjax.Controls.Add(this.tabPage4);
            this.tbAjax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAjax.Location = new System.Drawing.Point(0, 0);
            this.tbAjax.Name = "tbAjax";
            this.tbAjax.Padding = new System.Drawing.Point(0, 0);
            this.tbAjax.SelectedIndex = 0;
            this.tbAjax.Size = new System.Drawing.Size(756, 534);
            this.tbAjax.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(748, 508);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "视图";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbView
            // 
            this.tbView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbView.Location = new System.Drawing.Point(3, 3);
            this.tbView.Name = "tbView";
            this.tbView.Size = new System.Drawing.Size(742, 502);
            this.tbView.TabIndex = 1;
            this.tbView.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbEntity);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(748, 508);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "实体";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbEntity
            // 
            this.tbEntity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEntity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbEntity.Location = new System.Drawing.Point(3, 3);
            this.tbEntity.Margin = new System.Windows.Forms.Padding(0);
            this.tbEntity.Name = "tbEntity";
            this.tbEntity.Size = new System.Drawing.Size(742, 502);
            this.tbEntity.TabIndex = 2;
            this.tbEntity.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tbDB);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(748, 508);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "数据库";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tbDB
            // 
            this.tbDB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDB.Location = new System.Drawing.Point(3, 3);
            this.tbDB.Margin = new System.Windows.Forms.Padding(0);
            this.tbDB.Name = "tbDB";
            this.tbDB.Size = new System.Drawing.Size(742, 502);
            this.tbDB.TabIndex = 2;
            this.tbDB.Text = "";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(748, 508);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Ajax";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "生成器";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tbAjax.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox dbObjList;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TabControl tbAjax;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox tbView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox tbEntity;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox tbDB;
        private System.Windows.Forms.TabPage tabPage4;
    }
}

