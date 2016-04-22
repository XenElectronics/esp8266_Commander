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
        public string response { get; set; } 
    }

    public class parameter
    {
        public string name { get; set; }
        public string description { get; set; }
        public parameterType typeP { get; set; }
    }

    public enum parameterType { stringP, intP };
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
                        variant = commandType.Set,
                        description = "Enter deep sleep mode for 'time' milliseconds.",
                        response = "'time' OK",
                        parameters = new List<parameter>(){
                            new parameter(){
                                name = "time",
                                description = "Time to sleep in milliseconds",
                                typeP = parameterType.intP
                            }
                        }
                    }
                }
            }
        );

            commandsList.Add(
                new command()
                {
                    name = "AT+CWMODE",
                    types = new List<type> {
                        new type(){
                            variant = commandType.Test,
                            description = "List valid modes.",
                            response = "+CWMODE:(1-3) OK\n1 = Station mode (client)\n2 = AP mode (host)\n3 = AP + Station mode (Yes, ESP8266 has a dual mode!)"
                            },

                        new type(){
                            variant = commandType.Query,
                            description = "Query AP’s info which is connected by ESP8266.",
                            response = "+CWMODE:'mode' OK",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "mode",
                                    description = "An integer designating the mode of operation either 1, 2, or 3.\n1 = Station mode (client)\n2 = AP mode (host)\n3 = AP + Station mode",
                                    typeP = parameterType.intP
                                }
                            }
                        },

                        new type(){
                            variant = commandType.Set,
                            description = "Set AP’s info which will be connect by ESP8266.",
                            response = "OK",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "mode",
                                    description = "An integer designating the mode of operation either 1, 2, or 3.\n1 = Station mode (client)\n2 = AP mode (host)\n3 = AP + Station mode",
                                    typeP = parameterType.intP
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
                            response = "+ CWJAP:'ssid' OK",
                            description = "Prints the SSID of Access Point ESP8266 is connected to.",
                            parameters = new List<parameter>(){
                                new parameter()
                                {
                                    name = "ssid",
                                    description = "String, AP’s SSID",
                                    typeP = parameterType.stringP
                                }
                            }
                        },

                        new type(){
                            variant = commandType.Set,
                            response = "OK",
                            description = "Commands ESP8266 to connect a SSID with supplied password.",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "ssid",
                                    description = "String, AP’s SSID",
                                    typeP = parameterType.stringP
                                },

                                new parameter(){
                                    name = "pwd",
                                    description = "String, not longer than 64 characters",
                                    typeP = parameterType.stringP
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
                            response = "AT+CWLAP:'ecn', 'ssid', 'rssi', 'mac' OK",
                            description = "Lists available Access Points.",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "ecn",
                                    description = "0 = OPEN, 1 = WEP, 2 = WPA_PSK\n3 = WPA2_PSK, 4 = WPA_WPA2_PSK",
                                    typeP = parameterType.intP
                                },

                                new parameter(){
                                    name = "ssid",
                                    description = "String, SSID of AP.",
                                    typeP = parameterType.stringP
                                },

                                new parameter(){
                                    name = "rssi",
                                    description = "Signal strength.",
                                },

                                new parameter(){
                                    name = "mac",
                                    description = "String, MAC address.",
                                    typeP = parameterType.stringP
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
                            response = "+CWSAP: 'ssid', 'pwd', 'ch', 'ecn' OK",
                            description = "Query configuration of ESP8266 softAP mode.",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "ssid",
                                    description = "String, ESP8266’s softAP SSID.",
                                    typeP = parameterType.stringP
                                },

                                new parameter(){
                                    name = "pwd",
                                    description = "String, Password, no longer than 64 characters.",
                                    typeP = parameterType.stringP
                                },

                                new parameter(){
                                    name = "ch",
                                    description = "Channel id.",
                                    typeP = parameterType.intP
                                },

                                new parameter(){
                                    name = "ecn",
                                    description = "0 = OPEN, 2 = WPA_PSK, 3 = WPA2_PSK, 4 = WPA_WPA2_PSK",
                                    typeP = parameterType.intP
                                },
                            }
                        },

                        new type(){
                            variant = commandType.Set,
                            description = "Set configuration of softAP mode.",
                            response = "OK",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "ssid",
                                    description = "String, ESP8266’s softAP SSID.",
                                    typeP = parameterType.stringP
                                },

                                new parameter(){
                                    name = "pwd",
                                    description = "String, Password, no longer than 64 characters.",
                                    typeP = parameterType.stringP
                                },

                                new parameter(){
                                    name = "ch",
                                    description = "Channel id.",
                                    typeP = parameterType.intP
                                },

                                new parameter(){
                                    name = "ecn",
                                    description = "0 = OPEN, 2 = WPA_PSK, 3 = WPA2_PSK, 4 = WPA_WPA2_PSK",
                                    typeP = parameterType.intP
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
                            variant = commandType.Set,
                            description = "Set configuration of softAP mode.",
                            response = "OK",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "mode",
                                    description = "0: set ESP8266 as a softAP, 1: set ESP8266 as a station\n2: set ESP8266 to both 0 and 1",
                                    typeP = parameterType.intP
                                },

                                new parameter(){
                                    name = "en",
                                    description = "0: Enable DHCP, 1: Disable DHCP",
                                    typeP = parameterType.intP
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
                            description = "Print current ESP8266’s MAC address.",
                            response = "+CIPSTAMAC:'mac' OK",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "mac",
                                    description = "String, MAC address of the ESP8266 station.",
                                    typeP = parameterType.stringP
                                }
                            }
                        },

                        new type(){
                            variant = commandType.Set,
                            description = "Set ESP8266’s MAC address.",
                            response = "OK",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "mac",
                                    description = "String, MAC address of the ESP8266 station.",
                                    typeP = parameterType.stringP
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
                            description = "Get MAC address of ESP8266 softAP.",
                            response = "+CIPAPMAC:'mac' OK",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "mac",
                                    description = "String, MAC address of the ESP8266 station.",
                                    typeP = parameterType.stringP
                                }
                            }
                        },

                        new type(){
                            variant = commandType.Set,
                            description = "Set mac of ESP8266 softAP.",
                            response = "OK",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "mac",
                                    description = "String, MAC address of the ESP8266 station.",
                                    typeP = parameterType.stringP
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
                            description = "Get IP address of ESP8266 station.",
                            response = "+CIPSTA:'ip' OK",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "ip",
                                    description = "String, ip address of the ESP8266 station.",
                                    typeP = parameterType.stringP
                                }
                            }
                        },

                        new type(){
                            variant = commandType.Set,
                            description = "Set ip address of ESP8266 station.",
                            response = "OK",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "ip",
                                    description = "String, ip address of the ESP8266 station.",
                                    typeP = parameterType.stringP
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
                            description = "Get ip address of ESP8266 softAP.",
                            response = "+CIPAP:'ip' OK",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "ip",
                                    description = "String, ip address of ESP8266 softAP.",
                                    typeP = parameterType.stringP
                                }
                            }
                        },

                        new type(){
                            variant = commandType.Set,
                            description = "Set ip address of ESP8266 softAP.",
                            response = "OK",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "ip",
                                    description = "String, ip address of ESP8266 softAP.",
                                    typeP = parameterType.stringP
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
                            response = "OK",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "id",
                                    description = "0-4, id of connection",
                                    typeP = parameterType.intP
                                },

                                new parameter(){
                                    name = "type",
                                    description = "String, “TCP” or “UDP”",
                                    typeP = parameterType.stringP
                                },

                                new parameter(){
                                    name = "addr",
                                    description = "String, remote IP",
                                    typeP = parameterType.stringP
                                },

                                new parameter(){
                                    name = "port",
                                    description = "String, remote port",
                                    typeP = parameterType.stringP
                                }
                            }
                        },

                        new type(){
                            variant = commandType.Test,
                            response = "+CIPSTART:'id', 'type', 'ip address', 'port' OK",
                            description = "List possible command variations.",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "id",
                                    description = "0-4, id of connection",
                                    typeP = parameterType.intP
                                },

                                new parameter(){
                                    name = "type",
                                    description = "String, “TCP” or “UDP”",
                                    typeP = parameterType.stringP
                                },

                                new parameter(){
                                    name = "addr",
                                    description = "String, remote IP",
                                    typeP = parameterType.stringP
                                },

                                new parameter(){
                                    name = "port",
                                    description = "String, remote port",
                                    typeP = parameterType.stringP
                                }
                            }
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
                            response = "OK"
                        },

                        new type(){
                            variant = commandType.Set,
                            description = "Set length of the data that will be sent. For normal send.",
                            response = "SEND OK",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "id",
                                    description = "ID no. of transmit connection",
                                    typeP = parameterType.intP
                                },

                                new parameter(){
                                    name = "length",
                                    description = "data length, MAX 2048 bytes",
                                    typeP = parameterType.intP
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
                            variant = commandType.Test,
                            response = "OK"
                        },

                        new type(){
                            variant = commandType.Set,
                            description = "Close TCP or UDP connection (Multiple connection mode).",
                            response = "OK",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "id",
                                    description = "ID no. of connection to close, when id=5, all connections will be closed.",
                                    typeP = parameterType.intP
                                }
                            }
                        },

                        new type(){
                            variant = commandType.Execute,
                            description = "Close TCP or UDP connection (Single connection mode).",
                            response = "OK"
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
                            response = "+CIPMUX:'mode' OK",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "mode",
                                    description = "0: Single connection\n1: Multiple connections (MAX 4)",
                                    typeP = parameterType.intP
                                }
                            }
                        },

                        new type(){
                            variant = commandType.Set,
                            description = "Enable / disable multiplex mode (up to 4 conenctions).",
                            response = "OK",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "mode",
                                    description = "0: Single connection\n1: Multiple connections (MAX 4)",
                                    typeP = parameterType.intP
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
                            response = "OK",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "mode",
                                    description = "0: Delete server (need to follow by restart), 1:	Create server",
                                    typeP = parameterType.intP
                                },

                                new parameter(){
                                    name = "port",
                                    description = "port number, default is 333",
                                    typeP = parameterType.intP
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
                            response = "	+CIPMODE:'mode' OK",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "mode",
                                    description = "0: normal mode\n1: unvarnished transmission mode",
                                    typeP = parameterType.intP
                                }
                            }
                        },

                        new type(){
                            variant = commandType.Set,
                            description = "Set transfer mode, normal or transparent transmission.",
                            response = "OK",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "mode",
                                    description = "0: normal mode\n1: unvarnished transmission mode",
                                    typeP = parameterType.intP
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
                            response = "+CIPSTO:'time'",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "time",
                                    description = "server timeout, range 0~7200 seconds",
                                    typeP = parameterType.intP
                                }
                            }
                        },

                        new type(){
                            variant = commandType.Set,
                            description = "Set server timeout.",
                            response = "OK",
                            parameters = new List<parameter>(){
                                new parameter(){
                                    name = "time",
                                    description = "server timeout, range 0~7200 seconds",
                                    typeP = parameterType.intP
                                }
                            }
                        }
                    }
                }
            );
        }
    }
}
