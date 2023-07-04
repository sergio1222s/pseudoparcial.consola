namespace SimulacionParcial.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {




            double radio = PedirDouble("Ingrese el valor del radio del cono:");
            double altura = PedirDouble("Ingrese el valor de la altura del cono:");

            double generatriz = CalcularGeneratriz(radio, altura);

            double area = CalcularArea(radio, generatriz);
            double volumen = CalcularVolumen(radio, altura);
            Console.WriteLine($"El área del cono es {area}");
            Console.WriteLine($"El volúmen del cono es {volumen}");
        }

        private static double CalcularVolumen(double radio, double altura)
        {
            return (Math.PI * Math.Pow(radio, 2) * altura) / 3;
        }

        private static double CalcularArea(double radio, double generatriz)
        {
            return Math.PI * radio * (radio + generatriz);
        }

        private static double CalcularGeneratriz(double radio, double altura)
        {

            return Math.Sqrt(Math.Pow(radio, 2) + Math.Pow(altura, 2));
        }

        private static double PedirDouble(string Mensaje)
        {
            double nro = 0;
            do
            {
                Console.Write(Mensaje);
                string strConsola = Console.ReadLine();
                if (!double.TryParse(strConsola, out nro))
                {
                    Console.WriteLine("Número mal ingresado");

                }
                else
                {
                    break;
                }

            } while (true);
            return nro;
        }
        private static double PedirDoubleEntreMinYMax(string Mensaje, double min, double max)
        {
            double nro = 0;
            do
            {
                Console.Write(Mensaje);
                string strConsola = Console.ReadLine();
                strConsola = strConsola.Replace('.', ',');
                if (!double.TryParse(strConsola, out nro))
                {
                    Console.WriteLine("Número mal ingresado");

                }
                else if (nro >= min && nro <= max)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"El número debe estar entre {min} y {max}");
                }

            } while (true);
            return nro;
        }

    }
}
