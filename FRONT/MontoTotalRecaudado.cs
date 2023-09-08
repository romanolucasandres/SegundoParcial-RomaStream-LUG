using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FRONT
{
    public partial class MontoTotalRecaudado : Form
    {
        BLLLive live;
        public MontoTotalRecaudado()
        {
            InitializeComponent();
        }
        private void MostrarMontoRecaudadoPorCategoria()
        {
            try
            {
                live = new BLLLive();
                List<BEStreaming> lista = live.Traer();

                if (lista != null)
                {
                    var montoPorCategoria = lista
                        .Where(s => !string.IsNullOrWhiteSpace(s.Categoria))
                        .GroupBy(s => s.Categoria)
                        .Select(group => new
                        {
                            Categoria = group.Key,
                            MontoTotal = group.Sum(s => s.Valor * (s.Duracion / 30))
                        });

                    chart1.Titles.Clear();
                    chart1.Series.Clear();

                    chart1.Titles.Add("Monto Recaudado por Categoría");

                    Series serieMonto = new Series("Monto Recaudado");
                    serieMonto.ChartType = SeriesChartType.Column;

                    foreach (var categoriaMonto in montoPorCategoria)
                    {
                        serieMonto.Points.AddXY(categoriaMonto.Categoria, categoriaMonto.MontoTotal);
                    }

                    chart1.Series.Add(serieMonto);
                }
                else
                    throw new Exception("No hay datos en la lista.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MontoTotalRecaudado_Load(object sender, EventArgs e)
        {
            MostrarMontoRecaudadoPorCategoria();
        }
    }
}
