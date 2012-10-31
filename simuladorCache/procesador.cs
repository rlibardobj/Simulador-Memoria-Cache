/*
 * Creado por SharpDevelop.
 * Usuario: rlibardobj
 * Fecha: 30/10/2012
 * Hora: 06:06 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace simuladorCache
{
	/// <summary>
	/// Description of procesador.
	/// </summary>
	public class procesador
	{
		Random random;
		int ultimaDireccion;
		public procesador()
		{
			random=new Random();
			ultimaDireccion=0;
		}
		
		public string obtenerDireccion()
		{
			int direccion=random.Next(ultimaDireccion,ultimaDireccion+3);
			ultimaDireccion=direccion;
			return Convert.ToString(direccion,2);
		}
	}
}
