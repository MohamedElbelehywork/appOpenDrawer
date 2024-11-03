using System;
using System.IO.Ports;
using System.Reflection;
using System.Windows.Forms;

namespace appOpenDrawer
{
    public partial class Form1 : Form
    {

        private SerialPort _serialPort;

        public Form1()
        {
            InitializeComponent();
            SetupSerialPort();
            SetFormTitle();
        }

        private void SetupSerialPort()
        {
            // Replace "COM3" with your cash drawer's COM port
            _serialPort = new SerialPort("COM3", 9600);
            try
            {
                _serialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening port: " + ex.Message);
            }
        }

        private void SetFormTitle()
        {
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            this.Text = $"فتح درج النقدية - V.{version.Major}.{version.Minor}.{version.Build}.{version.Revision}";
        }

        private void OpenCashDrawer()
        {
            // ESC/POS command to open cash drawer
            // Common commands are:
            // 1. Send 27, 112, 48, 55, 121
            // 2. Send 27, 105 for some models
            try
            {
                byte[] command = new byte[] { 27, 112, 48, 55, 121 };
                _serialPort.Write(command, 0, command.Length);
                MessageBox.Show("Cash drawer opened!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (_serialPort != null && _serialPort.IsOpen)
            {
                _serialPort.Close();
            }
            base.OnFormClosing(e);
        }

        private void btnOpenDrawer_Click(object sender, EventArgs e)
        {
            OpenCashDrawer();
        }
    }
}
