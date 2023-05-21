using parcialUno.essentials.models;
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

namespace parcialUno
{
    public partial class FormGrafico : Form
    {
        Chart chartGrafico;
        public FormGrafico()
        {
            InitializeComponent();
            InitializeChart();
        }
        private void InitializeChart()
        {
            chartGrafico = new Chart();

            chartGrafico.Size = new System.Drawing.Size(600, 300);
            chartGrafico.Location = new System.Drawing.Point(40, 40);
            chartGrafico.BackColor = Color.LightGray;

            ChartArea chartArea = new ChartArea("MiArea");

            chartGrafico.ChartAreas.Add(chartArea);

            Controls.Add(chartGrafico);
        }

        private async Task AñadirDatosChart()
        {
            chartGrafico.Series.Clear();

            Series series = new Series("Productos Comprados");
            series.ChartType = SeriesChartType.Column;
            ListaVentas ventas = new ListaVentas();


            await ventas.CargarFireAsync();
            var ventasDict = ventas.CalcularCantidad();
            foreach (string clave in ventasDict.Keys)
            {
                series.Points.AddXY(clave, ventasDict[clave]);
            }

            chartGrafico.Series.Add(series);
        }

        private async void FormGrafico_Load(object sender, EventArgs e)
        {
            await AñadirDatosChart();
        }
    }
}
