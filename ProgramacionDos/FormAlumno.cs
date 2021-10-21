using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//todo: falta darle funcionalidad
namespace ProgramacionDos
{
    public partial class FormAlumno : Form
    {
        
        public Alumno objEntAlum = new Alumno();
        public NegAlumnos objNegAlumnos = new NegAlumnos();

        public FormAlumno()
        {
            InitializeComponent();
            dgvAlumnos.ColumnCount = 7;
            dgvAlumnos.Columns[0].HeaderText = "Nombre";
            dgvAlumnos.Columns[1].HeaderText = "Apellido";
            dgvAlumnos.Columns[2].HeaderText = "DNI";
            dgvAlumnos.Columns[3].HeaderText = "Nacimiento";
            dgvAlumnos.Columns[4].HeaderText = "Sexo";
            dgvAlumnos.Columns[4].Width = 40;
            dgvAlumnos.Columns[5].HeaderText = "Carrera";
            dgvAlumnos.Columns[6].HeaderText = "Legajo";            
            LlenarDGVAlumno();
        }

        #region Metodos

        private void LlenarDGVAlumno()
        {
            dgvAlumnos.Rows.Clear();

            DataSet dds = new DataSet();

            dds = objNegAlumnos.listadoAlumnos("Todos");

            if (dds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow ddr in dds.Tables[0].Rows)
                {
                    //Lo que quieres mostrar esta en dr[0].ToString(), dr[1].ToString(),etc.
                    dgvAlumnos.Rows.Add(ddr[0], ddr[1], ddr[2], Convert.ToDateTime(ddr[3]).ToShortDateString(), ddr[4], ddr[5], ddr[6]);

                }
            }
            else
                lblMensaje.Text = "No hay Alumnos cargados en el sistema";
        }


        private void TxtBox_a_Obj() //Prepara el objeto a enviar a la capa de Negocio
        {
            objEntAlum.Nombre = txtNombre.Text;
            objEntAlum.Apellido = txtApellido.Text;
            objEntAlum.Dni = long.Parse(txtDni.Text);
            objEntAlum.FechNac = dtpNacimiento.Value;
            objEntAlum.Sexo = ValorSexo();
            objEntAlum.Carrera = cmbCarrera.Text;
            objEntAlum.Legajo = long.Parse(txtLegajo.Text);
        }

        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDni.Text = string.Empty;
            dtpNacimiento.Value = DateTime.Now;
            cmbCarrera.Text = string.Empty;
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
            txtNombre.Text = objEntAlum.Nombre.ToString();
            txtApellido.Text = objEntAlum.Apellido.ToString();
            txtDni.Text = objEntAlum.Dni.ToString();
            dtpNacimiento.Value = objEntAlum.FechNac;
            cmbCarrera.Text = objEntAlum.Carrera.ToString();
            txtLegajo.Text = objEntAlum.Legajo.ToString();
        }

        private void Dgv_a_Obj()
        {

            if (dgvAlumnos.CurrentRow.Cells[0].Value.ToString() != string.Empty)
            {
                objEntAlum.Nombre = Convert.ToString(dgvAlumnos.CurrentRow.Cells[0].Value);
            }
            if (dgvAlumnos.CurrentRow.Cells[1].Value.ToString() != string.Empty)
            {
                objEntAlum.Apellido = Convert.ToString(dgvAlumnos.CurrentRow.Cells[1].Value);
            }
            if (dgvAlumnos.CurrentRow.Cells[2].Value.ToString() != string.Empty)
            {
                objEntAlum.Dni = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[2].Value);
            }
            if (dgvAlumnos.CurrentRow.Cells[3].Value.ToString() != string.Empty)
            {
                objEntAlum.FechNac = Convert.ToDateTime(dgvAlumnos.CurrentRow.Cells[3].Value);
            }
            if (dgvAlumnos.CurrentRow.Cells[4].Value.ToString() != string.Empty)
            {
                objEntAlum.Sexo = Convert.ToChar(dgvAlumnos.CurrentRow.Cells[4].Value);
            }
            if (dgvAlumnos.CurrentRow.Cells[5].Value.ToString() != string.Empty)
            {
                objEntAlum.Carrera = Convert.ToString(dgvAlumnos.CurrentRow.Cells[5].Value);
            }

            if (dgvAlumnos.CurrentRow.Cells[6].Value.ToString() != string.Empty)
            {
                objEntAlum.Legajo = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[6].Value);
            }


        }

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
                        nGrabados = objNegAlumnos.ambAlumnos("Agregar", objEntAlum);
                        if (nGrabados == -1)
                            lblMensaje.Text = " No pudo grabar al alumno en el sistema";
                        else
                        {
                            MessageBox.Show(" Se cargó a " + objEntAlum.Nombre + " " + objEntAlum.Apellido + " con éxito.", "Aviso");
                            LlenarDGVAlumno();
                            Limpiar();
                        }
                        break;
                    }
                case 2:
                    {
                        int nResultado = -1;
                        TxtBox_a_Obj();
                        nResultado = objNegAlumnos.ambAlumnos("Modificar", objEntAlum);//invoco a la capa de negocio
                        if (nResultado != -1)
                        {
                            MessageBox.Show("El Alumno "+ objEntAlum.Nombre + " " + objEntAlum.Apellido +" fue Modificado con éxito", "Aviso");
                            Limpiar();
                            LlenarDGVAlumno();
                        }
                        else
                            lblMensaje.Text = "Se produjo un error al intentar modificar el Alumno";
                        break;
                    }

                case 3:
                    {
                        int nEliminados = -1;
                        //llamo al método que carga los datos del objeto
                        TxtBox_a_Obj();
                        nEliminados = objNegAlumnos.ambAlumnos("Eliminar", objEntAlum); //invoco a la capa de negocio
                        if (nEliminados == -1)
                            lblMensaje.Text = " No pudo Eliminar al alumno en el sistema";
                        else
                        {
                            MessageBox.Show(" Se eliminó a " + objEntAlum.Nombre + " " + objEntAlum.Apellido + " con éxito.", "Aviso");
                            LlenarDGVAlumno();
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

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            int Grabados = 2;
            EligeError(Grabados);

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            int Grabados = 3;
            EligeError(Grabados);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Dgv_a_Obj();
            Obj_a_Txt();
        }


        #endregion

    }
}
