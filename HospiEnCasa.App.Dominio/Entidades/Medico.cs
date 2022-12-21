using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospiEnCasa.App.Dominio.Entidades
{
    public class Medico: Persona
    {
        public string Especialidad {get; set;}
        public string Codigo {get; set;}
        public string registro {get; set;}

        public Medico(){} //Constructor vacío

        public Medico(int id, string nombre, string apellidos, string telefono ,Genero genero, string especialidad, string codigo, string registro) : base(id,nombre,apellidos,telefono, genero)
        {         
            this.Id=id;
            this.Nombre= nombre;
            this.Apellidos= apellidos;
            this.Telefono= telefono;
            this.Genero= genero;
            Especialidad= especialidad;
            Codigo= codigo;
            registro= registro;
        }

    }
}