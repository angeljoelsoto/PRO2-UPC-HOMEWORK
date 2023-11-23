using System.Security.Cryptography.X509Certificates;

static class Program
{
    private static void Main(string[] args)
    {
     //long f = Factorial(64);
           //Console.WriteLine(f);
           GenerarSerieV1Recursivo(6);

   
            
        }
            */* public static void GenerarSerieV1Recursivo(int N){
            // int i = 1;
            if(N == 0){
                return;
            }else{
                Console.WriteLine("antes => N: "+ N);
                GenerarSerieV1Recursivo(N - 1); 
                Console.WriteLine("después=> N: " + serie);
                i = serie;   
                }*/
         }
        static int A = 0;
        static int B = 7;

         public static void GenerarDomino(int N){

            if(N == 0){
                return;
            }else{
                 GenerarSerieV1Recursivo(N - 1); 
            int serie1 = X + 1;
            int serie2 = Y - 1;

                Console.WriteLine("Serie: " + serie1);
                Console.WriteLine("Serie: " + serie2);
                X = serie1;    
                Y = serie2;

                }
         }
}