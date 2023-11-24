namespace Video8
{
    class Program
    {
        static void Main(string[] agrs)
        {
            clsClienteVentas Cliente;
            Cliente = new clsClienteVentas();
            Cliente.IdClientes = 123;
            Cliente.Apellidos = "Soto Espinoza";
            Cliente.Nombres = "Angel Joel";
            Cliente.RFC = "Hehm";
            Cliente.Direccion = "Satélite Norte";
            Cliente.Colonia = "Pentaguzú";
            Cliente.Municipio = "Warnes";
            Cliente.EsCredito = true;
            Console.WriteLine(Cliente.Apellidos + "" + Cliente.Nombres);
            Console.WriteLine(Cliente.Direccion + " " + Cliente.Colonia + " " + Cliente.Municipio);
            Console.WriteLine(Cliente.RFC);
            if(Cliente.EsCredito){
                Console.WriteLine("El cliente tiene el crédito");
            }else{
                Console.WriteLine("El cliente no tiene el crédito");
                }
            Console.ReadKey();
        }
    }
}