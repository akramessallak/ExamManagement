using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ExamManagement
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        static string chaine = @"Data Source=DESKTOP-KIMOシ\SQLEXPRESS;Initial Catalog=Exam;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        public void display()
        {
            cmd.Connection = cnx;
            cmd.CommandText = "select * from ListQ ";
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
            cnx.Open();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            display();

        }
        private void OpenQ_Click(object sender, EventArgs e)
        {
            display();
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
            cmd.Connection = cnx;
            cnx.Open();
            cmd.CommandText = "INSERT INTO ListQ(ID, Type) " + "values('" + ID.Text + "','Open Question')";
            cmd.ExecuteNonQuery();
            cnx.Close();
            display();
            this.Hide();
            Form4 f = new Form4();
            f.Show();
        }
        private void ChoiceQ_Click(object sender, EventArgs e)
        {
            display();
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
            cmd.Connection = cnx;
            cnx.Open();
            cmd.CommandText = "INSERT INTO ListQ(ID, Type) " + "values('" + ID.Text + "','Choice Question')";
            cmd.ExecuteNonQuery();
            cnx.Close();
            display();
            this.Hide();
            Form3 f = new Form3();
            f.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string msgbox = "Are you sure you want to delete this item?";

            string YNBox = "Confirm Deletion";


            if (MessageBox.Show(msgbox, YNBox, MessageBoxButtons.YesNo) == DialogResult.Yes)

            {
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "delete from ListQ where ID='" + ID.Text + "' ";
                cmd.ExecuteNonQuery();
                ID.Clear();
            }
        }
    }
}
