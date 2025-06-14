using System;
using System.IO.Ports;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinLoRaDTM
{
    public partial class Main : Form
    {
        private SerialPort serialPortTX;
        private SerialPort serialPortRX;
        private bool isTXPortOpen = false;
        private bool isRXPortOpen = false;
        String ReceivedData = string.Empty;
        byte[] ReceivedBytes = [];

        private int serialBaudRate = 115200; // Set the baud rate as needed
        private int serialDataBits = 8; // Set data bits 
        private Parity serialParity = Parity.None; // Set parity    
        private StopBits serialStopBits = StopBits.One; // Set stop bits
        private Handshake serialHandshake = Handshake.None; // Set handshake method
        private int serialReadTimeout = 1000; // Set read timeout 
        private int serialWriteTimeout = 1000; // Set write timeout
        private Encoding serialEncoding = Encoding.UTF8; // Set encoding to UTF-8

        public Main()
        {
            InitializeComponent();
            serialPortTX = new SerialPort();
            serialPortRX = new SerialPort();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            PopulateTXComPortsComboBox(comboBoxComPortSelectionTX);
            PopulateRXComPortsComboBox(comboBoxComPortSelectionRX);
        }

        private void PopulateTXComPortsComboBox(System.Windows.Forms.ComboBox comboBox)
        {
            comboBox.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            comboBox.Items.Add("None");
            comboBox.Items.AddRange(ports);
            comboBox.SelectedIndex = 0; // @TODO: set default selection to None
        }

        private void PopulateRXComPortsComboBox(System.Windows.Forms.ComboBox comboBox)
        {
            comboBox.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            comboBox.Items.Add("None");
            comboBox.Items.AddRange(ports);
            comboBox.SelectedIndex = 0; // @TODO: set default selection to None
        }

        private void buttonTXOpenClose_Click(object sender, EventArgs e)
        {
            if (comboBoxComPortSelectionTX.SelectedItem == null)
            {
                MessageBox.Show("Please select a COM port first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (comboBoxComPortSelectionTX.SelectedItem.ToString() == "None")
            {
                MessageBox.Show("No COM port selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!isTXPortOpen)
            {
                try
                {
                    serialPortTX.PortName = comboBoxComPortSelectionTX.SelectedItem.ToString();
                    serialPortTX.BaudRate = serialBaudRate;
                    serialPortTX.DataBits = serialDataBits;
                    serialPortTX.Parity = serialParity;
                    serialPortTX.StopBits = serialStopBits;
                    serialPortTX.Handshake = serialHandshake;
                    serialPortTX.ReadTimeout = serialReadTimeout;
                    serialPortTX.WriteTimeout = serialWriteTimeout;
                    serialPortTX.Encoding = serialEncoding;
                    serialPortTX.Open();
                    isTXPortOpen = true;
                    buttonTXOpenClose.Text = "Close Port";
                    textBoxTX.AppendText("Port opened successfully.\r\n");
                    statusStrip.Items[0].Text = $"TX Port: {serialPortTX.PortName} Opened";
                    comboBoxComPortSelectionTX.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to open port: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                try
                {
                    serialPortTX.Close();
                    isTXPortOpen = false;
                    buttonTXOpenClose.Text = "Open Port";
                    textBoxTX.AppendText("Port closed successfully.\r\n");
                    statusStrip.Items[0].Text = "TX Port: Closed";
                    comboBoxComPortSelectionTX.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to close port: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }

        }

        private void buttonRXOpenClose_Click(object sender, EventArgs e)
        {
            if (comboBoxComPortSelectionRX.SelectedItem == null)
            {
                MessageBox.Show("Please select a COM port first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (comboBoxComPortSelectionRX.SelectedItem.ToString() == "None")
            {
                MessageBox.Show("No COM port selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!isRXPortOpen)
            {
                try
                {
                    serialPortRX.PortName = comboBoxComPortSelectionRX.SelectedItem.ToString();
                    serialPortRX.BaudRate = serialBaudRate;
                    serialPortRX.DataBits = serialDataBits;
                    serialPortRX.Parity = serialParity;
                    serialPortRX.StopBits = serialStopBits;
                    serialPortRX.Handshake = serialHandshake;
                    serialPortRX.ReadTimeout = serialReadTimeout;
                    serialPortRX.WriteTimeout = serialWriteTimeout;
                    serialPortRX.Encoding = serialEncoding;
                    serialPortRX.DataReceived += new SerialDataReceivedEventHandler(serialPortRX_DataReceived);
                    serialPortRX.Open();
                    isRXPortOpen = true;
                    buttonRXOpenClose.Text = "Close Port";
                    textBoxRX.AppendText("Port opened successfully.\r\n");
                    statusStrip.Items[1].Text = $"RX Port: {serialPortRX.PortName} Opened";
                    comboBoxComPortSelectionRX.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to open port: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                try
                {
                    serialPortRX.Close();
                    isRXPortOpen = false;
                    buttonRXOpenClose.Text = "Open Port";
                    textBoxRX.AppendText("Port closed successfully.\r\n");
                    statusStrip.Items[1].Text = "RX Port: Closed";
                    comboBoxComPortSelectionRX.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to close port: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isTXPortOpen)
            {
                try
                {
                    serialPortTX.Close();
                    serialPortRX.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error closing port on exit: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Close();
        }

        private void comboBoxComPortSelectionTX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxComPortSelectionTX.SelectedItem != null && comboBoxComPortSelectionTX.SelectedItem.ToString() != "None")
            {
                if (comboBoxComPortSelectionTX.SelectedItem.ToString() == comboBoxComPortSelectionRX.SelectedItem.ToString())
                {
                    comboBoxComPortSelectionRX.SelectedIndex = 0; // Reset RX selection if it matches TX
                    buttonTXOpenClose.Enabled = false;
                }
                buttonTXOpenClose.Enabled = true;
            }
            else if (comboBoxComPortSelectionTX.SelectedItem.ToString() == "None")
            {
                // Enable the button only if a valid port is selected
                buttonTXOpenClose.Enabled = false;
            }
            else
            {
                buttonTXOpenClose.Enabled = true;
            }
        }

        private void comboBoxComPortSelectionRX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxComPortSelectionRX.SelectedItem != null && comboBoxComPortSelectionRX.SelectedItem.ToString() != "None")
            {
                if (comboBoxComPortSelectionRX.SelectedItem.ToString() == comboBoxComPortSelectionTX.SelectedItem.ToString())
                {
                    comboBoxComPortSelectionTX.SelectedIndex = 0; // Reset TX selection if it matches RX
                    buttonRXOpenClose.Enabled = false;
                }
                buttonRXOpenClose.Enabled = true;
            }
            else if (comboBoxComPortSelectionRX.SelectedItem.ToString() == "None")
            {
                // Enable the button only if a valid port is selected
                buttonRXOpenClose.Enabled = false;
            }
            else
            {
                buttonRXOpenClose.Enabled = true;
            }
        }

        private void buttonTX_Click(object sender, EventArgs e)
        {
            // @TODO: toggle enable/disable buttonTX based on port status
            // @TODO: add error handling for sending data
            String sentMessage = textBoxMessage.Text.Trim();
            serialPortTX.WriteLine(sentMessage);
            //byte[] bytes = Encoding.UTF8.GetBytes(sentMessage);
            //serialPortTX.Write(bytes, 0, bytes.Length);
            textBoxTX.AppendText($"Sent: {sentMessage}\r\n");
        }

        //Received data event  
        private void serialPortRX_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try {
                //ReceivedData = serialPortRX.ReadLine();
                //ReceivedData = serialPortRX.ReadExisting();
                //ReceivedData = serialPortRX.ReadTo("\r\n"); // Read until newline character

                //while ((sender as SerialPort).BytesToRead > 0)
                //{
                //    ReceivedBytes = (sender as SerialPort).ReadExisting();
                //}
                //(sender as SerialPort).DiscardInBuffer();
                //ReceivedData = Encoding.UTF8.GetString(ReceivedBytes); // Trim any extra whitespace or newlines

                int bytesToRead = serialPortRX.BytesToRead;
                byte[] data = new byte[bytesToRead];
                int actualBytesRead = 0;
                do
                {
                    actualBytesRead = serialPortRX.Read(data, 0, bytesToRead);
                } while (actualBytesRead != bytesToRead);

                ReceivedData = actualBytesRead > 0 ? Encoding.UTF8.GetString(data, 0, actualBytesRead).Trim() : string.Empty;
            }
            catch (Exception ex)
            {
                textBoxRX.AppendText($"Error reading data: {ex.Message}\r\n");
                return;
            }
            //String receivedMessage = serialPortRX.ReadExisting(); // Read all available data
            //String receivedMessage = serialPortRX.ReadLine(); // Read a line of data
            this.Invoke(new EventHandler(interp_string));
            
        }

        private void interp_string(object sender, EventArgs e)
        {
            textBoxRX.AppendText(ReceivedData.ToString() + "\r\n");
            ReceivedData = string.Empty; // Clear the buffer after processing
        }
    }
}
