using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autocred
{
    public partial class Proveedor : Form
    {
        Modelo.Proveedor oProv;
        Controladora.ControladoraProveedor cProv;
        Controladora.ControladoraRubro cRubro;
        Modelo.Rubro oRubro;
        string ACCION;
        public Proveedor(Modelo.Proveedor miProv, string miACCION)
        {
            InitializeComponent();
            cProv = Controladora.ControladoraProveedor.obtener_instancia();
            cRubro = Controladora.ControladoraRubro.obtener_instancia();
            oProv = miProv;
            ACCION = miACCION;
            if (ACCION != "A")
            {

                txtRazonSocial.Text = oProv.Razon_Social;
                txtEmail.Text = oProv.Email;
                textBoxDireccionCalle.Text = oProv.Direccion_Calle;
                textBoxDireccionNro.Text = oProv.Direccion_Nro;





            }
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            //Modelo.Usuario oUSUARIO = new Modelo.Usuario();
            if (string.IsNullOrEmpty(txtRazonSocial.Text))
            {
                MessageBox.Show("Debe ingresar La razon Social para el acceso al sistema", "ATENCION!!");
                return;
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Debe ingresar el Email", "ATENCION!!");
                return;
            }
           


            oProv.Razon_Social = txtRazonSocial.Text;
            oProv.Email = txtEmail.Text;
            oProv.Direccion_Calle = textBoxDireccionCalle.Text;
            oProv.Direccion_Nro = textBoxDireccionNro.Text;




            if (ACCION == "A")
            {
                if (cProv.VALIDA_NOMBRE_Proveedor(txtRazonSocial.Text))
                {
                    MessageBox.Show("El nombre de Razon Social  ya se encuentra asignado a otro Proveedor", "ATENCION!!");
                    return;
                }

                
                oRubro.Proveedor.Add(oProv);

                cProv.Agregar_Proveedor(oProv);

            }
            else
            {
                Modelo.SingletonContexto.obtener_instancia().Contexto.ProveedorSet.Attach(oProv);
                oRubro.Proveedor.Add(oProv);
                cProv.Modificar(oProv);
                //oUSUARIO.Grupo.Id = Convert.ToInt32(txtIdGrupo.Text);
                //cGrupos.modificarGrupos(oGrupo);

            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Rubros frm = new Rubros();

            frm.Size = new Size(295, 450);
            frm.btnCANCELAR.Visible = true;
            frm.btnGUARDAR.Visible = true;
            frm.btnALTAS.Visible = false;
            frm.btnBAJAS.Visible = false;
            frm.btnMODIFICACIONES.Visible = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                oRubro = frm.GrupoSelec;
                txtIdRubro.Text = oRubro.Id.ToString();
                txtDescripcionRubro.Text = oRubro.Descripcion;



            }
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
