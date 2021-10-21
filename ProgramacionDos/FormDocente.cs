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

namespace ProgramacionDos
{
    public partial class FormDocente : Form
    {
     
 
        public Docente objEntDocen = new Docente();
        public NegDocentes objNegDocentes = new NegDocentes();
        public FormDocente()
        {
            InitializeComponent();
            dgvDocentes.ColumnCount = 7;
            dgvDocentes.Columns[0].HeaderText = "Nombre";
            dgvDocentes.Columns[1].HeaderText = "Apellido";
            dgvDocentes.Columns[2].HeaderText = "DNI";
            dgvDocentes.Columns[3].HeaderText = "Nacimiento";
            dgvDocentes.Columns[4].HeaderText = "Sexo";
            dgvDocentes.Columns[5].HeaderText = "Materia";
            dgvDocentes.Columns[6].HeaderText = "Legajo";
            dgvDocentes.Columns[4].Width = 40;
           LlenarDGVDocente();
        }

        #region Metodos

        private void LlenarDGVDocente()
        {
            dgvDocentes.Rows.Clear();

            DataSet dds = new DataSet();
          
            dds = objNegDocentes.listadoDocentes("Todos");

            if ( dds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow ddr in dds.Tables[0].Rows)
                { 
                    //Lo que quieres mostrar esta en dr[0].ToString(), dr[1].ToString(),etc.
                    dgvDocentes.Rows.Add(ddr[0], ddr[1], ddr[2], Convert.ToDateTime(ddr[3]).ToShortDateString(), ddr[4],ddr[5], ddr[6]);
                }
            }
            else
                lblMensaje.Text = "No hay docentes cargados en el sistema";
        }
       
