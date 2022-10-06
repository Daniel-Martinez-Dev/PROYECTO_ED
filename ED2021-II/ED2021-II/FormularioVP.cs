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
using System.Globalization;
using System.Threading;

namespace ED2021_II
{
    public partial class FormularioProductos : Form
    {
        public int product_id;
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

        public String Bring_Data(string Statement)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Statement;
            cmd.ExecuteNonQuery();

            string Result = Convert.ToString(cmd.ExecuteScalar());
            con.Close();

            return Result;
        }

        public FormularioProductos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void B_Editar_Click(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
            string Statement = @"UPDATE Products
                                SET product_name = '" + TB_Name.Text + @"',
                                product_retail_price = "+ Convert.ToSingle(TB_Price.Text) +@",
                                product_cost = " + Convert.ToSingle(TB_Cost.Text) + @",
                                product_weight = " + Convert.ToSingle(TB_Weight.Text) + @"                      
                                WHERE product_id = " + product_id;
            Execute(Statement);
            MessageBox.Show("Registro Editado Exitosamente, Gracias");
            this.Close();
        }

        private void FormularioProductos_Load(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
            LB_ID.Text = "   "+Convert.ToString(product_id);

            string statement = "SELECT product_brand FROM Products WHERE product_id = " + product_id;
            LB_Brand.Text = "   " + Bring_Data(statement);

            statement = "SELECT product_name FROM Products WHERE product_id = " + product_id;
            TB_Name.Text = "" + Bring_Data(statement);

            statement = "SELECT product_sku FROM Products WHERE product_id = " + product_id;
            LB_SKU.Text = "   " + Bring_Data(statement);

            statement = "SELECT product_retail_price FROM Products WHERE product_id = " + product_id;
            TB_Price.Text = "" + Convert.ToString(Bring_Data(statement));

            statement = "SELECT product_cost FROM Products WHERE product_id = " + product_id;
            TB_Cost.Text = "" + Convert.ToString(Bring_Data(statement));

            statement = "SELECT product_weight FROM Products WHERE product_id = " + product_id;
            TB_Weight.Text = "" + Convert.ToString(Bring_Data(statement));
        }
    }
}
