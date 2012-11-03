/*
 * Creado por SharpDevelop.
 * Usuario: rlibardobj
 * Fecha: 30/10/2012
 * Hora: 07:09 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using simuladorCache.Memoria_Cache;
using simuladorCache.Memoria_RAM;
using simuladorCache.Procesador;

namespace simuladorCache
{
	/// <summary>
	/// Description of controladorPrograma.
	/// </summary>
	public class controladorPrograma
	{
		memoriaRam RAM;
		memoriaCache memoria1,memoria2,memoria3;
		procesador procesador;
		public int _set,posicion,etiqueta,cantidadDatos=16,asociatividad,direccionamiento=25,referencias,tipo,hits,misses,bitsPosicion,bitsSet,bitsEtiqueta,contadorReferencias,reemplazos,tamañoRAM=100;
		string direccion,nulo="";
		public controladorPrograma(string tamaño, string tipo, string referencias, string asociatividad)
		{
			this.asociatividad=int.Parse(asociatividad);
			this.crearCache(int.Parse(tamaño),int.Parse(tipo));
			this.referencias=int.Parse(referencias);
			procesador=new procesador();
			RAM=new memoriaRam(tamañoRAM);
			setearBits(int.Parse(tamaño));
		}
		
		//Función que permite la creación de la memoria caché.
		//Recibe el tamaño de la caché y su tipo.
		public void crearCache(int tamaño, int tipo)
		{
			memoria1=new memoriaCache(tipo,(int)Math.Truncate((double)tamaño/(cantidadDatos*asociatividad)+1),asociatividad,cantidadDatos);
		}
		
		//Funcion que permite hacer una emulación automática del sistema de cache
		//Debe pedir las isntrucciones al procesador, verificarlas y por último checkear en la cache
		//Si no se encuentra en cache debera buscar en RAM y actualizar la cache.
		public void emulacionAutomatica()
		{
			while (contadorReferencias<referencias){
				direccion=procesador.obtenerDireccion(tamañoRAM);
				emulacionManual();
			}
		}
		
		//Permite al usuario la emulación manual de la memoria caché.
		public void emulacionManual()
		{
			verificarInstruccion();
			aislarUbicacion();
			string busqueda=memoria1.buscarDireccion(_set,posicion,etiqueta);
			if (busqueda==null){
				busqueda="";
			}
			if (busqueda.Equals(nulo))
			{
				contadorReferencias++;
				misses++;
				string[] direcciones=RAM.obtenerDireccion(Convert.ToInt32(direccion,2),cantidadDatos);
				if (memoria1.ingresarDireccion(direcciones,_set,etiqueta))
				{
					reemplazos++;
				}
			}
			
			else
			{
				hits++;
			}
		}
		
		//Se encarga de llenar con ceros la instruccion en caso de que no cumpla con los 11 bits de direccionamiento.
		public void verificarInstruccion()
		{
			while(direccion.Length<direccionamiento)
			{
				direccion= "0"+direccion;
			}
		}
		
		//Establece la cantidad de bits que se utilizarán para la posición, la etiqueta y para el set de una dirección.
		public void aislarUbicacion()
		{
			posicion=Convert.ToInt32(direccion.Substring(direccionamiento-bitsPosicion,bitsPosicion),2);
			_set=Convert.ToInt32(direccion.Substring(direccionamiento-(bitsPosicion+bitsSet),bitsSet),2);
			etiqueta=Convert.ToInt32(direccion.Substring(direccionamiento-(bitsSet+bitsPosicion+bitsEtiqueta),bitsEtiqueta),2);
		}
		
		//Recibe el tamaño de la memoria cache, en Kbyte, ejemplo 32KB
		public void setearBits(int tamañoCache)
		{
			int cantidad=0,resultado=1,tamañoSet,cantidadSets;
			while(resultado<cantidadDatos)
			{
				resultado = resultado * 2;
				cantidad++;
			}
			
			bitsPosicion = cantidad;
			tamañoSet = asociatividad * cantidadDatos;
			cantidadSets=(int)Math.Truncate((double)tamañoCache / tamañoSet +1);
			cantidad = 0;
			resultado = 1;
			
			while(resultado<cantidadSets)
			{
				resultado = resultado * 2;
				cantidad++;
			}
			bitsSet = cantidad;
			bitsEtiqueta = direccionamiento - (bitsPosicion+bitsSet);
		}
	}
}
