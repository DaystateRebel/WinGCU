using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO.Ports;

namespace WinGCU
{
    internal class Gcu
    {
        Mutex mt = new Mutex(false, "gcuMutex");
        /* Send the 7 byte command, consume the echo from 1 wire operation */
        private bool send_cmd(ref SerialPort serialPort, ref char[] cmd) {
            Thread.Sleep(200);
            serialPort.Write(cmd, 0, cmd.Length);
            try
            {
                for (int i = 0; i < cmd.Length; i++)
                {
                    serialPort.ReadByte();
                }
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }

        private bool read_response(ref SerialPort serialPort, ref String response)
        {
            try
            {
                response = serialPort.ReadLine();
                //System.Diagnostics.Debug.WriteLine(response);
                if (response.Equals("ERROR"))
                {
                    return false;
                }
                if (response.Equals("OK"))
                {
                    return true;
                }
                var verdict = serialPort.ReadLine();
                //System.Diagnostics.Debug.WriteLine(verdict);
                if (!verdict.Equals("OK"))
                {
                    return false;
                }
            }
            catch 
            {
                return false;
            }
            return true;
        }

        public bool connect(ref SerialPort serialPort, ref String version)
        {
            mt.WaitOne();
            char[] cmd = new char[] { 'V', ' ', ' ', ' ', ' ', ' ', ' ' };
            serialPort.DtrEnable = true;
            Thread.Sleep(500);
            send_cmd(ref serialPort, ref cmd);
            return read_response(ref serialPort, ref version);
            mt.ReleaseMutex();
        }

        public void disconnect(ref SerialPort serialPort)
        {
            mt.WaitOne();
            char[] cmd = new char[] { 'Q', ' ', ' ', ' ', ' ', ' ', ' ' };
            send_cmd(ref serialPort, ref cmd);
            serialPort.DtrEnable = false;
            mt.ReleaseMutex();
        }

        public bool read_pressure(ref SerialPort serialPort, ref uint pressure)
        {
            mt.WaitOne();
            string response_str = System.String.Empty;
            char[] cmd = new char[] { 'P', ' ', ' ', ' ', ' ', ' ', ' ' };
            send_cmd(ref serialPort, ref cmd);
            if(!read_response(ref serialPort, ref response_str))
            {
                mt.ReleaseMutex();
                return false;
            }
            pressure = Convert.ToUInt16(response_str, 10);
            mt.ReleaseMutex();
            return true;
        }
        public bool read_pulse(ref SerialPort serialPort, ref uint pressure)
        {
            mt.WaitOne();
            string response_str = System.String.Empty;
            char[] cmd = new char[] { 'A', ' ', ' ', ' ', ' ', ' ', ' ' };
            send_cmd(ref serialPort, ref cmd);
            if (!read_response(ref serialPort, ref response_str))
            {
                mt.ReleaseMutex();
                return false;
            }
            pressure = Convert.ToUInt16(response_str, 10);
            mt.ReleaseMutex();
            return true;
        }

        public bool read_u16(ref SerialPort serialPort, int address, ref uint value)
        {
            mt.WaitOne();
            var address_string = address.ToString("D2");
            char[] charArr = address_string.ToCharArray();
            string response_str = System.String.Empty;
            char[] cmd = new char[] { 'R', charArr[0], charArr[1], ' ', ' ', ' ', ' ' };
            send_cmd(ref serialPort, ref cmd);
            if (!read_response(ref serialPort, ref response_str))
            {
                mt.ReleaseMutex();
                return false;
            }
            value = Convert.ToUInt16(response_str, 10);
            mt.ReleaseMutex();
            return true;
        }

        public bool write_u16(ref SerialPort serialPort, int address, uint value)
        {
            mt.WaitOne();
            var address_string = address.ToString("D2");
            char[] charA = address_string.ToCharArray();
            var value_string = value.ToString("D4");
            char[] charV = value_string.ToCharArray();

            string response_str = System.String.Empty;
            char[] cmd = new char[] { 'W', charA[0], charA[1], charV[0], charV[1], charV[2], charV[3] };
            send_cmd(ref serialPort, ref cmd);
            var result = read_response(ref serialPort, ref response_str);
            mt.ReleaseMutex();
            return result;
        }
        public bool power_lock(ref SerialPort serialPort, uint pulse, uint volts)
        {
            mt.WaitOne();
            string response_str = System.String.Empty;
            if(!write_u16(ref serialPort, 14, pulse))
            {
                return false;
            }
            if (!write_u16(ref serialPort, 16, volts))
            {
                return false;
            }
            char[] cmd = new char[] { 'T', ' ', ' ', ' ', ' ', ' ', ' ' };
            send_cmd(ref serialPort, ref cmd);
            //var result = read_response(ref serialPort, ref response_str);
            mt.ReleaseMutex();
            return true;
        }
        public bool power_unlock(ref SerialPort serialPort)
        {
            mt.WaitOne();
            string response_str = System.String.Empty;
            char[] cmd = new char[] { 'Q', ' ', ' ', ' ', ' ', ' ', ' ' };
            send_cmd(ref serialPort, ref cmd);
            mt.ReleaseMutex();
            return true;
        }

    }
}
