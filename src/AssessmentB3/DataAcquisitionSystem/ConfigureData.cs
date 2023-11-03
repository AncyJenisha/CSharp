using System.Numerics;

namespace DataAcquisitionSystem
{
    public class ConfigureData
    {
        public int Rate { get; set; } 

        public List<ConfigureParameter> Parameters { get; set; } = new List<ConfigureParameter>();

    }
}