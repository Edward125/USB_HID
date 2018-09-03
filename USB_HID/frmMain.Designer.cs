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
            this.lstMsg = new System.Windows.Forms.ListBox();
            this.btnOpenDevice = new System.Windows.Forms.Button();
            this.btnCloseDevice = new System.Windows.Forms.Button();
            this.lblDeviceStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnOpenRelay1 = new System.Windows.Forms.Button();
            this.btnCloseRelay1 = new System.Windows.Forms.Button();
            this.lblRelayStatus1 = new System.Windows.Forms.Label();
            this.lblRelayStatus2 = new System.Windows.Forms.Label();
            this.btnCloseRelay2 = new System.Windows.Forms.Button();
            this.btnOpenRelay2 = new System.Windows.Forms.Button();
            this.lblRelayStatus3 = new System.Windows.Forms.Label();
            this.btnCloseRelay3 = new System.Windows.Forms.Button();
            this.btnOpenRelay3 = new System.Windows.Forms.Button();
            this.lblRelayStatus4 = new System.Windows.Forms.Label();
            this.btnCloseRelay4 = new System.Windows.Forms.Button();
            this.btnOpenRelay4 = new System.Windows.Forms.Button();
            this.lblRelayStatus5 = new System.Windows.Forms.Label();
            this.btnCloseRelay5 = new System.Windows.Forms.Button();
            this.btnOpenRelay5 = new System.Windows.Forms.Button();
            this.lblRelayStatus6 = new System.Windows.Forms.Label();
            this.btnCloseRelay6 = new System.Windows.Forms.Button();
            this.btnOpenRelay6 = new System.Windows.Forms.Button();
            this.lblRelayStatus7 = new System.Windows.Forms.Label();
            this.btnCloseRelay7 = new System.Windows.Forms.Button();
            this.btnOpenRelay7 = new System.Windows.Forms.Button();
            this.lblRelayStatus8 = new System.Windows.Forms.Label();
            this.btnCloseRelay8 = new System.Windows.Forms.Button();
            this.btnOpenRelay8 = new System.Windows.Forms.Button();
            this.btnCloseAll = new System.Windows.Forms.Button();
            this.btnOpenAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFindDevice
            // 
            this.btnFindDevice.Location = new System.Drawing.Point(25, 29);
            this.btnFindDevice.Name = "btnFindDevice";
            this.btnFindDevice.Size = new System.Drawing.Size(98, 30);
            this.btnFindDevice.TabIndex = 0;
            this.btnFindDevice.Text = "Find Device";
            this.btnFindDevice.UseVisualStyleBackColor = true;
            this.btnFindDevice.Click += new System.EventHandler(this.btnFindDevice_Click);
            // 
            // comboDeviceList
            // 
            this.comboDeviceList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDeviceList.FormattingEnabled = true;
            this.comboDeviceList.Location = new System.Drawing.Point(129, 33);
            this.comboDeviceList.Name = "comboDeviceList";
            this.comboDeviceList.Size = new System.Drawing.Size(140, 22);
            this.comboDeviceList.TabIndex = 1;
            this.comboDeviceList.SelectedIndexChanged += new System.EventHandler(this.comboDeviceList_SelectedIndexChanged);
            // 
            // lstMsg
            // 
            this.lstMsg.FormattingEnabled = true;
            this.lstMsg.ItemHeight = 14;
            this.lstMsg.Location = new System.Drawing.Point(286, 34);
            this.lstMsg.Name = "lstMsg";
            this.lstMsg.Size = new System.Drawing.Size(354, 410);
            this.lstMsg.TabIndex = 2;
            // 
            // btnOpenDevice
            // 
            this.btnOpenDevice.Location = new System.Drawing.Point(25, 65);
            this.btnOpenDevice.Name = "btnOpenDevice";
            this.btnOpenDevice.Size = new System.Drawing.Size(84, 32);
            this.btnOpenDevice.TabIndex = 3;
            this.btnOpenDevice.Text = "Open Device";
            this.btnOpenDevice.UseVisualStyleBackColor = true;
            // 
            // btnCloseDevice
            // 
            this.btnCloseDevice.Location = new System.Drawing.Point(183, 65);
            this.btnCloseDevice.Name = "btnCloseDevice";
            this.btnCloseDevice.Size = new System.Drawing.Size(86, 32);
            this.btnCloseDevice.TabIndex = 4;
            this.btnCloseDevice.Text = "Close Device";
            this.btnCloseDevice.UseVisualStyleBackColor = true;
            // 
            // lblDeviceStatus
            // 
            this.lblDeviceStatus.AutoSize = true;
            this.lblDeviceStatus.BackColor = System.Drawing.Color.White;
            this.lblDeviceStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeviceStatus.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceStatus.Location = new System.Drawing.Point(123, 69);
            this.lblDeviceStatus.Name = "lblDeviceStatus";
            this.lblDeviceStatus.Size = new System.Drawing.Size(44, 25);
            this.lblDeviceStatus.TabIndex = 5;
            this.lblDeviceStatus.Text = "        ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Relay 1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Relay 2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Relay 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Relay 4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Relay 5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Relay 6";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Relay 7";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Relay 8";
            // 
            // btnOpenRelay1
            // 
            this.btnOpenRelay1.Location = new System.Drawing.Point(96, 106);
            this.btnOpenRelay1.Name = "btnOpenRelay1";
            this.btnOpenRelay1.Size = new System.Drawing.Size(60, 32);
            this.btnOpenRelay1.TabIndex = 14;
            this.btnOpenRelay1.Text = "Open";
            this.btnOpenRelay1.UseVisualStyleBackColor = true;
            // 
            // btnCloseRelay1
            // 
            this.btnCloseRelay1.Location = new System.Drawing.Point(211, 106);
            this.btnCloseRelay1.Name = "btnCloseRelay1";
            this.btnCloseRelay1.Size = new System.Drawing.Size(60, 32);
            this.btnCloseRelay1.TabIndex = 15;
            this.btnCloseRelay1.Text = "Close";
            this.btnCloseRelay1.UseVisualStyleBackColor = true;
            // 
            // lblRelayStatus1
            // 
            this.lblRelayStatus1.AutoSize = true;
            this.lblRelayStatus1.BackColor = System.Drawing.Color.White;
            this.lblRelayStatus1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRelayStatus1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelayStatus1.Location = new System.Drawing.Point(162, 110);
            this.lblRelayStatus1.Name = "lblRelayStatus1";
            this.lblRelayStatus1.Size = new System.Drawing.Size(44, 25);
            this.lblRelayStatus1.TabIndex = 16;
            this.lblRelayStatus1.Text = "        ";
            // 
            // lblRelayStatus2
            // 
            this.lblRelayStatus2.AutoSize = true;
            this.lblRelayStatus2.BackColor = System.Drawing.Color.White;
            this.lblRelayStatus2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRelayStatus2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelayStatus2.Location = new System.Drawing.Point(162, 147);
            this.lblRelayStatus2.Name = "lblRelayStatus2";
            this.lblRelayStatus2.Size = new System.Drawing.Size(44, 25);
            this.lblRelayStatus2.TabIndex = 19;
            this.lblRelayStatus2.Text = "        ";
            // 
            // btnCloseRelay2
            // 
            this.btnCloseRelay2.Location = new System.Drawing.Point(211, 143);
            this.btnCloseRelay2.Name = "btnCloseRelay2";
            this.btnCloseRelay2.Size = new System.Drawing.Size(60, 32);
            this.btnCloseRelay2.TabIndex = 18;
            this.btnCloseRelay2.Text = "Close";
            this.btnCloseRelay2.UseVisualStyleBackColor = true;
            // 
            // btnOpenRelay2
            // 
            this.btnOpenRelay2.Location = new System.Drawing.Point(96, 143);
            this.btnOpenRelay2.Name = "btnOpenRelay2";
            this.btnOpenRelay2.Size = new System.Drawing.Size(60, 32);
            this.btnOpenRelay2.TabIndex = 17;
            this.btnOpenRelay2.Text = "Open";
            this.btnOpenRelay2.UseVisualStyleBackColor = true;
            // 
            // lblRelayStatus3
            // 
            this.lblRelayStatus3.AutoSize = true;
            this.lblRelayStatus3.BackColor = System.Drawing.Color.White;
            this.lblRelayStatus3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRelayStatus3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelayStatus3.Location = new System.Drawing.Point(162, 184);
            this.lblRelayStatus3.Name = "lblRelayStatus3";
            this.lblRelayStatus3.Size = new System.Drawing.Size(44, 25);
            this.lblRelayStatus3.TabIndex = 22;
            this.lblRelayStatus3.Text = "        ";
            // 
            // btnCloseRelay3
            // 
            this.btnCloseRelay3.Location = new System.Drawing.Point(211, 180);
            this.btnCloseRelay3.Name = "btnCloseRelay3";
            this.btnCloseRelay3.Size = new System.Drawing.Size(60, 32);
            this.btnCloseRelay3.TabIndex = 21;
            this.btnCloseRelay3.Text = "Close";
            this.btnCloseRelay3.UseVisualStyleBackColor = true;
            // 
            // btnOpenRelay3
            // 
            this.btnOpenRelay3.Location = new System.Drawing.Point(96, 180);
            this.btnOpenRelay3.Name = "btnOpenRelay3";
            this.btnOpenRelay3.Size = new System.Drawing.Size(60, 32);
            this.btnOpenRelay3.TabIndex = 20;
            this.btnOpenRelay3.Text = "Open";
            this.btnOpenRelay3.UseVisualStyleBackColor = true;
            // 
            // lblRelayStatus4
            // 
            this.lblRelayStatus4.AutoSize = true;
            this.lblRelayStatus4.BackColor = System.Drawing.Color.White;
            this.lblRelayStatus4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRelayStatus4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelayStatus4.Location = new System.Drawing.Point(162, 221);
            this.lblRelayStatus4.Name = "lblRelayStatus4";
            this.lblRelayStatus4.Size = new System.Drawing.Size(44, 25);
            this.lblRelayStatus4.TabIndex = 25;
            this.lblRelayStatus4.Text = "        ";
            // 
            // btnCloseRelay4
            // 
            this.btnCloseRelay4.Location = new System.Drawing.Point(211, 217);
            this.btnCloseRelay4.Name = "btnCloseRelay4";
            this.btnCloseRelay4.Size = new System.Drawing.Size(60, 32);
            this.btnCloseRelay4.TabIndex = 24;
            this.btnCloseRelay4.Text = "Close";
            this.btnCloseRelay4.UseVisualStyleBackColor = true;
            // 
            // btnOpenRelay4
            // 
            this.btnOpenRelay4.Location = new System.Drawing.Point(96, 217);
            this.btnOpenRelay4.Name = "btnOpenRelay4";
            this.btnOpenRelay4.Size = new System.Drawing.Size(60, 32);
            this.btnOpenRelay4.TabIndex = 23;
            this.btnOpenRelay4.Text = "Open";
            this.btnOpenRelay4.UseVisualStyleBackColor = true;
            // 
            // lblRelayStatus5
            // 
            this.lblRelayStatus5.AutoSize = true;
            this.lblRelayStatus5.BackColor = System.Drawing.Color.White;
            this.lblRelayStatus5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRelayStatus5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelayStatus5.Location = new System.Drawing.Point(162, 258);
            this.lblRelayStatus5.Name = "lblRelayStatus5";
            this.lblRelayStatus5.Size = new System.Drawing.Size(44, 25);
            this.lblRelayStatus5.TabIndex = 28;
            this.lblRelayStatus5.Text = "        ";
            // 
            // btnCloseRelay5
            // 
            this.btnCloseRelay5.Location = new System.Drawing.Point(211, 254);
            this.btnCloseRelay5.Name = "btnCloseRelay5";
            this.btnCloseRelay5.Size = new System.Drawing.Size(60, 32);
            this.btnCloseRelay5.TabIndex = 27;
            this.btnCloseRelay5.Text = "Close";
            this.btnCloseRelay5.UseVisualStyleBackColor = true;
            // 
            // btnOpenRelay5
            // 
            this.btnOpenRelay5.Location = new System.Drawing.Point(96, 254);
            this.btnOpenRelay5.Name = "btnOpenRelay5";
            this.btnOpenRelay5.Size = new System.Drawing.Size(60, 32);
            this.btnOpenRelay5.TabIndex = 26;
            this.btnOpenRelay5.Text = "Open";
            this.btnOpenRelay5.UseVisualStyleBackColor = true;
            // 
            // lblRelayStatus6
            // 
            this.lblRelayStatus6.AutoSize = true;
            this.lblRelayStatus6.BackColor = System.Drawing.Color.White;
            this.lblRelayStatus6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRelayStatus6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelayStatus6.Location = new System.Drawing.Point(162, 295);
            this.lblRelayStatus6.Name = "lblRelayStatus6";
            this.lblRelayStatus6.Size = new System.Drawing.Size(44, 25);
            this.lblRelayStatus6.TabIndex = 31;
            this.lblRelayStatus6.Text = "        ";
            // 
            // btnCloseRelay6
            // 
            this.btnCloseRelay6.Location = new System.Drawing.Point(211, 291);
            this.btnCloseRelay6.Name = "btnCloseRelay6";
            this.btnCloseRelay6.Size = new System.Drawing.Size(60, 32);
            this.btnCloseRelay6.TabIndex = 30;
            this.btnCloseRelay6.Text = "Close";
            this.btnCloseRelay6.UseVisualStyleBackColor = true;
            // 
            // btnOpenRelay6
            // 
            this.btnOpenRelay6.Location = new System.Drawing.Point(96, 291);
            this.btnOpenRelay6.Name = "btnOpenRelay6";
            this.btnOpenRelay6.Size = new System.Drawing.Size(60, 32);
            this.btnOpenRelay6.TabIndex = 29;
            this.btnOpenRelay6.Text = "Open";
            this.btnOpenRelay6.UseVisualStyleBackColor = true;
            // 
            // lblRelayStatus7
            // 
            this.lblRelayStatus7.AutoSize = true;
            this.lblRelayStatus7.BackColor = System.Drawing.Color.White;
            this.lblRelayStatus7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRelayStatus7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelayStatus7.Location = new System.Drawing.Point(162, 332);
            this.lblRelayStatus7.Name = "lblRelayStatus7";
            this.lblRelayStatus7.Size = new System.Drawing.Size(44, 25);
            this.lblRelayStatus7.TabIndex = 34;
            this.lblRelayStatus7.Text = "        ";
            // 
            // btnCloseRelay7
            // 
            this.btnCloseRelay7.Location = new System.Drawing.Point(211, 328);
            this.btnCloseRelay7.Name = "btnCloseRelay7";
            this.btnCloseRelay7.Size = new System.Drawing.Size(60, 32);
            this.btnCloseRelay7.TabIndex = 33;
            this.btnCloseRelay7.Text = "Close";
            this.btnCloseRelay7.UseVisualStyleBackColor = true;
            // 
            // btnOpenRelay7
            // 
            this.btnOpenRelay7.Location = new System.Drawing.Point(96, 328);
            this.btnOpenRelay7.Name = "btnOpenRelay7";
            this.btnOpenRelay7.Size = new System.Drawing.Size(60, 32);
            this.btnOpenRelay7.TabIndex = 32;
            this.btnOpenRelay7.Text = "Open";
            this.btnOpenRelay7.UseVisualStyleBackColor = true;
            // 
            // lblRelayStatus8
            // 
            this.lblRelayStatus8.AutoSize = true;
            this.lblRelayStatus8.BackColor = System.Drawing.Color.White;
            this.lblRelayStatus8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRelayStatus8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelayStatus8.Location = new System.Drawing.Point(162, 369);
            this.lblRelayStatus8.Name = "lblRelayStatus8";
            this.lblRelayStatus8.Size = new System.Drawing.Size(44, 25);
            this.lblRelayStatus8.TabIndex = 37;
            this.lblRelayStatus8.Text = "        ";
            // 
            // btnCloseRelay8
            // 
            this.btnCloseRelay8.Location = new System.Drawing.Point(211, 365);
            this.btnCloseRelay8.Name = "btnCloseRelay8";
            this.btnCloseRelay8.Size = new System.Drawing.Size(60, 32);
            this.btnCloseRelay8.TabIndex = 36;
            this.btnCloseRelay8.Text = "Close";
            this.btnCloseRelay8.UseVisualStyleBackColor = true;
            // 
            // btnOpenRelay8
            // 
            this.btnOpenRelay8.Location = new System.Drawing.Point(96, 365);
            this.btnOpenRelay8.Name = "btnOpenRelay8";
            this.btnOpenRelay8.Size = new System.Drawing.Size(60, 32);
            this.btnOpenRelay8.TabIndex = 35;
            this.btnOpenRelay8.Text = "Open";
            this.btnOpenRelay8.UseVisualStyleBackColor = true;
            // 
            // btnCloseAll
            // 
            this.btnCloseAll.Location = new System.Drawing.Point(162, 412);
            this.btnCloseAll.Name = "btnCloseAll";
            this.btnCloseAll.Size = new System.Drawing.Size(107, 32);
            this.btnCloseAll.TabIndex = 39;
            this.btnCloseAll.Text = "Close All";
            this.btnCloseAll.UseVisualStyleBackColor = true;
            // 
            // btnOpenAll
            // 
            this.btnOpenAll.Location = new System.Drawing.Point(25, 412);
            this.btnOpenAll.Name = "btnOpenAll";
            this.btnOpenAll.Size = new System.Drawing.Size(110, 32);
            this.btnOpenAll.TabIndex = 38;
            this.btnOpenAll.Text = "Open All";
            this.btnOpenAll.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 463);
            this.Controls.Add(this.btnCloseAll);
            this.Controls.Add(this.btnOpenAll);
            this.Controls.Add(this.lblRelayStatus8);
            this.Controls.Add(this.btnCloseRelay8);
            this.Controls.Add(this.btnOpenRelay8);
            this.Controls.Add(this.lblRelayStatus7);
            this.Controls.Add(this.btnCloseRelay7);
            this.Controls.Add(this.btnOpenRelay7);
            this.Controls.Add(this.lblRelayStatus6);
            this.Controls.Add(this.btnCloseRelay6);
            this.Controls.Add(this.btnOpenRelay6);
            this.Controls.Add(this.lblRelayStatus5);
            this.Controls.Add(this.btnCloseRelay5);
            this.Controls.Add(this.btnOpenRelay5);
            this.Controls.Add(this.lblRelayStatus4);
            this.Controls.Add(this.btnCloseRelay4);
            this.Controls.Add(this.btnOpenRelay4);
            this.Controls.Add(this.lblRelayStatus3);
            this.Controls.Add(this.btnCloseRelay3);
            this.Controls.Add(this.btnOpenRelay3);
            this.Controls.Add(this.lblRelayStatus2);
            this.Controls.Add(this.btnCloseRelay2);
            this.Controls.Add(this.btnOpenRelay2);
            this.Controls.Add(this.lblRelayStatus1);
            this.Controls.Add(this.btnCloseRelay1);
            this.Controls.Add(this.btnOpenRelay1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDeviceStatus);
            this.Controls.Add(this.btnCloseDevice);
            this.Controls.Add(this.btnOpenDevice);
            this.Controls.Add(this.lstMsg);
            this.Controls.Add(this.comboDeviceList);
            this.Controls.Add(this.btnFindDevice);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindDevice;
        private System.Windows.Forms.ComboBox comboDeviceList;
        private System.Windows.Forms.ListBox lstMsg;
        private System.Windows.Forms.Button btnOpenDevice;
        private System.Windows.Forms.Button btnCloseDevice;
        private System.Windows.Forms.Label lblDeviceStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnOpenRelay1;
        private System.Windows.Forms.Button btnCloseRelay1;
        private System.Windows.Forms.Label lblRelayStatus1;
        private System.Windows.Forms.Label lblRelayStatus2;
        private System.Windows.Forms.Button btnCloseRelay2;
        private System.Windows.Forms.Button btnOpenRelay2;
        private System.Windows.Forms.Label lblRelayStatus3;
        private System.Windows.Forms.Button btnCloseRelay3;
        private System.Windows.Forms.Button btnOpenRelay3;
        private System.Windows.Forms.Label lblRelayStatus4;
        private System.Windows.Forms.Button btnCloseRelay4;
        private System.Windows.Forms.Button btnOpenRelay4;
        private System.Windows.Forms.Label lblRelayStatus5;
        private System.Windows.Forms.Button btnCloseRelay5;
        private System.Windows.Forms.Button btnOpenRelay5;
        private System.Windows.Forms.Label lblRelayStatus6;
        private System.Windows.Forms.Button btnCloseRelay6;
        private System.Windows.Forms.Button btnOpenRelay6;
        private System.Windows.Forms.Label lblRelayStatus7;
        private System.Windows.Forms.Button btnCloseRelay7;
        private System.Windows.Forms.Button btnOpenRelay7;
        private System.Windows.Forms.Label lblRelayStatus8;
        private System.Windows.Forms.Button btnCloseRelay8;
        private System.Windows.Forms.Button btnOpenRelay8;
        private System.Windows.Forms.Button btnCloseAll;
        private System.Windows.Forms.Button btnOpenAll;
    }
}

