using notas.Entidades;
using notas.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notas.vistas
{
    public partial class Proceso : Form
    {
        public int mate;
        public Proceso()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        ClsDatos cls = new ClsDatos();
        private void button1_Click(object sender, EventArgs e)
        {   
            
            string materia="";
            if (mate == 1)
            {
                materia = "poo";
            }
            if (mate == 2)
            {
                materia = "matematica";
            }
            if (mate == 3)
            {
                materia = "Software Utilitario";
            }
            if (mate == 4)
            {
                materia = "Base de datos";
            }
            if (mate == 5)
            {
                materia = "Psicologia";
            }

            cls.Labo1 = double.Parse(lab1.Text);
            cls.Labo2 = double.Parse(lab2.Text);
            cls.Labo3 = double.Parse(lab3.Text);
            cls.Parc1 = double.Parse(par1.Text);
            cls.Parc2 = double.Parse(par2.Text);
            cls.Parc3 = double.Parse(par3.Text);
            
            NClslogica proceso = new NClslogica();
            
            MessageBox.Show("los promedios de "+ materia+ " son\n"+proceso.calculo(cls));
            
            this.Close();

        }
    }
}
