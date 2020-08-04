using System;
using System.Collections.Generic;

namespace Explicación_de_flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            //Creo una serie de listas que sirve para tener a los diferentes flyweight
            //Clasificación de los flyweights
            List<int> Americana = new List<int>();
            List<int> Italiana = new List<int>();
            List<int> Mexicana = new List<int>();

            List<int> Carnes = new List<int>();
            List<int> Sopas = new List<int>();
            List<int> Ensaladas = new List<int>();

            List<int> Rapida = new List<int>();

            //Creo una instancia de CFlyweightFactory
            CFlyweightFactory flywf = new CFlyweightFactory();

            //Se adicionan las recetas en todas las listas

            //A flywf se le dice que adicione hamburguesa
            //Y flywf regresa el indice de la hamburguesa
            i = flywf.Adiciona("Hamburguesa");
            //El cual se adiciona en Americana, Carnes y Rapida
            Americana.Add(i);
            Carnes.Add(i);
            Rapida.Add(i);
            //Y esto por que hamburguesa pertenece a estas clasificaciones

            //Se siguen adicionando las demás recetas
            i = flywf.Adiciona("Wisconsin cheese");
            Americana.Add(i);
            Ensaladas.Add(i);

            i = flywf.Adiciona("Minestrone");
            Italiana.Add(i);
            Sopas.Add(i);

            i = flywf.Adiciona("Antipasto");
            Italiana.Add(i);
            Ensaladas.Add(i);

            i = flywf.Adiciona("Tacos al pastor");
            Mexicana.Add(i);
            Carnes.Add(i);
            Rapida.Add(i);

            i = flywf.Adiciona("Coditos");
            Mexicana.Add(i);
            Sopas.Add(i);

            i = flywf.Adiciona("Nopales");
            Mexicana.Add(i);
            Ensaladas.Add(i);

            i = flywf.Adiciona("Pizza");
            Italiana.Add(i);
            Rapida.Add(i);
            //Ya se tienen adicionados los objetos de tipo Flyweight
            //Como se puede observar solo se tiene una instancia
            //Esa instancia queda referenciada como el indice, como lo estoy haciendo en este ejemplo
            //También puede ser como una variable de referencia

            //De esta manera no hay que estar repitiendo los objetos y solo hay un objeto que puede pertenecer a diferentes conexiones

            //Se hace un foreach para recorrer una de las listas
            //Se muestra y se lleva a cabo el proceso de comida rapida
            foreach (int n in Rapida)
            {
                //Se selecionan cada uno de los elementos que se encuentran dentro de la lista de comida rapida
                CReceta receta = (CReceta)flywf[n];
                //Se muestra el estado del objeto que se obtiene a través de un calculo
                receta.CalculaCosto();
                //Va a mostar que el valor calculado es de venta
                //Tambien muestra el nombre y el nombre es el estado que se está compartiendo en todos los demás objetos
                receta.Mostrar();
            }
            //Los guiones son para indicar que ya finalizó
            Console.WriteLine("----");

            //Ahora se muestra la Americana
            foreach (int n in Americana)
            {
                CReceta receta = (CReceta)flywf[n];
                //Aquí no se lleva a cabo la parte de calcular costo ya que no se tiene ningun calculo
                //receta.CalculaCosto();
                receta.Mostrar();
            }
            Console.WriteLine("----");

            //Se intenta adicionar uno ya existente
            //Para comprobar que al momento de ejecutarlo saldrá que el objeto ya existe
            i = flywf.Adiciona("Pizza");

            Console.WriteLine("----");

            //Ahora se muestra y se lleva a cabo el proceso de ensaladas
            foreach (int n in Ensaladas)
            {
                CReceta receta = (CReceta)flywf[n];
                receta.CalculaCosto();
                receta.Mostrar();
            }
            Console.WriteLine("----");

            //Ahora se muestran todas las recetas que se encuentran dentro del Factory

            int m = 0;
            for (m = 0; m  < flywf.Conteo; m++)
            {
                CReceta receta = (CReceta)flywf[m];
                receta.Mostrar();
            }
        }
    }
}



/*
 *              Carnes          Sopas         Ensaladas
 * Americana    Hamburguesa                   Wisconsin cheese
 * Italiana                     Minestrone    Antipasto            pizza
 * Mexicana     T. al pastor    Coditos       Nopales
 * 
 * Rapida          Hamburguesa     T. al pastor     pizza
 * 
 * si se hace uso de flyweight 8 en lugar de 21
 */