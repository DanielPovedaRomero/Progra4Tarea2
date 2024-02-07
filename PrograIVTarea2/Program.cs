using System.Text;

namespace PrograIVTarea2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] medias = { "Rojo", "Azul", "Rojo", "Blanco", "Blanco", "Negro", "Rojo", "Azul", "Blanco"};
            var mediasPares = new List<Par>();
            StringBuilder respuesta = new StringBuilder();

            respuesta.Append("Pares:");

            foreach (Par color in AgruparMedias(medias))
            {
                int cantidadParesDeUnColor = color.cantidad / 2;
                mediasPares.Add( new Par { nombre = color.nombre, cantidad = cantidadParesDeUnColor });
            }

            foreach (var par in mediasPares)
            {
                respuesta.Append($" {par.nombre} - {par.cantidad} ");
            }

            Console.WriteLine( respuesta.ToString() );
        }

        public static List<Par> AgruparMedias(string[] medias) 
        { 
            List<Par> mediasAgrupadas = new List<Par>();

            foreach (var media in medias)
            {
                var index = mediasAgrupadas.FindIndex(x => x.nombre.ToUpper() == media.ToUpper());

                if (index != -1)
                    mediasAgrupadas[index].cantidad++;
                else
                    mediasAgrupadas.Add(new Par { nombre = media, cantidad = 1 });
            }

            return mediasAgrupadas;
        }

        public class Par
        {
            public string nombre { get; set; }
            public int cantidad { get; set; }
        }
    }
}