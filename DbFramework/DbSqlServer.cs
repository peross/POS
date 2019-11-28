using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;

namespace DbFramework
{
    public class DbSqlServer
    {
        private string _connstring;

        public DbSqlServer(string consntring)
        {
            _connstring = consntring;
        }

        public object vratiSkalarnuVrijednost(string storedProceIme)
        {
            object vrijednost = null;
            using (SqlConnection conn = new SqlConnection(_connstring))
            {
                using (SqlCommand cmd = new SqlCommand(storedProceIme, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    conn.Open();
                    vrijednost = cmd.ExecuteScalar();
                }
            }
            return vrijednost;
        }

        public object vratiSkalarnuVrijednost(string storedProceIme, DbParametri parametar)
        {
            object vrijednost = null;
            using (SqlConnection conn = new SqlConnection(_connstring))
            {
                using (SqlCommand cmd = new SqlCommand(storedProceIme, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue(parametar.Parametar, parametar.Vrijednost);
                    vrijednost = cmd.ExecuteScalar();
                }
            }
            return vrijednost;
        }

        public object vratiSkalarnuVrijednost(string storedProceIme, DbParametri[] parametri)
        {
            object vrijednost = null;
            using (SqlConnection conn = new SqlConnection(_connstring))
            {
                using (SqlCommand cmd = new SqlCommand(storedProceIme, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    conn.Open();
                    foreach (var para in parametri)
                        cmd.Parameters.AddWithValue(para.Parametar, para.Vrijednost);
                    vrijednost = cmd.ExecuteScalar();
                }
            }
            return vrijednost;
        }

        public DataTable vratiPodatkeLista(string storedProceIme)
        {
            DataTable dtPodaci = new DataTable();

            using (SqlConnection kon = new SqlConnection(_connstring))
            {
                using (SqlCommand kom = new SqlCommand(storedProceIme, kon))
                {
                    kom.CommandType = CommandType.StoredProcedure;
                    kon.Open();
                    SqlDataReader citac = kom.ExecuteReader();

                    dtPodaci.Load(citac);
                }
            }
            return dtPodaci;
        }

        //jedan parametar
        public DataTable vratiPodatkeLista(string storedProceIme, DbParametri parametar)
        {
            DataTable dtPodaci = new DataTable();

            using (SqlConnection kon = new SqlConnection(_connstring))
            {
                using (SqlCommand kom = new SqlCommand(storedProceIme, kon))
                {
                    kom.CommandType = CommandType.StoredProcedure;
                    kon.Open();

                    kom.Parameters.AddWithValue(parametar.Parametar, parametar.Vrijednost);

                    SqlDataReader citac = kom.ExecuteReader();

                    dtPodaci.Load(citac);
                }
            }
            return dtPodaci;
        }

        //vise parametara
        public DataTable vratiPodatkeLista(string storedProceIme, DbParametri[] parametri)
        {
            DataTable dtPodaci = new DataTable();

            using (SqlConnection kon = new SqlConnection(_connstring))
            {
                using (SqlCommand kom = new SqlCommand(storedProceIme, kon))
                {
                    kom.CommandType = CommandType.StoredProcedure;
                    kon.Open();

                    foreach (var para in parametri)
                        kom.Parameters.AddWithValue(para.Parametar, para.Vrijednost);

                    SqlDataReader citac = kom.ExecuteReader();

                    dtPodaci.Load(citac);
                }
            }
            return dtPodaci;
        }

        public void snimiIliAzurirajZapis(string storedProceIme, object obj)
        {
            using (SqlConnection kon = new SqlConnection(_connstring))
            {
                using (SqlCommand kom = new SqlCommand(storedProceIme, kon))
                {
                    kom.CommandType = CommandType.StoredProcedure;
                    kon.Open();

                    //parametri
                    Type tip = obj.GetType();
                    BindingFlags zastavica = BindingFlags.Public | BindingFlags.Instance;
                    PropertyInfo[] svojsta = tip.GetProperties(zastavica);

                    foreach (var svojstvo in svojsta)
                    {
                        kom.Parameters.AddWithValue("@" + svojstvo.Name, svojstvo.GetValue(obj, null)); //dodavanje na osnovu parametara iz procedure u sql-u
                    }

                    kom.ExecuteNonQuery();
                }
            }
        }

    }
}
