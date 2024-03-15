﻿using SistemasVentas.BSS;
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

namespace SistemaVentas.VISTA.PersonasVistas
{
    public partial class PersonaInsertarVista : Form
    {
        public PersonaInsertarVista()
        {
            InitializeComponent();
        }
        PersonaBss bss = new PersonaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Persona p = new Persona();
            p.Nombre = txtNombre.Text;
            p.Apellido = txtApellido.Text;
            p.Telefono = txtTelefono.Text;
            p.Ci = txtCi.Text;
            p.Correo = txtCorreo.Text;

            bss.InsertarPersonaBss(p);

            MessageBox.Show("Se guardo correctamente la persona");
        }
    }
}
