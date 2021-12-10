using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;

namespace AgendaApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        AgendaManager admAgenda;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Agenda agenda = new Agenda()
                {
                    Id_Agenda = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()),
                    Nombre = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    Apellido = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(),
                    Fecha_de_nacimiento = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString(),
                    Direccion = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString(),
                    Genero = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString(),
                    Estado_civil = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString(),
                    Movil = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString(),
                    Telefono = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString(),
                    Correo_Electronico = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString(),
                };

                txtId.Text = agenda.Id_Agenda.ToString();
                txtNombre.Text = agenda.Nombre;
                txtApellido.Text = agenda.Apellido;
                dateTimePicker.Text = (agenda?.Fecha_de_nacimiento ?? DateTime.Now.ToString());
                txtDir.Text = agenda.Direccion;
                txtMovil.Text = agenda.Movil;
                txtTel.Text = agenda.Telefono;
                txtCorreo.Text = agenda.Correo_Electronico;

                switch (agenda.Genero)
                {
                    case "Masculino": radGenM.Checked = true; break;
                    case "Femenino": radGenF.Checked = true; break;
                    case "Otro": radGenO.Checked = true; break;
                }

                switch (agenda.Estado_civil)
                {
                    case "Divorciado/a": radDivorciado.Checked = true; break;
                    case "Viudo/a": radViudo.Checked = true; break;
                    case "Soltero/a": radSoltero.Checked = true; break;
                    case "Casado/a": radCasado.Checked = true; break;
                }
            }
            else if (e.ColumnIndex == 1)
            {
                DialogResult dialog = MessageBox.Show("¿Esta seguro de eliminar este registro?", "Advertencia", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    Agenda agenda = new Agenda();
                    agenda.Nombre = txtNombre.Text;
                    agenda.Apellido = txtApellido.Text;
                    agenda.Fecha_de_nacimiento = (dateTimePicker.Text);
                    agenda.Direccion = txtDir.Text;
                    agenda.Movil = txtMovil.Text;
                    agenda.Telefono = txtTel.Text;
                    agenda.Correo_Electronico = txtCorreo.Text;

                    if (radGenM.Checked)
                        agenda.Genero = "Masculino";
                    else if (radGenF.Checked)
                        agenda.Genero = "Femenino";
                    else if (radGenO.Checked)
                        agenda.Genero = "Otro";

                    if (radDivorciado.Checked)
                        agenda.Estado_civil = "Divorciado/a";
                    else if (radViudo.Checked)
                        agenda.Estado_civil = "Viudo/a";
                    else if (radSoltero.Checked)
                        agenda.Estado_civil = "Soltero/a";
                    else if (radCasado.Checked)
                        agenda.Estado_civil = "Casado/a";

                    admAgenda = new AgendaManager();
                    admAgenda.PutAgenda(agenda, 1);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Agenda agenda = new Agenda();

            //txtNombre.Text = "";
            //txtApellido.Text = "";
            //dateTimePicker.Text = "";
            //txtDir.Text = "";
            //txtMovil.Text = "";
            //txtTel.Text = "";
            //txtCorreo.Text = "";

            //string genero = "";
            //string estado = "";

            //if (radGenM.Checked)
            //    genero = "Masculino";
            //else if (radGenF.Checked)
            //    genero = "Femenino";
            //else if (radGenO.Checked)s
            //    genero = "Otro";

            //if (radDivorciado.Checked)
            //    estado = "Divorciado/a";
            //else if (radViudo.Checked)
            //    estado = "Viudo/a";
            //else if (radSoltero.Checked)
            //    estado = "Soltero/a";
            //else if (radCasado.Checked)
            //    estado = "Casado/a";

            //agenda.Genero = genero;
            //agenda.Estado_civil = estado;

            Agenda agenda = new Agenda();
            agenda.Nombre = txtNombre.Text;
            agenda.Apellido = txtApellido.Text;
            agenda.Fecha_de_nacimiento = (dateTimePicker.Text);
            agenda.Direccion = txtDir.Text;
            agenda.Movil = txtMovil.Text;
            agenda.Telefono = txtTel.Text;
            agenda.Correo_Electronico = txtCorreo.Text;

            if (radGenM.Checked)
                agenda.Genero = "Masculino";
            else if (radGenF.Checked)
                agenda.Genero = "Femenino";
            else if (radGenO.Checked)
                agenda.Genero = "Otro";

            if (radDivorciado.Checked)
                agenda.Estado_civil = "Divorciado/a";
            else if (radViudo.Checked)
                agenda.Estado_civil = "Viudo/a";
            else if (radSoltero.Checked)
                agenda.Estado_civil = "Soltero/a";
            else if (radCasado.Checked)
                agenda.Estado_civil = "Casado/a";


            admAgenda = new AgendaManager();

            if (txtId.Text != "")
            {
                agenda.Id_Agenda = int.Parse(txtId.Text);

                DialogResult dialog = MessageBox.Show("¿Esta seguro de editar este registro?", "Advertencia", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                    admAgenda.PutAgenda(agenda, 0);
            }
            else 
                admAgenda.PutAgenda(agenda, 0);


            txtId.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            dateTimePicker.Text = "";
            txtDir.Text = "";
            txtMovil.Text = "";
            txtTel.Text = "";
            txtCorreo.Text = "";
            admAgenda = new AgendaManager();
            dataGridView1.DataSource = admAgenda.GetAgenda(new Agenda());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            admAgenda = new AgendaManager();
            dataGridView1.DataSource = admAgenda.GetAgenda(new Agenda());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = default;
            string x = txtBuscar.Text.Trim();
            admAgenda = new AgendaManager();
            dataGridView1.DataSource = admAgenda.LookAgenda(x);
        }
    }
}
