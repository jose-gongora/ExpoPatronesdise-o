using System;
using System.Collections.Generic;
using System.Text;

namespace Explicación_de_flyweight
{
    /*
     * Se crea la parte de la fabrica
     * Para que se encargue de administrar a los Flyweight
     */
    class CFlyweightFactory
    {
        /*
         * Primero se crea una colección en la cual se va a guardar los Flyweight
         * Es decir los objetos creados de las clases que implementan a la interfaz de Iflyweight
         */

        //Se crea una lista que va a guardar objetos que implementen a Iflyweihts
        private List<IFlyweight> flyweights = new List<IFlyweight>();
        //Pongo una variable que apoyo que será la variable conteo de tipo entero
        private int conteo = 0;

        //Aquí se tiene su propiedad 
        public int Conteo { get => conteo; set => conteo = value; }

        //Aquí se tiene una implementación que es el método Adiciona 
        //Este sirve para adicionar una nueva receta
        //Se pasa el nombre de la nueva receta
        //Y se va a verificar si existe
        //Si ya existe no se va a crear una nueva instancia y si no existe se crea una nueva
        //Y se adiciona a la lista de Iflyweights
        public int Adiciona(string pNombre)
        {
          
            bool existe = false;
            foreach (IFlyweight f in flyweights)
            {
                //Se recorren todos los flywights que se encuentran dentro de la lista
                //Si alguno de ellos tiene el nombre existe el valor de true
                //Para indicar que ya existe
                if (f.ObtenNombre() == pNombre)
                    existe = true;
                //El metodo que utilizo para saber si existe o no solo me baso en el nombre para saber si existe o no

            }
            //Si ninguno hubiera tenido el nombre sale del Foreach conservando su valor de False

            if (existe)
            {
                Console.WriteLine("El objeto ya existe, no se ha adicionado");
                return -1;
                //Se hace un retorno de -1 para indicar que hubo un problema
                //Indicando que adiciona no pudo llevar a cabo la adicion
            }
            
            
            else
            {
                //Si existe tuviera el valor de false entonces se crea una nueva receta
                CReceta miReceta = new CReceta();
                //Indico el nombre correspondiente
                miReceta.ColocarNombre(pNombre);
                //Adiciono la receta a la lista de Flyweight
                flyweights.Add(miReceta);
                //Actualizo mi variable de conteo, para saber cuantos objetos hay en la lista
                conteo = flyweights.Count;
                //Regreso conteo -1 para indicar el indice del objeto que se acaba de adicionar a la lista 
                return conteo - 1;
            }
            
            
        }
        //Indexers es una propiedad que permite trabajar con un objeto como si fuera un array
        //También permiten instancias de clases o strucs ser indexadas como array
        //Es una sintaxis similar a la que tiene los arreglos
        public IFlyweight this[int index]
        {
        get { return flyweights[index]; }
            //Se usa para facilitar la sintaxis del lado del cliente y que se pueda acceder facilmente al contenido de la lista Flweights
        }
    }
}
