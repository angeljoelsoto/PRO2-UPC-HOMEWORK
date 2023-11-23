namespace Exposicion
{
    class Program
    {
        static void Main(string[]args)
        {
           Console.WriteLine("ingrese el numero que quieres fcalcular su factorial");
           int numero = Convert.ToInt32(Console.ReadLine());
           int NumFactorial = Factorial (numero) ;

           Console.WriteLine("el factorial de " + numero + " es igual a " + NumFactorial );

        }
        static int Factorial( int numero)
        {
            if(numero == 1)
            {
                return 1;
            }else
            {
                return numero * Factorial(numero - 1);
            }
           
         




       
        }
    }
}