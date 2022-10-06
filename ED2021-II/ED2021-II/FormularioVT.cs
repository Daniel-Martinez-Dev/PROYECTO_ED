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
    public partial class FormularioTiendas : Form
    {
        public int store_id = 0;
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



        public void Execute(string Statement)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Statement;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public FormularioTiendas()
        {
            
            InitializeComponent();
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FormularioTiendas_Load(object sender, EventArgs e)
        {
            L_ID.Text = Convert.ToString(store_id);

            string statement = "SELECT region_id FROM Stores WHERE store_id = " + store_id;
            L_RegionId.Text = "      " + Bring_Data(statement);

            statement = "SELECT store_country FROM Stores WHERE store_id = " + store_id;
            L_type.Text = "      " + Bring_Data(statement);

            statement = "SELECT store_name FROM Stores WHERE store_id = " + store_id;
            L_name.Text = "      " + Bring_Data(statement);

            statement = "SELECT store_street_address FROM Stores WHERE store_id = " + store_id;
            L_Address.Text = "      " + Bring_Data(statement);

            statement = "SELECT store_city FROM Stores WHERE store_id = " + store_id;
            L_city.Text = "      " + Bring_Data(statement);

            statement = "SELECT store_state FROM Stores WHERE store_id = " + store_id;
            L_State.Text = "      " + Bring_Data(statement);

            statement = "SELECT store_country FROM Stores WHERE store_id = " + store_id;
            L_country.Text = "      " + Bring_Data(statement);

            statement = "SELECT store_phone FROM Stores WHERE store_id = " + store_id;
            TB_Telephone.Text = "" + Bring_Data(statement);

            statement = "SELECT first_opened_date FROM Stores WHERE store_id = " + store_id;
            L_opening.Text = "      " + Bring_Data(statement);

            statement = "SELECT last_remodel_date FROM Stores WHERE store_id = " + store_id;
            TB_Remodel.Text = "" + Bring_Data(statement);

            statement = "SELECT total_sqft FROM Stores WHERE store_id = " + store_id;
            TB_SQFT.Text = "" + Bring_Data(statement);

            statement = "SELECT grocery_sqft FROM Stores WHERE store_id = " + store_id;
            TB_G_SQFT.Text = "" + Bring_Data(statement);

            

            //MessageBox.Show(Bring_Data(statement));
        }

        private void B_Editar_Click(object sender, EventArgs e)
        {
            string Statement = @"UPDATE Stores
                                SET store_phone = '" + TB_Telephone.Text + @"',
                                last_remodel_date = '" + TB_Remodel.Text + @"',
                                total_sqft = " + Convert.ToSingle(TB_SQFT.Text) + @",
                                grocery_sqft = " + Convert.ToSingle(TB_G_SQFT.Text) + @"
                                WHERE store_id = " + store_id;
            Execute(Statement);
            MessageBox.Show("Registro Editado Exitosamente, Gracias");
            this.Close();
        }
    }
}
