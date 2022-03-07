using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinGCU
{
    public partial class Form1 : Form
    {
        SerialPort serialPort = new SerialPort();
        List<PowerLevel> powerLevels = new List<PowerLevel>();
        Gcu gcu = new Gcu();
        private String gcu_version;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            upload.Enabled = false;
            download.Enabled = false;
            save.Enabled = false;
            PowerSetting.Enabled = false;
            highPressure.Enabled = false;
            midPressure.Enabled = false;
            lowPressure.Enabled = false;
            highPulse.Enabled = false;
            midPulse.Enabled = false;
            lowPulse.Enabled = false;
            volts.Enabled = false;
            update_AvailableSerialPorts();
            if (AvailableSerialPorts.Items.Count > 0)
            {
                AvailableSerialPorts.SelectedIndex = 0;
                connectionstate.Enabled = true;
            }
            else
            {
                connectionstate.Enabled = false;
            }
        }

        private void update_AvailableSerialPorts()
        {
            AvailableSerialPorts.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (string p in ports)
            {
                AvailableSerialPorts.Items.Add(p);
            }
        }

        private void AvailableSerialPorts_DropDown(object sender, EventArgs e)
        {
            update_AvailableSerialPorts();
        }
        private void AvailableSerialPorts_SelectionChangeCommitted(object sender, EventArgs e)
        {
            connectionstate.Enabled = AvailableSerialPorts.Items.Count > 0 && AvailableSerialPorts.SelectedIndex != -1;
        }

        private void ConnectionState_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                if (AvailableSerialPorts.SelectedIndex == -1)
                {
                    historyListBox.Items.Add("Error: No Serial Port Selected");
                    return;
                }
                serialPort.PortName = AvailableSerialPorts.SelectedItem.ToString();
                serialPort.BaudRate = 9600;
                serialPort.DataBits = 8;
                serialPort.StopBits = StopBits  .One;
                serialPort.Parity = Parity.None;
                

                try
                {
                    serialPort.Open();
                }
                catch (System.Exception ex)
                {
                    historyListBox.Items.Add(String.Format("Connecting on {0} Failed : {1}", AvailableSerialPorts.SelectedItem.ToString(), ex.Message));
                    return;
                }
                historyListBox.Items.Add(String.Format("Connecting on {0} ...", AvailableSerialPorts.SelectedItem.ToString()));
                serialPort.NewLine = "\r";
                serialPort.ReadTimeout = 3000;
                if (gcu.connect(ref serialPort, ref gcu_version))
                {
                    version.Text = gcu_version;
                    upload.Enabled = powerLevels.Count == 3;
                    download.Enabled = true;
                    connectionstate.Text = "Disconnect";
                    historyListBox.Items.Add("Connected Ok");
                    poll_timer.Enabled = true;
                }
                else
                {
                    serialPort.Close();
                    historyListBox.Items.Add("Connection Failed");
                }

            }
            else
            {
                poll_timer.Enabled = false;
                gcu.disconnect(ref serialPort);
                serialPort.Close();
                connectionstate.Text = "Connect";
                upload.Enabled = false;
                download.Enabled = false;
                version.Text = "";
                pressure.Text = "";
                pulse_duration.Text = "";
                version.Text = "";
                historyListBox.Items.Add("Disconnected");
            }
        }
        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Title = "Save GCU Power Settings Files",
                CheckPathExists = true,
                DefaultExt = "csv",
                Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (var writer = new System.IO.StreamWriter(saveFileDialog1.FileName))
                using (var csv = new CsvHelper.CsvWriter(writer, System.Globalization.CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(powerLevels);
                }
                historyListBox.Items.Add(String.Format("File saved : {0}", saveFileDialog1.FileName));
            }
        }
        private void load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Browse GCU Power Settings Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "csv",
                Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                powerLevels.Clear();
                using (var reader = new System.IO.StreamReader(openFileDialog1.FileName))
                using (var csv = new CsvHelper.CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
                {
                    csv.Read();
                    csv.ReadHeader();
                    while (csv.Read())
                    {
                        var powerLevel = new PowerLevel
                        {
                            high_pressure = csv.GetField<uint>("high_pressure"),
                            mid_pressure = csv.GetField<uint>("mid_pressure"),
                            low_pressure = csv.GetField<uint>("low_pressure"),
                            high_pulse = csv.GetField<uint>("high_pulse"),
                            mid_pulse = csv.GetField<uint>("mid_pulse"),
                            low_pulse = csv.GetField<uint>("low_pulse"),
                            high_slope = csv.GetField<uint>("high_slope"),
                            low_slope = csv.GetField<uint>("low_slope"),
                            volts = csv.GetField<uint>("volts")
                        };
                        powerLevels.Add(powerLevel);
                    }
                }
                if(powerLevels.Count != 3)
                {
                    MessageBox.Show("Bad Power Level Data", "OK");
                    powerLevels.Clear();
                    PowerSetting.Enabled = false;
                    save.Enabled = false;
                    highPressure.Enabled = false;
                    midPressure.Enabled = false;
                    lowPressure.Enabled = false;
                    highPulse.Enabled = false;
                    midPulse.Enabled = false;
                    lowPulse.Enabled = false;
                    volts.Enabled = false;
                }
                else
                {
                    PowerSetting.SelectedIndex = 0;
                    Update_Power_Settings();
                    save.Enabled = true;
                    PowerSetting.Enabled = true;
                    highPressure.Enabled = true;
                    midPressure.Enabled = true;
                    lowPressure.Enabled = true;
                    highPulse.Enabled = true;
                    midPulse.Enabled = true;
                    lowPulse.Enabled = true;
                    volts.Enabled = true;
                    upload.Enabled = serialPort.IsOpen;
                    historyListBox.Items.Add(String.Format("File loaded : {0}", openFileDialog1.FileName));
                }

            }
        }
        private decimal Raw_To_Bar(uint raw)
        {
            return (decimal)Math.Round((raw + 105)/4.1); 
        }
        private decimal Raw_To_Volts(uint raw)
        {
            return (decimal)(raw * 0.075);
        }
        private uint Volts_To_Raw(decimal volts)
        {
            return (uint)((double)volts / 0.075);
        }
        private double Raw_To_Slope(uint raw)
        {
            return (raw * 4.1) / 128;
        }
        private void Update_Power_Settings()
        {
            /* Do this song & dance to avoid getting overwritten is old value is less than new minimum etc */
            var h = powerLevels[PowerSetting.SelectedIndex].high_pressure;
            var m = powerLevels[PowerSetting.SelectedIndex].mid_pressure;
            var l = powerLevels[PowerSetting.SelectedIndex].low_pressure;

            highPressure.Minimum = m + 1;
            midPressure.Maximum = h - 1;
            midPressure.Minimum = l + 1;
            lowPressure.Maximum = m - 1;

            highPressure.Value = h;
            midPressure.Value = m;
            lowPressure.Value = l;

            highPulse.Value = powerLevels[PowerSetting.SelectedIndex].high_pulse;
            midPulse.Value = powerLevels[PowerSetting.SelectedIndex].mid_pulse;
            lowPulse.Value = powerLevels[PowerSetting.SelectedIndex].low_pulse;

            volts.Value = Raw_To_Volts(powerLevels[PowerSetting.SelectedIndex].volts);

            highBar.Text = String.Format("{0} BAR", Raw_To_Bar(powerLevels[PowerSetting.SelectedIndex].high_pressure));
            midBar.Text = String.Format("{0} BAR", Raw_To_Bar(powerLevels[PowerSetting.SelectedIndex].mid_pressure));
            lowBar.Text = String.Format("{0} BAR", Raw_To_Bar(powerLevels[PowerSetting.SelectedIndex].low_pressure));
            update_high_slope();
            update_low_slope();

        }

        private void PowerSetting_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Update_Power_Settings();
        }

        private void update_high_slope()
        {
            var d_Pr = powerLevels[PowerSetting.SelectedIndex].high_pressure - powerLevels[PowerSetting.SelectedIndex].mid_pressure;
            var d_Pu = powerLevels[PowerSetting.SelectedIndex].high_pulse - powerLevels[PowerSetting.SelectedIndex].mid_pulse;
            powerLevels[PowerSetting.SelectedIndex].high_slope = (d_Pu * 128) / d_Pr;
            highSlope.Text = String.Format("{0:0.00}", Raw_To_Slope(powerLevels[PowerSetting.SelectedIndex].high_slope));
        }
        private void update_low_slope()
        {
            var d_Pr = powerLevels[PowerSetting.SelectedIndex].mid_pressure - powerLevels[PowerSetting.SelectedIndex].low_pressure;
            var d_Pu = powerLevels[PowerSetting.SelectedIndex].mid_pulse - powerLevels[PowerSetting.SelectedIndex].low_pulse;
            powerLevels[PowerSetting.SelectedIndex].low_slope = (d_Pu * 128) / d_Pr;
            lowSlope.Text = String.Format("{0:0.00}", Raw_To_Slope(powerLevels[PowerSetting.SelectedIndex].low_slope));
        }


        private void highPressure_ValueChanged(object sender, EventArgs e)
        {
            powerLevels[PowerSetting.SelectedIndex].high_pressure = (uint)highPressure.Value;
            highBar.Text = String.Format("{0} BAR", Raw_To_Bar(powerLevels[PowerSetting.SelectedIndex].high_pressure));
            update_high_slope();
            midPressure.Maximum = powerLevels[PowerSetting.SelectedIndex].high_pressure - 1;
        }

        private void midPressure_ValueChanged(object sender, EventArgs e)
        {
            powerLevels[PowerSetting.SelectedIndex].mid_pressure = (uint)midPressure.Value;
            midBar.Text = String.Format("{0} BAR", Raw_To_Bar(powerLevels[PowerSetting.SelectedIndex].mid_pressure));
            update_high_slope();
            update_low_slope();
            highPressure.Minimum = powerLevels[PowerSetting.SelectedIndex].mid_pressure + 1;
            lowPressure.Maximum = powerLevels[PowerSetting.SelectedIndex].mid_pressure - 1;
        }

        private void lowPressure_ValueChanged(object sender, EventArgs e)
        {
            powerLevels[PowerSetting.SelectedIndex].low_pressure = (uint)lowPressure.Value;
            lowBar.Text = String.Format("{0} BAR", Raw_To_Bar(powerLevels[PowerSetting.SelectedIndex].low_pressure));
            update_low_slope();
            midPressure.Minimum = powerLevels[PowerSetting.SelectedIndex].low_pressure + 1;
        }

        private void volts_ValueChanged(object sender, EventArgs e)
        {
            powerLevels[PowerSetting.SelectedIndex].volts = Volts_To_Raw(volts.Value);
        }

        private void highPulse_ValueChanged(object sender, EventArgs e)
        {
            powerLevels[PowerSetting.SelectedIndex].high_pulse = (uint)highPulse.Value;
            update_high_slope();
        }

        private void midPulse_ValueChanged(object sender, EventArgs e)
        {
            powerLevels[PowerSetting.SelectedIndex].mid_pulse = (uint)midPulse.Value;
            update_high_slope();
            update_low_slope();
        }

        private void lowPulse_ValueChanged(object sender, EventArgs e)
        {
            powerLevels[PowerSetting.SelectedIndex].low_pulse = (uint)lowPulse.Value;
            update_low_slope();
        }

        private void poll_timer_Tick(object sender, EventArgs e)
        {
            uint p = 0;
            if(gcu.read_pressure(ref serialPort, ref p))
            {
                if(p >= 100)
                {
                    pressure.Text = String.Format("{0} BAR", Raw_To_Bar(p));
                }
                else
                {
                    pressure.Text = "--- BAR";
                }
            }
            uint a = 0;
            if(gcu.read_pulse(ref serialPort, ref a))
            {
                pulse_duration.Text = String.Format("{0}", a);
            }
        }

        private void download_Click(object sender, EventArgs e)
        {
            uint high_pressure = 0;
            uint mid_pressure = 0;
            uint low_pressure = 0;
            uint high_pulse = 0;
            uint mid_pulse = 0;
            uint low_pulse = 0;
            uint high_slope = 0;
            uint low_slope = 0;
            uint vlts = 0;

            historyListBox.Items.Add("Downloading Settings ...");
            powerLevels.Clear();
            char[] address = new char[2];
            for(int pl = 0; pl < 3; pl++)
            {
                if (!(gcu.read_u16(ref serialPort, 0 + (pl + 1) * 20, ref high_pressure) &&
                gcu.read_u16(ref serialPort, 2 + (pl + 1) * 20, ref mid_pressure) &&
                gcu.read_u16(ref serialPort, 4 + (pl + 1) * 20, ref low_pressure) &&
                gcu.read_u16(ref serialPort, 6 + (pl + 1) * 20, ref high_pulse) &&
                gcu.read_u16(ref serialPort, 8 + (pl + 1) * 20, ref mid_pulse) &&
                gcu.read_u16(ref serialPort, 10 +(pl + 1) * 20, ref low_pulse) &&
                gcu.read_u16(ref serialPort, 12 +(pl + 1) * 20, ref high_slope) &&
                gcu.read_u16(ref serialPort, 14 +(pl + 1) * 20, ref low_slope) &&
                gcu.read_u16(ref serialPort, 16 +(pl + 1) * 20, ref vlts)))
                {
                    historyListBox.Items.Add("Download Failed");
                    powerLevels.Clear();
                    return;
                }

                var powerLevel = new PowerLevel
                {
                    high_pressure = high_pressure,
                    mid_pressure = mid_pressure,
                    low_pressure = low_pressure,
                    high_pulse = high_pulse,
                    mid_pulse = mid_pulse,
                    low_pulse = low_pulse,
                    high_slope = high_pulse,
                    low_slope = low_slope,
                    volts = vlts
                };
                powerLevels.Add(powerLevel);
            }
            PowerSetting.SelectedIndex = 0;
            Update_Power_Settings();
            save.Enabled = true;
            PowerSetting.Enabled = true;
            highPressure.Enabled = true;
            midPressure.Enabled = true;
            lowPressure.Enabled = true;
            highPulse.Enabled = true;
            midPulse.Enabled = true;
            lowPulse.Enabled = true;
            volts.Enabled = true;
            upload.Enabled = true;
            historyListBox.Items.Add("Download OK");
        }

        private void upload_Click(object sender, EventArgs e)
        {
            historyListBox.Items.Add("Uploading Settings ...");
            for (int pl = 0; pl < 3; pl++)
            {
                if (!(gcu.write_u16(ref serialPort, 0 + (pl + 1) * 20, powerLevels[pl].high_pressure) &&
                gcu.write_u16(ref serialPort, 2 + (pl + 1) * 20, powerLevels[pl].mid_pressure) &&
                gcu.write_u16(ref serialPort, 4 + (pl + 1) * 20, powerLevels[pl].low_pressure) &&
                gcu.write_u16(ref serialPort, 6 + (pl + 1) * 20, powerLevels[pl].high_pulse) &&
                gcu.write_u16(ref serialPort, 8 + (pl + 1) * 20, powerLevels[pl].mid_pulse) &&
                gcu.write_u16(ref serialPort, 10 + (pl + 1) * 20, powerLevels[pl].low_pulse) &&
                gcu.write_u16(ref serialPort, 12 + (pl + 1) * 20, powerLevels[pl].high_slope) &&
                gcu.write_u16(ref serialPort, 14 + (pl + 1) * 20, powerLevels[pl].low_slope) &&
                gcu.write_u16(ref serialPort, 16 + (pl + 1) * 20, powerLevels[pl].volts)))
                {
                    historyListBox.Items.Add("Upload Failed");
                    powerLevels.Clear();
                    return;
                }
            }
            historyListBox.Items.Add("Upload OK");
        }

        private void pl_high_CheckedChanged(object sender, EventArgs e)
        {
            if(pl_high.Checked)
            {
                pl_medium.Checked = false;
                pl_low.Checked = false;
                if(!gcu.power_lock(ref serialPort, powerLevels[PowerSetting.SelectedIndex].high_pulse, powerLevels[PowerSetting.SelectedIndex].volts))
                {
                    historyListBox.Items.Add("Power Lock: High: Failed");
                }
                else
                {
                    historyListBox.Items.Add("Power Lock: High: Ok");
                }
            }
            else
            {
                gcu.power_unlock(ref serialPort);
                historyListBox.Items.Add("Power Lock: Unlock");
            }
        }

        private void pl_medium_CheckedChanged(object sender, EventArgs e)
        {
            if (pl_medium.Checked)
            {
                pl_high.Checked = false;
                pl_low.Checked = false;
                if (!gcu.power_lock(ref serialPort, powerLevels[PowerSetting.SelectedIndex].mid_pulse, powerLevels[PowerSetting.SelectedIndex].volts))
                {
                    historyListBox.Items.Add("Power Lock: Medium: Failed");
                }
                else
                {
                    historyListBox.Items.Add("Power Lock: Medium: Ok");
                }
            }
            else
            {
                gcu.power_unlock(ref serialPort);
                historyListBox.Items.Add("Power Lock: Unlock");
            }
        }

        private void pl_low_CheckedChanged(object sender, EventArgs e)
        {
            if (pl_low.Checked)
            {
                pl_high.Checked = false;
                pl_medium.Checked = false;
                if (!gcu.power_lock(ref serialPort, powerLevels[PowerSetting.SelectedIndex].low_pulse, powerLevels[PowerSetting.SelectedIndex].volts))
                {
                    historyListBox.Items.Add("Power Lock: Low: Failed");
                }
                else
                {
                    historyListBox.Items.Add("Power Lock: Low: Ok");
                }
            }
            else
            {
                gcu.power_unlock(ref serialPort);
                historyListBox.Items.Add("Power Lock: Unlock");
            }
        }

        private void clear_history_Click(object sender, EventArgs e)
        {
            historyListBox.Items.Clear();
        }
    }
}
