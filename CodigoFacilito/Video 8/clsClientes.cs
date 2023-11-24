using System.ComponentModel;

namespace video8
{
    public class clsClientes
    {
        private int _IdCliente;
        public int IdClientes
        {
            get{ return _IdCliente;}
            set{ _IdCliente = value;}
        }

        private string _Nombres;
        public string Nombres
        {
            get{ return _Nombres;}
            set{ _Nombres = value;}

        }

        private string _Apellidos;
        public string Apellidos
        {
            get{return _Apellidos;}
            set{_Apellidos = value;}
        }
    }
}