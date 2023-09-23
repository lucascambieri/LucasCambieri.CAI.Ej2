namespace LucasCambieri.CAI.Ej2
{
    public partial class Form1 : Form
    {
        Ejercicio02Model modelo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            modelo = new Ejercicio02Model();
            this.marcaComboBox.Items.AddRange(modelo.Marcas);
            this.usuarioLabel.Text = modelo.NombreUsuario;
            this.nombreRealLabel.Text = modelo.NombreReal;
            this.marcaComboBox.SelectedIndex = 0;
            this.fechaActualLabel.Text = modelo.Fecha.ToString();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void AñoTexto_TextChanged(object sender, EventArgs e)
        {

        }

        private void marcaLabel_Click(object sender, EventArgs e)
        {

        }

        private void MarcaBoton_Click(object sender, EventArgs e)
        {
            modelo.Precio = this.precioText.Text;
            modelo.Modelo = this.modeloText.Text;
            modelo.Año = this.añoText.Text;
            modelo.Marca = (string)this.marcaComboBox.SelectedItem;

            string mensaje = modelo.Validar();
            MessageBox.Show(mensaje);
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("¿Está seguro que quiere cerrar el programa?", "Ejercicio02", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}