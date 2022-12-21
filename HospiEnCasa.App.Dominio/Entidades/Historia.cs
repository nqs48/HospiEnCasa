using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospiEnCasa.App.Dominio.Entidades
{
    public class Historia
    {
        public int Id {get; set;}
        public DateTime Fecha {get; set;}
        public string DescripcionDePaciente {get; set;}
        public SugerenciaCuidado sugerenciaCuidado {get; set;}

        public Historia(){} //Constructor vacío

        public Historia(int id, DateTime fecha, string descripcionDePaciente)
        {         
            this.Id=id;
            this.Fecha= fecha;
            this.DescripcionDePaciente= descripcionDePaciente;
        }
    }
}