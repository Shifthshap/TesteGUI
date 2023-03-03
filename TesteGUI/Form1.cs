using System;
using System.Drawing;
using System.Windows.Forms;

namespace TesteGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.Text = "Jardel Mandel";
            //this.Size = new Size(600 , 400);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Carregando a Form";
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.Text = "Clicando na Form";
            this.Size = new Size(500, 300);
        }

        public void MeuMetodo(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            button1.Size = new Size(100, 80);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Clicou no botão";
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Evento mouse enter acionado";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "Evento mouse leave acionado";
        }
    }
}
