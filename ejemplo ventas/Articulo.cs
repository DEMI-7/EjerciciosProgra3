using System;
using System.Collections.Generic;
using System.Text;

namespace ejemplo_ventas
{
    public class Articulo
    {
        //private int codigoArticulo

        public int CodigoArticulo { get; set; }
        //private float precio;
        public float Precio {  get; set; }

        private int codMarca;

        public int CodigoMarca
        {
            get { return codMarca; }
            set {
                if (value > 0 && value < 11) {
                    codMarca = value;
                }
                else {
                    codMarca = -1;
                }
            }
        }

        public Articulo(int codArticulo, float precio, int codMarca)
        {
            this.CodigoMarca = codMarca;
            this.CodigoArticulo = codArticulo;
            this.Precio = precio;
        }
    }
}
