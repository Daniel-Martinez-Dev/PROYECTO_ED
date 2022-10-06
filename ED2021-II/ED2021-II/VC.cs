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
    public partial class VentanaClientes : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B0T6A3V;Initial Catalog=BDNegocio;Integrated Security=True");
        public void FillCombo(ComboBox combo, string Statement, string ValueMember, string DisplayMember)
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Statement;
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            combo.DataSource = dt;
            combo.DisplayMember = DisplayMember;
            combo.ValueMember = ValueMember;

            con.Close();
        }
        public void Show_Data(DataGridView DGV, string Statement)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Statement;
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DGV.DataSource = dt;

            con.Close();
        }
        public void Execute(string Statement)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Statement;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public VentanaClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void B_Consultar_Click(object sender, EventArgs e)
        {
            string Statement = "SELECT * FROM Customers WHERE first_name = '" + CB_Nombre.Text+"' ORDER BY customer_id ASC";
            Show_Data(DGV_Clientes, Statement);
        }

        private void CB_Nombre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void B_Por_Click(object sender, EventArgs e)
        {
            string Text = @"SELECT
                            B.first_name + ' ' + B.last_name as full_name, B.customer_city, B.customer_country, B.gender, B.member_card,
                            A.Amount
                            FROM
                            (
                                SELECT TOP "+CB_TOP.Value+

                                @" A.customer_id, cast(SUM(A.Total * B.product_retail_price) as integer) as Amount

                                FROM
                                (
                                    SELECT customer_id, product_id, SUM(quantity) as Total FROM Transactions$

                                    GROUP BY customer_id, product_id
                                ) A

                                LEFT JOIN Products B

                                ON A.product_id = B.product_id

                                GROUP BY customer_id

                                ORDER BY Amount DESC
                            ) A
                            LEFT JOIN Customers B
                            ON A.customer_id = B.customer_id
                            ORDER BY Amount DESC";

            Show_Data(DGV_Clientes, Text);
        }

        private void VentanaClientes_Load(object sender, EventArgs e)
        {
            
            string Statement = "SELECT DISTINCT first_name  FROM Customers ORDER BY first_name";
            string Valuemember = "first_name";
            string Displaymember ="first_name";
            FillCombo(CB_Nombre, Statement, Valuemember, Displaymember);

            Statement = "SELECT customer_id, first_name  FROM Customers ORDER BY customer_id";
            Valuemember = "customer_id";
            Displaymember = "customer_id";
            FillCombo(CB_ID, Statement, Valuemember, Displaymember);
        }

        private void CB_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void CB_TOP_ValueChanged(object sender, EventArgs e)
        {

        }

        private void B_Eliminar_Click(object sender, EventArgs e)
        {
            string Text = "SELECT * FROM Customers WHERE customer_id = " + CB_ID.Text;
            Show_Data(DGV_Clientes, Text);
            string message = "¿Desea continuar?";
            string title = "Warning";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Text = "DELETE FROM Customers WHERE customer_id = " + CB_ID.Text;
                Execute(Text);
                MessageBox.Show("Registro eliminado exitosamente, gracias");
            }
            else
            {
                
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void CB_VER_Click(object sender, EventArgs e)
        {
            string Text = "SELECT * FROM Customers WHERE customer_id = " + CB_ID.Text;
            Show_Data(DGV_Clientes, Text);
        }

        private void B_Editar_Click(object sender, EventArgs e)
        {
            FormularioClientesEdicion FCE = new FormularioClientesEdicion();
            FCE.client_id = Convert.ToInt32(CB_ID.Text);
            FCE.ShowDialog();

            string Statement = "SELECT * FROM Customers WHERE customer_id = " + FCE.client_id;
            Show_Data(DGV_Clientes, Statement);
        }

        private void B_NuevoCliente_Click(object sender, EventArgs e)
        {
            FormularioClientes FC = new FormularioClientes();
            FC.ShowDialog();

            string Statement = "SELECT * FROM Customers WHERE customer_id = " + FC.client_id;
            Show_Data(DGV_Clientes, Statement);
        }
    }
}
