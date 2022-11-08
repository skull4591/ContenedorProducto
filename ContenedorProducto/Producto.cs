using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContenedorProducto
{
    class Producto
    {
        #region Atributos

        private int _codigoDeBarra;
        private string _nombre;
        private double _precio;
        private eTipoComestible _tipo;

        #endregion

        #region Constructores

        private Producto(int codigoDeBarra)
        {
            this._codigoDeBarra = codigoDeBarra;
        }

        public Producto(int codigoDeBarra, string nombre, eTipoComestible tipo)
            :this(codigoDeBarra)
        {
            this._nombre = nombre;
            this._tipo = tipo;
        }

        public Producto(int codigoDeBarra, string nombre, eTipoComestible tipo, double precio)
            :this(codigoDeBarra, nombre, tipo)
        {
            this._precio = precio;
        }

        #endregion

        #region Sobrecarga de Operadores

        public static bool operator ==(Producto ProUno, Producto proDos)

        {
            if ((ProUno._tipo == proDos._tipo) & (ProUno._nombre == proDos._nombre) & (ProUno._codigoDeBarra == proDos._codigoDeBarra))
                return true;
            return false;
        }

        public static bool operator !=(Producto ProUno, Producto proDos)

        {
            if (!(ProUno == proDos))
                return true;
            return false;
        }

        public static bool operator ==(Producto ProUno, eTipoComestible tipo)

        {
            if (ProUno._tipo == tipo)
                return true;
            return false;
        }

        public static bool operator !=(Producto ProUno, eTipoComestible tipo)

        {
            if (!(ProUno == tipo))
                return true;
            return false;
        }

        #endregion

        #region Métodos de Instancia

        public void mostrar()

        {
            Console.WriteLine("Nombre: " + this._nombre);
            Console.WriteLine("Tipo: " + this._tipo);
            Console.WriteLine("Codigo: " + this._codigoDeBarra);
            Console.WriteLine("Precio: " + this._precio);
        }

        #endregion


    }
}
