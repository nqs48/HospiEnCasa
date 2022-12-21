using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospiEnCasa.App.Dominio.Entidades
{
    public class Enfermera: Persona
    {
        public string TarjetaProfesional {get; set;}
        public int HorasLaborales {get; set;}

        public Enfermera(){} //Constructor vacío

        public Enfermera(int id, string nombre, string apellidos, string telefono ,Genero genero, string tarjetaProfesional, int horasLaborales) : base(id,nombre,apellidos,telefono, genero)
        {         
            this.Id=id;
            this.Nombre= nombre;
            this.Apellidos= apellidos;
            this.Telefono= telefono;
            this.Genero= genero;
            TarjetaProfesional= tarjetaProfesional;
            HorasLaborales= horasLaborales;
        }
    }
}