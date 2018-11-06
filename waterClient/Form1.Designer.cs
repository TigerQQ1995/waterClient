namespace waterClient
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
            this.btnconn = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.tbxMessage = new System.Windows.Forms.RichTextBox();
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.tbxIP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnconn
            // 
            this.btnconn.Location = new System.Drawing.Point(12, 12);
            this.btnconn.Name = "btnconn";
            this.btnconn.Size = new System.Drawing.Size(75, 23);
            this.btnconn.TabIndex = 0;
            this.btnconn.Text = "连接服务器";
            this.btnconn.UseVisualStyleBackColor = true;
            this.btnconn.Click += new System.EventHandler(this.btnconn_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(526, 445);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(494, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 52);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(614, 213);
            this.txtLog.TabIndex = 3;
            this.txtLog.Text = "";
            // 
            // tbxMessage
            // 
            this.tbxMessage.Location = new System.Drawing.Point(12, 271);
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.Size = new System.Drawing.Size(614, 158);
            this.tbxMessage.TabIndex = 4;
            this.tbxMessage.Text = "";
            // 
            // tbxPort
            // 
            this.tbxPort.Location = new System.Drawing.Point(244, 12);
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(100, 21);
            this.tbxPort.TabIndex = 5;
            // 
            // tbxIP
            // 
            this.tbxIP.Location = new System.Drawing.Point(106, 14);
            this.tbxIP.Name = "tbxIP";
            this.tbxIP.Size = new System.Drawing.Size(100, 21);
            this.tbxIP.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 490);
            this.Controls.Add(this.tbxIP);
            this.Controls.Add(this.tbxPort);
            this.Controls.Add(this.tbxMessage);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnconn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconn;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.RichTextBox tbxMessage;
        private System.Windows.Forms.TextBox tbxPort;
        private System.Windows.Forms.TextBox tbxIP;
    }
}

