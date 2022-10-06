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
    public partial class VentanaTiendas : Form
    {
        
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-B0T6A3V;Initial Catalog=BDNegocio;Integrated Security=True");
        public void FillCombo(ComboBox combo, string Statement, string ValueMember, string DisplayMember)
        {

            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Statement;
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            combo.DataSource = dt;
            combo.DisplayMember = DisplayMember;
            combo.ValueMember = ValueMember;

            conn.Close();
        }
        public void Show_Data(DataGridView DGV, string Statement)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Statement;
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DGV.DataSource = dt;

            conn.Close();
        }
        public void Execute(string Statement)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Statement;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public VentanaTiendas()
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

        private void B_Por_Click(object sender, EventArgs e)
        {
            if (CB_Por.Text == "Numero de Ventas")
            {
                string statement = "SELECT TOP " +CB_TOP.Value+ @" C.store_name, C.store_type, C.store_city, C.store_country, SUM(A.quantity) as Amount
                                FROM Transactions$ A
                                LEFT JOIN Products B
                                ON A.product_id = B.product_id
                                LEFT JOIN Stores C
                                ON A.store_id = C.store_id
                                GROUP BY C.store_name, C.store_type, C.store_city, C.store_country
                                ORDER BY Amount DESC";
                Show_Data(DGV_Tiendas, statement);
            }
            else if (CB_Por.Text == "Monto de Ventas")
            {
                string statement = "SELECT TOP "+CB_TOP.Value+@" C.store_name, C.store_type, C.store_city, C.store_country, cast(SUM(A.quantity * B.product_retail_price)as integer) as Amount
                                FROM Transactions$ A
                                LEFT JOIN Products B
                                ON A.product_id = B.product_id
                                LEFT JOIN Stores C
                                ON A.store_id = C.store_id
                                GROUP BY C.store_name, C.store_type, C.store_city, C.store_country
                                ORDER BY Amount DESC";
                Show_Data(DGV_Tiendas, statement);
            }
        }

        private void CB_ID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void L_ID_Click(object sender, EventArgs e)
        {

        }

        private void B_Eliminar_Click(object sender, EventArgs e)
        {
            string Text = "SELECT * FROM Stores WHERE store_id = " + CB_ID.Text;
            Show_Data(DGV_Tiendas, Text);
            string message = "¿Desea continuar?";
            string title = "Warning";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Text = "DELETE FROM Stores WHERE store_id = " + CB_ID.Text;
                Execute(Text);
                MessageBox.Show("Registro Eliminado Exitosamente, Gracias");
            }
            else
            {

            }
        }

        private void B_Consultar_Click(object sender, EventArgs e)
        {
            string statement = "SELECT * FROM Stores WHERE store_country = '" + CB_Country.Text + "'  AND store_state = '" + CB_state.Text + "' AND store_city = '" + CB_City.Text + "' ORDER BY store_id ASC";
            Show_Data(DGV_Tiendas, statement);
        }

        private void VentanaTiendas_Load(object sender, EventArgs e)
        {
            string Statement = "SELECT DISTINCT store_country  FROM Stores";
            string Valuemember = "store_country";
            string Displaymember = "store_country";
            FillCombo(CB_Country, Statement, Valuemember, Displaymember);

            

            Statement = "SELECT store_id FROM Stores ORDER BY store_id";
            Valuemember = "store_id";
            Displaymember = "store_id";
            FillCombo(CB_ID, Statement, Valuemember, Displaymember);
        }

        private void CB_Country_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CB_City_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }


            private void CB_Country_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string Statement = "SELECT DISTINCT store_state  FROM Stores WHERE store_country = '" + CB_Country.Text + "';";
            string Valuemember = "store_state";
            string Displaymember = "store_state";
            FillCombo(CB_state, Statement, Valuemember, Displaymember);
        }

        private void CB_City_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void CB_state_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string Statement = "SELECT DISTINCT store_city  FROM Stores WHERE store_state = '" + CB_state.Text + "';";
            string Valuemember = "store_city";
            string Displaymember = "store_city";
            FillCombo(CB_City, Statement, Valuemember, Displaymember);
        }

        private void B_Editar_Click(object sender, EventArgs e)
        {
            
            FormularioTiendas FT = new FormularioTiendas();
            FT.store_id = Convert.ToInt32(CB_ID.Text);
            FT.ShowDialog();

            string Statement = "SELECT * FROM Stores WHERE store_id = " + FT.store_id;
            Show_Data(DGV_Tiendas, Statement);

        }
    }
}