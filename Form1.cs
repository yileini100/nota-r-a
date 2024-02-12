using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            int nota1, nota2, nota3, nota4, promedio;
            string situacion;

            nota1 = int.Parse(txt_nota1.Text);
            nota2 = int.Parse(txt_nota2.Text);
            nota3 = int.Parse(txt_nota3.Text);
            nota4 = int.Parse(txt_nota4.Text);

            promedio = (nota1 + nota2 + nota3 + nota4) / 4;

            
            if (promedio >= 70)
            {
                situacion = "Aprobado";
                txt_situacion.ForeColor = Color.Green;
            }
            else
            {
                situacion = "Reprobado";
                txt_situacion.ForeColor = Color.Red;
            }

           
            txt_promedio.Text = promedio.ToString();
            txt_situacion.Text = situacion;
        }

        private void btn_limpiar_Click_1(object sender, EventArgs e)
        {
            txt_nota1.Clear();
            txt_nota2.Clear();
            txt_nota3.Clear();
            txt_nota4.Text = string.Empty;
            txt_promedio.Clear();
            txt_situacion.Clear();
        }
    }
}