        private void TxtBox_a_Obj() //Prepara el objeto a enviar a la capa de Negocio
        {
                objEntDocen.Nombre = txtNombre.Text;
                objEntDocen.Apellido = txtApellido.Text;
                objEntDocen.Dni = long.Parse(txtDni.Text);
                objEntDocen.FechNac = dtpNacimiento.Value;
                objEntDocen.Sexo = ValorSexo();
                objEntDocen.Materia = cmbMateria.Text;
                objEntDocen.Legajo = long.Parse(txtLegajo.Text);
        }

        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDni.Text = string.Empty;
            dtpNacimiento.Value = DateTime.Now;
            cmbMateria.Text = string.Empty;
            txtLegajo.Text = string.Empty;
        }

        //private void Ds_a_TxtBox(DataSet dds)
        //{
        //    txtNombre.Text = dds.Tables[0].Rows[0]["Nombre"].ToString();
        //    txtApellido.Text = dds.Tables[0].Rows[0]["Apellido"].ToString();
        //    txtDni.Text = dds.Tables[0].Rows[0]["DNI"].ToString();
        //    txtLegajo.Text = dds.Tables[0].Rows[0]["Legajo"].ToString();
        //}

        private char ValorSexo()
        {
            char ValorSexo = char.Parse("X");
            if (this.rbF.Checked)
            {
                ValorSexo = char.Parse("F");
            }
            if (this.rbM.Checked)
            {
                ValorSexo = char.Parse("M");
            }
            return ValorSexo;
        }

        private void Obj_a_Txt()
        {
            txtNombre.Text = objEntDocen.Nombre.ToString();
            txtApellido.Text = objEntDocen.Apellido.ToString();
            txtDni.Text = objEntDocen.Dni.ToString();
            dtpNacimiento.Value = objEntDocen.FechNac;
            cmbMateria.Text = objEntDocen.Materia.ToString();
            txtLegajo.Text = objEntDocen.Legajo.ToString();
        }

        private void Dgv_a_Obj()
        {
                if (dgvDocentes.CurrentRow.Cells[0].Value.ToString() != string.Empty)
                {
                    objEntDocen.Nombre = Convert.ToString(dgvDocentes.CurrentRow.Cells[0].Value);
                }
                if (dgvDocentes.CurrentRow.Cells[1].Value.ToString() != string.Empty)
                {
                    objEntDocen.Apellido = Convert.ToString(dgvDocentes.CurrentRow.Cells[1].Value);
                }
                if (dgvDocentes.CurrentRow.Cells[2].Value.ToString() != string.Empty)
                {
                    objEntDocen.Dni = Convert.ToInt32(dgvDocentes.CurrentRow.Cells[2].Value);
                }
                if (dgvDocentes.CurrentRow.Cells[3].Value.ToString() != string.Empty)
                {
                    objEntDocen.FechNac = Convert.ToDateTime(dgvDocentes.CurrentRow.Cells[3].Value);
                }
                if (dgvDocentes.CurrentRow.Cells[4].Value.ToString() != string.Empty)
                {
                    objEntDocen.Sexo = Convert.ToChar(dgvDocentes.CurrentRow.Cells[4].Value);
                }
                if (dgvDocentes.CurrentRow.Cells[5].Value.ToString() != string.Empty)
                {
                    objEntDocen.Materia = Convert.ToString(dgvDocentes.CurrentRow.Cells[5].Value);
                }

                if (dgvDocentes.CurrentRow.Cells[6].Value.ToString() != string.Empty)
                {
                    objEntDocen.Legajo = Convert.ToInt32(dgvDocentes.CurrentRow.Cells[6].Value);
                }

        }

        //para los eventos de botones
        private void EligeError(int Grabados)
        {
            switch (Validaciones())
            {
                case 0:
                    {
                        errorProvider1.SetError(groupBoxA, "");
                        InfGrabar(Grabados);
                        break;
                    }
                case 1:
                    {
                        errorProvider1.SetError(groupBoxA, "Deben estar completos todos los campos");
                        break;
                    }
                case 2:
                    {
                        errorProvider1.SetError(groupBoxA, "El DNI y el Legajo deben ser ingresados solo con numeros");
                        break;
                    }
                case 3:
                    {
                        errorProvider1.SetError(groupBoxA, "El Nombre y el Apellido deben ser ingresados solo con letras");
                        break;
                    }
            }
            int Validaciones()
            {
                if ((txtNombre.Text == string.Empty) || (txtApellido.Text == string.Empty) || (txtDni.Text == string.Empty) || (txtLegajo.Text == string.Empty))
                {
                    return 1;
                }
                else
                {                   
                    if (!(txtDni.Text.All(Char.IsDigit)) || (txtDni.Text == "") || !(txtLegajo.Text.All(Char.IsDigit)) || (txtLegajo.Text == ""))
                    {
                        return 2;
                    }
                    if (!(txtNombre.Text.All(Char.IsLetter)) || !(txtApellido.Text.All(Char.IsLetter)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        private void InfGrabar(int Grabados)
        {
            switch (Grabados)
            {
                case 1:
                    {
                        int nGrabados = -1;
                        //llamo al método que carga los datos del objeto
                        TxtBox_a_Obj();
                        //invoco a la capa de negocio
                        nGrabados = objNegDocentes.ambDocentes("Agregar", objEntDocen);
                        if (nGrabados == -1)
                            lblMensaje.Text = " No pudo grabar docentes en el sistema";
                        else
                        {
                            MessageBox.Show(" Se cargó a " + objEntDocen.Nombre + " " + objEntDocen.Apellido + " con éxito.", "Aviso");
                            LlenarDGVDocente();
                            Limpiar();
                        }
                        break;
                    }
                case 2:
                    {
                        int nResultado = -1;
                        TxtBox_a_Obj();
                        nResultado = objNegDocentes.ambDocentes("Modificar", objEntDocen);//invoco a la capa de negocio
                        if (nResultado != -1)
                        {
                            MessageBox.Show("El Alumno " + objEntDocen.Nombre + " " + objEntDocen.Apellido + " fue Modificado con éxito", "Aviso");
                            Limpiar();
                            LlenarDGVDocente();
                        }
                        else
                            lblMensaje.Text = "Se produjo un error al intentar modificar el Docente";
                        break;
                    }

                case 3:
                    {
                        int nEliminados = -1;
                        //llamo al método que carga los datos del objeto
                        TxtBox_a_Obj();
                        nEliminados = objNegDocentes.ambDocentes("Eliminar", objEntDocen); //invoco a la capa de negocio
                        if (nEliminados == -1)
                            lblMensaje.Text = " No pudo Eliminar docentes en el sistema";
                        else
                        {
                            MessageBox.Show(" Se eliminó a " + objEntDocen.Nombre + " " + objEntDocen.Apellido + " con éxito.", "Aviso");
                            LlenarDGVDocente();
                            Limpiar();
                        }
                        break;
                    }
            }
        }
        #endregion

        #region Eventos        

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int Grabados = 1;
            EligeError(Grabados);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
           int Grabados = 2;
            EligeError(Grabados);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int Grabados = 3;
                EligeError(Grabados);
            }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dgvDocentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Dgv_a_Obj();
            Obj_a_Txt();
        }
        #endregion
    }
}
