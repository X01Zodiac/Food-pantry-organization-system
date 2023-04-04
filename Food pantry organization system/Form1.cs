using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;

namespace Food_pantry_organization_system
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost; database=food_pantry; uid=root; pwd=Nick1015; ");
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;
        string InsertString = "INSERT INTO canned_goods(canned_goods.item) VALUES (@item)";
        string InsertInt = "INSERT INTO canned_goods(canned_goods.quantity) VALUES (@quantity)";
        string sql;
        public Form1()
        {
            InitializeComponent();
        }

        private void fill_data(string sql, ListBox lst)
        {
            try
            {
                con.Open();
                cmd = new MySqlCommand();
                da = new MySqlDataAdapter();
                dt = new DataTable();

                cmd.Connection = con;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);

                lst.DataSource = dt;
                lst.DisplayMember = "item";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();
                da.Dispose();
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost; database=food_pantry; uid=root; pwd=nick1015; ";
            cnn = new MySqlConnection(connetionString);*/

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sql = "SELECT item FROM `canned_goods`";
            fill_data(sql, listBoxInventory);
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new MySqlCommand(InsertString, con);               
                cmd.Parameters.Add("@item", MySqlDbType.VarChar).Value = textBoxItem.Text;                
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Inserted SuccessFully");
                }
                else
                {
                    MessageBox.Show("Data Failed To Insert SuccessFully");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error" + err);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }

            try
            {
                con.Open();              
                cmd = new MySqlCommand(InsertInt, con);               
                cmd.Parameters.Add("@quantity", MySqlDbType.Int64).Value = numericUpDown1.Value;
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Inserted SuccessFully");
                }
                else
                {
                    MessageBox.Show("Data Failed To Insert SuccessFully");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error" + err);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }
    }
}