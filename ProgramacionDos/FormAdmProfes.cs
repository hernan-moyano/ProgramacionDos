using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocios;
//todo: falta carga las validaciones
namespace ProgramacionDos
{
    public partial class FormAdmProfes : Form
    {
        public Profesional objEntProf = new Profesional();
        public NegProfesionales objNegProf = new NegProfesionales();

        public FormAdmProfes()
        {
            InitializeComponent();
            dgvProfesionales.ColumnCount = 2;
            dgvProfesionales.Columns[0].HeaderText = "Código";
            dgvProfesionales.Columns[1].HeaderText = "Nombre";
            dgvProfesionales.Columns[0].Width = 60;
            dgvProfesionales.Columns[1].Width = 200;
            LlenarDGV();
        }

        #region Metodos
        private void LlenarDGV()
        {
            dgvProfesionales.Rows.Clear();

            DataSet ds = new DataSet();
            ds = objNegProf.listadoProfesionales("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    //Lo que quieres mostrar esta en dr[0].ToString(), dr[1].ToString(),etc.
                    dgvProfesionales.Rows.Add(dr[0].ToString(), dr[1]);
                }
            }
            else
                lblMensaje.Text = "No hay profesionales cargados en el sistema";
        }


        private void TxtBox_a_Obj() //Prepara el objeto a enviar a la capa de Negocio
        {
            try
            {
                objEntProf.CodProf = int.Parse(txtCodigo.Text);
                objEntProf.Nombre = txtNombre.Text;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        private void Limpiar()
        {
            txtCodigo.Text = string.Empty;
            txtNombre.Text = string.Empty;
        }

        private void Ds_a_TxtBox(DataSet ds)
        {
            txtCodigo.Text = ds.Tables[0].Rows[0]["CodProf"].ToString();
            txtNombre.Text = ds.Tables[0].Rows[0]["Nombre"].ToString();
            txtCodigo.Enabled = false;
        }

        private void Obj_a_Txt()
        {
            txtCodigo.Text = objEntProf.CodProf.ToString();
            txtNombre.Text = objEntProf.Nombre.ToString();
        }

        private void Dgv_a_Obj()
        {
            if (dgvProfesionales.CurrentRow.Cells[0].Value.ToString() != string.Empty)
            {
                objEntProf.CodProf = Convert.ToInt32(dgvProfesionales.CurrentRow.Cells[0].Value);
            }
            if (dgvProfesionales.CurrentRow.Cells[0].Value.ToString() != string.Empty)
            {
                objEntProf.Nombre = Convert.ToString(dgvProfesionales.CurrentRow.Cells[1].Value);
            }
        }

        private void controlDatos(object box, string validar)
        {

            if (validar.Trim() != string.Empty)
            {
                errorProvider1.SetError((Control)box, "");
                if (txtCodigo.Text.Trim() != string.Empty && txtNombre.Text.Trim() != string.Empty)
                {
                    btnGrabar.Enabled = true;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                }
            }
            else
            {
                errorProvider1.SetError((Control)box, "Completar Campo");
                btnGrabar.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }

        }

        #endregion

        #region Eventos
        private void dgvProfesionales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataSet ds = new DataSet();
            objEntProf.CodProf = Convert.ToInt32(dgvProfesionales.CurrentRow.Cells[0].Value);
            ds = objNegProf.listadoProfesionales(objEntProf.CodProf.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                Ds_a_TxtBox(ds);
                btnGrabar.Visible = false;
                lblMensaje.Text = string.Empty;
            }

        }
        private void dgvProfesionales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Dgv_a_Obj();
            Obj_a_Txt();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            int nResultado = -1;
            TxtBox_a_Obj();
            nResultado = objNegProf.abmProfesionales("Modificar", objEntProf); //invoco a la capa de negocio
            if (nResultado != -1)
            {
                MessageBox.Show("Aviso", "El Profesional fue Modificado con éxito");
                Limpiar();
                LlenarDGV();
                txtCodigo.Enabled = true;
            }
            else
                MessageBox.Show("Error", "Se produjo un error al intentar modificar el Profesional");
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int nGrabados = -1;
            //llamo al método que carga los datos del objeto
            TxtBox_a_Obj();
            nGrabados = objNegProf.abmProfesionales("Agregar", objEntProf); //invoco a la capa de negocio
            if (nGrabados == -1)
                lblMensaje.Text = " No pudo grabar profesionales en el sistema";
            else
            {
                lblMensaje.Text = " Se grabó con éxito profesionales.";
                LlenarDGV();
                Limpiar();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int nEliminados = -1;
            //llamo al método que carga los datos del objeto
            TxtBox_a_Obj();
            nEliminados = objNegProf.abmProfesionales("Eliminar", objEntProf); //invoco a la capa de negocio
            if (nEliminados == -1)
                lblMensaje.Text = " No pudo Eliminar profesionales en el sistema";
            else
            {
                lblMensaje.Text = " Se Eliminó con éxito profesionales.";
                LlenarDGV();
                Limpiar();
            }


        }

        #endregion

        private void FormAdmProfes_Load(object sender, EventArgs e)
        {
            btnGrabar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            object box = txtCodigo;
            string validar = txtCodigo.Text;
            controlDatos(box, validar);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            object box = txtNombre;
            string validar = txtNombre.Text;
            controlDatos(box, validar);
        }
    }
}
