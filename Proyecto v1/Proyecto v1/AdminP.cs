using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_v1
{
    public partial class Admin : Form
    {

        
        string nombre, clave, documento, contacto;
        bool validar;
       
        public Admin()
        {

            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            validar = valDatos( nombre, documento, clave, contacto);

           

     
        }

       public bool valDatos(string name, string id, string pass, string contact)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Falta ingresar el NOMBRE ");
                errorProviderValidar.SetError(txtName, "Ingrese nombre");
                validar = false;
            }else

            if (txtPass.Text == "")
            {
                MessageBox.Show("Falta ingresar la CONTRASEÑA ");
                errorProviderValidar.SetError(txtPass, "Ingrese contraseña");
                validar = false;
            }
            else

            if (txtId.Text == "")
            {
                MessageBox.Show("Falta ingresar el DOCUMENTO");
                errorProviderValidar.SetError(txtId, "Ingrese documento.");
                validar = false;
            }
            else

            if (txtContact.Text == "") { MessageBox.Show("Falta ingresar la información de CONTACTO");
                errorProviderValidar.SetError(txtContact, "Ingrese la información de contacto");
                validar = false;

            }
            else
            {

                validar = true;
                errorProviderValidar.SetError(txtName, "");
                errorProviderValidar.SetError(txtPass, "");
                errorProviderValidar.SetError(txtId, "");
                errorProviderValidar.SetError(txtContact, "");
            }

            return validar;
        }

    }
}
