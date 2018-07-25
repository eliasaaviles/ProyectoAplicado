
using FacturacionAplicado.Entidades;
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
    public partial class CProducto : Form
    {
        public CProducto()
        {
            InitializeComponent();
        }
    
        private void Consultabutton_Click(object sender, EventArgs e)
        {
            int id;
            List<Producto> lista = new List<Producto>();
            if(TipocomboBox.Text ==string.Empty&& CriteriotextBox.Text ==string.Empty)
            {
                lista = BLL.ProductoBLL.Buscar();
            }
            
            switch (TipocomboBox.SelectedIndex)
            {
                //ID
                case 0:
                    LimpiarError();
                    if (SetError(1))
                    {
                        MessageBox.Show("Introduce un numero");
                        return;

                    }
                    id = int.Parse(CriteriotextBox.Text);
                    lista =  BLL.ProductoBLL.Getlist(TipocomboBox.Text, CriteriotextBox.Text);
                    break;
                //Descripcion
                case 1:
                    LimpiarError();
                    if (SetError(2))
                    {
                        MessageBox.Show("Introduce un caracter");
                        return;
                    }
                     lista = BLL.ProductoBLL.Getlist(TipocomboBox.Text, CriteriotextBox.Text);
                    break;
                
                //Cantidad
                case 2:
                    LimpiarError();
                    if (SetError(1))
                    {
                        MessageBox.Show("Introduce un numero");
                        return;

                    }
                     lista = BLL.ProductoBLL.Getlist(TipocomboBox.Text, CriteriotextBox.Text);
                    break;
                //precio
                case 3:
                    LimpiarError();
                    if (SetError(1))
                    {
                        MessageBox.Show("Introduce un numero");
                        return;

                    }
                     lista = BLL.ProductoBLL.Getlist(TipocomboBox.Text, CriteriotextBox.Text);
                    break;
                //idDepartamento
                case 4:
                    LimpiarError();
                    if (SetError(1))
                    {
                        MessageBox.Show("Introduce un numero");
                        return;

                    }
                     lista = BLL.ProductoBLL.Getlist(TipocomboBox.Text, CriteriotextBox.Text);
                    break;

                //Listar Todo
                case 5:

                     lista = BLL.ProductoBLL.Buscar();
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

        private void ReporteButton_Click(object sender, EventArgs e)
        {
            
        }

        private void TipocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CriteriotextBox.Clear();
            LimpiarError();
            if (TipocomboBox.SelectedIndex == 5)
            {
                CriteriotextBox.Enabled = false;

            }
            else
            {
                CriteriotextBox.Enabled = true;
            }
        }
    }
}
