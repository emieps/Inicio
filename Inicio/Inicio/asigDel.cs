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
    public partial class asigDel : Form
    {
        private static string vpath = AppDomain.CurrentDomain.BaseDirectory + "asignatura.csv";
       
        public asigDel()
        {
            InitializeComponent();
        }

        private void asigClaveDeltxt_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void asigDelbtn_Click(object sender, EventArgs e)
        {
            string clave = Process.Input(asigClaveDeltxt.Text); 
            Verifier.FindSub(clave, false, out bool vfound, out int vloc);
            if (vfound)
            {
                Modifier.Del(vloc, 2);
                MessageBox.Show("Eliminado correctamente", "Eliminado",
             MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(" No existe " , "Error",
              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
