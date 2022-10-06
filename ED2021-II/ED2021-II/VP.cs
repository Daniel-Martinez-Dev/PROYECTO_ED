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
    public partial class VentanaProductos : Form
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


        public VentanaProductos()
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
            string statement = "SELECT * FROM Products WHERE product_name = '" + CB_Nombre.Text + "' ORDER BY product_id ASC";
            Show_Data(DGV_Productos, statement);
        }

        private void CB_Por_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void B_Eliminar_Click(object sender, EventArgs e)
        {
            string Text = "SELECT * FROM Products WHERE product_id = " + CB_ID.Text;
            Show_Data(DGV_Productos, Text);
            string message = "¿Desea continuar?";
            string title = "Warning";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Text = "DELETE FROM Products WHERE product_id = " + CB_ID.Text;
                Execute(Text);
                MessageBox.Show("Registro Eliminado Exitosamente, Gracias");

            }
            else
            {

            }
        }

        private void B_Por_Click(object sender, EventArgs e)
        {
            if (CB_POR.Text == "Precio")
            {
                string statement = "SELECT  TOP " +CB_TOP.Value+
                                    @"B.product_name, B.product_brand, B.product_retail_price as Price
                                    FROM Products B
                                    ORDER BY Price DESC";
                Show_Data(DGV_Productos, statement);

            }
            else if (CB_POR.Text == "Cantidad Vendida")
            {
                string statement = "SELECT  TOP " +CB_TOP.Value+
                                @"B.product_name, B.product_brand, SUM(A.quantity) as Amount
                                FROM Transactions$ A
                                LEFT JOIN Products B
                                ON A.product_id = B.product_id
                                GROUP BY B.Product_name, B.product_brand
                                ORDER BY Amount DESC";
                Show_Data(DGV_Productos, statement);
            }
            else if (CB_POR.Text == "Monto Vendido")
            {
                string statement = "SELECT  TOP " +CB_TOP.Value+
                                    @"B.product_name, B.product_brand, cast(SUM(A.quantity * B.product_retail_price)as integer) as Amount
                                    FROM Transactions$ A
                                    LEFT JOIN Products B
                                    ON A.product_id = B.product_id
                                    GROUP BY B.Product_name, B.product_brand
                                    ORDER BY Amount DESC";
                Show_Data(DGV_Productos, statement);
            }
        }

        private void VentanaProductos_Load(object sender, EventArgs e)
        {
            string Statement = "SELECT DISTINCT product_name  FROM Products";
            string Valuemember = "product_name";
            string Displaymember = "product_name";
            FillCombo(CB_Nombre, Statement, Valuemember, Displaymember);



            Statement = "SELECT product_id FROM Products ORDER BY product_id";
            Valuemember = "product_id";
            Displaymember = "product_id";
            FillCombo(CB_ID, Statement, Valuemember, Displaymember);
        }

        private void B_VER_Click(object sender, EventArgs e)
        {
            string Text = "SELECT * FROM Products WHERE product_id = " + CB_ID.Text;
            Show_Data(DGV_Productos, Text);
        }

        private void B_Editar_Click(object sender, EventArgs e)
        {
            FormularioProductos FP = new FormularioProductos();
            FP.product_id = Convert.ToInt32(CB_ID.Text);
            FP.ShowDialog();
            
            string Statement = "SELECT * FROM Products WHERE product_id = " + FP.product_id;
            Show_Data(DGV_Productos, Statement);


        }
    }
}
