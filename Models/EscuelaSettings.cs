namespace ApiMongo.Models
{
    public class EscuelaSettings: IEscuelaSettings
    {
        public string Server { get; set; }
        public string Database { get; }
        public string Collection { get; }
    }

    public interface IEscuelaSettings
    {
        string Server { get; }
        string Database { get; }
        string Collection { get; }
    }
}
