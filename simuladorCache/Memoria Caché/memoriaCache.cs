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
		
		public string buscarDireccion(int _set, int posicion, int etiqueta)
		{	
			bloqueCache bloque=bloques[_set];
			for (int i=0;i<bloque.lineas.Length;i++)
			{
				if ((bloque.lineas[i].etiqueta==etiqueta)&&(bloque.lineas[i].valida))
				{
					return bloque.lineas[i].datos[posicion];
				}
			}
			return "";
		}
		
		public void ingresarDireccion(string[] direccion, int _set, int etiqueta)
		{
			bloqueCache bloque=bloques[_set];
			for (int i=0;i<bloque.lineas.Length;i++)
			{
				if (bloque.lineas[i].valida==false)
				{
					for (int a=0;a<bloque.lineas[i].datos.Length;a++)
					{
						bloque.lineas[i].datos[a]=direccion[a];
					}
					bloque.lineas[i].etiqueta=etiqueta;
					bloque.lineas[i].valida=true;
					return;
				}
			}
			int linea=new Random().Next(0,bloque.lineas.Length);
			for (int i=0;i<bloque.lineas[0].datos.Length;i++)
			{
				bloque.lineas[linea].datos[i]=direccion[i];
			}
			bloque.lineas[linea].etiqueta=etiqueta;
			bloque.lineas[linea].valida=true;
			return;
		}
	}
}
