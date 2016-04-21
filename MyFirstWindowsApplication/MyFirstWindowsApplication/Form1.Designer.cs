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
            this.label3 = new System.Windows.Forms.Label();
            this.advancedCommandBox = new System.Windows.Forms.ComboBox();
            this.commandTypeBox = new System.Windows.Forms.ComboBox();
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
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
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
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Advanced commands:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(340, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Not connected";
            // 
            // advancedCommandBox
            // 
            this.advancedCommandBox.FormattingEnabled = true;
            this.advancedCommandBox.Location = new System.Drawing.Point(12, 130);
            this.advancedCommandBox.Name = "advancedCommandBox";
            this.advancedCommandBox.Size = new System.Drawing.Size(121, 21);
            this.advancedCommandBox.TabIndex = 17;
            this.advancedCommandBox.Text = "Command";
            // 
            // commandTypeBox
            // 
            this.commandTypeBox.FormattingEnabled = true;
            this.commandTypeBox.Location = new System.Drawing.Point(139, 130);
            this.commandTypeBox.Name = "commandTypeBox";
            this.commandTypeBox.Size = new System.Drawing.Size(98, 21);
            this.commandTypeBox.TabIndex = 18;
            this.commandTypeBox.Text = "Command type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 464);
            this.Controls.Add(this.commandTypeBox);
            this.Controls.Add(this.advancedCommandBox);
            this.Controls.Add(this.label3);
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
            commandsList.Add(
                new command()
                {
                    name = "AT+GSLP",
                    types = new List<type> { new type(){ 
                        variant = commandType.Set, parameters = new List<parameter>(){ 
                            new parameter(){ name = "time"}
                            } 
                        }
                    }
                }
            );

            commandsList.Add(
                new command()
                {
                    name = "AT+CWMODE",
                    types = new List<type> { new type(){ 
                        variant = commandType.Test, 
                        description = "List valid modes."
                        },

                        new type(){ 
                            variant = commandType.Query, 
                            description = "Query AP’s info which is connected by ESP8266.",
                            parameters = new List<parameter>(){
                                new parameter(){ 
                                    name = "mode",
                                    description = "An integer designating the mode of operation either 1, 2, or 3./n1 = Station mode (client)/n2 = AP mode (host)/n3 = AP + Station mode",
                                }
                            }
                        },

                        new type(){ 
                            variant = commandType.Execute,
                            description = "Set AP’s info which will be connect by ESP8266.",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "mode",
                                    description = "An integer designating the mode of operation either 1, 2, or 3./n1 = Station mode (client)/n2 = AP mode (host)/n3 = AP + Station mode",
                                }
                            }
                        }
                    }
                }
            );

            commandsList.Add(
                new command() 
                { 
                    name = "AT+CWJAP",
                    types = new List<type> { 
                        new type(){
                            variant = commandType.Query,
                            description = "Prints the SSID of Access Point ESP8266 is connected to."
                        },

                        new type(){
                            variant = commandType.Execute,
                            description = "Commands ESP8266 to connect a SSID with supplied password.",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "ssid",
                                    description = "String, AP’s SSID" 
                                },

                                new parameter(){
                                    name = "pwd",
                                    description = "String, not longer than 64 characters"
                                }
                            }
                        }
                    }                
                }
            );

            commandsList.Add(
                new command()
                {
                    name = "AT+CWLAP",
                    types = new List<type> { 

                        /*new type(){ //Not sure if works
                            variant = commandType.Set,
                            description = "Search available APs with specific conditions.",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "ssid",
                                    description = "String, SSID of AP."
                                },

                                new parameter(){
                                    name = "mac",
                                    description = "String, MAC address."
                                },

                                new parameter(){
                                    name = "ch",
                                    description = ""
                                }
                            }
                        },*/

                        new type(){
                            variant = commandType.Execute,
                            description = "Lists available Access Points.",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "ecn",
                                    description = "0 = OPEN/n1 = WEP/n2 = WPA_PSK/n3 = WPA2_PSK/n4 = WPA_WPA2_PSK"
                                },

                                new parameter(){
                                    name = "ssid",
                                    description = "String, SSID of AP."
                                },

                                new parameter(){
                                    name = "rssi",
                                    description = "Signal strength."
                                },

                                new parameter(){
                                    name = "mac",
                                    description = "String, MAC address."
                                },
                            }
                        }
                    }
                }
            );

            commandsList.Add(
                new command()
                {
                    name = "AT+CWSAP",
                    types = new List<type> { 
                        new type(){
                            variant = commandType.Query,
                            description = "Query configuration of ESP8266 softAP mode."
                        },

                        new type(){
                            variant = commandType.Set,
                            description = "",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "ssid",
                                    description = "String, ESP8266’s softAP SSID."
                                },

                                new parameter(){
                                    name = "pwd",
                                    description = "String, Password, no longer than 64 characters."
                                },

                                new parameter(){
                                    name = "ch",
                                    description = "Channel id."
                                },

                                new parameter(){
                                    name = "ecn",
                                    description = "0 = OPEN/n2 = WPA_PSK/n3 = WPA2_PSK/n4 = WPA_WPA2_PSK"
                                },
                            }
                        }
                    }
                }
            );

            commandsList.Add(
                new command()
                {
                    name = "AT+CWDHCP",
                    types = new List<type> { 
                        new type(){
                            variant = commandType.Query,
                            description = "Query configuration of ESP8266 softAP mode."
                        },

                        new type(){
                            variant = commandType.Set,
                            description = "Set configuration of softAP mode.",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "ssid",
                                    description = "String, ESP8266’s softAP SSID."
                                },

                                new parameter(){
                                    name = "pwd",
                                    description = "String, Password, no longer than 64 characters."
                                },

                                new parameter(){
                                    name = "ch",
                                    description = "Channel id."
                                },

                                new parameter(){
                                    name = "ecn",
                                    description = "0 = OPEN/n2 = WPA_PSK/n3 = WPA2_PSK/n4 = WPA_WPA2_PSK"
                                }
                            }
                        }
                    }
                }
            );

            commandsList.Add(
                new command()
                {
                    name = "AT+CIPSTAMAC",
                    types = new List<type> { 
                        new type(){
                            variant = commandType.Query,
                            description = "Print current MAC ESP8266’s address."
                        },

                        new type(){
                            variant = commandType.Execute,
                            description = "Set ESP8266’s MAC address.",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "mac",
                                    description = "String, MAC address of the ESP8266 station."
                                }
                            }
                        }
                    }
                }
            );

            commandsList.Add(
                new command()
                {
                    name = "AT+CIPAPMAC",
                    types = new List<type> { 
                        new type(){
                            variant = commandType.Query,
                            description = "Get MAC address of ESP8266 softAP."
                        },

                        new type(){
                            variant = commandType.Execute,
                            description = "Set mac of ESP8266 softAP.",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "mac",
                                    description = "String, MAC address of the ESP8266 station."
                                }
                            }
                        }
                    }
                }
            );

            commandsList.Add(
                new command()
                {
                    name = "AT+CIPSTA",
                    types = new List<type> { 
                        new type(){
                            variant = commandType.Query,
                            description = "Get IP address of ESP8266 station."
                        },

                        new type(){
                            variant = commandType.Execute,
                            description = "Set ip address of ESP8266 station.",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "ip",
                                    description = "String, ip address of the ESP8266 station."
                                }
                            }
                        }
                    }
                }
            );

            commandsList.Add(
                new command()
                {
                    name = "AT+CIPAP",
                    types = new List<type> { 
                        new type(){
                            variant = commandType.Query,
                            description = "Get ip address of ESP8266 softAP."
                        },

                        new type(){
                            variant = commandType.Execute,
                            description = "Set ip address of ESP8266 softAP.",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "ip",
                                    description = "String, ip address of ESP8266 softAP."
                                }
                            }
                        }
                    }
                }
            );

            commandsList.Add(
                new command()
                {
                    name = "AT+CIPSTART",
                    types = new List<type> { 

                        new type(){
                            variant = commandType.Set,
                            description = "Start a connection as client.",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "id",
                                    description = "0-4, id of connection"
                                },

                                new parameter(){
                                    name = "type",
                                    description = "String, “TCP” or “UDP”"
                                },

                                new parameter(){
                                    name = "addr",
                                    description = "String, remote IP"
                                },

                                new parameter(){
                                    name = "port",
                                    description = "String, remote port"
                                }
                            }
                        },

                        new type(){
                            variant = commandType.Test,
                            description = "List possible command variations."
                        }
                    }
                }
            );

            commandsList.Add(
                new command()
                {
                    name = "AT+CIPSEND",
                    types = new List<type> { 
                        new type(){
                            variant = commandType.Test,
                        },

                        new type(){
                            variant = commandType.Set,
                            description = "Set length of the data that will be sent. For normal send.",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "id",
                                    description = "ID no. of transmit connection"
                                },

                                new parameter(){
                                    name = "length",
                                    description = "data length, MAX 2048 bytes"
                                }
                            }
                        },

                        new type(){
                            variant = commandType.Execute,
                            description = "Send data. For unvarnished transmission mode."
                        }
                    }
                }
            );

            commandsList.Add(
                new command()
                {
                    name = "AT+CIPCLOSE",
                    types = new List<type> { 
                        new type(){
                            variant = commandType.Test
                        },

                        new type(){
                            variant = commandType.Set,
                            description = "Close TCP or UDP connection (Multiple connection mode).",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "id",
                                    description = "ID no. of connection to close, when id=5, all connections will be closed."
                                }
                            }
                        },

                        new type(){
                            variant = commandType.Execute,
                            description = "Close TCP or UDP connection (Single connection mode).",
                            parameters = new List<parameter>(){
                            }
                        }
                    }
                }
            );

            commandsList.Add(
                new command()
                {
                    name = "AT+CIPMUX",
                    types = new List<type> { 
                        new type(){
                            variant = commandType.Query,
                            description = "Print current multiplex mode.",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "mode",
                                    description = "0: Single connection/n1: Multiple connections (MAX 4)"
                                }
                            }
                        },

                        new type(){
                            variant = commandType.Set,
                            description = "Enable / disable multiplex mode (up to 4 conenctions).",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "mode",
                                    description = "0: Single connection/n1: Multiple connections (MAX 4)"
                                }
                            }
                        }
                    }
                }
            );

            commandsList.Add(
                new command()
                {
                    name = "AT+CIPSERVER",
                    types = new List<type> { 

                        new type(){
                            variant = commandType.Set,
                            description = "Configure ESP8266 as server.",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "mode",
                                    description = "0: Delete server (need to follow by restart)/n1:	Create server"
                                },

                                new parameter(){
                                    name = "port",
                                    description = "port number, default is 333"
                                }
                            }
                        },
                    }
                }
            );

            commandsList.Add(
                new command()
                {
                    name = "AT+CIPMODE",
                    types = new List<type> { 
                        new type(){
                            variant = commandType.Query,
                            description = ""
                        },

                        new type(){
                            variant = commandType.Set,
                            description = "",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "",
                                    description = ""
                                }
                            }
                        },
                    }
                }
            );

            commandsList.Add(new command { name = "AT+CIPMODE" });
            commandsList.Add(new command { name = "AT+CIPSTO" });

            commandsList.Add(
                new command()
                {
                    name = "AT+CWJAP",
                    types = new List<type> { 
                        new type(){
                            variant = commandType.Query,
                            description = ""
                        },

                        new type(){
                            variant = commandType.Set,
                            description = "",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "",
                                    description = ""
                                }
                            }
                        },

                        new type(){
                            variant = commandType.Execute,
                            description = "",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "",
                                    description = ""
                                }
                            }
                        }
                    }
                }
            );
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
        private Label label3;
        private ComboBox advancedCommandBox;
        private ComboBox commandTypeBox;
    }
}

