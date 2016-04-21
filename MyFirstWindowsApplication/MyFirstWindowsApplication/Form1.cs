using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace MyFirstWindowsApplication
{
    public partial class Form1 : Form
    {
        private command selectedCommand;
        private type selectedType;
        private string rxString;
        private bool connected = false;

        public Form1()
        {
            InitializeComponent();
            InitializeCommandList();
            InitializeBaudRateBox();
            InitializeAdvancedCommandBox();
        }

        private void commandChange(object sender, EventArgs e)
        {
            var selectedCommandString = advancedCommandBox.SelectedItem.ToString();
            commandTypeBox.Items.Clear();
            selectedCommand = commandsList.Single(s => s.name.Equals(selectedCommandString));
            var types = selectedCommand.types.Select(s => s.variant);
            commandTypeBox.Items.AddRange(listOfEnumsToListOfStrings(types).ToArray());
            commandTypeBox.SelectedIndex = 0;
            if (selectedCommand.description != null)
            {
                descriptionTitleLabel.Visible = true;
                descriptionLabel.Visible = true;
            }
            else{
                descriptionTitleLabel.Visible = false;
                descriptionLabel.Visible = false;
            }
        }

        private List<string> listOfEnumsToListOfStrings(IEnumerable<commandType> enumsList)
        {
            List<string> stringsList = new List<string>();
            foreach (var item in enumsList)
            {
                stringsList.Add(item.ToString());
            }
            return stringsList;
        }

        private void commandTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedEnum = Enum.Parse(typeof(commandType), commandTypeBox.SelectedItem.ToString());
            selectedType = selectedCommand.types.Single(s => s.variant.Equals(selectedEnum));
            if (selectedType.description != null)
            {
                functionLabel.Text = selectedType.description;
                functionLabel.Visible = true;
                functionTitle.Visible = true;
            }
            else
            {
                functionLabel.Visible = false;
                functionTitle.Visible = false;
            }

            if (selectedType.parameters != null)
            {
                string parameters = null;
                foreach (var parameter in selectedType.parameters)
                {
                    parameters += parameter.name + ": " + parameter.description + "\n";
                }
                parametersLabel.Text = parameters;
                parametersLabel.Visible = true;
                parametersNameLabel.Visible = true;
            }
            else
            {
                parametersLabel.Visible = false;
                parametersNameLabel.Visible = false;
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (connected)
            {
                serialPort.Close();
                statusLabel.Text = "Not onnected";
                statusLabel.ForeColor = Color.Red;
                connectButton.Text = "Connect";
                connected = false;
            }
            else {
                if (comPortBox.SelectedItem != null && baudRateBox.SelectedItem != null)
                {
                    serialPort.BaudRate = int.Parse(baudRateBox.SelectedItem.ToString());
                    serialPort.PortName = comPortBox.SelectedItem.ToString();
                    serialPort.Open();
                    if (serialPort.IsOpen)
                    {
                        statusLabel.Text = "Connected";
                        statusLabel.ForeColor = Color.Green;
                        connectButton.Text = "Disconnect";
                        connected = true;
                    }
                }
            }
        }

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            rxString = serialPort.ReadExisting();
            this.Invoke(new EventHandler(displayText));  
        }

        private void displayText(object sender, EventArgs e)
        {
            feedBox.AppendText(rxString);
            feedBox.ScrollToCaret();
        }

        private void comPortBox_DropDown(object sender, EventArgs e)
        {
            var portNames = SerialPort.GetPortNames();
            if (portNames != null)
            {
                comPortBox.Items.Clear();
                comPortBox.Items.AddRange(portNames);
            }
            else
            {
                comPortBox.Items.Clear();
                comPortBox.Text = "COM Port";
            }
        }

        private void AT_Click(object sender, EventArgs e)
        {
            serialWriteBasic(AT.Text);
        }

        private void ATRST_Click(object sender, EventArgs e)
        {
            serialWriteBasic(ATRST.Text);   
        }

        private void ATGMR_Click(object sender, EventArgs e)
        {
            serialWriteBasic(ATGMR.Text);
        }

        private void ATEO_Click(object sender, EventArgs e)
        {
            serialWriteBasic(ATEO.Text);
        }

        private void ATEI_Click(object sender, EventArgs e)
        {
            serialWriteBasic(ATEI.Text);
        }

        private void ATCWLAP_Click(object sender, EventArgs e)
        {
            serialWriteBasic(ATCWLAP.Text);
        }

        private void ATCWQAP_Click(object sender, EventArgs e)
        {
            serialWriteBasic(ATCWQAP.Text);
        }

        private void ATCWLIF_Click(object sender, EventArgs e)
        {
            serialWriteBasic(ATCWLIF.Text);
        }

        private void ATCIPSTATUS_Click(object sender, EventArgs e)
        {
            serialWriteBasic(ATCIPSTATUS.Text);
        }

        private void ATCIFSR_Click(object sender, EventArgs e)
        {
            serialWriteBasic(ATCIFSR.Text);
        }

        private void serialWriteBasic(string atCommand)
        {
            if (connected)
            {
                serialPort.Write(atCommand + "\r\n");
            }
        }
    }
}