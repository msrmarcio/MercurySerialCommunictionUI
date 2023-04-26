using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialCom
{
    public partial class MainForm : Form
    {
        string cincoReais = "N005";
        string dezReais = "N010";
        string vinteReais = "N020";
        string cinquentaReais = "N050";
        string cemReais = "N100";
        string duzentosReais = "N200";

        string cmdExtra = "B0";
        string cmdNumeros = "B1";
        string cmdCartelas = "B2";
        string cmdJogar = "B4";
        string cmdAposta = "B5";
        string cmdAjuda = "B6";
        string cmdCobrar = "B9";
        string cmdTurbo = "B10";

        string cmdB3 = "B3";
        string cmdB7 = "B7";
        string cmdB8 = "B8";
        string cmdB11 = "B11";
        string cmdB12 = "B12";
        string cmdB13 = "B13";
        string cmdB14 = "B14";
        string cmdB15 = "B15";
        string cmdB16 = "B16";

        bool sidebarExpand;

        //Instancia o objeto porta serial
        SerialPort serialPort = new SerialPort();

        String saveDataFile = null;
        FileStream saveDataFS = null;

        public MainForm()
        {
            InitializeComponent();


        }


        //Inicializa as configurações dos parâmetros da interface da porta serial
        private void Init_Port_Confs()
        {
            /*------Configuração do parâmetro da interface da porta serial------*/

            //Verifica se existe porta serial
            string[] str = SerialPort.GetPortNames();
            if (str == null)
            {
                MessageBox.Show("Esta máquina não possui porta serial!", "Erro");
                return;
            }
            //adiciona porta serial
            foreach (string s in str)
            {
                comboBoxCom.Items.Add(s);
            }
            //Configura as opções de porta serial padrão
            comboBoxCom.SelectedIndex = 0;

            /*------Configuração da taxa de transmissão-------*/
            string[] baudRate = { "9600", "19200", "38400", "57600", "115200" };
            foreach (string s in baudRate)
            {
                comboBoxBaudRate.Items.Add(s);
            }
            comboBoxBaudRate.SelectedIndex = 0;

            /*------configuração do bit de dados-------*/
            string[] dataBit = { "5", "6", "7", "8" };
            foreach (string s in dataBit)
            {
                comboBoxDataBit.Items.Add(s);
            }
            comboBoxDataBit.SelectedIndex = 3;


            /*------verificar configuração de dígito-------*/
            string[] checkBit = { "None", "Even", "Odd", "Mask", "Space" };
            foreach (string s in checkBit)
            {
                comboBoxCheckBit.Items.Add(s);
            }
            comboBoxCheckBit.SelectedIndex = 0;


            /*------configuração do bit de parada-------*/
            string[] stopBit = { "1", "1.5", "2" };
            foreach (string s in stopBit)
            {
                comboBoxStopBit.Items.Add(s);
            }
            comboBoxStopBit.SelectedIndex = 0;

            /*------configuração do formato de dados-------*/
            radioButtonSendDataASCII.Checked = true;
            radioButtonReceiveDataASCII.Checked = true;
        }

        //carrega o formulário principal
        private void MainForm_Load(object sender, EventArgs e)
        {

            Init_Port_Confs();

            Control.CheckForIllegalCrossThreadCalls = false;
            serialPort.DataReceived += new SerialDataReceivedEventHandler(dataReceived);


            //Preparar                            
            serialPort.DtrEnable = true;
            serialPort.RtsEnable = true;
            //Define o tempo limite de leitura de dados para 1 segundo
            //serialPort.ReadTimeout = 1000;

            serialPort.Close();

            buttonSendData.Enabled = false;

        }


        //Abre a porta serial e fecha a porta serial
        private void buttonOpenCloseCom_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)//A porta serial está fechada
            {

                try
                {

                    if (comboBoxCom.SelectedIndex == -1)
                    {
                        MessageBox.Show("Erro: porta inválida, escolha novamente", "Error");
                        return;
                    }
                    string strSerialName = comboBoxCom.SelectedItem.ToString();
                    string strBaudRate = comboBoxBaudRate.SelectedItem.ToString();
                    string strDataBit = comboBoxDataBit.SelectedItem.ToString();
                    string strCheckBit = comboBoxCheckBit.SelectedItem.ToString();
                    string strStopBit = comboBoxStopBit.SelectedItem.ToString();

                    Int32 iBaudRate = Convert.ToInt32(strBaudRate);
                    Int32 iDataBit = Convert.ToInt32(strDataBit);

                    serialPort.PortName = strSerialName;//número da porta serial
                    serialPort.BaudRate = iBaudRate;//taxa de transmissão
                    serialPort.DataBits = iDataBit;//bits de dados



                    switch (strStopBit)            //bit de parada
                    {
                        case "1":
                            serialPort.StopBits = StopBits.One;
                            break;
                        case "1.5":
                            serialPort.StopBits = StopBits.OnePointFive;
                            break;
                        case "2":
                            serialPort.StopBits = StopBits.Two;
                            break;
                        default:
                            MessageBox.Show("Error：O parâmetro stop bit está incorreto!", "Error");
                            break;
                    }
                    switch (strCheckBit) //verifica o bit
                    {
                        case "None":
                            serialPort.Parity = Parity.None;
                            break;
                        case "Odd":
                            serialPort.Parity = Parity.Odd;
                            break;
                        case "Even":
                            serialPort.Parity = Parity.Even;
                            break;
                        default:
                            MessageBox.Show("Error：Parâmetro de dígito de verificação incorreto!", "Error");
                            break;
                    }



                    if (saveDataFile != null)
                    {
                        saveDataFS = File.Create(saveDataFile);
                    }

                    //abre a porta serial
                    serialPort.Open();

                    //As configurações não serão mais válidas após a abertura da porta serial
                    comboBoxCom.Enabled = false;
                    comboBoxBaudRate.Enabled = false;
                    comboBoxDataBit.Enabled = false;
                    comboBoxCheckBit.Enabled = false;
                    comboBoxStopBit.Enabled = false;
                    radioButtonSendDataASCII.Enabled = false;
                    radioButtonSendDataHex.Enabled = false;
                    radioButtonReceiveDataASCII.Enabled = false;
                    radioButtonReceiveDataHEX.Enabled = false;
                    buttonSendData.Enabled = true;
                    Button_Refresh.Enabled = false;

                    buttonOpenCloseCom.Text = "Fechar a porta serial";
                    buttonOpenCloseCom.BackColor = Color.Red;
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "Error");
                    return;
                }
            }
            else //A porta serial está aberta
            {

                serialPort.Close();//  Fecha a porta serial 
                //A configuração é válida quando a porta serial está fechada
                comboBoxCom.Enabled = true;
                comboBoxBaudRate.Enabled = true;
                comboBoxDataBit.Enabled = true;
                comboBoxCheckBit.Enabled = true;
                comboBoxStopBit.Enabled = true;
                radioButtonSendDataASCII.Enabled = true;
                radioButtonSendDataHex.Enabled = true;
                radioButtonReceiveDataASCII.Enabled = true;
                radioButtonReceiveDataHEX.Enabled = true;
                buttonSendData.Enabled = false;
                Button_Refresh.Enabled = true;

                buttonOpenCloseCom.Text = "porta serial aberta";
                buttonOpenCloseCom.BackColor = Color.Lime;


                if (saveDataFS != null)
                {
                    saveDataFS.Close(); // fecha o arquivo
                    saveDataFS = null;//Libera o identificador de arquivo
                }

            }
        }

        //receber dados
        private void dataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                //MessageBox.Show("sss","OK");
                //tempo atual de saída
                DateTime dateTimeNow = DateTime.Now;
                //dateTimeNow.GetDateTimeFormats(); 
                //dateTimeNow.GetDateTimeFormats('f')[0].ToString() + "\r\n"; 

                if (radioButtonReceiveDataASCII.Checked == true) //O formato de recebimento é ASCII
                {
                    try
                    {
                        String input = serialPort.ReadExisting();
                        //String input = serialPort.ReadLine(); 

                        richTextBox1.ForeColor = Color.Red;
                        richTextBox1.AppendText(string.Format("{0} - [OUT] -> {1}\r\n", DateTime.Now, input));

                        // save data to file
                        if (saveDataFS != null)
                        {
                            byte[] info = new UTF8Encoding(true).GetBytes(input + "\r\n");
                            saveDataFS.Write(info, 0, info.Length);
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Há algum problema com sua taxa de transmissão?？？？");
                        return;
                    }

                    //textBoxReceive.SelectionStart = textBoxReceive.Text.Length;
                    //textBoxReceive.ScrollToCaret();//role para o cursor

                    richTextBox1.SelectionStart = richTextBox1.Text.Length;
                    richTextBox1.ScrollToCaret();

                    serialPort.DiscardInBuffer(); //Limpe o Buffer do controle SerialPort 
                }
                else //O formato de recebimento é HEX
                {
                    try
                    {

                        string input = serialPort.ReadLine();
                        char[] values = input.ToCharArray();
                        foreach (char letter in values)
                        {
                            // Get the integral value of the character.
                            int value = Convert.ToInt32(letter);
                            // Convert the decimal value to a hexadecimal value in string form.
                            string hexOutput = String.Format("{0:X}", value);
                            richTextBox1.AppendText(hexOutput + " ");
                            richTextBox1.SelectionStart = richTextBox1.Text.Length;
                            richTextBox1.ScrollToCaret();//role para o cursor
                            //textBoxReceive.Text += hexOutput + " ";

                        }

                        // save data to file
                        if (saveDataFS != null)
                        {
                            byte[] info = new UTF8Encoding(true).GetBytes(input + "\r\n");
                            saveDataFS.Write(info, 0, info.Length);
                        }


                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                        richTextBox1.Text = "";//vazio
                    }
                }
            }
            else
            {
                MessageBox.Show("Abra uma porta serial", "Prompt de erro");
            }
        }

        //enviar dados
        private void buttonSendData_Click(object sender, EventArgs e)
        {
            SendDataBySerial(textBoxSend.Text.Trim());

        }

        private void SendDataBySerial(string strComando)
        {
            if (!serialPort.IsOpen)
            {
                MessageBox.Show("Por favor, abra a porta serial primeiro", "Error");
                return;
            }

            //String strSend = ("#" + textBoxSend.Text + ".").Trim(); //enviar dados da caixa
            String strSend = string.Format("#{0}.", strComando);

            if (radioButtonSendDataASCII.Checked == true)//enviar como string ASCII
            {
                serialPort.WriteLine(strSend);//enviar uma linha de dados 
                richTextBox1.ForeColor = Color.Blue;
                richTextBox1.AppendText(string.Format("{0} - [IN ] -> {1} \r\n", DateTime.Now, strSend));
            }
            else
            {
                //Envio de formato de dados hexadecimais HXE

                char[] values = strSend.ToCharArray();
                foreach (char letter in values)
                {
                    // Get the integral value of the character.
                    int value = Convert.ToInt32(letter);
                    // Convert the decimal value to a hexadecimal value in string form.
                    string hexIutput = String.Format("{0:X}", value);
                    serialPort.WriteLine(hexIutput);

                }
            }
        }

        //Limpe o quadro de dados recebidos
        private void buttonClearRecData_Click(object sender, EventArgs e)
        {

            richTextBox1.Text = "";

        }


        //quando o formulário é fechado
        private void MainForm_Closing(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }

            if (saveDataFS != null)
            {
                saveDataFS.Close(); //close file
                saveDataFS = null;//release the file handle
            }

        }

        //Refresh the serial port
        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            comboBoxCom.Text = "";
            comboBoxCom.Items.Clear();

            string[] str = SerialPort.GetPortNames();
            if (str == null)
            {
                MessageBox.Show("This machine has no serial port！", "Error");
                return;
            }

            //添加串口
            foreach (string s in str)
            {
                comboBoxCom.Items.Add(s);
            }

            //设置默认串口
            comboBoxCom.SelectedIndex = 0;
            comboBoxBaudRate.SelectedIndex = 0;
            comboBoxDataBit.SelectedIndex = 3;
            comboBoxCheckBit.SelectedIndex = 0;
            comboBoxStopBit.SelectedIndex = 0;

        }

        // 退出
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();//feche a porta serial
            }
            if (saveDataFS != null)
            {
                saveDataFS.Close(); // fechar arquivo
                saveDataFS = null;//solte o identificador de arquivo
            }

            this.Close();
        }

        // Redefinir configurações de parâmetro da porta serial
        private void ResetPortConfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBoxCom.SelectedIndex = 0;
            comboBoxBaudRate.SelectedIndex = 0;
            comboBoxDataBit.SelectedIndex = 3;
            comboBoxCheckBit.SelectedIndex = 0;
            comboBoxStopBit.SelectedIndex = 0;
            radioButtonSendDataASCII.Checked = true;
            radioButtonReceiveDataASCII.Checked = true;

        }

        // Salvar dados recebidos em arquivo
        private void SaveReceiveDataToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Txt |*.txt";
            saveFileDialog.Title = "Salvar os dados recebidos no arquivo";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != null)
            {
                saveDataFile = saveFileDialog.FileName;
            }


        }

        private void textBoxSend_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox currentContainer = ((TextBox)sender);
            int caretPosition = currentContainer.SelectionStart;

            currentContainer.Text = currentContainer.Text.ToUpper();
            currentContainer.SelectionStart = caretPosition++;
        }



        private void btn10_Click(object sender, EventArgs e)
        {
            SendDataBySerial(dezReais);
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            SendDataBySerial(vinteReais);
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            SendDataBySerial(cinquentaReais);

        }

        private void btn100_Click(object sender, EventArgs e)
        {
            SendDataBySerial(cemReais);

        }

        private void btn200_Click(object sender, EventArgs e)
        {
            SendDataBySerial(duzentosReais);

        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            SendDataBySerial(cmdAjuda);

        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            SendDataBySerial(cmdCobrar);

        }

        private void btnCartelas_Click(object sender, EventArgs e)
        {
            SendDataBySerial(cmdCartelas);

        }

        private void btnNumeros_Click(object sender, EventArgs e)
        {
            SendDataBySerial(cmdNumeros);

        }

        private void btnTurbo_Click(object sender, EventArgs e)
        {
            SendDataBySerial(cmdTurbo);

        }

        private void btnAposta_Click(object sender, EventArgs e)
        {
            SendDataBySerial(cmdAposta);

        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            SendDataBySerial(cmdJogar);
        }

        private void btnExtra_Click(object sender, EventArgs e)
        {
            SendDataBySerial(cmdExtra);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            // scroll it automatically
            richTextBox1.ScrollToCaret();
        }

        private void textBoxSend_Enter(object sender, EventArgs e)
        {
            this.textBoxSend.BackColor = Color.Yellow;
        }

        private void textBoxSend_Leave(object sender, EventArgs e)
        {
            this.textBoxSend.BackColor = Color.White;
        }
         

        private void btnB3_Click(object sender, EventArgs e)
        {
            SendDataBySerial(cmdB3);

        }

        private void btnB7_Click(object sender, EventArgs e)
        {
            SendDataBySerial(cmdB7);
        }

        private void btnB8_Click(object sender, EventArgs e)
        {
            SendDataBySerial(cmdB8);
        }

        private void btnB11_Click(object sender, EventArgs e)
        {
            SendDataBySerial(cmdB11);
        }

        private void btnB12_Click(object sender, EventArgs e)
        {
            SendDataBySerial(cmdB12);
        }

        private void btnB13_Click(object sender, EventArgs e)
        {
            SendDataBySerial(cmdB13);
        }

        private void btnB14_Click(object sender, EventArgs e)
        {
            SendDataBySerial(cmdB14);
        }

        private void btnB15_Click(object sender, EventArgs e)
        {
            SendDataBySerial(cmdB15);
        }
    }
}
