namespace API_Capacitacion.Data
{
    public class PostgresSQLConfiguration
    {
        public string? connection { get; set; }
        public PostgresSQLConfiguration(string Connection) => this.connection = Connection;
    }
}
