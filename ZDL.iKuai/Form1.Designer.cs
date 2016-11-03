namespace ZDL.iKuai
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
            this.tb_domain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_url = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rtb_result = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.comb_method = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_gwid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_partner = new System.Windows.Forms.TextBox();
            this.rtb_body = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_domain
            // 
            this.tb_domain.Location = new System.Drawing.Point(113, 50);
            this.tb_domain.Name = "tb_domain";
            this.tb_domain.Size = new System.Drawing.Size(104, 21);
            this.tb_domain.TabIndex = 0;
            this.tb_domain.Text = "58.83.148.32";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "远控服务器";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "请求地址";
            // 
            // tb_url
            // 
            this.tb_url.Location = new System.Drawing.Point(113, 88);
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(463, 21);
            this.tb_url.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "请求体";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(659, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "连接";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtb_result
            // 
            this.rtb_result.Location = new System.Drawing.Point(113, 430);
            this.rtb_result.Name = "rtb_result";
            this.rtb_result.Size = new System.Drawing.Size(621, 243);
            this.rtb_result.TabIndex = 9;
            this.rtb_result.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "返回结果";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "端口";
            // 
            // tb_port
            // 
            this.tb_port.Location = new System.Drawing.Point(258, 50);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(33, 21);
            this.tb_port.TabIndex = 12;
            this.tb_port.Text = "2048";
            // 
            // comb_method
            // 
            this.comb_method.FormattingEnabled = true;
            this.comb_method.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PUT",
            "PATCH",
            "DELETE"});
            this.comb_method.Location = new System.Drawing.Point(651, 88);
            this.comb_method.Name = "comb_method";
            this.comb_method.Size = new System.Drawing.Size(83, 20);
            this.comb_method.TabIndex = 13;
            this.comb_method.Text = "GET";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(616, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "方法";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "GWID";
            // 
            // tb_gwid
            // 
            this.tb_gwid.Location = new System.Drawing.Point(332, 50);
            this.tb_gwid.Name = "tb_gwid";
            this.tb_gwid.Size = new System.Drawing.Size(202, 21);
            this.tb_gwid.TabIndex = 16;
            this.tb_gwid.Text = "dc1048e7a583d33ab1b5d11a2db66bef";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(540, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "合作商";
            // 
            // tb_partner
            // 
            this.tb_partner.Location = new System.Drawing.Point(587, 50);
            this.tb_partner.Name = "tb_partner";
            this.tb_partner.Size = new System.Drawing.Size(147, 21);
            this.tb_partner.TabIndex = 18;
            this.tb_partner.Text = "2014070917481057440";
            // 
            // rtb_body
            // 
            this.rtb_body.Location = new System.Drawing.Point(113, 140);
            this.rtb_body.Multiline = true;
            this.rtb_body.Name = "rtb_body";
            this.rtb_body.Size = new System.Drawing.Size(621, 210);
            this.rtb_body.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 713);
            this.Controls.Add(this.rtb_body);
            this.Controls.Add(this.tb_partner);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_gwid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comb_method);
            this.Controls.Add(this.tb_port);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtb_result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_url);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_domain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "iKuai接口测试";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_domain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtb_result;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.ComboBox comb_method;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_gwid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_partner;
        private System.Windows.Forms.TextBox rtb_body;
    }
}

