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
    public partial class frmUsuario : Form
    {
        BDHelper oDatos = new BDHelper("Data Source=maquis;Initial Catalog=BugsHisto;User ID=avisuales1;Password=avisuales1");
        //bandera para incorporar/distinguir un usuario nuevo o no
        bool nuevo = false;

        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            //hay que deshabilitar los campos txt 
            //habilitar los botones que no necesito
            //creo una tabla y voy llenando sus filas con los campos que traigo desde la bdd.
            DataTable tabla = oDatos.consultarTabla("perfiles");
            cmbPerfil.DataSource = tabla;
            cmbPerfil.valueMember = tabla.Columns[0].ColumnName;
            cmbPerfil.DisplayMember = tabla.Columns[1].ColumnName;

            //esto deberia cargar nuestra tabla local
            tabla = oDatos.consultarTabla("users");
            lstUsuarios.DataSource = tabla;
            lstUsuarios.ValueMember = tabla.Columns[0].ColumnName;
            lstUsuarios.DisplayMember = "n_usuario";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btmSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?",
                "Salir",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1)
                == DialogResult.OK)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void btmGrabar_Click(object sender, EventArgs e)
        {
            //deberia existir un metodo validar()
            //if (nuevo)
            //{
                //insert
            //la " y ' se usan para cuando se usan Text
            string sql = "insert into Users (n_usuario, password, email, id_perfil, estado) values ("
                                            +"'"+txtNombre.Text+"','"
                                            +"'"+txtContraseña.Text+"','"
                                            +"'"+txtEmail.Text+"',"
                                            +cmbPerfil.selectedValue+", 'S')";
                                            

            //}
            //else
            //{   
            //update
            //}
            //nuevo=false;
            //actualizarLista()
            //poner un cartel q avise q ya se grabo o modifico
            //como ya grabe tengo q volver al mismo estado incial:
            //hay que deshabilitar los campos txt 
            //habilitar los botones que no necesito
            
            //hay q verificar si el q estoy grabando es un usuario nuevo o alguno q estoy modificando, lo puedo hacer a traves de una bandera
        }

        private void btmNuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            //hay que habilitar los campos txt (hay que hacer un metodo que haga eso, por defecto los campos tienen q estar desactivados)
            //deshabilitar los botones que no necesito
            //limpiar los txt
            //dar foco en el campo correspondiente a la carga, en la secuencia que yo quiero (el id en nuevo tiene q estar deshabilitada porq se pone automatico con la bd)
            txtNombre.Focus();
        }

        private void btmEditar_Click(object sender, EventArgs e)
        {
            ////hay que habilitar los campos txt (hay que hacer un metodo que haga eso, por defecto los campos tienen q estar desactivados)
            //deshabilitar los botones que no necesito
            //el id NO se puede editar
            //NO limpia los campos para no perder los datos
            txtNombre.Focus();
        }

        private void btmBorrar_Click(object sender, EventArgs e)
        {
            //hay q hacer igual q cuando quiero salir un cartel q me permita asegurarme q quiero borrar un usuario
            //cuando se borra no es q se borra directamente si no q se cambia el estado
            //para q no figure en la lista, esta debe filtrar y mostrar solo los usuarios con estado activo

        }
    }
}
