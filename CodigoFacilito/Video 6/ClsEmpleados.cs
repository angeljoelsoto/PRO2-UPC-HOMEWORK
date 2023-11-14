namespace Video6{
public class ClsEmpleados
{
    public string Nombre;
    public decimal SuledoDiario;
    public int edad;

    public ClsEmpleados()
    {
        Nombre = "";
        SuledoDiario = 0.0m;
        edad = 0; 
    }
    public decimal CalcularSalario(int NumeroDias)
    {
        return SuledoDiario * NumeroDias;
    }
}
}