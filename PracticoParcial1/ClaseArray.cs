using System.Collections;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

class ClaseArray
{
	public int[] ArrayEnteros;




	//constructor 
	public ClaseArray(int cantidad)
	{
		ArrayEnteros = new int [cantidad];
	}



	//metodos  (procedimientos y funciones)
	public void MostrarArray()
	{
		string resp = "[";
		for (int i = 0; i < ArrayEnteros.Length; i++)
		{
			resp += ArrayEnteros[i] + ", ";
		}
		Console.WriteLine(resp + "]");
	}



	//metodo ejercicio 1 
	public void MostraMaxMinArrayEnteros()
	{
		int max = ArrayEnteros[0];
		int min = ArrayEnteros[0];
		

	for (int i = 1; i < ArrayEnteros.Length; i++)
	{
   	 if (ArrayEnteros[i] > max)
    	{
        	max = ArrayEnteros[i];
    	}
    	else if (ArrayEnteros[i] < min)
    	{
        	min = ArrayEnteros[i];
    	}
	}
		Console.WriteLine("El valor maximo es: " + max);
		Console.WriteLine("El valor minimo es: " + min);
	}

	//metodo ejercicio 2 
	public void SumarElementos()
	{
		int suma = 0;
		int n= ArrayEnteros.Length;
		for(int i = 0; i < n - 1; i++)
		{
			suma = suma + ArrayEnteros[0];
		}
		Console.WriteLine("La suma del Array es: " + suma);
	}

	//metodo ejercicio 3 

	public void PromedioArray()
	{
		double promedio = 0, suma= 0;
		int n = ArrayEnteros.Length;
		 
		for (int i = 0; i <= n - 1; i++)
		{
			suma = suma + ArrayEnteros[i];
			promedio = suma / ArrayEnteros.Length;
		}
		Console.WriteLine(promedio);	
	}	
	
		
}	
	  
	



