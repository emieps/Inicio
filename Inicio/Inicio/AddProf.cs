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
    public partial class AddProf : Form
    {
        private static string vpath = AppDomain.CurrentDomain.BaseDirectory + "profesor.csv";
        
        public AddProf()
        {
            InitializeComponent();
        }

        private void AddProf_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void profIDtxt_TextChanged(object sender, EventArgs e)
        {
            string ID = Process.Digit(profIDtxt.Text);
        }

        private void profNomtxt_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void proAddBtn_Click(object sender, EventArgs e)
        {
            string profNom = profNomtxt.Text; 
            if (Verifier.Srch(Process.Input(profIDtxt.Text), 1) == false)
            {
                File.AppendAllText(vpath, $"{profIDtxt.Text},{profNom}" + Environment.NewLine);
            }

            profIDtxt.Clear();
            profNomtxt.Clear();
           
        }
    }
}
