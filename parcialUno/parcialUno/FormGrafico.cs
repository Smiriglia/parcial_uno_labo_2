using parcialUno.essentials.models;
using parcialUno.essentials.utilidades;
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
        Chart? chartGrafico;
        private Dictionary<string, int> _ventasDict;
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

        private async Task AñadirDatosChartAsync()
        {
            chartGrafico.Series.Clear();

            Series series = new Series("Productos Comprados");
            series.ChartType = SeriesChartType.Column;
            ListaVentas ventas = new ListaVentas();


            await ventas.CargarFireAsync();
            _ventasDict = ventas.CalcularCantidad();
            foreach (string clave in _ventasDict.Keys)
            {
                series.Points.AddXY(clave, _ventasDict[clave]);
            }

            chartGrafico.Series.Add(series);
        }

        private async void FormGrafico_Load(object sender, EventArgs e)
        {
            try
            {
                await AñadirDatosChartAsync();
            }
            catch
            {
                MessageBox.Show("Error al cargar los datos",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string path = saveFileDialog1.FileName;

                    Serializador ser = new Serializador(path);
                    ser.Serializar(_ventasDict);
                    MessageBox.Show("Datos exportados correctamente",
                            "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
