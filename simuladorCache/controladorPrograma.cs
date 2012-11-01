﻿/*
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
		int _set,posicion,etiqueta,cantidadDatos=16,asociatividad=4,direcionamiento=15,referencias,tipo,hits,misses,bitsPosicion,bitsSet,bitsEtiqueta;
		string direccion;
		public controladorPrograma(string tamaño, string tipo, string referencias)
		{
			this.crearCache(int.Parse(tamaño),int.Parse(tipo));
			this.referencias=int.Parse(referencias);
			procesador=new procesador();
			RAM=new memoriaRam(100);
			setearBits(int.Parse(tamaño));
		}
		
		public void crearCache(int tamaño, int tipo)
		{
			memoria1=new memoriaCache(tipo,tamaño/(cantidadDatos*asociatividad),asociatividad,cantidadDatos);
		}
		
		//Funcion que permite hacer una emulación automática del sistema de cache
		//Debe pedir las isntrucciones al procesador, verificarlas y por último checkear en la cache
		//Si no se encuentra en cache debera buscar en RAM y actualizar la cache		
		public void emulacionAutomatica()
		{
			direccion=procesador.obtenerDireccion();
			verificarInstruccion();
			aislarUbicacion();
			if (memoria1.buscarDireccion(_set,posicion,etiqueta).Equals(""))
			{
				hits++;
			}
			else
			{
				string[] direcciones=RAM.obtenerDireccion(Convert.ToInt32(direccion,2),cantidadDatos);
				memoria1.ingresarDireccion();
			}
		}
		
		//Se encarga de llenar con ceros la instruccion en caso de que no cumpla con los 11 bits de direccionamiento
		public void verificarInstruccion()
		{
			String tag = Convert.ToString(etiqueta),set = Convert.ToString(_set),offset = Convert.ToString(posicion);
			
			while(tag.Length<bitsEtiqueta)
			{
				tag= "0"+tag;
			}
			while(set.Length<bitsSet)
			{
				set = "0"+set;
			}
			while(offset.Length<bitsPosicion)
			{
				offset = "0"+offset;
			}			
			//tag+set+offset
			direccion = tag+set+offset;
		}
		
		public void aislarUbicacion()
		{
			
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
			cantidadSets = (tamañoCache*1024) / tamañoSet;
			cantidad = 0;
			resultado = 1;
			
			while(resultado<cantidadSets)
			{
				resultado = resultado * 2;
				cantidad++;
			}
			bitsSet = cantidad;
			bitsEtiqueta = tamañoCache - (posicion + _set);
		}
	}
}
