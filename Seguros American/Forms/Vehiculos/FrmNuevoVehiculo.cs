﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguros_American.Forms.Clientes;

namespace Seguros_American.Forms.Vehiculos
{
    public partial class FrmNuevoVehiculo : Form
    {
        public FrmNuevoVehiculo()
        {
            InitializeComponent();
        }

        private void FrmCatalogoVehiculos_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FrmAuxCliente auxiliarcliente = new FrmAuxCliente();
            auxiliarcliente.ShowDialog();
        }
    }
}
