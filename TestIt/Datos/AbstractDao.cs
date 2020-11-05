using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIt.Datos
{
    abstract class AbstractDao
    {
        private string tabla;

        public AbstractDao(string tabla)
        {
            this.tabla = tabla;
        }

        public List<object> getAll()
        {
            return buscar(consultaTodo());
        }

        public List<object> filtrar(Dictionary<string, dynamic> filtros)
        {
            return buscar(consultaFiltrar(filtros));
        }

        protected List<object> buscar(string consulta)
        {
            DataTable resultado = DataManager.GetInstance().ConsultaSQL(consulta);
            List<object> objectsList = new List<object>();

            if (resultado.Rows.Count > 0)
            {
                foreach (DataRow row in resultado.Rows)
                    objectsList.Add(mappingObject(row));
            }

            return objectsList;
        }
        protected object buscarUno(string consulta)
        {
            DataTable resultado = DataManager.GetInstance().ConsultaSQL(consulta);

            if (resultado.Rows.Count > 0)
                return mappingObject(resultado.Rows[0]);
            
            return null;
        }


        protected string consultaTodo()
        {
            return "SELECT * FROM " + tabla + " WHERE borrado=0";
        }

        protected string consultaFiltrar(Dictionary<string, dynamic> filtros)
        {
            string consulta = "SELECT * FROM " + tabla + " WHERE borrado=0";

            foreach (KeyValuePair<string, dynamic> f in filtros)
            {
                if (f.Value is string) consulta += " AND " + f.Key + " LIKE '" + f.Value + "%'";
                else if (f.Key == "desde") consulta += " AND fecha BETWEEN '" + f.Value.ToString("yyyy-MM-dd") + "'";
                else if (f.Key == "hasta") consulta += " AND '" + f.Value.ToString("yyyy-MM-dd") + "'";
                else if (f.Value != -1) consulta += " AND " + f.Key + " = " + f.Value;
            }

            return consulta;
        }

        public object buscarPorId(int id)
        {
            return buscarUno("SELECT * FROM " + tabla + " WHERE id = " + id);
        }

        public object buscarPorCampo(string campo, dynamic valor)
        {
            string consulta = "SELECT * FROM " + tabla + " WHERE borrado = 0 AND " + campo;
            if (valor is string) consulta += " LIKE '" + valor + "'";
            else consulta += " = " + valor;

            return buscarUno(consulta);
        }

        public string buscarCampoPorId(string campo, int id)
        {
            return DataManager.GetInstance().ConsultaSQLScalar("SELECT " + campo + " FROM " + tabla + " WHERE id = " + id).ToString();
        }

        public int buscarIdPorCampo(string campo, string valor)
        {
            var result = DataManager.GetInstance().ConsultaSQLScalar("SELECT id FROM " + tabla + " WHERE " + campo + " = " + valor);
            if (result == null) return -1;
            return (int) result;
        }

        protected abstract object mappingObject(DataRow row);

        public bool Create(object o)
        {
            DataManager dm = DataManager.GetInstance();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                sqlCreate(o);
                dm.Commit();
            }

            catch (Exception ex)
            {
                dm.Rollback();
                throw ex;
            }
            finally
            {
                dm.Close();
            }
            return true;
        }

        public bool Update(object o)
        {
            DataManager dm = DataManager.GetInstance();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                sqlUpdate(o);
                dm.Commit();
            }

            catch (Exception ex)
            {
                dm.Rollback();
                throw ex;
            }
            finally
            {
                dm.Close();
            }
            return true;
        }

        public bool Delete(object o)
        {
            DataManager dm = DataManager.GetInstance();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                sqlDelete(o);
                dm.Commit();
            }

            catch (Exception ex)
            {
                dm.Rollback();
                throw ex;
            }

            finally
            {
                dm.Close();
            }

            return true;
        }

        protected abstract void sqlCreate(object o);
        protected abstract void sqlUpdate(object o);
        protected abstract void sqlDelete(object o);
    }
}
