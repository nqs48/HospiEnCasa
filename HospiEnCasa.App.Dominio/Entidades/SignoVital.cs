using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospiEnCasa.App.Dominio.Entidades
{
    public class SignoVital
    {
        public int Id {get; set;}
        public string Diagnostico {get; set;}
        public string Entorno {get; set;}

        public SignoVital(){} //Constructor vacío

        public SignoVital(int id, string diagnostico, string entorno)
        {         
            this.Id=id;
            this.Diagnostico= diagnostico;
            this.Entorno= entorno;
        }
    }
}