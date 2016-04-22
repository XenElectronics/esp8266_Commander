using System.Collections.Generic;
using System.IO.Ports;
using System.Windows.Forms;
using System.Linq;
namespace esp8266Commander
{
    partial class param1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(param1));
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
            this.functionTitle = new System.Windows.Forms.Label();
            this.functionLabel = new System.Windows.Forms.Label();
            this.parametersNameLabel = new System.Windows.Forms.Label();
            this.parametersLabel = new System.Windows.Forms.Label();
            this.responseTitle = new System.Windows.Forms.Label();
            this.responseLabel = new System.Windows.Forms.Label();
            this.paramBox1 = new System.Windows.Forms.TextBox();
            this.paramBox2 = new System.Windows.Forms.TextBox();
            this.paramBox3 = new System.Windows.Forms.TextBox();
            this.paramBox4 = new System.Windows.Forms.TextBox();
            this.executeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // comPortBox
            // 
            this.comPortBox.ItemHeight = 13;
            this.comPortBox.Location = new System.Drawing.Point(10, 10);
            this.comPortBox.Name = "comPortBox";
            this.comPortBox.Size = new System.Drawing.Size(75, 21);
            this.comPortBox.TabIndex = 0;
            this.comPortBox.Text = "COM Port";
            this.comPortBox.DropDown += new System.EventHandler(this.comPortBox_DropDown);
            // 
            // baudRateBox
            // 
            this.baudRateBox.DropDownWidth = 80;
            this.baudRateBox.FormattingEnabled = true;
            this.baudRateBox.ItemHeight = 13;
            this.baudRateBox.Location = new System.Drawing.Point(90, 10);
            this.baudRateBox.Name = "baudRateBox";
            this.baudRateBox.Size = new System.Drawing.Size(80, 21);
            this.baudRateBox.TabIndex = 1;
            this.baudRateBox.Text = "Baud Rate";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(175, 9);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // feedBox
            // 
            this.feedBox.Location = new System.Drawing.Point(10, 270);
            this.feedBox.Name = "feedBox";
            this.feedBox.Size = new System.Drawing.Size(420, 105);
            this.feedBox.TabIndex = 3;
            this.feedBox.Text = "";
            // 
            // AT
            // 
            this.AT.Location = new System.Drawing.Point(10, 60);
            this.AT.Name = "AT";
            this.AT.Size = new System.Drawing.Size(30, 25);
            this.AT.TabIndex = 4;
            this.AT.Text = "AT";
            this.commandInformation.SetToolTip(this.AT, "Test if AT system works correctly");
            this.AT.UseVisualStyleBackColor = true;
            this.AT.Click += new System.EventHandler(this.AT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Basic commands:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ATRST
            // 
            this.ATRST.Location = new System.Drawing.Point(45, 60);
            this.ATRST.Name = "ATRST";
            this.ATRST.Size = new System.Drawing.Size(60, 25);
            this.ATRST.TabIndex = 6;
            this.ATRST.Text = "AT+RST";
            this.commandInformation.SetToolTip(this.ATRST, "Reset the module");
            this.ATRST.UseVisualStyleBackColor = true;
            this.ATRST.Click += new System.EventHandler(this.ATRST_Click);
            // 
            // ATGMR
            // 
            this.ATGMR.Location = new System.Drawing.Point(110, 60);
            this.ATGMR.Name = "ATGMR";
            this.ATGMR.Size = new System.Drawing.Size(60, 25);
            this.ATGMR.TabIndex = 7;
            this.ATGMR.Text = "AT+GMR";
            this.commandInformation.SetToolTip(this.ATGMR, "Print firmware version");
            this.ATGMR.UseVisualStyleBackColor = true;
            this.ATGMR.Click += new System.EventHandler(this.ATGMR_Click);
            // 
            // ATEO
            // 
            this.ATEO.Location = new System.Drawing.Point(175, 60);
            this.ATEO.Name = "ATEO";
            this.ATEO.Size = new System.Drawing.Size(45, 25);
            this.ATEO.TabIndex = 8;
            this.ATEO.Text = "ATE0";
            this.commandInformation.SetToolTip(this.ATEO, "Disable echo");
            this.ATEO.UseVisualStyleBackColor = true;
            this.ATEO.Click += new System.EventHandler(this.ATEO_Click);
            // 
            // ATEI
            // 
            this.ATEI.Location = new System.Drawing.Point(225, 60);
            this.ATEI.Name = "ATEI";
            this.ATEI.Size = new System.Drawing.Size(45, 25);
            this.ATEI.TabIndex = 9;
            this.ATEI.Text = "ATE1";
            this.commandInformation.SetToolTip(this.ATEI, "Enable echo");
            this.ATEI.UseVisualStyleBackColor = true;
            this.ATEI.Click += new System.EventHandler(this.ATEI_Click);
            // 
            // ATCWLAP
            // 
            this.ATCWLAP.Location = new System.Drawing.Point(275, 60);
            this.ATCWLAP.Name = "ATCWLAP";
            this.ATCWLAP.Size = new System.Drawing.Size(75, 25);
            this.ATCWLAP.TabIndex = 10;
            this.ATCWLAP.Text = "AT+CWLAP";
            this.commandInformation.SetToolTip(this.ATCWLAP, "List available APs");
            this.ATCWLAP.UseVisualStyleBackColor = true;
            this.ATCWLAP.Click += new System.EventHandler(this.ATCWLAP_Click);
            // 
            // ATCWQAP
            // 
            this.ATCWQAP.Location = new System.Drawing.Point(355, 60);
            this.ATCWQAP.Name = "ATCWQAP";
            this.ATCWQAP.Size = new System.Drawing.Size(75, 25);
            this.ATCWQAP.TabIndex = 11;
            this.ATCWQAP.Text = "AT+CWQAP";
            this.commandInformation.SetToolTip(this.ATCWQAP, "Disconnect from AP");
            this.ATCWQAP.UseVisualStyleBackColor = true;
            this.ATCWQAP.Click += new System.EventHandler(this.ATCWQAP_Click);
            // 
            // ATCWLIF
            // 
            this.ATCWLIF.Location = new System.Drawing.Point(10, 90);
            this.ATCWLIF.Name = "ATCWLIF";
            this.ATCWLIF.Size = new System.Drawing.Size(75, 25);
            this.ATCWLIF.TabIndex = 12;
            this.ATCWLIF.Text = "AT+CWLIF";
            this.commandInformation.SetToolTip(this.ATCWLIF, "List connected clients");
            this.ATCWLIF.UseVisualStyleBackColor = true;
            this.ATCWLIF.Click += new System.EventHandler(this.ATCWLIF_Click);
            // 
            // ATCIPSTATUS
            // 
            this.ATCIPSTATUS.Location = new System.Drawing.Point(90, 90);
            this.ATCIPSTATUS.Name = "ATCIPSTATUS";
            this.ATCIPSTATUS.Size = new System.Drawing.Size(100, 25);
            this.ATCIPSTATUS.TabIndex = 13;
            this.ATCIPSTATUS.Text = "AT+CIPSTATUS";
            this.commandInformation.SetToolTip(this.ATCIPSTATUS, "Connection information");
            this.ATCIPSTATUS.UseVisualStyleBackColor = true;
            this.ATCIPSTATUS.Click += new System.EventHandler(this.ATCIPSTATUS_Click);
            // 
            // ATCIFSR
            // 
            this.ATCIFSR.Location = new System.Drawing.Point(195, 90);
            this.ATCIFSR.Name = "ATCIFSR";
            this.ATCIFSR.Size = new System.Drawing.Size(75, 25);
            this.ATCIFSR.TabIndex = 14;
            this.ATCIFSR.Text = "AT+CIFSR";
            this.commandInformation.SetToolTip(this.ATCIFSR, "Get local IP address");
            this.ATCIFSR.UseVisualStyleBackColor = true;
            this.ATCIFSR.Click += new System.EventHandler(this.ATCIFSR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Advanced commands:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.statusLabel.ForeColor = System.Drawing.Color.Red;
            this.statusLabel.Location = new System.Drawing.Point(320, 10);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(113, 17);
            this.statusLabel.TabIndex = 16;
            this.statusLabel.Text = "Not connected";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // advancedCommandBox
            // 
            this.advancedCommandBox.FormattingEnabled = true;
            this.advancedCommandBox.Location = new System.Drawing.Point(10, 140);
            this.advancedCommandBox.Name = "advancedCommandBox";
            this.advancedCommandBox.Size = new System.Drawing.Size(105, 21);
            this.advancedCommandBox.TabIndex = 17;
            this.advancedCommandBox.Text = "Command";
            this.advancedCommandBox.SelectedIndexChanged += new System.EventHandler(this.commandChange);
            // 
            // commandTypeBox
            // 
            this.commandTypeBox.FormattingEnabled = true;
            this.commandTypeBox.Location = new System.Drawing.Point(120, 140);
            this.commandTypeBox.Name = "commandTypeBox";
            this.commandTypeBox.Size = new System.Drawing.Size(70, 21);
            this.commandTypeBox.TabIndex = 18;
            this.commandTypeBox.Text = "Type";
            this.commandTypeBox.SelectedIndexChanged += new System.EventHandler(this.commandTypeBox_SelectedIndexChanged);
            // 
            // functionTitle
            // 
            this.functionTitle.AutoSize = true;
            this.functionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.functionTitle.Location = new System.Drawing.Point(7, 165);
            this.functionTitle.Name = "functionTitle";
            this.functionTitle.Size = new System.Drawing.Size(60, 13);
            this.functionTitle.TabIndex = 20;
            this.functionTitle.Text = "Function:";
            this.functionTitle.Visible = false;
            // 
            // functionLabel
            // 
            this.functionLabel.AutoSize = true;
            this.functionLabel.Location = new System.Drawing.Point(67, 165);
            this.functionLabel.Name = "functionLabel";
            this.functionLabel.Size = new System.Drawing.Size(71, 13);
            this.functionLabel.TabIndex = 21;
            this.functionLabel.Text = "functionLabel";
            this.functionLabel.Visible = false;
            // 
            // parametersNameLabel
            // 
            this.parametersNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parametersNameLabel.Location = new System.Drawing.Point(7, 195);
            this.parametersNameLabel.Name = "parametersNameLabel";
            this.parametersNameLabel.Size = new System.Drawing.Size(75, 13);
            this.parametersNameLabel.TabIndex = 0;
            this.parametersNameLabel.Text = "Parameters:";
            this.parametersNameLabel.Visible = false;
            // 
            // parametersLabel
            // 
            this.parametersLabel.AutoSize = true;
            this.parametersLabel.Location = new System.Drawing.Point(82, 195);
            this.parametersLabel.Name = "parametersLabel";
            this.parametersLabel.Size = new System.Drawing.Size(85, 13);
            this.parametersLabel.TabIndex = 22;
            this.parametersLabel.Text = "parametersLabel";
            this.parametersLabel.Visible = false;
            // 
            // responseTitle
            // 
            this.responseTitle.AutoSize = true;
            this.responseTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.responseTitle.Location = new System.Drawing.Point(7, 180);
            this.responseTitle.Name = "responseTitle";
            this.responseTitle.Size = new System.Drawing.Size(67, 13);
            this.responseTitle.TabIndex = 23;
            this.responseTitle.Text = "Response:";
            this.responseTitle.Visible = false;
            // 
            // responseLabel
            // 
            this.responseLabel.AutoSize = true;
            this.responseLabel.Location = new System.Drawing.Point(73, 180);
            this.responseLabel.Name = "responseLabel";
            this.responseLabel.Size = new System.Drawing.Size(76, 13);
            this.responseLabel.TabIndex = 24;
            this.responseLabel.Text = "responseLabel";
            this.responseLabel.Visible = false;
            // 
            // paramBox1
            // 
            this.paramBox1.Enabled = false;
            this.paramBox1.Location = new System.Drawing.Point(195, 140);
            this.paramBox1.Name = "paramBox1";
            this.paramBox1.Size = new System.Drawing.Size(40, 20);
            this.paramBox1.TabIndex = 25;
            this.paramBox1.Enter += new System.EventHandler(this.paramBox1_Enter);
            this.paramBox1.Leave += new System.EventHandler(this.paramBox1_Leave);
            // 
            // paramBox2
            // 
            this.paramBox2.Enabled = false;
            this.paramBox2.Location = new System.Drawing.Point(240, 140);
            this.paramBox2.Name = "paramBox2";
            this.paramBox2.Size = new System.Drawing.Size(40, 20);
            this.paramBox2.TabIndex = 26;
            this.paramBox2.Enter += new System.EventHandler(this.paramBox2_Enter);
            this.paramBox2.Leave += new System.EventHandler(this.paramBox2_Leave);
            // 
            // paramBox3
            // 
            this.paramBox3.Enabled = false;
            this.paramBox3.Location = new System.Drawing.Point(285, 140);
            this.paramBox3.Name = "paramBox3";
            this.paramBox3.Size = new System.Drawing.Size(40, 20);
            this.paramBox3.TabIndex = 27;
            this.paramBox3.Enter += new System.EventHandler(this.paramBox3_Enter);
            this.paramBox3.Leave += new System.EventHandler(this.paramBox3_Leave);
            // 
            // paramBox4
            // 
            this.paramBox4.Enabled = false;
            this.paramBox4.Location = new System.Drawing.Point(330, 140);
            this.paramBox4.Name = "paramBox4";
            this.paramBox4.Size = new System.Drawing.Size(40, 20);
            this.paramBox4.TabIndex = 28;
            this.paramBox4.Enter += new System.EventHandler(this.paramBox4_Enter);
            this.paramBox4.Leave += new System.EventHandler(this.paramBox4_Leave);
            // 
            // executeBtn
            // 
            this.executeBtn.Location = new System.Drawing.Point(375, 139);
            this.executeBtn.Name = "executeBtn";
            this.executeBtn.Size = new System.Drawing.Size(55, 22);
            this.executeBtn.TabIndex = 29;
            this.executeBtn.Text = "Execute";
            this.executeBtn.UseVisualStyleBackColor = true;
            this.executeBtn.Click += new System.EventHandler(this.executeBtn_Click);
            // 
            // param1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 386);
            this.Controls.Add(this.executeBtn);
            this.Controls.Add(this.paramBox4);
            this.Controls.Add(this.paramBox3);
            this.Controls.Add(this.paramBox2);
            this.Controls.Add(this.paramBox1);
            this.Controls.Add(this.responseLabel);
            this.Controls.Add(this.responseTitle);
            this.Controls.Add(this.parametersLabel);
            this.Controls.Add(this.parametersNameLabel);
            this.Controls.Add(this.functionLabel);
            this.Controls.Add(this.functionTitle);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "param1";
            this.Text = "ESP8266 Commander v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void InitializeCommandList()
        {
            commandsGenerator.generateCommandsList(commandsList);
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
        private Label functionTitle;
        private Label functionLabel;
        private Label parametersNameLabel;
        private Label parametersLabel;
        private Label responseTitle;
        private Label responseLabel;
        private TextBox paramBox1;
        private TextBox paramBox2;
        private TextBox paramBox3;
        private TextBox paramBox4;
        private Button executeBtn;
    }
}

