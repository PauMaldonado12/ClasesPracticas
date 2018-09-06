using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMenu
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comprarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario fu = new frmUsuario();
            fu.ShowDialog();

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducto fp = new frmProducto();
            fp.ShowDialog();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //el dialog se usa para q la segunda ventana q llamo hasta q no se cierre no pueda volver a la anterior.
            frmInforme fventa = new frmInforme();
            fventa.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            // el cancel es un valor booleano que preg si se quiere cerrar o no una ventana, se usa con un if.
            if (MessageBox.Show("¿Desea salir?", 
                "Salir",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1)
                == DialogResult.OK)
                e.Cancel = false;
            else
                e.Cancel = true;

        }
    }
}
