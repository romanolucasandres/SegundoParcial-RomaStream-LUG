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
    public partial class InformeMenor : Form
    {
        BLLLive live;
        public InformeMenor()
        {
            InitializeComponent();
        }
        private void MostrarMenorStreamingEnChart()
        {
            try
            {
                live = new BLLLive();
                List<BEStreaming> lista = live.Traer();

                if (lista != null)
                {
                    var streamingPorCategoria = lista
                        .Where(s => !string.IsNullOrWhiteSpace(s.Categoria))
                        .GroupBy(s => s.Categoria)
                        .Select(group => new
                        {
                            Categoria = group.Key,
                            MenorStreaming = group.OrderBy(s => s.Duracion).FirstOrDefault()
                        });

                    chart1.Titles.Clear();
                    chart1.Series.Clear();

                    chart1.Titles.Add("Menor Streaming por Categoría");

                    Series serieDuracion = new Series("Duración");
                    serieDuracion.ChartType = SeriesChartType.Column;
                    Series serieMontoRecaudado = new Series("Monto Recaudado");
                    serieMontoRecaudado.ChartType = SeriesChartType.Column;

                    foreach (var categoriaStreaming in streamingPorCategoria)
                    {
                        if (categoriaStreaming.MenorStreaming != null)
                        {
                            var streaming = categoriaStreaming.MenorStreaming;
                            decimal valor = streaming.Valor;
                            int duracion = streaming.Duracion;
                            decimal montoRecaudado = valor * (duracion / 30);

                            serieDuracion.Points.AddXY(categoriaStreaming.Categoria, duracion);
                            serieMontoRecaudado.Points.AddXY(categoriaStreaming.Categoria, montoRecaudado);
                        }
                    }

                    chart1.Series.Add(serieDuracion);
                    chart1.Series.Add(serieMontoRecaudado);
                }
                else
                    throw new Exception("No hay datos en la lista.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void InformeMenor_Load(object sender, EventArgs e)
        {
            MostrarMenorStreamingEnChart();
        }
    }
}
