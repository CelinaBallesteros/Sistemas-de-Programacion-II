using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distancia_de_dos_puntos
{
    public partial class FrmDistancia : Form
    {
        public FrmDistancia()
        {
            InitializeComponent();
        }   

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Txt_x1.Clear();
            Txt_x2.Clear();
            Txt_y1.Clear();
            Txt_y2.Clear();
            TxtDistancia.Clear() ;
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
             
            double x1 = double.Parse(Txt_x1.Text);
            double x2 = double.Parse(Txt_x2.Text);
            double y1 = double.Parse(Txt_y1.Text);
            double y2 = double.Parse(Txt_y2.Text);

            double Distancia = Math.Sqrt (((x2 - x1)*(x2 - x1)) + ((y2 - y1)*(y2-y1)));
            TxtDistancia.Text = Distancia.ToString();

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
