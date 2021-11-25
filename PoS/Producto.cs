using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoS
{
	public class Producto
	{
		private int _productoCodigo;
		private string _productoNombre;
		private int _productoCantidad;
		private double _productoPrecio;
		private Guid _productoIdentificador;

		public Producto(int productoCodigo, string productoNombre, int productoCantidad, double productoPrecio)
		{
			_productoCodigo = productoCodigo;
			_productoNombre = productoNombre;
			_productoCantidad = productoCantidad;
			_productoPrecio = productoPrecio;
		}

		public Guid productoIdentificador
		{
			get { return _productoIdentificador; }
			set { _productoIdentificador = value; }
		}
		public int ProductoCodigo
		{
			get { return _productoCodigo; }
			set { _productoCodigo = value; }
		}

		public string ProductoNombre
		{
			get { return _productoNombre; }
			set { _productoNombre = value; }
		}

		public int ProductoCantidad
		{
			get { return _productoCantidad; }
			set { _productoCantidad = value; }
		}

		public double ProductoPrecio
		{
			get { return _productoPrecio; }
			set { _productoPrecio = value; }
		}
	}
}
