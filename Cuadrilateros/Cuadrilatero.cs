using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Los datos privados de la clase base deben ser las coordenadas x-y de los cuatro 
 * vértices de la figura y debe contener un método abstracto para calcular el área.
 */
namespace TareaClase16_Cuadrilateros.Cuadrilateros {
    internal abstract class Cuadrilatero {
        private int x1, y1, x2, y2, x3, y3, x4, y4;
        public Cuadrilatero(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4) {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
            this.x4 = x4;
            this.y4 = y4;
        }

        internal abstract decimal Area();

    }

}

/*
 *Public: El acceso a estos tipos esta disponible desde el propio proyecto o desde otro sin ninguna restricción.
 *Private: Permite el acceso solo a los miembros de la misma clase.
 *Protected: Accesible solo a los miembros de la misma clase y de las clases hijas de este.
 *Internal: El acceso está disponible desde cualquier clase del mismo proyecto, pero no de otros proyectos de la misma solución.
*/