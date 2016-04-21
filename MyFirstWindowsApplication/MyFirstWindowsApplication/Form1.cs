using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWindowsApplication
{
    public partial class Form1 : Form
    {
        private command selectedCommand;
        private type selectedType;
        private string rxString;

        public Form1()
        {
            InitializeComponent();
            InitializeCommandList();
            InitializePortBox();
            InitializeBaudRateBox();
            InitializeAdvancedCommandBox();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            InitializePortBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void commandChange(object sender, EventArgs e)
        {
            var selectedCommandString = advancedCommandBox.SelectedItem.ToString();
            commandTypeBox.Items.Clear();
            selectedCommand = commandsList.Single(s => s.name.Equals(selectedCommandString));
            var types = selectedCommand.types.Select(s => s.variant);
            commandTypeBox.Items.AddRange(listOfEnumsToListOfStrings(types).ToArray());
            commandTypeBox.SelectedIndex = 0;
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
            functionLabel.Text = selectedType.description;
            functionLabel.Visible = true;

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
            if (comPortBox.SelectedItem != null && baudRateBox.SelectedItem != null)
            {
                serialPort.BaudRate = int.Parse(baudRateBox.SelectedItem.ToString());
                serialPort.PortName = comPortBox.SelectedItem.ToString();
                serialPort.Open();
                if (serialPort.IsOpen)
                {
                    statusLabel.Text = "Connected";
                    statusLabel.ForeColor = Color.Green;
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
            feedBox.SelectionStart = feedBox.TextLength;
            feedBox.ScrollToCaret();
        }
    }
}