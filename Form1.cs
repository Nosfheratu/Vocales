using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vocales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtA.Text = txtE.Text = txtI.Text = txtO.Text = txtU.Text = "0";
            lblLetraMayor.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtA.Text = txtE.Text = txtI.Text = txtO.Text = txtU.Text = "0";
            lblLetraMayor.Text = "";
        }
        
        private void ActualizarResultado(TextBox objeto)
        {
            objeto.Text = (Convert.ToInt32(objeto.Text) + 1).ToString();

            List<TextBox> listaVocales = new List<TextBox>() { txtA, txtE, txtI, txtO, txtU };

            var vocal = listaVocales.OrderByDescending(t=>Convert.ToInt32(t.Text)).First().Name.Substring(3);

            lblLetraMayor.Text = string.Format("La mas alta es {0}", vocal);
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            ActualizarResultado(txtA);
        }
        
        private void btnE_Click(object sender, EventArgs e)
        {
            ActualizarResultado(txtE);
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            ActualizarResultado(txtI);
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            ActualizarResultado(txtO);
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            ActualizarResultado(txtU);
        }
    }
}
