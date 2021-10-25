
namespace ProgramacionDos
{
    partial class FormAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.groupBoxA = new System.Windows.Forms.GroupBox();
            this.rbX = new System.Windows.Forms.RadioButton();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.rbF = new System.Windows.Forms.RadioButton();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(711, 357);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(610, 357);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(408, 357);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 8;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // groupBoxA
            // 
            this.groupBoxA.Controls.Add(this.rbX);
            this.groupBoxA.Controls.Add(this.cmbCarrera);
            this.groupBoxA.Controls.Add(this.txtApellido);
            this.groupBoxA.Controls.Add(this.label7);
            this.groupBoxA.Controls.Add(this.txtLegajo);
            this.groupBoxA.Controls.Add(this.txtDni);
            this.groupBoxA.Controls.Add(this.txtNombre);
            this.groupBoxA.Controls.Add(this.dtpNacimiento);
            this.groupBoxA.Controls.Add(this.rbF);
            this.groupBoxA.Controls.Add(this.rbM);
            this.groupBoxA.Controls.Add(this.label6);
            this.groupBoxA.Controls.Add(this.label5);
            this.groupBoxA.Controls.Add(this.label4);
            this.groupBoxA.Controls.Add(this.label3);
            this.groupBoxA.Controls.Add(this.label2);
            this.groupBoxA.Controls.Add(this.label1);
            this.errorProvider1.SetIconAlignment(this.groupBoxA, System.Windows.Forms.ErrorIconAlignment.TopLeft);
            this.groupBoxA.Location = new System.Drawing.Point(21, 189);
            this.groupBoxA.Name = "groupBoxA";
            this.groupBoxA.Size = new System.Drawing.Size(765, 160);
            this.groupBoxA.TabIndex = 12;
            this.groupBoxA.TabStop = false;
            // 
            // rbX
            // 
            this.rbX.AutoSize = true;
            this.rbX.Checked = true;
            this.rbX.Location = new System.Drawing.Point(643, 38);
            this.rbX.Name = "rbX";
            this.rbX.Size = new System.Drawing.Size(45, 17);
            this.rbX.TabIndex = 15;
            this.rbX.TabStop = true;
            this.rbX.Text = "Otro";
            this.rbX.UseVisualStyleBackColor = true;
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Items.AddRange(new object[] {
            "Contador Público",
            "Ingeniería Aeronáutica",
            "Ingeniería Ambiental",
            "Ingeniería Biomédica",
            "Ingeniería Civil",
            "Ingeniería Electromecánica",
            "Ingeniería Electrónica",
            "Ingeniería en Agrimensura",
            "Ingeniería en Computación",
            "Ingeniería Industrial",
            "Ingeniería Mecánica",
            "Ingeniería en Química",
            "Licenciatura en Administración",
            "Licenciatura en Economía",
            "Licenciatura en Astronomía",
            "Licenciatura en Ciencias de la Computación",
            "Licenciatura en Física",
            "Licenciatura en Matemática"});
            this.cmbCarrera.Location = new System.Drawing.Point(448, 74);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(217, 21);
            this.cmbCarrera.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(76, 62);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(183, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Apellido:";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(448, 118);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(100, 20);
            this.txtLegajo.TabIndex = 7;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(76, 95);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(76, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(263, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Location = new System.Drawing.Point(139, 135);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpNacimiento.TabIndex = 3;
            // 
            // rbF
            // 
            this.rbF.AutoSize = true;
            this.rbF.Location = new System.Drawing.Point(551, 38);
            this.rbF.Name = "rbF";
            this.rbF.Size = new System.Drawing.Size(71, 17);
            this.rbF.TabIndex = 5;
            this.rbF.Text = "Femenino";
            this.rbF.UseVisualStyleBackColor = true;
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Location = new System.Drawing.Point(457, 38);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(73, 17);
            this.rbM.TabIndex = 4;
            this.rbM.Text = "Masculino";
            this.rbM.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(384, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Legajo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Carrera:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sexo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Nacimiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DNI:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AllowUserToAddRows = false;
            this.dgvAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.DNI,
            this.Nacimiento,
            this.Sexo,
            this.Carrera,
            this.Legajo});
            this.dgvAlumnos.Location = new System.Drawing.Point(21, 17);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.Size = new System.Drawing.Size(767, 150);
            this.dgvAlumnos.TabIndex = 11;
            this.dgvAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumnos_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // Nacimiento
            // 
            this.Nacimiento.HeaderText = "Nacimiento";
            this.Nacimiento.Name = "Nacimiento";
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            // 
            // Carrera
            // 
            this.Carrera.HeaderText = "Carrera";
            this.Carrera.Name = "Carrera";
            // 
            // Legajo
            // 
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.Name = "Legajo";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(28, 174);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje.TabIndex = 14;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(509, 357);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 390);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.groupBoxA);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGrabar);
            this.Name = "FormAlumno";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Alumno";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBoxA.ResumeLayout(false);
            this.groupBoxA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.GroupBox groupBoxA;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.RadioButton rbF;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RadioButton rbX;
    }
}