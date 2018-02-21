using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNACH.Windows
{
    public partial class Modelo1 : Form
    {
        public Modelo1()
        {
            InitializeComponent();
        }

       

        int i = 0;

        private void btn_empezar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btn_pausar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label1.Text = "";
            i = 0;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i > 0 && i <= 9)
            {
                label1.Text = "0" + i.ToString() ;
            }
            else
            {
                label1.Text = i.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cambiar_Click(object sender, EventArgs e)
        {
            this.Hide();//metodo que oculta 
            Modelo2 obj = new Modelo2();//instanciacion de la clase
            obj.Show();
        }
    }
}
