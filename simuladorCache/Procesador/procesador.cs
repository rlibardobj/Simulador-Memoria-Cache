/*
 * Creado por SharpDevelop.
 * Usuario: rlibardobj
 * Fecha: 30/10/2012
 * Hora: 06:06 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using simuladorCache.Memoria_RAM;

namespace simuladorCache.Procesador
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
			int direccion=random.Next(ultimaDireccion,ultimaDireccion);
			ultimaDireccion=direccion;
			return Convert.ToString(direccion,2);
		}
	}
}
