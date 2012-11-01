/*
 * Creado por SharpDevelop.
 * Usuario: rlibardobj
 * Fecha: 30/10/2012
 * Hora: 09:50 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace simuladorCache.Memoria_Cache
{
	/// <summary>
	/// Description of lineaCache.
	/// </summary>
	public class lineaCache
	{
		public string[] datos;
		public int etiqueta;
		public bool valida;
		
		public lineaCache(int cantidadDatos)
		{
			this.datos=new string[cantidadDatos];
			valida=false;
			this.inicializarDatos(cantidadDatos);
		}
		
		private void inicializarDatos(int cantidadDatos)
		{
			for (int i=0;i<cantidadDatos;i++)
			{
				this.datos[i]="Dato: "+i;
			}
		}
	}
}
