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
    public partial class FormularioClientes : Form
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

        public FormularioClientes()
        {
            InitializeComponent();
        }

        private void B_Editar_Click(object sender, EventArgs e)
        {

            string statement = @"INSERT INTO Customers
            (customer_id, customer_acct_num, first_name, last_name,
            customer_address, customer_city, customer_state_province,
            customer_postal_code, customer_country, Birthday, marital_status,
            yearly_income, gender, total_children, num_children_at_home, education,
            Acct_Oppening, member_card, occupation, homeowner)
            VALUES 
            (" + client_id +", "+
            Convert.ToInt64(LB_Account.Text) + ", '" +
            TB_Name.Text + "', '" +
            TB_Last_name.Text + "', '" +
            TB_Address.Text + "', '" +
            TB_City.Text + "', '" +
            TB_State.Text + "', " +
            Convert.ToSingle(TB_PC.Text) + ", '" +
            TB_Country.Text + "', '" +
            LB_DOB.Text + "', '" +
            CB_Marital.Text + "', '" +
            TB_Income.Text + "', '" +
            CB_Gender.Text + "', " +
            Convert.ToSingle(TB_Children.Text) + ", " +
            Convert.ToSingle(TB_Children_Home.Text) + ", '" +
            BC_Education.Text + "', '" +
            TB_Oppening.Text + "', '" +
            CB_Card.Text + "', '" +
            TB_Occupation.Text + "', '" +
            CB_HomeOwner.Text + "' " +
            ")";

            Execute(statement);
            MessageBox.Show("Registro Insertado exitosamente, gracias");
            this.Close();
        }

        private void FormularioClientes_Load(object sender, EventArgs e)
        {
            string Statement = "SELECT TOP 1 customer_id FROM Customers ORDER BY customer_id DESC";
            client_id = Convert.ToInt32(Bring_Data(Statement)) + 1;
            LB_ID.Text = Convert.ToString(client_id);

            Statement = "SELECT TOP 1 customer_acct_num FROM Customers ORDER BY customer_acct_num DESC";
            LB_Account.Text = Convert.ToString(Convert.ToInt64(Bring_Data(Statement)) + 1);

            string statement = "SELECT DISTINCT marital_status FROM Customers";
            string Valuemember = "marital_status";
            string Displaymember = "marital_status";
            FillCombo(CB_Marital, statement, Valuemember, Displaymember);

            statement = "SELECT DISTINCT gender FROM Customers";
            Valuemember = "gender";
            Displaymember = "gender";
            FillCombo(CB_Gender, statement, Valuemember, Displaymember);

            statement = "SELECT DISTINCT education FROM Customers";
            Valuemember = "education";
            Displaymember = "education";
            FillCombo(BC_Education, statement, Valuemember, Displaymember);

            statement = "SELECT DISTINCT homeowner FROM Customers";
            Valuemember = "homeowner";
            Displaymember = "homeowner";
            FillCombo(CB_HomeOwner, statement, Valuemember, Displaymember);

            statement = "SELECT DISTINCT member_card FROM Customers";
            Valuemember = "member_card";
            Displaymember = "member_card";
            FillCombo(CB_Card, statement, Valuemember, Displaymember);

            


        }
    }
}
