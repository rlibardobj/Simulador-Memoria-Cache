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
		public int ultimaDireccion;
		public procesador()
		{
			random=new Random();
			ultimaDireccion=0;
		}
		
		//Genera una dirección random que se utilizará para la emulación.
		//Toma como parámetro el límite de dirección que puede generar, tomando como referencia el tamaño de la memoria
		//RAM.
		public string obtenerDireccion(int limite)
		{
			int direccion=random.Next(ultimaDireccion,ultimaDireccion+40);
			if (direccion>limite){
				direccion=random.Next(0,limite-1);
				ultimaDireccion=direccion;
			}
			else
				ultimaDireccion=direccion;
			return Convert.ToString(direccion,2);
		}
	}
}
