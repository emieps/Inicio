using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio
{
    public partial class asigEdit : Form
    {
        public asigEdit()
        {
            InitializeComponent();
        }

        private void asigClaveNomEdittxt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void asigNomNomEdittxt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void asigNomEdittbtn_Click(object sender, EventArgs e)
        {
            string vkeyNom = Process.Input(asigClaveNomEdittxt.Text);
            string vname = Process.Input(asigNomNomEdittxt.Text);
            Verifier.FindSub(vkeyNom, false, out bool vfound, out int vloc);
            if (vfound)
            {
                Modifier.Data(vname, 1, vloc, 2);
            }
        }

        private void asigClaveCreditEdittxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void asigCreditCreditEdittxt_TextChanged(object sender, EventArgs e)
        {
           string vpoint = Process.Digit(asigCreditCreditEdittxt.Text);
        }

        private void asigCreditEdittbtn_Click(object sender, EventArgs e)
        {
           string vkeyCredit = Process.Input(asigClaveCreditEdittxt.Text);
           string  vpoint = asigCreditCreditEdittxt.Text;
            Verifier.FindSub(vkeyCredit, false, out bool vfound, out int vloc);
            if (vfound)
            {
                Modifier.Data(vpoint, 2, vloc, 2);
            }
            
        }

        private void asigEdit_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
