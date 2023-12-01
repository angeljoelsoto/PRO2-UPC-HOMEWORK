using System.ComponentModel;
using System.Runtime.CompilerServices;

public class clsDirecciones 
{
    public clsDirecciones()
    {
        Calle = string.Empty;
        numeroExterior = string.Empty; 
        numeroInterior = string.Empty;
        colonia = string.Empty;
        municipio = string.Empty;
        estadio  =string.Empty;
        CP = String.Empty; 
    }

    public string Calle {get; set;}
    public string numeroExterior {get; set;}
    public string numeroInterior {get; set;}
    public string colonia{get;set;}
    public string municipio{get;set;}
    public string estadio{get;set;}
    public string CP{get;set;}
    }