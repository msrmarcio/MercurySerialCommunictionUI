namespace SerialCom
{
    partial class MainForm
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

        #region Código gerado pelo Windows Forms Designer

        /// <resumo>
        /// Métodos necessários para suporte ao designer - não modifique
        /// Use o editor de código para modificar o conteúdo deste método.
        /// </resumo>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveReceiveDataToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetPortConfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuIHelp = new System.Windows.Forms.ToolStripMenuItem();
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
            this.buttonOpenCloseCom = new System.Windows.Forms.Button();
            this.groupBoxSendSetting = new System.Windows.Forms.GroupBox();
            this.radioButtonSendDataHex = new System.Windows.Forms.RadioButton();
            this.radioButtonSendDataASCII = new System.Windows.Forms.RadioButton();
            this.groupBoxReceiveSetting = new System.Windows.Forms.GroupBox();
            this.radioButtonReceiveDataHEX = new System.Windows.Forms.RadioButton();
            this.radioButtonReceiveDataASCII = new System.Windows.Forms.RadioButton();
            this.groupBoxReceiveData = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonClearRecData = new System.Windows.Forms.Button();
            this.groupBoxSendData = new System.Windows.Forms.GroupBox();
            this.buttonSendData = new System.Windows.Forms.Button();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.Button_Refresh = new System.Windows.Forms.Button();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.btnTurbo = new System.Windows.Forms.Button();
            this.btnNumeros = new System.Windows.Forms.Button();
            this.btnCartelas = new System.Windows.Forms.Button();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.btnExtra = new System.Windows.Forms.Button();
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnAposta = new System.Windows.Forms.Button();
            this.btnB3 = new System.Windows.Forms.Button();
            this.btnB7 = new System.Windows.Forms.Button();
            this.btnB12 = new System.Windows.Forms.Button();
            this.btnB11 = new System.Windows.Forms.Button();
            this.btnB8 = new System.Windows.Forms.Button();
            this.btnB15 = new System.Windows.Forms.Button();
            this.btnB14 = new System.Windows.Forms.Button();
            this.btnB13 = new System.Windows.Forms.Button();
            this.btn200 = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.btn50 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBoxSerialPortSetting.SuspendLayout();
            this.groupBoxSendSetting.SuspendLayout();
            this.groupBoxReceiveSetting.SuspendLayout();
            this.groupBoxReceiveData.SuspendLayout();
            this.groupBoxSendData.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuSetting,
            this.MenuIHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(872, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveReceiveDataToFileToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(61, 20);
            this.MenuFile.Text = "Arquivo";
            // 
            // SaveReceiveDataToFileToolStripMenuItem
            // 
            this.SaveReceiveDataToFileToolStripMenuItem.Name = "SaveReceiveDataToFileToolStripMenuItem";
            this.SaveReceiveDataToFileToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.SaveReceiveDataToFileToolStripMenuItem.Text = "Log - Salvar Dados Recebidos";
            this.SaveReceiveDataToFileToolStripMenuItem.Click += new System.EventHandler(this.SaveReceiveDataToFileToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.ExitToolStripMenuItem.Text = "Sair";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // MenuSetting
            // 
            this.MenuSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ResetPortConfToolStripMenuItem});
            this.MenuSetting.Name = "MenuSetting";
            this.MenuSetting.Size = new System.Drawing.Size(91, 20);
            this.MenuSetting.Text = "Configuração";
            // 
            // ResetPortConfToolStripMenuItem
            // 
            this.ResetPortConfToolStripMenuItem.Name = "ResetPortConfToolStripMenuItem";
            this.ResetPortConfToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.ResetPortConfToolStripMenuItem.Text = "Reinicia Configurações do Serial";
            this.ResetPortConfToolStripMenuItem.Click += new System.EventHandler(this.ResetPortConfToolStripMenuItem_Click);
            // 
            // MenuIHelp
            // 
            this.MenuIHelp.Name = "MenuIHelp";
            this.MenuIHelp.Size = new System.Drawing.Size(42, 20);
            this.MenuIHelp.Text = "help";
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
            this.groupBoxSerialPortSetting.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxSerialPortSetting.Location = new System.Drawing.Point(5, 51);
            this.groupBoxSerialPortSetting.Name = "groupBoxSerialPortSetting";
            this.groupBoxSerialPortSetting.Size = new System.Drawing.Size(200, 219);
            this.groupBoxSerialPortSetting.TabIndex = 2;
            this.groupBoxSerialPortSetting.TabStop = false;
            this.groupBoxSerialPortSetting.Text = "Porta Serial Configurações";
            // 
            // comboBoxStopBit
            // 
            this.comboBoxStopBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStopBit.FormattingEnabled = true;
            this.comboBoxStopBit.Location = new System.Drawing.Point(99, 171);
            this.comboBoxStopBit.Name = "comboBoxStopBit";
            this.comboBoxStopBit.Size = new System.Drawing.Size(90, 25);
            this.comboBoxStopBit.TabIndex = 9;
            // 
            // comboBoxCheckBit
            // 
            this.comboBoxCheckBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCheckBit.FormattingEnabled = true;
            this.comboBoxCheckBit.Location = new System.Drawing.Point(99, 133);
            this.comboBoxCheckBit.Name = "comboBoxCheckBit";
            this.comboBoxCheckBit.Size = new System.Drawing.Size(90, 25);
            this.comboBoxCheckBit.TabIndex = 8;
            // 
            // comboBoxDataBit
            // 
            this.comboBoxDataBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDataBit.FormattingEnabled = true;
            this.comboBoxDataBit.Location = new System.Drawing.Point(99, 99);
            this.comboBoxDataBit.Name = "comboBoxDataBit";
            this.comboBoxDataBit.Size = new System.Drawing.Size(90, 25);
            this.comboBoxDataBit.TabIndex = 7;
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Location = new System.Drawing.Point(99, 65);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(90, 25);
            this.comboBoxBaudRate.TabIndex = 6;
            // 
            // comboBoxCom
            // 
            this.comboBoxCom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxCom.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCom.FormattingEnabled = true;
            this.comboBoxCom.Location = new System.Drawing.Point(99, 34);
            this.comboBoxCom.Name = "comboBoxCom";
            this.comboBoxCom.Size = new System.Drawing.Size(90, 25);
            this.comboBoxCom.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(22, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "stop bit";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(22, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Check Digit";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(22, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "data bit";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(22, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "baud rate";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port COM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonOpenCloseCom
            // 
            this.buttonOpenCloseCom.BackColor = System.Drawing.Color.Lime;
            this.buttonOpenCloseCom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenCloseCom.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonOpenCloseCom.Location = new System.Drawing.Point(373, 25);
            this.buttonOpenCloseCom.Name = "buttonOpenCloseCom";
            this.buttonOpenCloseCom.Size = new System.Drawing.Size(123, 49);
            this.buttonOpenCloseCom.TabIndex = 3;
            this.buttonOpenCloseCom.Text = "Conectar Porta COM";
            this.buttonOpenCloseCom.UseVisualStyleBackColor = false;
            this.buttonOpenCloseCom.Click += new System.EventHandler(this.buttonOpenCloseCom_Click);
            // 
            // groupBoxSendSetting
            // 
            this.groupBoxSendSetting.Controls.Add(this.radioButtonSendDataHex);
            this.groupBoxSendSetting.Controls.Add(this.radioButtonSendDataASCII);
            this.groupBoxSendSetting.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxSendSetting.Location = new System.Drawing.Point(5, 276);
            this.groupBoxSendSetting.Name = "groupBoxSendSetting";
            this.groupBoxSendSetting.Size = new System.Drawing.Size(200, 53);
            this.groupBoxSendSetting.TabIndex = 5;
            this.groupBoxSendSetting.TabStop = false;
            this.groupBoxSendSetting.Text = "Config. de Envio";
            // 
            // radioButtonSendDataHex
            // 
            this.radioButtonSendDataHex.AutoSize = true;
            this.radioButtonSendDataHex.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonSendDataHex.Location = new System.Drawing.Point(87, 22);
            this.radioButtonSendDataHex.Name = "radioButtonSendDataHex";
            this.radioButtonSendDataHex.Size = new System.Drawing.Size(50, 21);
            this.radioButtonSendDataHex.TabIndex = 1;
            this.radioButtonSendDataHex.TabStop = true;
            this.radioButtonSendDataHex.Text = "HEX";
            this.radioButtonSendDataHex.UseVisualStyleBackColor = true;
            // 
            // radioButtonSendDataASCII
            // 
            this.radioButtonSendDataASCII.AutoSize = true;
            this.radioButtonSendDataASCII.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonSendDataASCII.Location = new System.Drawing.Point(24, 23);
            this.radioButtonSendDataASCII.Name = "radioButtonSendDataASCII";
            this.radioButtonSendDataASCII.Size = new System.Drawing.Size(57, 21);
            this.radioButtonSendDataASCII.TabIndex = 0;
            this.radioButtonSendDataASCII.TabStop = true;
            this.radioButtonSendDataASCII.Text = "ASCII";
            this.radioButtonSendDataASCII.UseVisualStyleBackColor = true;
            // 
            // groupBoxReceiveSetting
            // 
            this.groupBoxReceiveSetting.Controls.Add(this.radioButtonReceiveDataHEX);
            this.groupBoxReceiveSetting.Controls.Add(this.radioButtonReceiveDataASCII);
            this.groupBoxReceiveSetting.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxReceiveSetting.Location = new System.Drawing.Point(5, 335);
            this.groupBoxReceiveSetting.Name = "groupBoxReceiveSetting";
            this.groupBoxReceiveSetting.Size = new System.Drawing.Size(200, 50);
            this.groupBoxReceiveSetting.TabIndex = 6;
            this.groupBoxReceiveSetting.TabStop = false;
            this.groupBoxReceiveSetting.Text = "Config. de Recebimento";
            // 
            // radioButtonReceiveDataHEX
            // 
            this.radioButtonReceiveDataHEX.AutoSize = true;
            this.radioButtonReceiveDataHEX.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonReceiveDataHEX.Location = new System.Drawing.Point(87, 22);
            this.radioButtonReceiveDataHEX.Name = "radioButtonReceiveDataHEX";
            this.radioButtonReceiveDataHEX.Size = new System.Drawing.Size(50, 21);
            this.radioButtonReceiveDataHEX.TabIndex = 1;
            this.radioButtonReceiveDataHEX.TabStop = true;
            this.radioButtonReceiveDataHEX.Text = "HEX";
            this.radioButtonReceiveDataHEX.UseVisualStyleBackColor = true;
            // 
            // radioButtonReceiveDataASCII
            // 
            this.radioButtonReceiveDataASCII.AutoSize = true;
            this.radioButtonReceiveDataASCII.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonReceiveDataASCII.Location = new System.Drawing.Point(24, 22);
            this.radioButtonReceiveDataASCII.Name = "radioButtonReceiveDataASCII";
            this.radioButtonReceiveDataASCII.Size = new System.Drawing.Size(57, 21);
            this.radioButtonReceiveDataASCII.TabIndex = 0;
            this.radioButtonReceiveDataASCII.TabStop = true;
            this.radioButtonReceiveDataASCII.Text = "ASCII";
            this.radioButtonReceiveDataASCII.UseVisualStyleBackColor = true;
            // 
            // groupBoxReceiveData
            // 
            this.groupBoxReceiveData.Controls.Add(this.richTextBox1);
            this.groupBoxReceiveData.Controls.Add(this.buttonClearRecData);
            this.groupBoxReceiveData.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxReceiveData.Location = new System.Drawing.Point(216, 87);
            this.groupBoxReceiveData.Name = "groupBoxReceiveData";
            this.groupBoxReceiveData.Size = new System.Drawing.Size(280, 242);
            this.groupBoxReceiveData.TabIndex = 7;
            this.groupBoxReceiveData.TabStop = false;
            this.groupBoxReceiveData.Text = "[ECO] - Dados recebidos de resposta";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.Location = new System.Drawing.Point(8, 22);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(270, 183);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // buttonClearRecData
            // 
            this.buttonClearRecData.BackColor = System.Drawing.Color.Silver;
            this.buttonClearRecData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearRecData.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonClearRecData.FlatAppearance.BorderSize = 2;
            this.buttonClearRecData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.buttonClearRecData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonClearRecData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearRecData.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearRecData.Location = new System.Drawing.Point(203, 207);
            this.buttonClearRecData.Name = "buttonClearRecData";
            this.buttonClearRecData.Size = new System.Drawing.Size(75, 30);
            this.buttonClearRecData.TabIndex = 1;
            this.buttonClearRecData.Text = "LIMPAR";
            this.buttonClearRecData.UseVisualStyleBackColor = false;
            this.buttonClearRecData.Click += new System.EventHandler(this.buttonClearRecData_Click);
            // 
            // groupBoxSendData
            // 
            this.groupBoxSendData.Controls.Add(this.buttonSendData);
            this.groupBoxSendData.Controls.Add(this.textBoxSend);
            this.groupBoxSendData.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxSendData.Location = new System.Drawing.Point(216, 334);
            this.groupBoxSendData.Name = "groupBoxSendData";
            this.groupBoxSendData.Size = new System.Drawing.Size(280, 50);
            this.groupBoxSendData.TabIndex = 8;
            this.groupBoxSendData.TabStop = false;
            this.groupBoxSendData.Text = "Comando";
            // 
            // buttonSendData
            // 
            this.buttonSendData.BackColor = System.Drawing.Color.Silver;
            this.buttonSendData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSendData.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSendData.FlatAppearance.BorderSize = 2;
            this.buttonSendData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.buttonSendData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonSendData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendData.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSendData.Location = new System.Drawing.Point(204, 12);
            this.buttonSendData.Name = "buttonSendData";
            this.buttonSendData.Size = new System.Drawing.Size(74, 33);
            this.buttonSendData.TabIndex = 1;
            this.buttonSendData.Text = "ENVIAR";
            this.buttonSendData.UseVisualStyleBackColor = false;
            this.buttonSendData.Click += new System.EventHandler(this.buttonSendData_Click);
            // 
            // textBoxSend
            // 
            this.textBoxSend.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSend.Location = new System.Drawing.Point(11, 19);
            this.textBoxSend.Multiline = true;
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(187, 26);
            this.textBoxSend.TabIndex = 0;
            this.textBoxSend.Enter += new System.EventHandler(this.textBoxSend_Enter);
            this.textBoxSend.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxSend_KeyUp);
            this.textBoxSend.Leave += new System.EventHandler(this.textBoxSend_Leave);
            // 
            // Button_Refresh
            // 
            this.Button_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Refresh.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_Refresh.Location = new System.Drawing.Point(216, 25);
            this.Button_Refresh.Name = "Button_Refresh";
            this.Button_Refresh.Size = new System.Drawing.Size(123, 49);
            this.Button_Refresh.TabIndex = 10;
            this.Button_Refresh.Text = "Atualizar lista de Porta Serial";
            this.Button_Refresh.UseVisualStyleBackColor = true;
            this.Button_Refresh.Click += new System.EventHandler(this.Button_Refresh_Click);
            // 
            // btnAjuda
            // 
            this.btnAjuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAjuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAjuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjuda.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAjuda.FlatAppearance.BorderSize = 2;
            this.btnAjuda.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAjuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnAjuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjuda.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjuda.Location = new System.Drawing.Point(648, 30);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(107, 33);
            this.btnAjuda.TabIndex = 16;
            this.btnAjuda.Text = "AJUDA";
            this.btnAjuda.UseVisualStyleBackColor = false;
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            // 
            // btnTurbo
            // 
            this.btnTurbo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTurbo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTurbo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTurbo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTurbo.FlatAppearance.BorderSize = 2;
            this.btnTurbo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnTurbo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnTurbo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTurbo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurbo.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurbo.Location = new System.Drawing.Point(648, 263);
            this.btnTurbo.Name = "btnTurbo";
            this.btnTurbo.Size = new System.Drawing.Size(107, 33);
            this.btnTurbo.TabIndex = 20;
            this.btnTurbo.Text = "TURBO";
            this.btnTurbo.UseVisualStyleBackColor = false;
            this.btnTurbo.Click += new System.EventHandler(this.btnTurbo_Click);
            // 
            // btnNumeros
            // 
            this.btnNumeros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNumeros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNumeros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNumeros.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNumeros.FlatAppearance.BorderSize = 2;
            this.btnNumeros.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnNumeros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnNumeros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNumeros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumeros.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumeros.Location = new System.Drawing.Point(648, 146);
            this.btnNumeros.Name = "btnNumeros";
            this.btnNumeros.Size = new System.Drawing.Size(107, 33);
            this.btnNumeros.TabIndex = 19;
            this.btnNumeros.Text = "NÚMEROS";
            this.btnNumeros.UseVisualStyleBackColor = false;
            this.btnNumeros.Click += new System.EventHandler(this.btnNumeros_Click);
            // 
            // btnCartelas
            // 
            this.btnCartelas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCartelas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCartelas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCartelas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCartelas.FlatAppearance.BorderSize = 2;
            this.btnCartelas.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCartelas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnCartelas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCartelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCartelas.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartelas.Location = new System.Drawing.Point(648, 69);
            this.btnCartelas.Name = "btnCartelas";
            this.btnCartelas.Size = new System.Drawing.Size(107, 33);
            this.btnCartelas.TabIndex = 18;
            this.btnCartelas.Text = "CARTELAS";
            this.btnCartelas.UseVisualStyleBackColor = false;
            this.btnCartelas.Click += new System.EventHandler(this.btnCartelas_Click);
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCobrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCobrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCobrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCobrar.FlatAppearance.BorderSize = 2;
            this.btnCobrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCobrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnCobrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrar.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.Location = new System.Drawing.Point(761, 30);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(107, 33);
            this.btnCobrar.TabIndex = 17;
            this.btnCobrar.Text = "COBRAR";
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // btnExtra
            // 
            this.btnExtra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExtra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExtra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExtra.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExtra.FlatAppearance.BorderSize = 2;
            this.btnExtra.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnExtra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnExtra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExtra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtra.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtra.Location = new System.Drawing.Point(648, 224);
            this.btnExtra.Name = "btnExtra";
            this.btnExtra.Size = new System.Drawing.Size(107, 33);
            this.btnExtra.TabIndex = 23;
            this.btnExtra.Text = "EXTRA";
            this.btnExtra.UseVisualStyleBackColor = false;
            this.btnExtra.Click += new System.EventHandler(this.btnExtra_Click);
            // 
            // btnJogar
            // 
            this.btnJogar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnJogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJogar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnJogar.FlatAppearance.BorderSize = 2;
            this.btnJogar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnJogar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnJogar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnJogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJogar.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogar.Location = new System.Drawing.Point(648, 185);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(107, 33);
            this.btnJogar.TabIndex = 22;
            this.btnJogar.Text = "JOGAR";
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // btnAposta
            // 
            this.btnAposta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAposta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAposta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAposta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAposta.FlatAppearance.BorderSize = 2;
            this.btnAposta.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAposta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnAposta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAposta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAposta.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAposta.Location = new System.Drawing.Point(648, 107);
            this.btnAposta.Name = "btnAposta";
            this.btnAposta.Size = new System.Drawing.Size(107, 33);
            this.btnAposta.TabIndex = 21;
            this.btnAposta.Text = "APOSTA";
            this.btnAposta.UseVisualStyleBackColor = false;
            this.btnAposta.Click += new System.EventHandler(this.btnAposta_Click);
            // 
            // btnB3
            // 
            this.btnB3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnB3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnB3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnB3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnB3.FlatAppearance.BorderSize = 2;
            this.btnB3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnB3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnB3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnB3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB3.Location = new System.Drawing.Point(648, 302);
            this.btnB3.Name = "btnB3";
            this.btnB3.Size = new System.Drawing.Size(107, 33);
            this.btnB3.TabIndex = 24;
            this.btnB3.Text = "B3";
            this.btnB3.UseVisualStyleBackColor = false;
            this.btnB3.Click += new System.EventHandler(this.btnB3_Click);
            // 
            // btnB7
            // 
            this.btnB7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnB7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnB7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnB7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnB7.FlatAppearance.BorderSize = 2;
            this.btnB7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnB7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnB7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnB7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB7.Location = new System.Drawing.Point(648, 341);
            this.btnB7.Name = "btnB7";
            this.btnB7.Size = new System.Drawing.Size(107, 33);
            this.btnB7.TabIndex = 25;
            this.btnB7.Text = "B7";
            this.btnB7.UseVisualStyleBackColor = false;
            this.btnB7.Click += new System.EventHandler(this.btnB7_Click);
            // 
            // btnB12
            // 
            this.btnB12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnB12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnB12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnB12.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnB12.FlatAppearance.BorderSize = 2;
            this.btnB12.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnB12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnB12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnB12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB12.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB12.Location = new System.Drawing.Point(761, 147);
            this.btnB12.Name = "btnB12";
            this.btnB12.Size = new System.Drawing.Size(107, 33);
            this.btnB12.TabIndex = 28;
            this.btnB12.Text = "B12";
            this.btnB12.UseVisualStyleBackColor = false;
            this.btnB12.Click += new System.EventHandler(this.btnB12_Click);
            // 
            // btnB11
            // 
            this.btnB11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnB11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnB11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnB11.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnB11.FlatAppearance.BorderSize = 2;
            this.btnB11.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnB11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnB11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnB11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB11.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB11.Location = new System.Drawing.Point(761, 108);
            this.btnB11.Name = "btnB11";
            this.btnB11.Size = new System.Drawing.Size(107, 33);
            this.btnB11.TabIndex = 27;
            this.btnB11.Text = "B11";
            this.btnB11.UseVisualStyleBackColor = false;
            this.btnB11.Click += new System.EventHandler(this.btnB11_Click);
            // 
            // btnB8
            // 
            this.btnB8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnB8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnB8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnB8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnB8.FlatAppearance.BorderSize = 2;
            this.btnB8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnB8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnB8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnB8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB8.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB8.Location = new System.Drawing.Point(761, 69);
            this.btnB8.Name = "btnB8";
            this.btnB8.Size = new System.Drawing.Size(107, 33);
            this.btnB8.TabIndex = 26;
            this.btnB8.Text = "DESCREDITAR";
            this.btnB8.UseVisualStyleBackColor = false;
            this.btnB8.Click += new System.EventHandler(this.btnB8_Click);
            // 
            // btnB15
            // 
            this.btnB15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnB15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnB15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnB15.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnB15.FlatAppearance.BorderSize = 2;
            this.btnB15.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnB15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnB15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnB15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB15.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB15.Location = new System.Drawing.Point(761, 263);
            this.btnB15.Name = "btnB15";
            this.btnB15.Size = new System.Drawing.Size(107, 33);
            this.btnB15.TabIndex = 31;
            this.btnB15.Text = "B15";
            this.btnB15.UseVisualStyleBackColor = false;
            this.btnB15.Click += new System.EventHandler(this.btnB15_Click);
            // 
            // btnB14
            // 
            this.btnB14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnB14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnB14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnB14.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnB14.FlatAppearance.BorderSize = 2;
            this.btnB14.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnB14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnB14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnB14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB14.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB14.Location = new System.Drawing.Point(761, 224);
            this.btnB14.Name = "btnB14";
            this.btnB14.Size = new System.Drawing.Size(107, 33);
            this.btnB14.TabIndex = 30;
            this.btnB14.Text = "B14";
            this.btnB14.UseVisualStyleBackColor = false;
            this.btnB14.Click += new System.EventHandler(this.btnB14_Click);
            // 
            // btnB13
            // 
            this.btnB13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnB13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnB13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnB13.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnB13.FlatAppearance.BorderSize = 2;
            this.btnB13.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnB13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnB13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnB13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB13.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB13.Location = new System.Drawing.Point(761, 185);
            this.btnB13.Name = "btnB13";
            this.btnB13.Size = new System.Drawing.Size(107, 33);
            this.btnB13.TabIndex = 29;
            this.btnB13.Text = "B13";
            this.btnB13.UseVisualStyleBackColor = false;
            this.btnB13.Click += new System.EventHandler(this.btnB13_Click);
            // 
            // btn200
            // 
            this.btn200.BackgroundImage = global::SerialCom.Properties.Resources._200_back;
            this.btn200.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn200.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn200.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn200.FlatAppearance.BorderSize = 2;
            this.btn200.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn200.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn200.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn200.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn200.Location = new System.Drawing.Point(511, 318);
            this.btn200.Name = "btn200";
            this.btn200.Size = new System.Drawing.Size(131, 66);
            this.btn200.TabIndex = 15;
            this.btn200.UseVisualStyleBackColor = true;
            this.btn200.Click += new System.EventHandler(this.btn200_Click);
            // 
            // btn100
            // 
            this.btn100.BackgroundImage = global::SerialCom.Properties.Resources._100_back;
            this.btn100.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn100.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn100.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn100.FlatAppearance.BorderSize = 2;
            this.btn100.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn100.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn100.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn100.Location = new System.Drawing.Point(511, 246);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(131, 66);
            this.btn100.TabIndex = 14;
            this.btn100.UseVisualStyleBackColor = true;
            this.btn100.Click += new System.EventHandler(this.btn100_Click);
            // 
            // btn50
            // 
            this.btn50.BackgroundImage = global::SerialCom.Properties.Resources._50_back;
            this.btn50.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn50.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn50.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn50.FlatAppearance.BorderSize = 2;
            this.btn50.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn50.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn50.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn50.Location = new System.Drawing.Point(511, 174);
            this.btn50.Name = "btn50";
            this.btn50.Size = new System.Drawing.Size(131, 66);
            this.btn50.TabIndex = 13;
            this.btn50.UseVisualStyleBackColor = true;
            this.btn50.Click += new System.EventHandler(this.btn50_Click);
            // 
            // btn20
            // 
            this.btn20.BackgroundImage = global::SerialCom.Properties.Resources._20_back;
            this.btn20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn20.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn20.FlatAppearance.BorderSize = 2;
            this.btn20.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn20.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn20.Location = new System.Drawing.Point(511, 102);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(131, 66);
            this.btn20.TabIndex = 12;
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Click += new System.EventHandler(this.btn20_Click);
            // 
            // btn10
            // 
            this.btn10.BackgroundImage = global::SerialCom.Properties.Resources._10_back;
            this.btn10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn10.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn10.FlatAppearance.BorderSize = 2;
            this.btn10.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn10.Location = new System.Drawing.Point(511, 30);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(131, 66);
            this.btn10.TabIndex = 11;
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 393);
            this.Controls.Add(this.btnB15);
            this.Controls.Add(this.btnB14);
            this.Controls.Add(this.btnB13);
            this.Controls.Add(this.btnB12);
            this.Controls.Add(this.btnB11);
            this.Controls.Add(this.btnB8);
            this.Controls.Add(this.btnB7);
            this.Controls.Add(this.btnB3);
            this.Controls.Add(this.btnExtra);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.btnAposta);
            this.Controls.Add(this.btnTurbo);
            this.Controls.Add(this.btnNumeros);
            this.Controls.Add(this.btnCartelas);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.btnAjuda);
            this.Controls.Add(this.btn200);
            this.Controls.Add(this.btn100);
            this.Controls.Add(this.btn50);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.Button_Refresh);
            this.Controls.Add(this.groupBoxSendData);
            this.Controls.Add(this.groupBoxReceiveData);
            this.Controls.Add(this.groupBoxReceiveSetting);
            this.Controls.Add(this.groupBoxSendSetting);
            this.Controls.Add(this.buttonOpenCloseCom);
            this.Controls.Add(this.groupBoxSerialPortSetting);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[Mercury Serial Communicator]";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxSerialPortSetting.ResumeLayout(false);
            this.groupBoxSerialPortSetting.PerformLayout();
            this.groupBoxSendSetting.ResumeLayout(false);
            this.groupBoxSendSetting.PerformLayout();
            this.groupBoxReceiveSetting.ResumeLayout(false);
            this.groupBoxReceiveSetting.PerformLayout();
            this.groupBoxReceiveData.ResumeLayout(false);
            this.groupBoxSendData.ResumeLayout(false);
            this.groupBoxSendData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem MenuSetting;
        private System.Windows.Forms.ToolStripMenuItem MenuIHelp;
        private System.Windows.Forms.GroupBox groupBoxSerialPortSetting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxStopBit;
        private System.Windows.Forms.ComboBox comboBoxCheckBit;
        private System.Windows.Forms.ComboBox comboBoxDataBit;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.ComboBox comboBoxCom;
        private System.Windows.Forms.Button buttonOpenCloseCom;
        private System.Windows.Forms.GroupBox groupBoxSendSetting;
        private System.Windows.Forms.RadioButton radioButtonSendDataASCII;
        private System.Windows.Forms.RadioButton radioButtonSendDataHex;
        private System.Windows.Forms.GroupBox groupBoxReceiveSetting;
        private System.Windows.Forms.RadioButton radioButtonReceiveDataASCII;
        private System.Windows.Forms.RadioButton radioButtonReceiveDataHEX;
        private System.Windows.Forms.GroupBox groupBoxReceiveData;
        private System.Windows.Forms.GroupBox groupBoxSendData;
        private System.Windows.Forms.Button buttonClearRecData;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.Button buttonSendData;
        private System.Windows.Forms.Button Button_Refresh;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ResetPortConfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveReceiveDataToFileToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Button btn50;
        private System.Windows.Forms.Button btn200;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Button btnTurbo;
        private System.Windows.Forms.Button btnNumeros;
        private System.Windows.Forms.Button btnCartelas;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnExtra;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnAposta;
        private System.Windows.Forms.Button btnB3;
        private System.Windows.Forms.Button btnB7;
        private System.Windows.Forms.Button btnB12;
        private System.Windows.Forms.Button btnB11;
        private System.Windows.Forms.Button btnB8;
        private System.Windows.Forms.Button btnB15;
        private System.Windows.Forms.Button btnB14;
        private System.Windows.Forms.Button btnB13;
    }
}

