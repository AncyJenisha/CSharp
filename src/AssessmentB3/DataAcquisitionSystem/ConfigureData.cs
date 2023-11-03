namespace DataAcquisitionSystem
{
    public class ConfigureData
    {
        public double rate { get; set; } 

        public List<ConfigureParameter> Parameters { get; set; } = new List<ConfigureParameter>();

    }
}