using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoS
{
	public static class Usuario
	{
		private static int _numeroDeEmpleado;
		private static string _nombreEmpleado;
		private static string _apellidoPaternoEmpleado;
		private static string _apellidoMaternoEmpleado;
		private static int _administrador;

		public static int NumeroDeEmpleado
		{
			get { return _numeroDeEmpleado; }
			set { _numeroDeEmpleado = value; }
		}

		public static string NombreEmpleado
		{
			get { return _nombreEmpleado; }
			set { _nombreEmpleado = value; }
		}

		public static string ApellidoPaternoEmpleado
		{
			get { return _apellidoPaternoEmpleado; }
			set { _apellidoPaternoEmpleado = value; }
		}

		public static string ApellidoMaternoEmpleado
		{
			get { return _apellidoMaternoEmpleado; }
			set { _apellidoMaternoEmpleado = value; }
		}

		public static int Administrador
		{
			get { return _administrador; }
			set { _administrador = value; }
		}
	}
}
