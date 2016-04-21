using System.Collections.Generic;
using System.IO.Ports;
using System.Windows.Forms;
using System.Linq;
namespace MyFirstWindowsApplication
{
    partial class Form1
    {
        private List<command> commandsList = new List<command>();
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
            this.components = new System.ComponentModel.Container();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.comPortBox = new System.Windows.Forms.ComboBox();
            this.baudRateBox = new System.Windows.Forms.ComboBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.feedBox = new System.Windows.Forms.RichTextBox();
            this.AT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ATRST = new System.Windows.Forms.Button();
            this.ATGMR = new System.Windows.Forms.Button();
            this.ATEO = new System.Windows.Forms.Button();
            this.ATEI = new System.Windows.Forms.Button();
            this.commandInformation = new System.Windows.Forms.ToolTip(this.components);
            this.ATCWLAP = new System.Windows.Forms.Button();
            this.ATCWQAP = new System.Windows.Forms.Button();
            this.ATCWLIF = new System.Windows.Forms.Button();
            this.ATCIPSTATUS = new System.Windows.Forms.Button();
            this.ATCIFSR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.advancedCommandBox = new System.Windows.Forms.ComboBox();
            this.commandTypeBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.functionLabel = new System.Windows.Forms.Label();
            this.parametersNameLabel = new System.Windows.Forms.Label();
            this.parametersLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(12, 12);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 0;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.refreshBtn_Click);
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // comPortBox
            // 
            this.comPortBox.Location = new System.Drawing.Point(93, 12);
            this.comPortBox.Name = "comPortBox";
            this.comPortBox.Size = new System.Drawing.Size(75, 21);
            this.comPortBox.TabIndex = 0;
            this.comPortBox.Text = "COM Port";
            // 
            // baudRateBox
            // 
            this.baudRateBox.FormattingEnabled = true;
            this.baudRateBox.Location = new System.Drawing.Point(174, 12);
            this.baudRateBox.Name = "baudRateBox";
            this.baudRateBox.Size = new System.Drawing.Size(78, 21);
            this.baudRateBox.TabIndex = 1;
            this.baudRateBox.Text = "Baud Rate";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(259, 12);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // feedBox
            // 
            this.feedBox.Location = new System.Drawing.Point(12, 356);
            this.feedBox.Name = "feedBox";
            this.feedBox.Size = new System.Drawing.Size(431, 96);
            this.feedBox.TabIndex = 3;
            this.feedBox.Text = "";
            // 
            // AT
            // 
            this.AT.Location = new System.Drawing.Point(12, 58);
            this.AT.Name = "AT";
            this.AT.Size = new System.Drawing.Size(31, 23);
            this.AT.TabIndex = 4;
            this.AT.Text = "AT";
            this.commandInformation.SetToolTip(this.AT, "Test if AT system works correctly");
            this.AT.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Basic commands:";
            // 
            // ATRST
            // 
            this.ATRST.Location = new System.Drawing.Point(49, 58);
            this.ATRST.Name = "ATRST";
            this.ATRST.Size = new System.Drawing.Size(62, 23);
            this.ATRST.TabIndex = 6;
            this.ATRST.Text = "AT+RST";
            this.commandInformation.SetToolTip(this.ATRST, "Reset the module");
            this.ATRST.UseVisualStyleBackColor = true;
            // 
            // ATGMR
            // 
            this.ATGMR.Location = new System.Drawing.Point(117, 58);
            this.ATGMR.Name = "ATGMR";
            this.ATGMR.Size = new System.Drawing.Size(61, 23);
            this.ATGMR.TabIndex = 7;
            this.ATGMR.Text = "AT+GMR";
            this.commandInformation.SetToolTip(this.ATGMR, "Print firmware version");
            this.ATGMR.UseVisualStyleBackColor = true;
            // 
            // ATEO
            // 
            this.ATEO.Location = new System.Drawing.Point(185, 58);
            this.ATEO.Name = "ATEO";
            this.ATEO.Size = new System.Drawing.Size(44, 23);
            this.ATEO.TabIndex = 8;
            this.ATEO.Text = "ATE0";
            this.ATEO.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.commandInformation.SetToolTip(this.ATEO, "Disable echo");
            this.ATEO.UseVisualStyleBackColor = true;
            this.ATEO.Click += new System.EventHandler(this.button1_Click);
            // 
            // ATEI
            // 
            this.ATEI.Location = new System.Drawing.Point(235, 58);
            this.ATEI.Name = "ATEI";
            this.ATEI.Size = new System.Drawing.Size(46, 23);
            this.ATEI.TabIndex = 9;
            this.ATEI.Text = "ATE1";
            this.commandInformation.SetToolTip(this.ATEI, "Enable echo");
            this.ATEI.UseVisualStyleBackColor = true;
            // 
            // ATCWLAP
            // 
            this.ATCWLAP.Location = new System.Drawing.Point(287, 58);
            this.ATCWLAP.Name = "ATCWLAP";
            this.ATCWLAP.Size = new System.Drawing.Size(75, 23);
            this.ATCWLAP.TabIndex = 10;
            this.ATCWLAP.Text = "AT+CWLAP";
            this.commandInformation.SetToolTip(this.ATCWLAP, "List available APs");
            this.ATCWLAP.UseVisualStyleBackColor = true;
            // 
            // ATCWQAP
            // 
            this.ATCWQAP.Location = new System.Drawing.Point(368, 58);
            this.ATCWQAP.Name = "ATCWQAP";
            this.ATCWQAP.Size = new System.Drawing.Size(75, 23);
            this.ATCWQAP.TabIndex = 11;
            this.ATCWQAP.Text = "AT+CWQAP";
            this.commandInformation.SetToolTip(this.ATCWQAP, "Disconnect from AP");
            this.ATCWQAP.UseVisualStyleBackColor = true;
            // 
            // ATCWLIF
            // 
            this.ATCWLIF.Location = new System.Drawing.Point(12, 87);
            this.ATCWLIF.Name = "ATCWLIF";
            this.ATCWLIF.Size = new System.Drawing.Size(75, 23);
            this.ATCWLIF.TabIndex = 12;
            this.ATCWLIF.Text = "AT+CWLIF";
            this.commandInformation.SetToolTip(this.ATCWLIF, "List connected clients");
            this.ATCWLIF.UseVisualStyleBackColor = true;
            // 
            // ATCIPSTATUS
            // 
            this.ATCIPSTATUS.Location = new System.Drawing.Point(93, 87);
            this.ATCIPSTATUS.Name = "ATCIPSTATUS";
            this.ATCIPSTATUS.Size = new System.Drawing.Size(99, 23);
            this.ATCIPSTATUS.TabIndex = 13;
            this.ATCIPSTATUS.Text = "AT+CIPSTATUS";
            this.commandInformation.SetToolTip(this.ATCIPSTATUS, "Connection information");
            this.ATCIPSTATUS.UseVisualStyleBackColor = true;
            // 
            // ATCIFSR
            // 
            this.ATCIFSR.Location = new System.Drawing.Point(198, 87);
            this.ATCIFSR.Name = "ATCIFSR";
            this.ATCIFSR.Size = new System.Drawing.Size(75, 23);
            this.ATCIFSR.TabIndex = 14;
            this.ATCIFSR.Text = "AT+CIFSR";
            this.commandInformation.SetToolTip(this.ATCIFSR, "Get local IP address");
            this.ATCIFSR.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Advanced commands:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.statusLabel.ForeColor = System.Drawing.Color.Red;
            this.statusLabel.Location = new System.Drawing.Point(340, 14);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(100, 17);
            this.statusLabel.TabIndex = 16;
            this.statusLabel.Text = "Not connected";
            // 
            // advancedCommandBox
            // 
            this.advancedCommandBox.FormattingEnabled = true;
            this.advancedCommandBox.Location = new System.Drawing.Point(12, 130);
            this.advancedCommandBox.Name = "advancedCommandBox";
            this.advancedCommandBox.Size = new System.Drawing.Size(121, 21);
            this.advancedCommandBox.TabIndex = 17;
            this.advancedCommandBox.Text = "Command";
            this.advancedCommandBox.SelectedIndexChanged += new System.EventHandler(this.commandChange);
            // 
            // commandTypeBox
            // 
            this.commandTypeBox.FormattingEnabled = true;
            this.commandTypeBox.Location = new System.Drawing.Point(139, 130);
            this.commandTypeBox.Name = "commandTypeBox";
            this.commandTypeBox.Size = new System.Drawing.Size(98, 21);
            this.commandTypeBox.TabIndex = 18;
            this.commandTypeBox.Text = "Type";
            this.commandTypeBox.SelectedIndexChanged += new System.EventHandler(this.commandTypeBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Command Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Function:";
            // 
            // functionLabel
            // 
            this.functionLabel.AutoSize = true;
            this.functionLabel.Location = new System.Drawing.Point(12, 167);
            this.functionLabel.Name = "functionLabel";
            this.functionLabel.Size = new System.Drawing.Size(71, 13);
            this.functionLabel.TabIndex = 21;
            this.functionLabel.Text = "functionLabel";
            this.functionLabel.Visible = false;
            // 
            // parametersNameLabel
            // 
            this.parametersNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parametersNameLabel.Location = new System.Drawing.Point(12, 180);
            this.parametersNameLabel.Name = "parametersNameLabel";
            this.parametersNameLabel.Size = new System.Drawing.Size(71, 13);
            this.parametersNameLabel.TabIndex = 0;
            this.parametersNameLabel.Text = "Parameters:";
            this.parametersNameLabel.Visible = false;
            // 
            // parametersLabel
            // 
            this.parametersLabel.AutoSize = true;
            this.parametersLabel.Location = new System.Drawing.Point(12, 193);
            this.parametersLabel.Name = "parametersLabel";
            this.parametersLabel.Size = new System.Drawing.Size(85, 13);
            this.parametersLabel.TabIndex = 22;
            this.parametersLabel.Text = "parametersLabel";
            this.parametersLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 464);
            this.Controls.Add(this.parametersLabel);
            this.Controls.Add(this.parametersNameLabel);
            this.Controls.Add(this.functionLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.commandTypeBox);
            this.Controls.Add(this.advancedCommandBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ATCIFSR);
            this.Controls.Add(this.ATCIPSTATUS);
            this.Controls.Add(this.ATCWLIF);
            this.Controls.Add(this.ATCWQAP);
            this.Controls.Add(this.ATCWLAP);
            this.Controls.Add(this.ATEI);
            this.Controls.Add(this.ATEO);
            this.Controls.Add(this.ATGMR);
            this.Controls.Add(this.ATRST);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AT);
            this.Controls.Add(this.feedBox);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.baudRateBox);
            this.Controls.Add(this.comPortBox);
            this.Controls.Add(this.refreshBtn);
            this.Name = "Form1";
            this.Text = "ESP8266 Commander";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void InitializeCommandList()
        {
            commandsGenerator.generateCommandsList(commandsList);
        }

        private void InitializePortBox()
        {
            comPortBox.Items.AddRange(SerialPort.GetPortNames());
        }

        private void InitializeBaudRateBox()
        {
            string[] baudRates = new string[] { "300", "1200", "2400", "4800", "9600", "14400", "19200", "28800", "38400", "57600", "115200", "230400" };
            baudRateBox.Items.AddRange(baudRates);
        }

        private void InitializeAdvancedCommandBox()
        {
            advancedCommandBox.Items.AddRange(commandsList.Select(s => s.name).ToArray());
        }

        #endregion

        private System.Windows.Forms.Button refreshBtn;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.ComboBox comPortBox;
        private ComboBox baudRateBox;
        private Button connectButton;
        private RichTextBox feedBox;
        private Button AT;
        private Label label1;
        private Button ATRST;
        private Button ATGMR;
        private Button ATEO;
        private Button ATEI;
        private ToolTip commandInformation;
        private Button ATCWLAP;
        private Button ATCWQAP;
        private Button ATCWLIF;
        private Button ATCIPSTATUS;
        private Button ATCIFSR;
        private Label label2;
        private Label statusLabel;
        private ComboBox advancedCommandBox;
        private ComboBox commandTypeBox;
        private Label label4;
        private Label label5;
        private Label functionLabel;
        private Label parametersNameLabel;
        private Label parametersLabel;
    }
}

