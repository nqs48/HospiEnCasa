using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospiEnCasa.App.Dominio.Entidades
{
    public class FamiliarDesignado: Persona
    {
        public string Parentezco {get; set;}
        public string Correo {get; set;}

        public FamiliarDesignado(){} //Constructor vacío

        public FamiliarDesignado(int id, string nombre, string apellidos, string telefono ,Genero genero, string parentezco, string correo) : base(id,nombre,apellidos,telefono, genero)
        {         
            this.Id=id;
            this.Nombre= nombre;
            this.Apellidos= apellidos;
            this.Telefono= telefono;
            this.Genero= genero;
            Parentezco= parentezco;
            Correo= correo;
        }
    }
}