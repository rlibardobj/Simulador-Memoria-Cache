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
	/// Description of lineaCache.
	/// </summary>
	public class lineaCache
	{
		private string[] datos;
		private int etiqueta;
		bool valida;
		
		public lineaCache(int cantidadDatos)
		{
			this.datos=new string[cantidadDatos];
			this.etiqueta=etiqueta;
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
