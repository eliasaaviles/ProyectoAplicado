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
    public class ProductoBLL
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
            MySqlDataAdapter con = new MySqlDataAdapter("select * from Productoes", db);
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
                dater.DeleteCommand = new MySqlCommand(" delete from Productoes where Idproducto=" + id, db);

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


        public static bool Guardar(Producto productos)
        {
            MySqlDataAdapter dater = new MySqlDataAdapter();
            bool estado = true;
            try
            {
                TestConnectiong();
                dater.InsertCommand = new MySqlCommand("insert into Productoes (Idproducto,Descripcion,Precio,DepartamentoId,Cantidad) values ('" + productos.Idproducto + "','" + productos.Descripcion + "','" + productos.Precio + "','" + productos.DepartamentoId +"','"+ productos.Cantidad+ "')", db);

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
        public static List<Producto> Buscar()
        {

            DataTable dt = new DataTable();

            TestConnectiong();
            MySqlDataAdapter con = new MySqlDataAdapter("select * from Productoes", db);
            try
            {


                con.Fill(dt);
                db.Close();


            }
            catch (Exception)
            {

                throw;
            }



            List<Producto> listName = dt.AsEnumerable().Select(m => new Producto()
            {
                Idproducto = m.Field<int>("Idproducto"),
                Descripcion = m.Field<string>("Descripcion"),
                Precio = m.Field<decimal>("Precio"),
                DepartamentoId = m.Field<int>("DepartamentoId"),
                Cantidad = m.Field<int>("Cantidad")
            }).ToList();


            return listName;
        }
        public static List<Producto> Buscar(string id)
        {

            DataTable dt = new DataTable();

            TestConnectiong();
            MySqlDataAdapter con = new MySqlDataAdapter("select * from Productoes where Idproducto="+ id, db);
            try
            {


                con.Fill(dt);
                db.Close();


            }
            catch (Exception)
            {

                throw;
            }



            List<Producto> listName = dt.AsEnumerable().Select(m => new Producto()
            {
                Idproducto = m.Field<int>("Idproducto"),
                Descripcion = m.Field<string>("Descripcion"),
                Precio = m.Field<decimal>("Precio"),
                DepartamentoId = m.Field<int>("DepartamentoId"),
                Cantidad = m.Field<int>("Cantidad")
            }).ToList();


            return listName;
        }



        public static bool Modificar(Producto producto)
        {
            MySqlDataAdapter dater = new MySqlDataAdapter();
            bool estado = true;
            try
            {
                TestConnectiong();

                dater.UpdateCommand = new MySqlCommand("update Productoes set Idproducto= '" + producto.Idproducto + "', Descripcion = '" + producto.Descripcion + "', Precio = '" + producto.Precio + "', DepartamentoId = '" + producto.DepartamentoId +"', Cantidad= '" + producto.Cantidad+ "'where Idproducto = '" + producto.Idproducto + "'", db);

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
