using System;
using System.Collections.Generic;
namespace Pelicula
{
    public class Pelicula
    {
        //Campos
        public string titulo;
        public string pais;
        public int año;
        public string director;
       // private List<Actor> actores = new List<Actor>();
        //Constructores
        //Métodos
        public Pelicula(string t, string p, int a, string d){
        this.titulo = t;
        this.pais = p;
        this.año = a;
        this.director = d;
        }
        public void Imprime()
        {
          Console.WriteLine($"{titulo} ({año})");
        }
    }
/*
    public class Actor
    {
        //Propiedades
        //Constructores
        //Métodos 
        public void Imprime()
        {
            Console.WriteLine($"{Nombre} ({Año})");
        }
    }
    // Puedes probar tu código en Main() pero lo importante es que pase las pruebas
    / */ 

    class Program
    {
        static void Main(string[] args)
        {
            Pelicula p1 = new Pelicula("Parasitos","Corea del Sur",2019,"Bong Joon-ho");
           p1.Imprime();
           Pelicula p2 = new Pelicula("Green Book","EUA",2019,"Peter Farrelly");
           p2.Imprime();
        }
    }
}
