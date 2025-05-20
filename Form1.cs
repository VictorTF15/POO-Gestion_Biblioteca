using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBiblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string email = textBox2.Text;
            string namebook = textBox3.Text;
            string autor = textBox4.Text;

            Usuario user = new Usuario(name, email);
            Libro book = new Libro(namebook, autor);

            book.Give();

            Prestamo give = new Prestamo(user, book);
            label5.Text = give.ShowInfo();
        }
    }
}
