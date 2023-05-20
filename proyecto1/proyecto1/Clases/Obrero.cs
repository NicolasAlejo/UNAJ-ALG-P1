/*
 * Proyecto 1 "Empresa Obras"
 * Creado por
 * Agustin Tottil
 * Sebastian Chaile
 * Nicolas Sanchez
 */
 
using System;

namespace proyecto1.Clases
{
	/// <summary>
	/// Description of Obrero.
	/// Legajo - Nombre - Apellido - DNI - Cargo - Grupo al que pertenece
	/// </summary>
	public class Obrero
	{
		// variables de instacia / atributos
        	private string nombre, apellido, cargo;
       		private int legajo, dni;
        	private int grupoAlQuePertenece;
			
			//constructor
			
			public Obrero(string nombre, string apellido, string cargo, int legajo, int dni, int grupoAlQuePertenece)
			{
				this.nombre = nombre;
				this.apellido = apellido;
				this.cargo = cargo;
				this.legajo = legajo;
				this.dni = dni;
				this.grupoAlQuePertenece = grupoAlQuePertenece;
			}
			
			//propiedades
			
			public string Nombre
			{
				set { nombre = value;}
				get { return nombre;}
			}
			
			public string Apellido
			{
				set { apellido = value;}
				get { return apellido;}
			}
			
			public string Cargo
			{
				set { cargo = value; } 
				get { return cargo;}
			}
			
			public int Legajo
      			{
           		 set { legajo = value; }
           		 get { return legajo; }
        		} 
			
			public int Dni
      			{
         	   	set { dni = value; }
        	    	get { return dni; }
        		}
			 
			public int GrupoAlQuePertenece
      			{
            		set { dni = value; }
            		get { return dni; }
        		}
			
			
			
			// METODOS
			
	}
}
