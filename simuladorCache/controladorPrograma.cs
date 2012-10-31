/*
 * Creado por SharpDevelop.
 * Usuario: rlibardobj
 * Fecha: 30/10/2012
 * Hora: 07:09 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace simuladorCache
{
	/// <summary>
	/// Description of controladorPrograma.
	/// </summary>
	public class controladorPrograma
	{
		memoriaCache memoria;
		procesador procesador;
		int _set,posicion,etiqueta,cantidadDatos=16,asociatividad=4,direcionamiento=11,referencias;
		public controladorPrograma(string tamaño, string tipo, string referencias)
		{
			this.crearCache(int.Parse(tamaño),int.Parse(tipo));
			this.referencias=int.Parse(referencias);
			procesador=new procesador();
		}
		
		public void crearCache(int tamaño, int tipo)
		{
			memoria=new memoriaCache(tipo,tamaño/(cantidadDatos*asociatividad),asociatividad,cantidadDatos);
		}
		
		//Funcion que permite hacer una emulación automática del sistema de cache
		//Debe pedir las isntrucciones al procesador, verificarlas y por último checkear en la cache
		//Si no se encuentra en cache debera buscar en RAM y actualizar la cache		
		public void emulacionAutomatica()
		{
			
		}
		
		//Se encarga de llenar con ceros la instruccion en caso de que no cumpla con los 11 bits de direccionamiento
		public void verificarInstruccion()
		{
			
		}
	}
}
