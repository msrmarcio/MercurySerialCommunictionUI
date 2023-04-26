
namespace SerialCom
{
    partial class frmSetupSerial
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
            this.groupBoxSerialPortSetting = new System.Windows.Forms.GroupBox();
            this.comboBoxStopBit = new System.Windows.Forms.ComboBox();
            this.comboBoxCheckBit = new System.Windows.Forms.ComboBox();
            this.comboBoxDataBit = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.comboBoxCom = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonSendDataASCII = new System.Windows.Forms.RadioButton();
            this.groupBoxReceiveSetting = new System.Windows.Forms.GroupBox();
            this.radioButtonReceiveDataHEX = new System.Windows.Forms.RadioButton();
            this.radioButtonReceiveDataASCII = new System.Windows.Forms.RadioButton();
            this.groupBoxSendSetting = new System.Windows.Forms.GroupBox();
            this.radioButtonSendDataHex = new System.Windows.Forms.RadioButton();
            this.groupBoxSerialPortSetting.SuspendLayout();
            this.groupBoxReceiveSetting.SuspendLayout();
            this.groupBoxSendSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSerialPortSetting
            // 
            this.groupBoxSerialPortSetting.Controls.Add(this.comboBoxStopBit);
            this.groupBoxSerialPortSetting.Controls.Add(this.comboBoxCheckBit);
            this.groupBoxSerialPortSetting.Controls.Add(this.comboBoxDataBit);
            this.groupBoxSerialPortSetting.Controls.Add(this.comboBoxBaudRate);
            this.groupBoxSerialPortSetting.Controls.Add(this.comboBoxCom);
            this.groupBoxSerialPortSetting.Controls.Add(this.label5);
            this.groupBoxSerialPortSetting.Controls.Add(this.label4);
            this.groupBoxSerialPortSetting.Controls.Add(this.label3);
            this.groupBoxSerialPortSetting.Controls.Add(this.label2);
            this.groupBoxSerialPortSetting.Controls.Add(this.label1);
            this.groupBoxSerialPortSetting.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSerialPortSetting.Name = "groupBoxSerialPortSetting";
            this.groupBoxSerialPortSetting.Size = new System.Drawing.Size(200, 219);
            this.groupBoxSerialPortSetting.TabIndex = 7;
            this.groupBoxSerialPortSetting.TabStop = false;
            this.groupBoxSerialPortSetting.Text = "Porta Serial Configurações";
            // 
            // comboBoxStopBit
            // 
            this.comboBoxStopBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStopBit.FormattingEnabled = true;
            this.comboBoxStopBit.Location = new System.Drawing.Point(94, 171);
            this.comboBoxStopBit.Name = "comboBoxStopBit";
            this.comboBoxStopBit.Size = new System.Drawing.Size(90, 21);
            this.comboBoxStopBit.TabIndex = 9;
            // 
            // comboBoxCheckBit
            // 
            this.comboBoxCheckBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCheckBit.FormattingEnabled = true;
            this.comboBoxCheckBit.Location = new System.Drawing.Point(94, 133);
            this.comboBoxCheckBit.Name = "comboBoxCheckBit";
            this.comboBoxCheckBit.Size = new System.Drawing.Size(90, 21);
            this.comboBoxCheckBit.TabIndex = 8;
            // 
            // comboBoxDataBit
            // 
            this.comboBoxDataBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDataBit.FormattingEnabled = true;
            this.comboBoxDataBit.Location = new System.Drawing.Point(94, 99);
            this.comboBoxDataBit.Name = "comboBoxDataBit";
            this.comboBoxDataBit.Size = new System.Drawing.Size(90, 21);
            this.comboBoxDataBit.TabIndex = 7;
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Location = new System.Drawing.Point(94, 65);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(90, 21);
            this.comboBoxBaudRate.TabIndex = 6;
            // 
            // comboBoxCom
            // 
            this.comboBoxCom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxCom.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCom.FormattingEnabled = true;
            this.comboBoxCom.Location = new System.Drawing.Point(94, 34);
            this.comboBoxCom.Name = "comboBoxCom";
            this.comboBoxCom.Size = new System.Drawing.Size(90, 21);
            this.comboBoxCom.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "stop bit";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Check Digit";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "data bit";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "baud rate";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port COM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radioButtonSendDataASCII
            // 
            this.radioButtonSendDataASCII.AutoSize = true;
            this.radioButtonSendDataASCII.Location = new System.Drawing.Point(19, 23);
            this.radioButtonSendDataASCII.Name = "radioButtonSendDataASCII";
            this.radioButtonSendDataASCII.Size = new System.Drawing.Size(52, 17);
            this.radioButtonSendDataASCII.TabIndex = 0;
            this.radioButtonSendDataASCII.TabStop = true;
            this.radioButtonSendDataASCII.Text = "ASCII";
            this.radioButtonSendDataASCII.UseVisualStyleBackColor = true;
            // 
            // groupBoxReceiveSetting
            // 
            this.groupBoxReceiveSetting.Controls.Add(this.radioButtonReceiveDataHEX);
            this.groupBoxReceiveSetting.Controls.Add(this.radioButtonReceiveDataASCII);
            this.groupBoxReceiveSetting.Location = new System.Drawing.Point(12, 296);
            this.groupBoxReceiveSetting.Name = "groupBoxReceiveSetting";
            this.groupBoxReceiveSetting.Size = new System.Drawing.Size(200, 50);
            this.groupBoxReceiveSetting.TabIndex = 9;
            this.groupBoxReceiveSetting.TabStop = false;
            this.groupBoxReceiveSetting.Text = "Config. de Recebimento";
            // 
            // radioButtonReceiveDataHEX
            // 
            this.radioButtonReceiveDataHEX.AutoSize = true;
            this.radioButtonReceiveDataHEX.Location = new System.Drawing.Point(82, 22);
            this.radioButtonReceiveDataHEX.Name = "radioButtonReceiveDataHEX";
            this.radioButtonReceiveDataHEX.Size = new System.Drawing.Size(47, 17);
            this.radioButtonReceiveDataHEX.TabIndex = 1;
            this.radioButtonReceiveDataHEX.TabStop = true;
            this.radioButtonReceiveDataHEX.Text = "HEX";
            this.radioButtonReceiveDataHEX.UseVisualStyleBackColor = true;
            // 
            // radioButtonReceiveDataASCII
            // 
            this.radioButtonReceiveDataASCII.AutoSize = true;
            this.radioButtonReceiveDataASCII.Location = new System.Drawing.Point(19, 22);
            this.radioButtonReceiveDataASCII.Name = "radioButtonReceiveDataASCII";
            this.radioButtonReceiveDataASCII.Size = new System.Drawing.Size(52, 17);
            this.radioButtonReceiveDataASCII.TabIndex = 0;
            this.radioButtonReceiveDataASCII.TabStop = true;
            this.radioButtonReceiveDataASCII.Text = "ASCII";
            this.radioButtonReceiveDataASCII.UseVisualStyleBackColor = true;
            // 
            // groupBoxSendSetting
            // 
            this.groupBoxSendSetting.Controls.Add(this.radioButtonSendDataHex);
            this.groupBoxSendSetting.Controls.Add(this.radioButtonSendDataASCII);
            this.groupBoxSendSetting.Location = new System.Drawing.Point(12, 237);
            this.groupBoxSendSetting.Name = "groupBoxSendSetting";
            this.groupBoxSendSetting.Size = new System.Drawing.Size(200, 53);
            this.groupBoxSendSetting.TabIndex = 8;
            this.groupBoxSendSetting.TabStop = false;
            this.groupBoxSendSetting.Text = "Config. de Envio";
            // 
            // radioButtonSendDataHex
            // 
            this.radioButtonSendDataHex.AutoSize = true;
            this.radioButtonSendDataHex.Location = new System.Drawing.Point(82, 22);
            this.radioButtonSendDataHex.Name = "radioButtonSendDataHex";
            this.radioButtonSendDataHex.Size = new System.Drawing.Size(47, 17);
            this.radioButtonSendDataHex.TabIndex = 1;
            this.radioButtonSendDataHex.TabStop = true;
            this.radioButtonSendDataHex.Text = "HEX";
            this.radioButtonSendDataHex.UseVisualStyleBackColor = true;
            // 
            // frmSetupSerial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 368);
            this.Controls.Add(this.groupBoxSerialPortSetting);
            this.Controls.Add(this.groupBoxReceiveSetting);
            this.Controls.Add(this.groupBoxSendSetting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmSetupSerial";
            this.Text = "Mercury - Setup Serial Communication";
            this.groupBoxSerialPortSetting.ResumeLayout(false);
            this.groupBoxSerialPortSetting.PerformLayout();
            this.groupBoxReceiveSetting.ResumeLayout(false);
            this.groupBoxReceiveSetting.PerformLayout();
            this.groupBoxSendSetting.ResumeLayout(false);
            this.groupBoxSendSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSerialPortSetting;
        private System.Windows.Forms.ComboBox comboBoxStopBit;
        private System.Windows.Forms.ComboBox comboBoxCheckBit;
        private System.Windows.Forms.ComboBox comboBoxDataBit;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.ComboBox comboBoxCom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonSendDataASCII;
        private System.Windows.Forms.GroupBox groupBoxReceiveSetting;
        private System.Windows.Forms.RadioButton radioButtonReceiveDataHEX;
        private System.Windows.Forms.RadioButton radioButtonReceiveDataASCII;
        private System.Windows.Forms.GroupBox groupBoxSendSetting;
        private System.Windows.Forms.RadioButton radioButtonSendDataHex;
    }
}