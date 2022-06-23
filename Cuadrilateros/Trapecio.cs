using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaClase16_Cuadrilateros.Cuadrilateros {
    internal class Trapecio : Cuadrilatero {
        private decimal ladoA { get; set; }
        private decimal ladoB { get; set; }
        private decimal ladoC { get; set; }
        private decimal ladoD { get; set; }
        private decimal ladoH { get; set; }

        public Trapecio(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4) : base(x1, y1, x2, y2, x3, y3, x4, y4) {
            this.ladoA=x4-x3;
            this.ladoB = x2 - x1;
            this.ladoH = y1 - y3;
        }


        internal override decimal Area() {
            return (this.ladoH*( (this.ladoA + this.ladoB) / 2) );
        }
    }
}
