namespace Presentacion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**************************************************************
             * LICCENCIADO TUVE PROBLEMAS CON MI COMPUTADORA POR ESO TARDE*
             * EN HACER LOS PRIMEROS VIDEOS DE LA TAREA                   *
             * ************************************************************/



            int i = 0;
            decimal x = 0.0m;
            float f = 0.0f;
            double d = 0.0D;
            string cadena = "";
            bool bandera = false;
            DateTime fecha = DateTime.MinValue;

            Console.WriteLine("El valor de i es: {0}", i);
            Console.WriteLine("El valor de x es: {0:c}", x);
            Console.WriteLine("El valor de f es: {0:F2}", f);
            Console.WriteLine("El valor de d es: {0:F2}", d);
            Console.WriteLine("El valor de la cadena es: " + cadena);
            Console.WriteLine("El valor de la bandera es: " + bandera.ToString());
            Console.WriteLine("El valor de la fecha es: " + fecha.ToShortDateString()); 
            Console.ReadKey();
        }
                 
        
    }
}