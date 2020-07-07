using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio
{
    public partial class asigAdd : Form
    {
       
        private static string vpath = AppDomain.CurrentDomain.BaseDirectory + "asignatura.csv";
        public asigAdd()
        {
            InitializeComponent();
        }


        private void asigClavetxt_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void asigCredittxt_TextChanged(object sender, EventArgs e)
        {
            string credit = Process.Digit(asigCredittxt.Text);
        }

        private void asigNomtxt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void asigAddbtn_Click(object sender, EventArgs e)
        {
            string clave = Process.Input(asigClavetxt.Text);
            string asigNom = Process.Input(asigNomtxt.Text);
            if (Verifier.Srch(clave, 2) == false)
            {
                File.AppendAllText(vpath, $"{clave},{asigNom},{asigCredittxt.Text}" + Environment.NewLine);
            }

            asigCredittxt.Clear();
            asigClavetxt.Clear();
            asigNomtxt.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void asigClavelab_Click(object sender, EventArgs e)
        {

        }
    }
}
