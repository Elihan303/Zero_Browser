using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavegadorWeb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Navegador.GoBack();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Navegador.Navigate(Url.Text);
        }

        private void Ahead_Click(object sender, EventArgs e)
        {
            Navegador.GoForward();
        }

        private void Refrescar_Click(object sender, EventArgs e)
        {
            Navegador.Refresh();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Navegador.Stop();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Navegador.GoHome();
        }
    }
}
