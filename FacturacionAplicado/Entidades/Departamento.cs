using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionAplicado.Entidades
{
    public class Departamento
    {
        public int id { get; set; }
        public string Nombre { get; set; }

        public Departamento(int idDepartamento, string nombre)
        {
            this.id = idDepartamento;
            this.Nombre = nombre;
        }

        public Departamento()
        {
            this.id = 0;
            this.Nombre = string.Empty;
        }
    }
}
