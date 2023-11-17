namespace PracticoParcial1
{
    class Program
    {
        public static void Main(string[] args)
        {
            ClaseArray A = new ClaseArray(5);
            A.ArrayEnteros[0] = 1;
            A.ArrayEnteros[1] = 10; 
            A.ArrayEnteros[2] = 8;
            A.ArrayEnteros[3] = 20;
            A.ArrayEnteros[4] = 3;
            A.MostrarArray(); 
            //mostrar valor máximo y mínimo del array
            A.MostraMaxMinArrayEnteros();
            A.SumarElementos();
           
           Console.WriteLine("");
           Console.WriteLine("");

            Cadena B = new Cadena("hola soy juan el marino que te quierte mucho");
            Console.WriteLine("se encontro el elemento: "); 
            B.BuscarElementoArrayCadenas("marino");



        }
    }

}
