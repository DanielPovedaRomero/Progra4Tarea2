using System.Text;

namespace PrograIVTarea2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] medias = { "Rojo", "Azul", "Rojo", "Blanco", "Blanco", "Negro", "Rojo", "Azul", "Blanco" };
            var mediasPares = new List<Par>();
            StringBuilder respuesta = new StringBuilder();
            respuesta.Append("Pares:");

            foreach (string color in medias.Distinct())
            {
                int cantidadDeUnColor = medias.Count(x => x == color) / 2;
                mediasPares.Add( new Par { nombre = color, cantidad = cantidadDeUnColor });
            }

            foreach (var par in mediasPares)
            {
                respuesta.Append($" {par.nombre} : {par.cantidad}, ");
            }

            Console.WriteLine( respuesta.ToString() );
        }

        public class Par
        {
            public string nombre { get; set; }
            public int cantidad { get; set; }
        }
    }
}