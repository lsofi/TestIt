using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestIt.Datos;

namespace TestIt.Logica
{
    abstract class AbstractService<T>
    {
        protected AbstractDao aDao;

        public string buscarNombre(int id)
        {
            return aDao.buscarCampoPorId("nombre", id);
        }

        public int buscarId(string nombre)
        {
            return aDao.buscarIdPorCampo("nombre", nombre);
        }

        protected T buscarPorCampo(string campo, dynamic valor)
        {
            return (T)aDao.buscarPorCampo(campo, valor);
        }

        protected string buscarCampoPorId(string campo, int id)
        {
            return aDao.buscarCampoPorId(campo, id);
        }

        public T buscarPorId(int id)
        {
            return buscarPorCampo("id", id);
        }

        public List<T> buscarTodos()
        {
            List<T> lista = new List<T>();

            foreach (object o in aDao.getAll())
                lista.Add((T)o);

            return lista;
        }

        protected List<T> filtrar(Dictionary<string, dynamic> filtros)
        {
            List<T> lista = new List<T>();

            foreach (object o in aDao.filtrar(filtros))
                lista.Add((T)o);

            return lista;
        }

        public bool grabar(T entidad)
        {
            return aDao.Create(entidad);
        }

        public bool actualizar(T entidad)
        {
            return aDao.Update(entidad);
        }

        public bool eliminar(T entidad)
        {
            return aDao.Delete(entidad);
        }


    }
}
