using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Ahorcado2
{
    public partial class Form1 : Form
    {
        int opcion;

        public Form1()
        {
            InitializeComponent();
            SoundPlayer sonido = new SoundPlayer();
            sonido.Stream = Properties.Resources.逃走中BGM___Running_One;
            sonido.PlayLooping();
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            opcion = 2;
            Form2 formulario2 = new Form2(opcion);
            formulario2.Show();
            formulario2.Visible = true;
            this.Visible = false;
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            opcion = 1;
            Form2 formulario2 = new Form2(opcion);
            formulario2.Show();
            formulario2.Visible = true;
            this.Visible = false;
        }

        private void btnDifficutl_Click(object sender, EventArgs e)
        {
            opcion = 3;
            Form2 formulario2 = new Form2(opcion);
            formulario2.Show();
            formulario2.Visible = true;
            this.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
