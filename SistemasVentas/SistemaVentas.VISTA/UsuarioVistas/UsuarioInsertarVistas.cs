using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.VISTA.UsuarioVistas
{
    public partial class UsuarioInsertarVistas : Form
    {
        public UsuarioInsertarVistas()
        {
            InitializeComponent();
        }
        UsuarioBss bss = new UsuarioBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.IdPersona = Convert.ToInt32(txtIdPersona.Text);
            u.NombreUser = txtNombreUser.Text;
            u.Contraseña = txtContraseña.Text;
            u.FechaReg = DateTime.Parse(txtFechaReg.Text);

            bss.InsertarUsuarioBss(u);

            MessageBox.Show("Se guardo correctamente");
        }
    }
}
