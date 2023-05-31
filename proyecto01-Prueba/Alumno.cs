namespace proyecto01_Prueba
{
    public partial class Alumno : Form
    {
        int tipoBoton = 0;
        public Alumno()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RefrescarAlumnos();
        }
        private void RefrescarAlumnos()
        {
            ConexionBD conexionBD = new ConexionBD();
            List<AlumnoBD> alumnos = new List<AlumnoBD>();
            alumnos = conexionBD.ObtenerListadoAlumnos();
            dataGridView1.DataSource = alumnos;
        }

        private void Alumno_Load(object sender, EventArgs e)
        {
            RefrescarAlumnos();
            HabilitarBotones(false);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int index = dataGridView1.CurrentRow.Index;
                txtId.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                txtNombre.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                txtApellido.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConexionBD coneccion = new ConexionBD();
            if (tipoBoton == 1)
            {
                String nombre = txtNombre.Text.Trim();
                String dni = txtApellido.Text.Trim();
                coneccion.CrearAlumnoNuevo(nombre, dni);
                txtNombre.Enabled = false;
                txtApellido.Enabled = false;
            }
            else if (tipoBoton == 2)
            {
                String nombre = txtNombre.Text.Trim();
                String dni = txtApellido.Text.Trim();
                Int32 id = Convert.ToInt32(txtId.Text.Trim());
                coneccion.EditarAlumno(id, nombre, dni);
                txtNombre.Enabled = false;
                txtApellido.Enabled = false;
            }
            RefrescarAlumnos();
            HabilitarBotones(false);
        }

        private void HabilitarBotones(bool nuevo)
        {
            if (nuevo)
            {
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button2.Enabled = true;
                button6.Enabled = true;
                dataGridView1.Enabled = false;
                button1.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button2.Enabled = false;
                button6.Enabled = false;
                dataGridView1.Enabled = true;
                button1.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // boton nuevo alumno
            HabilitarBotones(true);
            txtId.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            tipoBoton = 1;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // boton de editar alumno
            HabilitarBotones(true);
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            tipoBoton = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // eliminar un alumno
            ConexionBD coneccion = new ConexionBD();
            Int32 id = Convert.ToInt32(txtId.Text.Trim());
            coneccion.EliminarAlumno(id);
            RefrescarAlumnos();
            HabilitarBotones(false);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HabilitarBotones(false);
            RefrescarAlumnos();
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
        }
    }
}