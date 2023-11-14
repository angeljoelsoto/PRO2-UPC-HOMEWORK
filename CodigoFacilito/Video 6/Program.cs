namespace Video6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ClsEmpleados empleado;
            empleado = new ClsEmpleados();
            empleado.edad = 15;
            empleado.Nombre = "Angel Joel Soto Espinoza";
            empleado.SuledoDiario = 12.5m;
            decimal total;
            total = empleado.CalcularSalario(30);
            Console.WriteLine("EL SUELDO MENSUAL DEL EMPLEADO: " + empleado.Nombre);
            Console.WriteLine("ES DE: " + total.ToString("C"));
            Console.ReadKey(); 


        }
    }
}