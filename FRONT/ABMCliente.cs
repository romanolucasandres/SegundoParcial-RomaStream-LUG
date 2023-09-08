using BE;
using BLL;
using FRONT.REGEX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FRONT
{
    public partial class ABMCliente : Form
    {
        BECliente cliente;
        BLLCliente clientebll;
        public ABMCliente()
        {
            InitializeComponent();
            cliente = new BECliente();
            clientebll = new BLLCliente();
        }

        private void ABMCliente_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarDatos();
            clientebll.Alta(cliente);
            Mostrar();

        }

        private void CargarDatos()
        {
            if (ExpresionesRegulares.ValidarSoloNumeros(textBox1.Text) == false)
            {
                throw new Exception("El Codigo solo debe contener números");
            }
            cliente.Codigo = Convert.ToInt32(textBox1.Text);
            if (ExpresionesRegulares.ValidarSoloLetras(textBox2.Text) == false)
            {
                throw new Exception("El Nombre  solo debe contener letras.");
            }
            cliente.Nombre = textBox2.Text;
            if (ExpresionesRegulares.ValidarSoloLetras(textBox3.Text) == false)
            {
                throw new Exception("El apellido  solo debe contener letras.");
            }
            cliente.Apellido = textBox3.Text;

            if (ExpresionesRegulares.ValidarSoloNumeros(textBox1.Text) == false)
            {
                throw new Exception("El Codigo solo debe contener números");
            }
            cliente.DNI = textBox4.Text;

            cliente.Email = textBox5.Text;
        }

        private void Vaciar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void Mostrar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = clientebll.Traer();
        }

        private void ModoSeleccion()
        {
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            cliente.Codigo = Convert.ToInt32(textBox1.Text);
            if (ExpresionesRegulares.ValidarSoloLetras(textBox2.Text) == false)
            {
                throw new Exception("El Nombre  solo debe contener letras.");
            }
            cliente.Nombre = textBox2.Text;
            if (ExpresionesRegulares.ValidarSoloLetras(textBox3.Text) == false)
            {
                throw new Exception("El apellido  solo debe contener letras.");
            }
            cliente.Apellido = textBox3.Text;

            if (ExpresionesRegulares.ValidarSoloNumeros(textBox1.Text) == false)
            {
                throw new Exception("El Codigo solo debe contener números");
            }
            cliente.DNI = textBox4.Text;

            cliente.Email = textBox5.Text;

            clientebll.Modificar(cliente);
            Mostrar();
            Vaciar();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cliente.Codigo = Convert.ToInt32(textBox1.Text);

                DialogResult resultado = MessageBox.Show("Está por eliminar al cliente " +
                    cliente.ToString() + "¿Confirma esta acción?", "Confirmar", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    clientebll.Baja(cliente);
                    Mostrar();
                    Vaciar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cliente = (BECliente)dataGridView1.CurrentRow.DataBoundItem;
            textBox1.Text = cliente.Codigo.ToString();
            textBox2.Text = cliente.Nombre.ToString();
            textBox3.Text = cliente.Apellido.ToString();
            textBox4.Text= cliente.DNI.ToString();
            textBox5.Text= cliente.Email.ToString();
        }
    }
}
