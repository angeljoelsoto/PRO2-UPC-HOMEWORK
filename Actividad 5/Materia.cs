public class Materia
{
    public string Grupo; 
    public string nomeMateria; 
    public string nomDocente;

    public Materia()
    {
        Grupo = "no asignado";
        nomeMateria = "Sin nombre de materia";
        nomDocente = "Sin nombre del docente";
    }

    public void asignarGrupo (string valor){
        valor = Grupo;

    }
}

