namespace video10
{ 
    public class ClientesContacto : ClientesBase
    {
        public ClientesContacto() 
        {
            _Direcciones = new clsDirecciones();
        }
        public string Telefono1 {get; set;}
        public string Telefono2 {get; set;}
        public string Email {get; set;}
        private clsDirecciones _Direcciones;
        public clsDirecciones Direccion
        {
            get {return _Direcciones;}
            set{ _Direcciones = value;}
        }

     }
 }
