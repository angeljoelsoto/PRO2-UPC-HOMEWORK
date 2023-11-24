namespace Video9 
{
    public abstract class AbsClientes 
    {
        public abstract int id {get; set; }
        public abstract string Nombre {get, set;}
        public abstract string Clave {get; set;}
        public abstract string RFC{ get; set;}
        public abstract int TipoRegimen{ get; set; }
        public abstract string NombreContacto{get; set;}
    }
}
