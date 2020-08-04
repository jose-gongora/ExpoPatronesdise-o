using System;
using System.Collections.Generic;
using System.Text;



namespace Explicación_de_flyweight
{
    /*
     *Esta interfaz va a ser implementada por cualquier clase
     *que vaya a crear objetos de tipo Flyweight
     */
    interface IFlyweight
    {
        /*
         * En este ejemplo, en esta interfaz hay 4 métodos
         */
        void ColocaNombre(string pNombre);
        void CalculaCosto();
        void Mostrar();
        string ObtenNombre();

       
    }
}
