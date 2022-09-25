using System;
using System.Windows.Forms;

namespace Proyecto_v1
{
    public partial class Admin : Form
    {


        string nombre, clave, documento, contacto;
        bool validar, validarId;
        int fila;

        public Admin()
        {

            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dvgDirectivos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            nombre = txtName.Text;
            documento = txtId.Text;
            clave = txtPass.Text;
            contacto = txtContact.Text;
            validar = valDatos(nombre, documento, clave, contacto);

            if (validar == true)
            {

                validarId = valId(documento);
                if(validarId== true)
                {

                    dvgDirectivos.Rows.Add(nombre, documento, clave, contacto);
                    MessageBox.Show("Usuario registrado con éxito");
                    limpiar();
                }

            }

        }

        public bool valDatos(string name, string id, string pass, string contact)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Falta ingresar el NOMBRE ");
                errorProviderValidar.SetError(txtName, "Ingrese nombre");
                validar = false;
            }
            else

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
                errorProviderValidar.SetError(txtId, "Ingrese documento");
                validar = false;
            }
            else

            if (txtContact.Text == "")
            {
                MessageBox.Show("Falta ingresar la información de CONTACTO");
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

        public bool valId(string id)
        {
            validarId = true;

            for(int i=0; i<dvgDirectivos.Rows.Count; i++)
            {
               
                foreach(DataGridViewRow Row in dvgDirectivos.Rows)
                {
                    String strFila = ColumnId.Index.ToString();
                    string valor = Convert.ToString(Row.Cells["ColumnId"].Value);

                    if(valor== id)
                    {
                        MessageBox.Show("Ya existe este documento:");
                        errorProviderValidar.SetError(txtId, "Ingrese otro documento");
                        validarId = false;
                        break;
                    }
                    else
                    {

                        errorProviderValidar.SetError(txtId, "");
                        validarId = true;
                    }
                    
                }
            }
            return validarId;
        }

        private int limpiar()
        {
            txtName.Text = "";
            txtContact.Text = "";
            txtPass.Text = "";
            txtId.Text = "";

            return 0;
        }

        private int actBtn() {

            btnAdd.Enabled = true;
            btnMod.Enabled = true;
            return 0;
        }

        private int desactBtn()
        {
            btnAdd.Enabled = false;
            btnMod.Enabled = false;
            return 0;
        }

    }
}
