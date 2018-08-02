
using FacturacionAplicado.Entidades;
using FacturacionAplicado.Reportes_Ventanas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace FacturacionAplicado.UI.Consultas
{
    public partial class CFactura : Form
    {
        public CFactura()
        {
            InitializeComponent();
        }
        List<Factura> lista = new List<Factura>();
        private void Consultabutton_Click(object sender, EventArgs e)
        {
            

            if (TipocomboBox.Text == string.Empty && CriteriotextBox.Text == string.Empty)
            {
                lista = BLL.FacturacionBLL.Buscar();
            }
            if (TipocomboBox.Text == string.Empty && CriteriotextBox.Text == string.Empty && ContadocheckBox.Checked == true)
            {
                lista = BLL.FacturacionBLL.BuscarTipo("Contado");
            }
            if (TipocomboBox.Text == string.Empty && CriteriotextBox.Text == string.Empty && CreditocheckBox.Checked == true)
            {
                lista = BLL.FacturacionBLL.BuscarTipo("Credito");
            }
            if (TipocomboBox.Text == string.Empty && CriteriotextBox.Text == string.Empty && CreditocheckBox.Checked == true && ContadocheckBox.Checked == true)
                lista = BLL.FacturacionBLL.Buscar();




            switch (TipocomboBox.SelectedIndex)
            {
                //    //ID
                case 0:
                    LimpiarError();
                    if (SetError(1))
                    {
                        MessageBox.Show("Introduce un numero");
                        return;

                    }

                    lista = BLL.FacturacionBLL.GetList(TipocomboBox.Text, CriteriotextBox.Text);

                    break;
                //    //ClienteID
                case 1:
                    LimpiarError();
                    if (SetError(1))
                    {
                        MessageBox.Show("Introduce un numero");
                        return;

                    }
                    if (ContadocheckBox.Checked == true)
                    {
                        lista = BLL.FacturacionBLL.GetList(TipocomboBox.Text, CriteriotextBox.Text, "Contado");
                    }
                    if (CreditocheckBox.Checked == true)
                    {
                        lista = BLL.FacturacionBLL.GetList(TipocomboBox.Text, CriteriotextBox.Text, "Credito");
                    }
                    if (CreditocheckBox.Checked == true && ContadocheckBox.Checked == true)
                        lista = BLL.FacturacionBLL.GetList(TipocomboBox.Text, CriteriotextBox.Text);
                    else
                        lista = BLL.FacturacionBLL.GetList(TipocomboBox.Text, CriteriotextBox.Text);

                    break;
                //    //IDusuario
                case 2:
                    LimpiarError();
                    if (SetError(1))
                    {
                        MessageBox.Show("Introduce un numero");
                        return;

                    }
                    if (ContadocheckBox.Checked == true)
                    {
                        lista = BLL.FacturacionBLL.GetList(TipocomboBox.Text, CriteriotextBox.Text, "Contado");
                    }
                    if (CreditocheckBox.Checked == true)
                    {
                        lista = BLL.FacturacionBLL.GetList(TipocomboBox.Text, CriteriotextBox.Text, "Credito");
                    }
                    if (CreditocheckBox.Checked == true && ContadocheckBox.Checked == true)
                        lista = BLL.FacturacionBLL.GetList(TipocomboBox.Text, CriteriotextBox.Text);
                    else
                        lista = BLL.FacturacionBLL.GetList(TipocomboBox.Text, CriteriotextBox.Text);

                    break;
                //    //Descripcion
                case 3:
                    LimpiarError();
                    if (SetError(2))
                    {
                        MessageBox.Show("Introduce un caracter");
                        return;
                    }
                    if (ContadocheckBox.Checked == true)
                    {
                        lista = BLL.FacturacionBLL.GetList(TipocomboBox.Text, CriteriotextBox.Text, "Contado");
                    }
                    if (CreditocheckBox.Checked == true)
                    {
                        lista = BLL.FacturacionBLL.GetList(TipocomboBox.Text, CriteriotextBox.Text, "Credito");
                    }
                    if (CreditocheckBox.Checked == true && ContadocheckBox.Checked == true)
                        lista = BLL.FacturacionBLL.GetList(TipocomboBox.Text, CriteriotextBox.Text);
                    else
                        lista = BLL.FacturacionBLL.GetList(TipocomboBox.Text, CriteriotextBox.Text);

                    break;
                //    //Lista todo
                case 4:
                    LimpiarError();
                    if (ContadocheckBox.Checked == true)
                    {
                        lista = BLL.FacturacionBLL.BuscarTipo("Contado");
                    }
                    if (CreditocheckBox.Checked == true)
                    {
                        lista = BLL.FacturacionBLL.BuscarTipo("Credito");
                    }
                    if (CreditocheckBox.Checked == true && ContadocheckBox.Checked == true)
                        lista = BLL.FacturacionBLL.Buscar();
                    else
                        lista = BLL.FacturacionBLL.Buscar();
                    break;

                //    //monto
                case 5:
                    LimpiarError();
                    if (SetError(1))
                    {
                        MessageBox.Show("Introduce un numero");
                        return;

                    }

                    if (ContadocheckBox.Checked == true)
                    {
                        lista = BLL.FacturacionBLL.GetList(TipocomboBox.Text, CriteriotextBox.Text, "Contado");
                    }
                    if (CreditocheckBox.Checked == true)
                    {
                        lista = BLL.FacturacionBLL.GetList(TipocomboBox.Text, CriteriotextBox.Text, "Credito");
                    }
                    if (CreditocheckBox.Checked == true && ContadocheckBox.Checked == true)
                        lista = BLL.FacturacionBLL.GetList(TipocomboBox.Text, CriteriotextBox.Text);
                    else
                        lista = BLL.FacturacionBLL.GetList(TipocomboBox.Text, CriteriotextBox.Text);

                    break;
                //    //efectivo recibido
                case 6:
                    LimpiarError();
                    if (SetError(1))
                    {
                        MessageBox.Show("Introduce un numero");
                        return;

                    }

                    lista = BLL.FacturacionBLL.GetList(TipocomboBox.Text, CriteriotextBox.Text);

                    break;

                //    //Devuelta
                case 7:
                    LimpiarError();
                    if (SetError(1))
                    {
                        MessageBox.Show("Introduce un numero");
                        return;

                    }

                    lista = BLL.FacturacionBLL.GetList(TipocomboBox.Text, CriteriotextBox.Text);

                    break;

            }


            ConsultadataGridView.DataSource = lista;
        }

        private bool SetError(int error)
        {
            bool paso = false;
            int ejem = 0;
            if (error == 1 && int.TryParse(CriteriotextBox.Text, out ejem) == false)
            {
                TexterrorProvider.SetError(CriteriotextBox, "Debe de introducir un numero");
                paso = true;
            }
            if (error == 2 && int.TryParse(CriteriotextBox.Text, out ejem) == true)
            {
                TexterrorProvider.SetError(CriteriotextBox, "Debe de introducir un caracter");
                paso = true;
            }

            return paso;
        }

        private void LimpiarError()
        {
            TexterrorProvider.Clear();
        }

        private void Reportebutton_Click(object sender, EventArgs e)
        {
            if (lista.Count == 0)
                lista = BLL.FacturacionBLL.Buscar();

            Facturas abrir = new Facturas(lista);
            abrir.Show();

        }

        private void TipocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool paso = false;
            CriteriotextBox.Clear();
            if (TipocomboBox.SelectedIndex == 4)
            {
                CriteriotextBox.Enabled = false;

            }
            else
            {
                CriteriotextBox.Enabled = true;
            }

            if (TipocomboBox.SelectedIndex == 0)
            {
                ContadocheckBox.Enabled = false;
                CreditocheckBox.Enabled = false;
                paso = true;
            }
            else
            {
                ContadocheckBox.Enabled = true;
                CreditocheckBox.Enabled = true;
                paso = false;
            }
            if (paso == false)
            {

                if (TipocomboBox.SelectedIndex == 7 || TipocomboBox.SelectedIndex == 6)
                {
                    CreditocheckBox.Enabled = false;
                    ContadocheckBox.Enabled = false;
                }
                else
                {
                    ContadocheckBox.Enabled = true;
                    CreditocheckBox.Enabled = true;
                }
            }


        }


    }
}
