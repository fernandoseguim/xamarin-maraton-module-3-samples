namespace iOSSampleControls
{
    public class Dados
    {

        public string Titulo { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public Dados(string titulo, double latitude, double longitude)
        {
            Titulo = titulo;
            Latitude = latitude;
            Longitude = longitude;
        }

    }
}