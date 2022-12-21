using System;

namespace HospiEnCasa.App.Dominio.Entidades{

public class Persona{

    public int Id {get;set;} 
    public string Nombre {get; set;}
    public string Apellidos {get; set;}
    public  string Telefono {get; set;}
    public Genero Genero {get; set;}

    public Persona(){}

    public Persona(int id, string nombre, string apellidos, string telefono, Genero genero ){
        Id= id;
        Nombre= nombre;
        Apellidos= apellidos;
        Telefono= telefono;
        Genero= genero;
    }



}

}