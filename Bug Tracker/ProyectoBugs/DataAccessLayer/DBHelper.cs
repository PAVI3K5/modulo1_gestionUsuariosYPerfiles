﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BugTacker.DataAccessLayer
{
    public class DBHelper
    {
        private string string_conexion;
        private static DBHelper instance = new DBHelper();

        private DBHelper()
        {
            //Acordarse de cambiar esta cadena para que no salga error
            string_conexion = "Data Source=.\\SQLEXPRESS;Initial Catalog=BugTracker;Integrated Security=True";
        }

        public static DBHelper GetDBHelper()
        {
            if (instance == null)
                instance = new DBHelper();
            return instance;
        }

        /// Resumen:
        ///     Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”. Recibe por valor una sentencia sql como string
        /// Devuelve:
        ///      un valor entero con el número de filas afectadas por la sentencia ejecutada
        /// Excepciones:
        ///      System.Data.SqlClient.SqlException:
        ///          El error de conexión se produce:
        ///              a) durante la apertura de la conexión
        ///              b) durante la ejecución del comando.
        public int EjecutarSQL(string strSql)
        {
            int afectadas = 0;
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlTransaction t = null;

            try
            {
                cnn.ConnectionString = string_conexion;
                cnn.Open();
                //comienzo de transaccion...
                t = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.CommandText = strSql;
                cmd.Transaction = t;
                afectadas = cmd.ExecuteNonQuery();
                //Commit de transacción...
                t.Commit();
            }
            catch (Exception ex)
            {
                if (t != null)
                {
                    t.Rollback();
                    afectadas = 0;
                }
                throw ex;
            }
            finally
            {
                this.CloseConnection(cnn);
            }

            return afectadas;
        }

        /// Resumen:
        ///     Se utiliza para sentencias SQL del tipo “Select”. Recibe por valor una sentencia sql como string
        /// Devuelve:
        ///      un objeto de tipo DataTable con el resultado de la consulta
        /// Excepciones:
        ///      System.Data.SqlClient.SqlException:
        ///          El error de conexión se produce:
        ///              a) durante la apertura de la conexión
        ///              b) durante la ejecución del comando.
        public DataTable ConsultaSQL(string strSql)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            try
            {
                cnn.ConnectionString = string_conexion;
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSql;
                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            finally
            {
                this.CloseConnection(cnn);
            }
        }
        public DataTable ConsultaSP(string nameSP)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            try
            {
                cnn.ConnectionString = string_conexion;
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nameSP;
                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            finally
            {
                this.CloseConnection(cnn);
            }
        }

        /// Resumen:
        ///      Se utiliza para sentencias SQL del tipo “Select” con parámetros recibidos desde la interfaz
        ///      La función recibe por valor una sentencia sql como string y un diccionario de objetos como parámetros
        /// Devuelve:
        ///      un objeto de tipo DataTable con el resultado de la consulta
        /// Excepciones:
        ///      System.Data.SqlClient.SqlException:
        ///          El error de conexión se produce:
        ///              a) durante la apertura de la conexión
        ///              b) durante la ejecución del comando.
        public DataTable ConsultarSQLConParametros(string sqlStr, Object[] prs)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            string n_param;
            try
            {
                cnn.ConnectionString = string_conexion;
                cnn.Open();
                cmd.Connection = cnn;

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlStr;

                //Agregamos a la colección de parámetros del comando los filtros recibidos
                //IMPORTANTE: cada parametro deberá llamarse: param1, param2,.., paramN
                for (int i = 0; i < prs.Length; i++)
                    if (prs[i] != null)
                    {
                        n_param = "param" + Convert.ToString(i + 1);
                        cmd.Parameters.AddWithValue(n_param, prs[i]);
                    }

                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                CloseConnection(cnn);
            }
        }

        public DataTable ConsultarSPConParametros(string nameSP, Object[] prs)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            string n_param;
            try
            {
                cnn.ConnectionString = string_conexion;
                cnn.Open();
                cmd.Connection = cnn;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nameSP;

                //Agregamos a la colección de parámetros del comando los filtros recibidos
                //IMPORTANTE: cada parametro deberá llamarse: param1, param2,.., paramN
                for (int i = 0; i < prs.Length; i++)
                    if (prs[i] != null)
                    {
                        n_param = "param" + Convert.ToString(i + 1);
                        cmd.Parameters.AddWithValue(n_param, prs[i]);
                    }

                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                CloseConnection(cnn);
            }
        }

        private void CloseConnection(SqlConnection cnn)
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
                cnn.Dispose();
            }
        }

    }
}
