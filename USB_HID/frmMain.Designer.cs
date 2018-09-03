namespace USB_HID
{
    partial class frmMain
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
            this.btnFindDevice = new System.Windows.Forms.Button();
            this.comboDeviceList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnFindDevice
            // 
            this.btnFindDevice.Location = new System.Drawing.Point(25, 34);
            this.btnFindDevice.Name = "btnFindDevice";
            this.btnFindDevice.Size = new System.Drawing.Size(75, 30);
            this.btnFindDevice.TabIndex = 0;
            this.btnFindDevice.Text = "FindDevice";
            this.btnFindDevice.UseVisualStyleBackColor = true;
            this.btnFindDevice.Click += new System.EventHandler(this.btnFindDevice_Click);
            // 
            // comboDeviceList
            // 
            this.comboDeviceList.FormattingEnabled = true;
            this.comboDeviceList.Location = new System.Drawing.Point(119, 37);
            this.comboDeviceList.Name = "comboDeviceList";
            this.comboDeviceList.Size = new System.Drawing.Size(121, 22);
            this.comboDeviceList.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 451);
            this.Controls.Add(this.comboDeviceList);
            this.Controls.Add(this.btnFindDevice);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFindDevice;
        private System.Windows.Forms.ComboBox comboDeviceList;
    }
}

