using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace BooksApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-K5LAKH0\\SQLEXPRESS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into UserTab values (@ID,@First_Name,@Last_Name)", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@First_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Last_Name", textBox3.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Saved");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-K5LAKH0\\SQLEXPRESS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update UserTab set First_Name=@First_Name, Last_Name=@Last_Name where ID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@First_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Last_Name", textBox3.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Updated");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-K5LAKH0\\SQLEXPRESS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete UserTab where ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Deleted");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-K5LAKH0\\SQLEXPRESS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from UserTab where ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-K5LAKH0\\SQLEXPRESS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from UserTab", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}