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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace FRONT
{
    public partial class ABMStreaming : Form
    {
        BLLCliente cliente;
      
        BLLStreaming streamingStreaming;
        public ABMStreaming()
        {
            InitializeComponent();
            cliente = new BLLCliente();
            streamingStreaming = new BLLVOD();
            
        }

        private void ABMStreaming_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(Categoria));
            comboBox1.SelectedIndex = 0;
            comboBox1.Text = "Selecciona";

            comboBox2.DataSource = Enum.GetValues(typeof(Stream));
            comboBox2.SelectedIndex = 0;
            comboBox2.Text = "Selecciona";
            
            comboBox3.DataSource = Enum.GetValues(typeof(Reproduccion));
            comboBox3.SelectedIndex = 0;
            comboBox3.Text = "Selecciona";

            comboBox4.DataSource = cliente.Traer();
            //comboBox4.SelectedIndex = 0;
            comboBox4.ValueMember = "Codigo";
            comboBox4.Text = "Selecciona";

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = streamingStreaming.Traer();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ExpresionesRegulares.ValidarSoloNumeros(textBox1.Text) == false)
            {
                throw new Exception("El Codigo solo debe contener números");
            }
            DateTime d = new DateTime();
            d = dateTimePicker1.Value;

            if (comboBox2.SelectedIndex == 0)
            {
                BELive streaming = new BELive();
                streamingStreaming = new BLLLive();
                if (ExpresionesRegulares.ValidarSoloNumeros(textBox1.Text) == false)
                {
                    throw new Exception("El Codigo solo debe contener números");
                }
                streaming.Codigo = Convert.ToInt32(textBox1.Text);
                streaming.Categoria=comboBox1.SelectedItem.ToString();
                var y = streaming.Categoria;
                streaming.Duracion = Convert.ToInt32(textBox3.Text);
                var x = streaming.Duracion;
                streaming.Stream=comboBox2.SelectedItem.ToString();
                streaming.Valor = streamingStreaming.Calcular(x,y);
                streaming.Fecha= Convert.ToDateTime(d.ToShortDateString());
                streaming.Cliente.Apellido = comboBox4.SelectedItem.ToString();
                streamingStreaming.Alta(streaming);
               
            }
            else
            {
                BEVOD streaming = new BEVOD();
                streamingStreaming = new BLLLive();
                if (ExpresionesRegulares.ValidarSoloNumeros(textBox1.Text) == false)
                {
                    throw new Exception("El Codigo solo debe contener números");
                }
                streaming.Codigo = Convert.ToInt32(textBox1.Text);
                streaming.Categoria = comboBox1.SelectedItem.ToString();
                var y = streaming.Categoria;
                streaming.Duracion = Convert.ToInt32(textBox3.Text);
                var x = streaming.Duracion;
                streaming.Stream = comboBox2.SelectedItem.ToString();
                streaming.Valor = streamingStreaming.Calcular(x, y);
                streaming.Reproduccion=comboBox3.SelectedItem.ToString();
                streaming.Cliente.Apellido = comboBox4.SelectedItem.ToString();
                streamingStreaming.Alta(streaming);
             
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = streamingStreaming.Traer();
            textBox1.Text = "";
            textBox3.Text = "";
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.Text == "Live") 
            {
                repro.Enabled= false;
                comboBox3.Enabled= false;
                label1.Enabled = true;
                dateTimePicker1.Enabled = true;
            }
            else if(comboBox2.Text =="VOD")
            {
                label1.Enabled= false;
                dateTimePicker1.Enabled= false;
                repro.Enabled = true;
                comboBox3.Enabled = true;
            }
        }
    }
}
