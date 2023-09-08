using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRONT
{
    public partial class Menu : Form
    {
        ABMCliente ABMCliente;
        ABMStreaming ABMStreaming;
        InformeMayor Mayor;
        InformeMenor Menor;
        MontoTotalRecaudado monto;
        
        
        public Menu()
        {
            InitializeComponent();
        }

        private void aBMClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ABMCliente != null)
                ABMCliente.BringToFront();
            else
            {
                ABMCliente = new ABMCliente();
                ABMCliente.FormClosed += (o, args) => ABMCliente = null;
                ABMCliente.MdiParent = this;
                ABMCliente.Show();
            }
        }

        private void aBMStreamingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ABMStreaming != null)
                ABMStreaming.BringToFront();
            else
            {
                ABMStreaming = new ABMStreaming();
                ABMStreaming.FormClosed += (o, args) => ABMStreaming = null;
                ABMStreaming.MdiParent = this;
                ABMStreaming.Show();
            }
        }

        private void mayorDuraciónCategoríaYMontoRecaudadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Mayor != null)
                ABMCliente.BringToFront();
            else
            {
                Mayor = new InformeMayor();
                Mayor.FormClosed += (o, args) => Mayor = null;
                Mayor.MdiParent = this;
                Mayor.Show();
            }
        }

        private void menorDuraciónCategoríaYMontoRecaudadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Menor != null)
                Menor.BringToFront();
            else
            {
                Menor = new InformeMenor();
                Menor.FormClosed += (o, args) => Menor = null;
                Menor.MdiParent = this;
                Menor.Show();
            }
        }

        private void montoTotalPorCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (monto != null)
                monto.BringToFront();
            else
            {
                monto = new MontoTotalRecaudado();
                monto.FormClosed += (o, args) => monto = null;
                monto.MdiParent = this;
                monto.Show();
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
