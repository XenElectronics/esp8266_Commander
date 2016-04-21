using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstWindowsApplication
{
    public class command
    {
        public string name { get; set; }
        public List<type> types { get; set; }
    }

    public class type
    {
        public commandType variant { get; set; }
        public List<parameter> parameters { get; set; }
        public string description { get; set; }
    }

    public class parameter
    {
        public string name { get; set; }
        public string description { get; set; }
    }

    public enum commandType { Test, Query, Set, Execute };

    public class commandTypeLookUp
    {
        public commandType commandType { get; set; }
        public string commandName { get; set; }
    }

    public class commandsGenerator
    {
        public static void generateCommandsList(List<command> commandsList)
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
                                description = "An integer designating the mode of operation either 1, 2, or 3.\n1 = Station mode (client)\n2 = AP mode (host)\n3 = AP + Station mode",
                            }
                        }
                    },

                    new type(){
                        variant = commandType.Execute,
                        description = "Set AP’s info which will be connect by ESP8266.",
                        parameters = new List<parameter>(){
                            new parameter(){
                                name = "mode",
                                description = "An integer designating the mode of operation either 1, 2, or 3.\n1 = Station mode (client)\n2 = AP mode (host)\n3 = AP + Station mode",
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

                    /*new type(){ /\not sure if works
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
                                description = "0 = OPEN\n1 = WEP\n2 = WPA_PSK\n3 = WPA2_PSK\n4 = WPA_WPA2_PSK"
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
                                description = "0 = OPEN\n2 = WPA_PSK\n3 = WPA2_PSK\n4 = WPA_WPA2_PSK"
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
                                description = "0 = OPEN\n2 = WPA_PSK\n3 = WPA2_PSK\n4 = WPA_WPA2_PSK"
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
                                description = "0: Single connection\n1: Multiple connections (MAX 4)"
                            }
                        }
                    },

                    new type(){
                        variant = commandType.Set,
                        description = "Enable / disable multiplex mode (up to 4 conenctions).",
                        parameters = new List<parameter>(){
                            new parameter(){
                                name = "mode",
                                description = "0: Single connection\n1: Multiple connections (MAX 4)"
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
                                description = "0: Delete server (need to follow by restart)\n1:	Create server"
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
                        description = "Get transfer mode.",
                        parameters = new List<parameter>(){
                            new parameter(){
                                name = "mode",
                                description = "0: normal mode\n1: unvarnished transmission mode"
                            }
                        }
                    },

                    new type(){
                        variant = commandType.Set,
                        description = "Set transfer mode, normal or transparent transmission.",
                        parameters = new List<parameter>(){
                            new parameter(){
                                name = "mode",
                                description = "0: normal mode\n1: unvarnished transmission mode"
                            }
                        }
                    },
                    }
                }
            );

            commandsList.Add(
                new command()
                {
                    name = "AT+CIPSTO",
                    types = new List<type> {
                    new type(){
                        variant = commandType.Query,
                        description = "Query server timeout.",
                        parameters = new List<parameter>(){
                            new parameter(){
                                name = "time",
                                description = "server timeout, range 0~7200 seconds"
                            }
                        }
                    },

                    new type(){
                        variant = commandType.Set,
                        description = "Set server timeout.",
                        parameters = new List<parameter>(){
                            new parameter(){
                                name = "time",
                                description = "server timeout, range 0~7200 seconds"
                            }
                        }
                    }
                    }
                }
            );
        }
    }
}
