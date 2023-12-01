using System.IO.Pipes;

namespace video10

{
	/****************************************
	 * constructor 1				        *
	 * usamos este ejemplo para la tarea #14*
	 ****************************************/
	
	public class ClientesBase : AbsClientes
	{
		public ClientesBase()
		{
			Id = 0;
			Nombre = string.Empty;
			Clave = string.Empty;
			RFC = string.Empty;
			TipoRegimen = 0;
			NombreContacto = string.Empty;
		}

		//constructor 2 
		public ClientesBase(int pId, string pNombre, string pClave, string pRFC, int pTipoRegimen, string pNombreCompleto)
		{
			Id = pId;
			Nombre = pNombre;
			Clave =  pClave;
			RFC = pRFC;
			TipoRegimen = pTipoRegimen;
			NombreContacto = pNombreCompleto; 
			
		}

        public override int Id { get; set;}
		public override string Nombre {get ; set;}
		public override string Clave {get; set;}
		public override string RFC {get ; set;}
		public override int TipoRegimen {get ; set;}
		public override string NombreContacto {get ; set;}

    }

}