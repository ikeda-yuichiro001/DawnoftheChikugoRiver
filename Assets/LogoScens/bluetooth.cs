using System;
using System.Text;
using System.Net;
using System.IO.Ports;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Net.Sockets;

public class BLE
{
    public delegate void Eve(string x);
    public SerialPort port = new SerialPort()
    {
        NewLine = "\n",
        BaudRate = 115200,
        Handshake = Handshake.None,
        Encoding = System.Text.Encoding.ASCII,
        ReadTimeout = 100,
        WriteTimeout = 100,
        Parity = Parity.None,
        DataBits = 8,
        StopBits = StopBits.One,
        RtsEnable = true,
    };

    public BLE(string PortName, int BaudRate, Eve Recv, Eve Error)
    {
        port.PortName = PortName;
        port.BaudRate = BaudRate;
        if (Recv != null)
            port.DataReceived += delegate (object m, SerialDataReceivedEventArgs e)
            {
                Recv(port.ReadLine());
            };
        if (Error != null)
            port.ErrorReceived += delegate (object m, SerialErrorReceivedEventArgs e)
            {
                Error(e.EventType.ToString());
            };
        port.Open();
        while (!port.IsOpen);
    }
    public void Send(string x)
    {
        if (x != string.Empty)
            port.Write(x);
    }
    ~BLE(){
        try
        {
            port.Close();
            port.Dispose();

        }
        catch (Exception)
        {

        }
    }
}