using Compilador.Clases;
namespace Compilador
{
    public partial class Form1 : Form
    {
<<<<<<< HEAD
        Comp analizador;
        public Form1()
        {
            analizador = new Comp();
            InitializeComponent();
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            analizador.analizar(textBox1.Text);
            dataGridView2.DataSource = analizador.lexico.lexemas;
            dataGridView1.DataSource = analizador.salidas;

=======
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anLex analizador = new anLex();
            analizador.analizar(textBox1.Text);
            dataGridView1.DataSource = analizador.lexemas;
>>>>>>> 01eea31e66e6daebeef2051cd739b3cb466e6d4e
        }
    }
}