using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace ps_control.source
{
    public class PSU
    {
        public string m_inst_name { get; set; }
        public string m_inst_ip { get; set; }
        public int m_inst_port { get; set; }
        public Socket m_inst_socket;
        public IPEndPoint m_inst_ipep = null;
        public bool m_inst_connected = false;

        // constructor
        public PSU(string inst_name, string ip, int port)
        {
            this.m_inst_name = inst_name;
            this.m_inst_ip = ip;
            this.m_inst_port = port;
        }

        // destructor
        ~PSU()
        {
        }

        public bool checkConnected()
        {
            if (m_inst_connected)
            {
                return true;
            }
            else
            {
                MessageBox.Show(
                    this.m_inst_name + " is not connected.", "No connection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return false;
            }
        }

        public void connectInst()
        {
            // attempt connection to instrument
            try
            {
                this.m_inst_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                this.m_inst_ipep = new IPEndPoint(IPAddress.Parse(this.m_inst_ip), this.m_inst_port);
                this.m_inst_socket.ReceiveTimeout = 1000;
                this.m_inst_socket.SendTimeout = 1000;
                this.m_inst_socket.Connect(this.m_inst_ipep);
                this.m_inst_connected = true;
            }
            catch
            {
                this.m_inst_connected = false;
                MessageBox.Show(
                    "Cannot Connect to Power Supply. " + this.m_inst_ip,
                    "Connection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public string getInstName()
        {
            return this.m_inst_name;
        }

        public string getCurr()
        {
            try
            {
                this.m_inst_socket.Send(Encoding.ASCII.GetBytes("measure:current?\n"));
                string readcurr = float.Parse(readLine().Trim()).ToString("0.####");
                return readcurr;
            }
            catch
            {
                this.m_inst_connected = false;
                return "";
            }
        }

        public string getVolt()
        {
            try
            {
                this.m_inst_socket.Send(Encoding.ASCII.GetBytes("measure:voltage?\n"));
                string readvolt = float.Parse(readLine().Trim()).ToString("0.####");
                return readvolt;
            }
            catch
            {
                this.m_inst_connected = false;
                return "";
            }
        }

        public bool isConnected()
        {
            return this.m_inst_connected;
        }

        public void performPowerCycle()
        {
            if (checkConnected())
            {
                this.m_inst_socket.Send(Encoding.ASCII.GetBytes("output off" + "\n"));
                System.Threading.Thread.Sleep(2000);
                this.m_inst_socket.Send(Encoding.ASCII.GetBytes("output on" + "\n"));
            }
        }

        public string readLine()
        {
            byte[] data = new byte[1024];
            int receivedDataLength = this.m_inst_socket.Receive(data);
            return Encoding.ASCII.GetString(data, 0, receivedDataLength);
        }

        public void setON()
        {
            if (checkConnected())
            {
                this.m_inst_socket.Send(Encoding.ASCII.GetBytes("output on" + "\n"));
            }
        }

        public void setOFF()
        {
            if (checkConnected())
            {
                this.m_inst_socket.Send(Encoding.ASCII.GetBytes("output off" + "\n"));
            }
        }

        public void setCurrLimit(double curr)
        {
            if (checkConnected())
            {
                this.m_inst_socket.Send(Encoding.ASCII.GetBytes("curr:lim " + curr + "\n"));
            }
        }

        public void setInstName(string inst_name)
        {
            this.m_inst_name = inst_name;
        }

        public void setVolt(double volt)
        {
            if (checkConnected())
            {
                if (volt >= 0 && volt <= 40)
                {
                    this.m_inst_socket.Send(Encoding.ASCII.GetBytes("volt " + volt + "\n"));
                }
                else
                {
                    MessageBox.Show(
                        "Voltage Range Must be within 0 - 40 V", "Voltage out of range",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
            }
        }

        public void setVoltLimit(double volt_limit) 
        {
            if (checkConnected())
            {
                if (volt_limit >= 0 && volt_limit <= 40)
                {
                    this.m_inst_socket.Send(Encoding.ASCII.GetBytes("volt:limit " + volt_limit + "\n"));
                }
                else
                {
                    MessageBox.Show(
                        "Voltage Range Must be within 0 - 40 V", "Voltage out of range",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
            }
        }

    }
}
