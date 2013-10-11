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

            Dictionary<TextBox, int> diccionario = new Dictionary<TextBox, int>();
            diccionario.Add(txtA, Convert.ToInt32(objeto.Text));
            diccionario.Add(txtE, Convert.ToInt32(objeto.Text));
            diccionario.Add(txtI, Convert.ToInt32(objeto.Text));
            diccionario.Add(txtO, Convert.ToInt32(objeto.Text));
            diccionario.Add(txtU, Convert.ToInt32(objeto.Text));

            var item = diccionario.Keys.OrderByDescending(t => Convert.ToInt32(t.Text)).First();

            lblLetraMayor.Text = string.Format("La mas alta es {0}", item.Name.Substring(3));
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
