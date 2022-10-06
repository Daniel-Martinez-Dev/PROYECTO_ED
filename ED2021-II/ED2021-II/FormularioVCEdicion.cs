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
    public partial class FormularioClientesEdicion : Form
    {
        public int client_id = 0;
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
        public FormularioClientesEdicion()
        {
            InitializeComponent();
        }

        private void B_Editar_Click(object sender, EventArgs e)
        {
            string Statement = @"UPDATE Customers
                                SET first_name = '" + TB_Name.Text + @"',
                                last_name = '" + TB_Last_name.Text + @"',
                                customer_address = '" + TB_Address.Text + @"',
                                customer_city = '" + TB_City.Text + @"',
                                customer_state_province = '" + TB_State + @"',
                                customer_postal_code = " + Convert.ToSingle(TB_PC.Text) + @",
                                customer_country = '" + TB_Country.Text + @"',
                                marital_status = '" + CB_Marital.Text + @"',
                                yearly_income = '" + TB_Income.Text + @"',
                                total_children = " + Convert.ToSingle(TB_Children.Text) + @",
                                num_children_at_home = " + Convert.ToSingle(TB_Children_Home.Text) + @",
                                education = '" + BC_Education.Text + @"',
                                member_card = '" + TB_Card.Text + @"',
                                occupation = '" + TB_Occupation.Text + @"',
                                homeowner = '" + CB_HomeOwner.Text + @"'                              
                                WHERE customer_id = " + client_id;
            Execute(Statement);
            MessageBox.Show("Registro Editado Exitosamente, Gracias");
            this.Close();
        }

        private void FormularioClientesEdicion_Load(object sender, EventArgs e)
        {
            LB_ID.Text = Convert.ToString(client_id);

            string statement = "SELECT customer_acct_num FROM Customers WHERE customer_id = " + client_id;
            LB_Account.Text = "      " + Bring_Data(statement);

            statement = "SELECT first_name FROM Customers WHERE customer_id = " + client_id;
            TB_Name.Text = "" + Bring_Data(statement);

            statement = "SELECT last_name FROM Customers WHERE customer_id = " + client_id;
            TB_Last_name.Text = "" + Bring_Data(statement);

            statement = "SELECT customer_address FROM Customers WHERE customer_id = " + client_id;
            TB_Address.Text = "" + Bring_Data(statement);

            statement = "SELECT customer_city FROM Customers WHERE customer_id = " + client_id;
            TB_City.Text = "" + Bring_Data(statement);

            statement = "SELECT customer_state_province FROM Customers WHERE customer_id = " + client_id;
            TB_State.Text = "" + Bring_Data(statement);

            statement = "SELECT customer_postal_code FROM Customers WHERE customer_id = " + client_id;
            TB_PC.Text = "" + Bring_Data(statement);

            statement = "SELECT customer_country FROM Customers WHERE customer_id = " + client_id;
            TB_Country.Text = "" + Bring_Data(statement);

            statement = "SELECT Birthday FROM Customers WHERE customer_id = " + client_id; ;
            LB_DOB.Text = "      " + Bring_Data(statement);

            statement = "SELECT DISTINCT marital_status FROM Customers";
            string Valuemember = "marital_status";
            string Displaymember = "marital_status";
            FillCombo(CB_Marital, statement, Valuemember, Displaymember);

            statement = "SELECT yearly_income FROM Customers WHERE customer_id = " + client_id;
            TB_Income.Text = "" + Bring_Data(statement);

            statement = "SELECT gender FROM Customers WHERE customer_id = " + client_id;
            LB_Gender.Text = "" + Bring_Data(statement);

            statement = "SELECT total_children FROM Customers WHERE customer_id = " + client_id;
            TB_Children.Text = "" + Bring_Data(statement);

            statement = "SELECT num_children_at_home FROM Customers WHERE customer_id = " + client_id;
            TB_Children_Home.Text = "" + Bring_Data(statement);

            statement = "SELECT DISTINCT education FROM Customers";
            Valuemember = "education";
            Displaymember = "education";
            FillCombo(BC_Education, statement, Valuemember, Displaymember);

            statement = "SELECT Acct_Oppening FROM Customers WHERE customer_id = " + client_id;
            LB_Oppening.Text = "" + Bring_Data(statement);

            statement = "SELECT member_card FROM Customers WHERE customer_id = " + client_id;
            TB_Card.Text = "" + Bring_Data(statement);

            statement = "SELECT occupation FROM Customers WHERE customer_id = " + client_id;
            TB_Occupation.Text = "" + Bring_Data(statement);

            statement = "SELECT DISTINCT homeowner FROM Customers";
            Valuemember = "homeowner";
            Displaymember = "homeowner";
            FillCombo(CB_HomeOwner, statement, Valuemember, Displaymember);


        }
    }
}
