using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ContenedorProducto
{
    class Container
    {

        #region Atributos

        private int _capacidad;
        private string _empresa;
        private List<Producto> _listaProductos;


        #endregion

        #region Constructores

        public Container(int capacidad, string empresa)
        {
            this._capacidad = capacidad;
            this._empresa = empresa;

            //Instancio la lista

            this._listaProductos = new List<Producto>();
        }

        #endregion

        #region Metodos de Clase

        public static void Mostrar(Container contenedor)

        {

            Console.WriteLine("-__-__Container__-__-");
            Console.WriteLine("Empresa: " + contenedor._empresa);
            Console.WriteLine("Capacidad: " + contenedor._listaProductos.Count());
            Console.WriteLine("Productos: ");

            foreach (Producto item in contenedor._listaProductos)
            {
                item.mostrar();
            }

        }

        #endregion

        #region Sobrecarga de Operadores

        public static bool operator ==(Container contenedor, Producto ProUno)

        {
            foreach (Producto item in contenedor._listaProductos)
            {
                if (item == ProUno)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Container contenedor, Producto ProUno)

        {
            if (!(contenedor == ProUno))
                return true;
            return false;
        }

        public static List<Producto> operator -(Container ContenedorUno, eTipoComestible tipo)

        {
            List<Producto> _listaRetorno = new List<Producto>();

            foreach (Producto item in ContenedorUno._listaProductos)
            {
                if (item == tipo)
                    _listaRetorno.Add(item);
            }
            return _listaRetorno;
        }

        #endregion

        #region Métodos de Instancia

        public bool Agregar(Producto proUno)

        { 
            if ((!(this == proUno)) & this._listaProductos.Count < this._capacidad)
            
            {
                this._listaProductos.Add(proUno);
                return true;
            }
            return false;
        }

        #endregion
    }
}
