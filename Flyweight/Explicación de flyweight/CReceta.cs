using System;
using System.Collections.Generic;
using System.Text;


namespace Explicación_de_flyweight
{
    /*
     * Se aplica Polimorfismo para llamar de la interfaz a los métodos 
     */
    class CReceta : IFlyweight
    {
        private string nombre;
        private double costo;
        private double venta;

        /*
         * Se recibe como parametro el nombre que se le va a poner a la receta
         * se pone dentro de la variable nombre
        */
        public void ColocarNombre(string pNombre)
        {
            nombre = pNombre;
        }
        public void CalcularCosto()
        {
            /*
             *Esto lo invente para tener algo computable, algo que se hiciera, algo que se calculara
             *Hice una sumatoria del codigo Ascii de cada una de las letras dentro del nombre
             
             */


            foreach (char letra in nombre)
                costo += (int)letra;

            venta = costo * 1.30;
        }
        public void Mostrar()
        {
            /*
             * Se muestra por pantalla tal nombre cuesta tanto venta
             */
            Console.WriteLine("{0} cuesta {1}", nombre, venta);
        }

        public string ObtenNombre()
        {
            /*
             * Aqui el método ObtenNombre que retorna el nombre de la receta
             */
            return nombre;
        }

        public void ColocaNombre(string pNombre)
        {
           
        }

        public void CalculaCosto()
        {
            
        }
    }
}
