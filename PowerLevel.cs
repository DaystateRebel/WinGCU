

namespace WinGCU
{
    internal class PowerLevel
    {
        public uint high_pressure { get; set; }
        public uint mid_pressure { get; set; }
        public uint low_pressure { get; set; }
        public uint high_pulse { get; set; }
        public uint mid_pulse { get; set; }
        public uint low_pulse { get; set; }
        public uint high_slope { get; set; }
        public uint low_slope { get; set; }
        public uint volts { get; set; }
    }
}