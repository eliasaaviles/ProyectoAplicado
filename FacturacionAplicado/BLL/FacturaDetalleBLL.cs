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
    public class FacturaDetalleBLL
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

        public static List<FacturaDetalle> Buscar(string id)
        {

            DataTable dt = new DataTable();

            TestConnectiong();
            MySqlDataAdapter con = new MySqlDataAdapter("select * from FacturaDetalles where Id=" + id, db);
            try
            {


                con.Fill(dt);
                db.Close();


            }
            catch (Exception)
            {

                throw;
            }



            List<FacturaDetalle> listName = dt.AsEnumerable().Select(m => new FacturaDetalle()
            {
                Id = m.Field<int>("Id"),
                FacturaId = m.Field<int>("FacturaId"),
                ProductoId = m.Field<int>("ProductoId"),
                Cantidad = m.Field<int>("Cantidad"),
                Precio = m.Field<decimal>("Precio"),
                Descripcion = m.Field<string>("Descripcion")

            }).ToList();


            return listName;
        }

        public static List<FacturaDetalle> BuscarFacturaID(string id)
        {

            DataTable dt = new DataTable();

            TestConnectiong();
            MySqlDataAdapter con = new MySqlDataAdapter("select * from FacturaDetalles where FacturaId=" + id, db);
            try
            {


                con.Fill(dt);
                db.Close();


            }
            catch (Exception)
            {

                throw;
            }



            List<FacturaDetalle> listName = dt.AsEnumerable().Select(m => new FacturaDetalle()
            {
                Id = m.Field<int>("Id"),
                FacturaId = m.Field<int>("FacturaId"),
                ProductoId = m.Field<int>("ProductoId"),
                Cantidad = m.Field<int>("Cantidad"),
                Precio = m.Field<decimal>("Precio"),
                Descripcion = m.Field<string>("Descripcion")

            }).ToList();


            return listName;
        }

        public static bool Eliminar(string id)
        {

            MySqlDataAdapter dater = new MySqlDataAdapter();
            bool estado = true;
            try
            {
                TestConnectiong();
                dater.DeleteCommand = new MySqlCommand(" delete from FacturaDetalles where Id=" + id, db);

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

        public static bool Eliminar(List<FacturaDetalle> facturaDetalles)
        {

            MySqlDataAdapter dater = new MySqlDataAdapter();
            bool estado = true;
            try
            {
                TestConnectiong();
                foreach (var item in facturaDetalles)
                {

                    dater.DeleteCommand = new MySqlCommand(" delete from FacturaDetalles where Id=" + item.Id, db);

                    dater.DeleteCommand.Connection = db;
                    dater.DeleteCommand.ExecuteNonQuery();
                }

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

        public static bool Modificar(List<FacturaDetalle> factura)
        {
            MySqlDataAdapter dater = new MySqlDataAdapter();
            bool estado = true;
            try
            {
                TestConnectiong();
                foreach (var item in factura)
                {

                    dater.UpdateCommand = new MySqlCommand("update FacturaDetalles set Id= '" + item.Id + "', FacturaId = '" + item.FacturaId + "', ProductoId = '" + item.ProductoId + "', Cantidad = '" + item.Cantidad + "', Precio= '" + item.Precio + "',Descripcion='" + item.Descripcion + "'where Id = '" + item.Id + "'", db);

                    dater.UpdateCommand.Connection = db;
                    dater.UpdateCommand.ExecuteNonQuery();
                }

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

        public static bool Guardar(List<FacturaDetalle> factura)
        {
            MySqlDataAdapter dater = new MySqlDataAdapter();
            bool estado = true;
            try
            {
                TestConnectiong();
                var Id = FacturacionBLL.Buscar();
                var IDfactura = Id.ElementAt(Id.Count()-1);

                foreach (var item in factura)
                {

                    dater.InsertCommand = new MySqlCommand("insert into FacturaDetalles (Id,FacturaId,ProductoId,Cantidad,Precio,Descripcion) values ('" + item.Id + "','" + IDfactura.FacturaId + "','" + item.ProductoId + "','" + item.Cantidad + "','" + item.Precio + "','" + item.Descripcion + "')", db);

                    dater.InsertCommand.Connection = db;
                    dater.InsertCommand.ExecuteNonQuery();
                }

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

        public static DataTable Consultar()
        {


            DataTable dt = new DataTable();
            TestConnectiong();
            MySqlDataAdapter con = new MySqlDataAdapter("select * from FacturaDetalles", db);
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
    }
}
