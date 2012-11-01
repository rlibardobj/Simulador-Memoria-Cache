/*
 * Creado por SharpDevelop.
 * Usuario: rlibardobj
 * Fecha: 30/10/2012
 * Hora: 09:51 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace simuladorCache.Memoria_Cache
{
	/// <summary>
	/// Description of bloqueCache.
	/// </summary>
	public class bloqueCache
	{
		public lineaCache[] lineas;
		
		public bloqueCache(int cantidadLineas, int cantidadDatos)
		{
			this.lineas=new lineaCache[cantidadLineas];
			this.inicializarLineas(cantidadLineas,cantidadDatos);
		}
		
		private void inicializarLineas(int cantidadLineas, int cantidadDatos)
		{
			for (int i=0;i<cantidadLineas;i++)
			{
				this.lineas[i]=new lineaCache(cantidadDatos);
			}
		}
	}
}
