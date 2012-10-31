/*
 * Creado por SharpDevelop.
 * Usuario: rlibardobj
 * Fecha: 30/10/2012
 * Hora: 09:50 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace simuladorCache
{
	/// <summary>
	/// Description of memoriaCache.
	/// </summary>
	public class memoriaCache
	{
		private bloqueCache[] bloques;
		int tipo;
		
		public memoriaCache(int tipo, int cantidadBloques, int cantidadLineas, int cantidadDatos)
		{
			this.tipo=tipo;
			this.bloques=new bloqueCache[cantidadBloques];
			this.inicializarBloques(cantidadBloques,cantidadLineas,cantidadDatos);
		}
		
		private void inicializarBloques(int cantidadBloques, int cantidadLineas, int cantidadDatos)
		{
			for (int i=0;i<cantidadBloques;i++)
			{
				this.bloques[i]=new bloqueCache(cantidadLineas,cantidadDatos);
			}
		}
		
		public bool buscarDireccion()
		{	
			//Falta por hacer
			return true;
		}
		
		public void ingresarDireccion()
		{
		}
	}
}
