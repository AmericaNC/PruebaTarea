using System;
using System.Collections.Generic;
    namespace Pelicula
    {
        public class  Pelicula {  
        //Campos
        private Int16 Año;
        private string titulo; 
        private string pais;
        private string director;
       // private List<Actor> actores = new List<Actor>();
        //Constructores
            public int GetAño(){return Año;}

            public void SetAño(Int16 a){Año = a;}
            public string GetTitulo(){return Titulo;}

            public void SetTitulo(string t){Titulo = t;}
            public string Titulo { //Propiedad
                get {return titulo;}
                set {titulo = value;}
                }
            public Pelicula(string t, Int16 a) {
            t = Titulo;
            a = Año;
            }
            public Pelicula() {

            }
            public void Imprime(){
            Console.WriteLine($"{Titulo} ({Año})");
            }
            }
             /*public Pelicula(string titulo, Int16 año){
                titulo = titulo;
                año = año;
            }
            
            public void Imprime(){
                Console.WriteLine($"{titulo} ({año})");
            }
        

            public class Actor{
                //Propiedades
                //Constructores
                //Métodos

            public void Imprime(){
            Console.WriteLine($"{Nombre} ({Año})");
            }
        }
    // Puedes probar tu código en Main() pero lo importante es que pase las pruebas
    */ 
    class Program
    {
        static void Main()
        {
            Pelicula p1 = new Pelicula();
            p1.SetTitulo("La La Land");
            p1.SetAño(2016);
            Console.WriteLine("{0}({1})", p1.GetTitulo(), p1.GetAño());
        }
    }
}

