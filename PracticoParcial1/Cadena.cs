class Cadena
{
    public string Cad;

    public Cadena(string newcadena)
    {
        Cad = newcadena;
    }
    //ejercicio 4
    public string BuscarElementoArrayCadenas(string elemento)
    {
        bool encontrado = Cad.Contains(Cad);

        if(encontrado)
        {
            Console.WriteLine("TRUE");
        }else
        {
            Console.WriteLine("False");
        }
        return "";
    }
}