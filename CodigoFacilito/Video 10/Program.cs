namespace video9
{
    class Program
    {
        static void Main(String[] args)
        {
            ClientesBase cliente = new ClientesBase(0, "angel soto", "256", "asje", 22, "Angel Joel Soto Espinoza");
            Console.WriteLine(cliente.Clave + " " + cliente.Nombre);
            Console.WriteLine(cliente.TipoRegimen);
            Console.WriteLine(cliente.RFC);
            Console.ReadKey();
            
         }
    }
}