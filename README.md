# ESP8266 Commander

This is a windows application for testing and setting up an ESP8266 module using AT commands. An arduino, ftdi or other prefered module can be used as a USB to UART bridge. The commands are split into two sections: basic and advanced. Basic commands are executed instantly on a click of a button. Advanced commands are executed when an execute button is clicked. When an advanced command is selected, some extra information about it is displayed underneath. All the information about the ESP8266 commands is taken from <a href="https://room-15.github.io/blog/2015/03/26/esp8266-at-command-reference/">this page</a> (credits to the author). The data that is received through the COM port is printed out in the textarea.

### Screenshot
![Alt text](/esp8266CommanderPreview.png "Basic Commands")

## Installation

No installation is needed. Just download the esp8266Commander.exe and run it.

## Usage

Select a COM port, baud rate and press connect.
Basic commands are straightforward and are executed on a click of the button.
In order to use advanced commands you will need to select the command, it's type and input parameters (if there are any).
Advanced commands are executed on a click of button "Execute" (duh!).
## Built With

Visual Studio - Windows Forms Application C#

## Contributing

1. Fork it!
2. Create your feature branch: `git checkout -b my-new-feature`
3. Commit your changes: `git commit -am 'Add some feature'`
4. Push to the branch: `git push origin my-new-feature`
5. Submit a pull request :D

## Authors

* **Danius Kalvaitis**
* **Nerijus Džindželėta**

## License

This project is licensed under the GNU General Public License License - see the [LICENSE](LICENSE) file for details
