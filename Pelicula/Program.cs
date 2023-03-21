using System;
using System.Collections.Generic;
//Esto es una prueba cambio
    namespace Pelicula
    {
        public class Pelicula {  
        //Campos
        private Int16 año {get; set;}
        private string titulo {get; set;}
        //private string pais;
        //private string director;
        private List<Actor> actores = new List<Actor>();
        //Constructores
            public Int16 GetAño(){return Año;}

            public void SetAño(Int16 a){Año = a;}
            public string GetTitulo(){return Titulo;}

            public void SetTitulo(string t){Titulo = t;}
            public string Titulo { //Propiedad
                get {return titulo;}
                set {titulo = value;}
                }
            public Int16 Año { //Propiedad
                get {return año;}
                set {año = value;}
                } 
            public Pelicula(string titulo, Int16 año) {
            this.titulo = titulo;
            this.año = año;
            }
            public Pelicula() {

            }
            public void Imprime(){
            Console.WriteLine($"{titulo} ({año})");
            }
            public void ImprimeActores(){

            foreach (Actor a in actores)
             {
               Console.WriteLine(a);
            }
                }
            public void AgregaActor(Actor actor) {
            actores.Add(actor);
            }
            }





            public class Actor{
                //Propiedades
                private string Nombre;
                private Int16 AñoActor; 
                
                 public override string ToString()
                {
                return $"{Nombre} ({AñoActor})";
                 }       
                public Actor(string Nombre, Int16 AñoActor) {
                    this.Nombre = Nombre;
                    this.AñoActor = AñoActor;
                }
                
               public Int16 GetAñoActor(){return AñoActor;}

                public void SetAñoActor(Int16 a){AñoActor = a;}
                public string GetNombre(){return Nombre;}

                 
                 
                 public void SetNombre(string n){Nombre = n;}
                 public string nombre { //Propiedad
                    get {return Nombre;}
                   set {Nombre = value;}
                 }
                public Int16 añoActor { //Propiedad
                    get {return AñoActor;}
                     set {AñoActor = value;}
                }
               
        }
    // Puedes probar tu código en Main() pero lo importante es que pase las pruebas
    class Program
    {
        static void Main()
        {
        List<Pelicula> peliculas = new List<Pelicula>();
        
        peliculas.Add(new Pelicula() { Titulo= "La La Land", Año = 2016 });
        peliculas.Add(new Pelicula() { Titulo = "Green Book", Año = 2019 });
        peliculas.Add(new Pelicula() { Titulo = "Parasite", Año = 2019 });

        foreach (Pelicula p in peliculas)
        {
            Console.WriteLine($"{p.Titulo} ({p.Año})");
        }
          
        Pelicula p1 = new Pelicula("La La Land", 2016);
            p1.AgregaActor(new Actor("Ryan Gosling", 1980));
            p1.AgregaActor(new Actor("Emma Stone", 1988));

            p1.ImprimeActores();
        }
    }
}

