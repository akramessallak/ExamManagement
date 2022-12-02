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

namespace ExamManagement
{
    public partial class Form4 : Form
    {
        public Form4()
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
            cmd.CommandText = "select * from OpenQ ";
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
            cnx.Open();

        }
        private void Form4_Load(object sender, EventArgs e)
        {
            display();
        }

        private void SaveOQ_Click(object sender, EventArgs e)
        {
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
            cmd.Connection = cnx;
            cnx.Open();
            cmd.CommandText = "INSERT INTO OpenQ(ID_2, Statement, Rating, Answer) " + "values('"+ IDOQ.Text + "','"+ Statement2.Text +"','"+ Rating2.Text +"','"+ Answer.Text +"')";
            cmd.ExecuteNonQuery();
            cnx.Close();
            display();
            this.Hide();
            Form2 f = new Form2();
            f.Show();

        }
    }
}
