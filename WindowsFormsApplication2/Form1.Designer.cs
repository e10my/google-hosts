﻿namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.altertime = new System.Windows.Forms.Label();
            this.IsEnable = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.hostspath = new System.Windows.Forms.TextBox();
            this.websrc = new System.Windows.Forms.TextBox();
            this.hostsstart = new System.Windows.Forms.TextBox();
            this.hostsend = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gitsrc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "启动更新hosts";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "修改状态：";
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Location = new System.Drawing.Point(13, 91);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(328, 107);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "管理员权限：";
            // 
            // altertime
            // 
            this.altertime.AutoSize = true;
            this.altertime.Location = new System.Drawing.Point(172, 12);
            this.altertime.Name = "altertime";
            this.altertime.Size = new System.Drawing.Size(95, 12);
            this.altertime.TabIndex = 5;
            this.altertime.Text = "hosts更新时间：";
            // 
            // IsEnable
            // 
            this.IsEnable.AutoSize = true;
            this.IsEnable.Location = new System.Drawing.Point(13, 12);
            this.IsEnable.Name = "IsEnable";
            this.IsEnable.Size = new System.Drawing.Size(0, 12);
            this.IsEnable.TabIndex = 6;
            // 
            // state
            // 
            this.state.AllowDrop = true;
            this.state.Location = new System.Drawing.Point(12, 226);
            this.state.Multiline = true;
            this.state.Name = "state";
            this.state.ReadOnly = true;
            this.state.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.state.Size = new System.Drawing.Size(328, 60);
            this.state.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "执行进度：";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 13);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 16);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "hosts增加只读属性";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // hostspath
            // 
            this.hostspath.Location = new System.Drawing.Point(384, 76);
            this.hostspath.Name = "hostspath";
            this.hostspath.Size = new System.Drawing.Size(240, 21);
            this.hostspath.TabIndex = 13;
            this.hostspath.Text = "c:\\windows\\system32\\drivers\\etc\\HOSTS";
            // 
            // websrc
            // 
            this.websrc.Location = new System.Drawing.Point(384, 135);
            this.websrc.Name = "websrc";
            this.websrc.Size = new System.Drawing.Size(240, 21);
            this.websrc.TabIndex = 14;
            this.websrc.Text = "http://www.360kb.com/kb/2_150.html";
            this.websrc.Visible = false;
            this.websrc.TextChanged += new System.EventHandler(this.websrc_TextChanged);
            // 
            // hostsstart
            // 
            this.hostsstart.Location = new System.Drawing.Point(384, 198);
            this.hostsstart.Name = "hostsstart";
            this.hostsstart.Size = new System.Drawing.Size(240, 21);
            this.hostsstart.TabIndex = 15;
            this.hostsstart.Text = "#base services";
            this.hostsstart.Visible = false;
            // 
            // hostsend
            // 
            this.hostsend.Location = new System.Drawing.Point(384, 256);
            this.hostsend.Name = "hostsend";
            this.hostsend.Size = new System.Drawing.Size(240, 21);
            this.hostsend.TabIndex = 16;
            this.hostsend.Text = "#google hosts 2015 end";
            this.hostsend.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "hosts文件位置：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(386, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 21;
            this.label8.Text = "GITHUB：";
            // 
            // gitsrc
            // 
            this.gitsrc.Location = new System.Drawing.Point(384, 29);
            this.gitsrc.Name = "gitsrc";
            this.gitsrc.ReadOnly = true;
            this.gitsrc.Size = new System.Drawing.Size(240, 21);
            this.gitsrc.TabIndex = 22;
            this.gitsrc.Text = "https://github.com/e10my/google-hosts";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 311);
            this.Controls.Add(this.gitsrc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hostsend);
            this.Controls.Add(this.hostsstart);
            this.Controls.Add(this.websrc);
            this.Controls.Add(this.hostspath);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.state);
            this.Controls.Add(this.IsEnable);
            this.Controls.Add(this.altertime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(661, 345);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(661, 345);
            this.Name = "Form1";
            this.Text = "GOOGLE HOSTS修改神器v1.5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label altertime;
        private System.Windows.Forms.Label IsEnable;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox hostspath;
        private System.Windows.Forms.TextBox websrc;
        private System.Windows.Forms.TextBox hostsstart;
        private System.Windows.Forms.TextBox hostsend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox gitsrc;
    }
}

