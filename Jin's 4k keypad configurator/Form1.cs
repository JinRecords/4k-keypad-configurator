using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Jin_s_4k_keypad_configurator
{
    public partial class Form1 : Form
    {
        private string in_data;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Get all ports
            string[] ports = SerialPort.GetPortNames();


            cboPort.Items.AddRange(ports);
            cboPort.SelectedIndex = 0;
            btnClose.Enabled = false;
            textboxKey1.Enabled = false;
            textboxKey2.Enabled = false;
            textboxKey3.Enabled = false;
            textboxKey4.Enabled = false;




        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
        }
        private void btnOpen_Click_1(object sender, EventArgs e)
        {
            btnOpen.Enabled = false;
            btnClose.Enabled = true;
            try
            {
                //Open port
                serialPort1.PortName = cboPort.Text;
                serialPort1.Open();
                textboxKey1.Enabled = true;
                textboxKey2.Enabled = true;
                textboxKey3.Enabled = true;
                textboxKey4.Enabled = true;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            {
                btnOpen.Enabled = true;
                btnClose.Enabled = false;
                try
                {
                    serialPort1.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textboxTest.Clear();
        }

        private void btnflash_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (serialPort1.IsOpen)
                    {


                        //send data to keypad
                        serialPort1.Write("0");
                        new System.Threading.ManualResetEvent(false).WaitOne(800);
                        progressBar1.Value = 17;
                        serialPort1.Write(textboxKey1.Text);
                        new System.Threading.ManualResetEvent(false).WaitOne(1300);
                        progressBar1.Value = 45;
                        serialPort1.Write(textboxKey2.Text);
                        new System.Threading.ManualResetEvent(false).WaitOne(1300);
                        progressBar1.Value = 73;
                        serialPort1.Write(textboxKey3.Text);
                        new System.Threading.ManualResetEvent(false).WaitOne(1300);
                        serialPort1.Write(textboxKey4.Text);
                        progressBar1.Value = 100;
                        textboxKey1.Clear();
                        textboxKey2.Clear();
                        textboxKey3.Clear();
                        textboxKey4.Clear();

                    }

                }


                catch (Exception)
                {
                    progressBar1.Value = 0;
                    MessageBox.Show("Conection is closed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                textboxKey1.Clear();

            }
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            try
            {
                in_data = serialPort1.ReadLine();
                this.Invoke(new EventHandler(displaymydata_event));
            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
            }
        }
        private void displaymydata_event(object sender, EventArgs e)
        {
            consoleOutput2.AppendText(" " + in_data + "\n");
            consoleOutput2.SelectionStart = consoleOutput2.Text.Length;
            // scroll it automatically
            consoleOutput2.ScrollToCaret();
        }
        private void btnSend_Click_1(object sender, EventArgs e)
        {
            serialPort1.Write(consoleInput.Text);
            consoleOutput2.AppendText(" User: " + consoleInput.Text + "\n");
            consoleInput.Clear();
        }

        private void consoleInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                serialPort1.Write(consoleInput.Text);
                consoleOutput2.AppendText(" User: " + consoleInput.Text + "\n");
                consoleInput.Clear();
            }
        }
        private void btnclear2_Click(object sender, EventArgs e)
        {
            consoleOutput2.Clear();
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["Console"];
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["Configurator"];
        }

        
    }
}



