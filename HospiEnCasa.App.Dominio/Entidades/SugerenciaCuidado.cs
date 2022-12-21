using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospiEnCasa.App.Dominio.Entidades
{
    public class SugerenciaCuidado
    {
        public int Id {get; set;}
        public DateTime Fecha {get; set;}
        public string Descripcion {get; set;}

        public SugerenciaCuidado(){} //Constructor vacío

        public SugerenciaCuidado(int id, DateTime fecha, string descripcion)
        {         
            this.Id= id;
            this.Fecha= fecha;
            this.Descripcion= descripcion;
        }
    }
}