/*
 * Creado por SharpDevelop.
 * Usuario: rlibardobj
 * Fecha: 30/10/2012
 * Hora: 08:33 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace simuladorCache.Memoria_RAM
{
	/// <summary>
	/// Description of memoriaRam.
	/// </summary>
	public class memoriaRam
	{
		private string[] datos;
		public memoriaRam(int cantidadDatos)
		{
			datos=new string[cantidadDatos];
			for (int i=0;i<cantidadDatos;i++)
			{
				datos[i]="Dato "+i;
			}
		}
		
		//Retorna un arreglo con las direcciones que se encuentren a partir del parámetro dirección.
		//Se devuelven tantas direcciones como lo indique el parámetro cantidadDatos.
		public string[] obtenerDireccion(int direccion, int cantidadDatos)
		{
			string[] resultado=new string[cantidadDatos];
			for (int i=0;i<cantidadDatos;i++)
			{
				if (direccion<datos.Length)
				{
					resultado[i]=datos[direccion];
					direccion++;
				}
				else
					break;
			}
			return resultado;
		}
	}
}
