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

namespace esp8266Commander
{
    public partial class param1 : Form
    {
        private command selectedCommand;
        private type selectedType;
        private string rxString;
        private bool connected = false;

        private string[] textBoxPlaceholder = new string[4];

        public param1()
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

            if (selectedType.response != null)
            {
                responseTitle.Visible = true;
                responseLabel.Text = selectedType.response;
                responseLabel.Visible = true;
            }
            else
            {
                responseTitle.Visible = false;
                responseLabel.Visible = false;
            }

            if (selectedType.variant == commandType.Set)
            {
                enableParamBoxes(false);
                for (int i = 0; i < selectedType.parameters.Count; i++)
                {
                    enableParamBox(i, selectedType.parameters.ElementAt(i).name);
                }
            }
            else
            {
                enableParamBoxes(false);
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

        private void enableParamBox(int id, string paramName)
        {
            textBoxPlaceholder[id] = paramName;
            switch (id)
            {
                case 0:
                    paramBox1.Enabled = true;
                    paramBox1.Text = paramName;
                    break;
                case 1:
                    paramBox2.Enabled = true;
                    paramBox2.Text = paramName;
                    break;
                case 2:
                    paramBox3.Enabled = true;
                    paramBox3.Text = paramName;
                    break;
                case 3:
                    paramBox4.Enabled = true;
                    paramBox4.Text = paramName;
                    break;
            }
        }

        private void enableParamBoxes(bool enabled)
        {
            paramBox1.Text = null;
            paramBox2.Text = null;
            paramBox3.Text = null;
            paramBox4.Text = null;
            paramBox1.Enabled = enabled;
            paramBox2.Enabled = enabled;
            paramBox3.Enabled = enabled;
            paramBox4.Enabled = enabled;
            for (int i = 0; i < 4; i++)
            {
                textBoxPlaceholder[i] = "";
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

        private void paramBox1_Enter(object sender, EventArgs e)
        {
            if (paramBox1.Text == textBoxPlaceholder[0])
            {
                paramBox1.Text = "";
            }
        }

        private void paramBox2_Enter(object sender, EventArgs e)
        {
            if (paramBox2.Text == textBoxPlaceholder[1])
            {
                paramBox2.Text = "";
                if (textBoxPlaceholder[1] == "pwd")
                {
                    paramBox2.UseSystemPasswordChar = true;
                }
            }
        }

        private void paramBox3_Enter(object sender, EventArgs e)
        {
            if (paramBox3.Text == textBoxPlaceholder[2])
            {
                paramBox3.Text = "";
            }
        }

        private void paramBox4_Enter(object sender, EventArgs e)
        {
            if (paramBox4.Text == textBoxPlaceholder[3])
            {
                paramBox4.Text = "";
            }
        }

        private void paramBox1_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(paramBox1.Text))
            {
                paramBox1.Text = textBoxPlaceholder[0];
            }
        }

        private void paramBox2_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(paramBox2.Text))
            {
                paramBox2.Text = textBoxPlaceholder[1];
                paramBox2.UseSystemPasswordChar = false;
            }
        }

        private void paramBox3_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(paramBox3.Text))
            {
                paramBox3.Text = textBoxPlaceholder[2];
            }
        }

        private void paramBox4_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(paramBox4.Text))
            {
                paramBox4.Text = textBoxPlaceholder[3];
            }
        }

        private void executeBtn_Click(object sender, EventArgs e)
        {
            if (connected && selectedCommand != null)
            {
                switch (selectedType.variant)
                {
                    case commandType.Execute:
                        serialPort.Write(selectedCommand.name + "\r\n");
                        break;
                    case commandType.Query:
                        serialPort.Write(selectedCommand.name + "?\r\n");
                        break;
                    case commandType.Set:
                        string commandString = selectedCommand.name + "=";
                        for (int i = 0; i < selectedType.parameters.Count; i++)
                        {
                            if(i != 0)
                            {
                                commandString += ",";
                            }

                            switch (selectedType.parameters.ElementAt(i).typeP)
                            {
                                case parameterType.intP:
                                    commandString += getTextBoxInt(i);
                                    break;
                                case parameterType.stringP:
                                    commandString += "\"" + getTextBoxString(i) + "\"";
                                    break;
                            }
                        }
                        commandString += "\r\n";
                        serialPort.Write(commandString);
                        break;
                    case commandType.Test:
                        serialPort.Write(selectedCommand.name + "=?\r\n");
                        break;
                }
            }
        }

        private int getTextBoxInt(int id)
        {
            try {
                switch (id)
                {
                    case 0:
                        return int.Parse(paramBox1.Text);
                    case 1:
                        return int.Parse(paramBox2.Text);
                    case 2:
                        return int.Parse(paramBox3.Text);
                    case 3:
                        return int.Parse(paramBox4.Text);
                }
            }
            catch
            {
                return 0;
            }
            return 0;
        }

        private string getTextBoxString(int id)
        {
            switch (id)
            {
                case 0:
                    return paramBox1.Text;
                case 1:
                    return paramBox2.Text;
                case 2:
                    return paramBox3.Text;
                case 3:
                    return paramBox4.Text;
            }
            return "";
        }
    }
}