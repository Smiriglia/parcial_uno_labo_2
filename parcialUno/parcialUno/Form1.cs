using parcialUno.essentials.models;

namespace parcialUno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        public async Task AddAsync()
        {
            var value = await Fire.Add();
            MessageBox.Show(value);

        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = await Fire.Add();
            MessageBox.Show(nombre);
        }
    }
}