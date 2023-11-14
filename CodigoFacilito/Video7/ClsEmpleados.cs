namespace Video6{
public class ClsEmpleados
{
    private string _Nombre;
    public int edad;

    public ClsEmpleados()
    {
        Nombre = "";
        SuledoDiario = 0.0m;
        edad = 0; 
    }


    
    public string Nombre
    {
    get{ return _Nombre;}
    set{ _Nombre = value;}
    }
    public decimal SuledoDiario{ get; set; }

    public decimal CalcularSalario(int NumeroDias)
    {
        return SuledoDiario * NumeroDias;
    }
}
}