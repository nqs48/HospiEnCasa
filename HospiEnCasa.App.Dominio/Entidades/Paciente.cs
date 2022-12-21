using System;
namespace HospiEnCasa.App.Dominio.Entidades{
    
    public class Paciente: Persona{
        public string Direccion {get; set;}
        public string Ciudad {get; set;}
        public DateTime FechaDeNacimiento {get; set;}
        public Enfermera Enfermera {get; set;}
        public FamiliarDesignado FamiliarDesignado {get; set;}
        public SignoVital SignoVital {get; set;}
        public Historia Historia {get; set;}


        public Paciente(){} //Constructor vacío

        public Paciente(int id, string nombre, string apellidos, string telefono ,Genero genero, string direccion, string ciudad, DateTime fechaDeNacimiento, Enfermera enfermera, FamiliarDesignado familiarDesignado) : base(id,nombre,apellidos,telefono, genero)
        {         
            this.Id=id;
            this.Nombre= nombre;
            this.Apellidos= apellidos;
            this.Telefono= telefono;
            this.Genero= genero;
            Direccion= direccion;
            Ciudad= ciudad;
            FechaDeNacimiento= fechaDeNacimiento;
            Enfermera= enfermera;
            FamiliarDesignado= familiarDesignado;
                
       }

        
    }

}


