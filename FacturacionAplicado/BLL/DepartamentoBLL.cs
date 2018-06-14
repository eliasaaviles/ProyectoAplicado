using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using FacturacionAplicado.Entidades;

namespace FacturacionAplicado.BLL
{
    public class DepartamentoBLL
    {
        public static MySqlConnection db;

        public static bool TestConnectiong()
        {
            bool paso = true;
            try
            {
                db = new MySqlConnection("server=localhost; database = FacturacionDb; user id=root;password=root");
                db.Open();


            }
            catch (Exception)
            {
                paso = false;
                throw;
            }

            return paso;
        }

        public static DataTable Consultar()
        {


            DataTable dt = new DataTable();
            TestConnectiong();
            MySqlDataAdapter con = new MySqlDataAdapter("select * from Departamentoes", db);
            try
            {


                con.Fill(dt);
                db.Close();


            }
            catch (Exception)
            {

                throw;
            }
            return dt;
        }

        public static bool Eliminar(string id)
        {

            MySqlDataAdapter dater = new MySqlDataAdapter();
            bool estado = true;
            try
            {
                TestConnectiong();
                dater.DeleteCommand = new MySqlCommand(" delete from Departamentoes where DepartamentoId=" + id, db);

                dater.DeleteCommand.Connection = db;
                dater.DeleteCommand.ExecuteNonQuery();

            }
            catch (Exception)
            {
                estado = false;
                throw;

            }
            finally
            {
                db.Close();
            }
            return estado;
        }


        public static bool Guardar(Departamento depart)
        {
            MySqlDataAdapter dater = new MySqlDataAdapter();
            bool estado = true;
            try
            {
                TestConnectiong();
                dater.InsertCommand = new MySqlCommand("insert into Departamentoes (Nombre) values ('" + depart.Nombre + "')", db);

                dater.InsertCommand.Connection = db;
                dater.InsertCommand.ExecuteNonQuery();

            }
            catch (Exception)
            {
                estado = false;
                throw;

            }
            finally
            {
                db.Close();
            }
            return estado;
        }


        //asi se pone un datatable en una lista 
        public static List<Departamento> Buscar()
        {

            DataTable dt = new DataTable();

            TestConnectiong();
            MySqlDataAdapter con = new MySqlDataAdapter("select * from Departamentoes", db);
            try
            {


                con.Fill(dt);
                db.Close();


            }
            catch (Exception)
            {

                throw;
            }



            List<Departamento> listName = dt.AsEnumerable().Select(m => new Departamento()
            {
                DepartamentoId = m.Field<int>("DepartamentoId"),
                Nombre = m.Field<string>("Nombre"),
                
            }).ToList();


            return listName;
        }

        public static bool Modificar(Departamento depart)
        {
            MySqlDataAdapter dater = new MySqlDataAdapter();
            bool estado = true;
            try
            {
                TestConnectiong();

                dater.UpdateCommand = new MySqlCommand("update Clientes set Nombre= '" + depart.Nombre +  "' where IdCliente = '" + depart.DepartamentoId + "'", db);

                dater.UpdateCommand.Connection = db;
                dater.UpdateCommand.ExecuteNonQuery();

            }
            catch (Exception)
            {
                estado = false;
                throw;

            }
            finally
            {
                db.Close();
            }
            return estado;

        }
    }
}
