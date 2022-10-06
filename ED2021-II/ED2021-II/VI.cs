using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ED2021_II
{
    public partial class VentanaInicial : Form
    {
        public VentanaInicial()
        {
            InitializeComponent();
        }

        private void BCLIENTES_Click(object sender, EventArgs e)
        {
            VentanaClientes VC = new VentanaClientes();
            VC.ShowDialog();
        }

        private void BPRODUCTOS_Click(object sender, EventArgs e)
        {
            VentanaProductos VP = new VentanaProductos();
            VP.ShowDialog();
        }

        private void BTIENDAS_Click(object sender, EventArgs e)
        {
            VentanaTiendas VT = new VentanaTiendas();
            VT.ShowDialog();
        }

        private void VentanaInicial_Load(object sender, EventArgs e)
        {

        }
    }
}
