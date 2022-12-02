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
    public partial class Form1 : Form
    {
        private bool Inup = false;
        private bool Inadd = false;
        public Form1()
        {
            InitializeComponent();
        }
        static string chaine = @"Data Source=DESKTOP-KIMOシ\SQLEXPRESS;Initial Catalog=Exam;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        public void initialstate()
        {
            ID.Enabled = false;
            Duration.Enabled = false;
            From.Enabled = false;
            To.Enabled = false;
            Cancel.Enabled = false;
            Save.Enabled = false;
            Update.Enabled = false;
            Delete.Enabled = false;
            Add.Enabled = true;
        }
        public void Selectstate()
        {
            ID.Enabled = true;
            Duration.Enabled = true;
            From.Enabled = true;
            To.Enabled = true;
            Save.Enabled = true;
            Cancel.Enabled = true;
            Update.Enabled = false;
            Delete.Enabled = false;
            Add.Enabled = false;
        }
        public void Cleartxtzone()
        {
            ID.Clear();
            Duration.Clear();
            From.Clear();
            To.Clear();
        }
        public void display()
        {
            cmd.Connection = cnx;
            cmd.CommandText = "select * from dbo.Exam";
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
            cnx.Open();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            initialstate();
            display();
        }
        private void Add_Click(object sender, EventArgs e)
        {
            Inadd = true;
            Cleartxtzone();
            display();
            Selectstate();

        }
        private void Update_Click(object sender, EventArgs e)
        {
            Inup = true;
            Selectstate();
            display();
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
                cmd.CommandText = "delete from Exam where ID_Exam='" + ID.Text + "' ";
                cmd.ExecuteNonQuery();
                cnx.Close();
                Cleartxtzone();
                initialstate();
            }
            else
            {
                ID.Enabled = false;
                Duration.Enabled = false;
                From.Enabled = false;
                To.Enabled = false;
                Save.Enabled = false;
                Cancel.Enabled = false;
                Update.Enabled = true;
                Delete.Enabled = true;
                Add.Enabled = true;
            }

        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
            cmd.Connection = cnx;
            cnx.Open();

            if (Inadd)
            {
                cmd.CommandText = "INSERT INTO Exam(ID_Exam,Duration,Fromd, Tod ) " + "values('" + ID.Text + "','" + Duration.Text + "','" + From.Text + "','" + To.Text + "')";
                cmd.ExecuteNonQuery();
                Inadd = false;
                Form2 f = new Form2();
                f.Show();
            }

            if (Inup)
            {
                cmd.CommandText = "UPDATE Exam set Duration='" + Duration.Text + "',Fromd ='" + From.Text + "',Tod ='" + To.Text + "' where ID_Exam ='" + ID.Text + "'";
                cmd.ExecuteNonQuery();
                Inup = false;

            }

            cnx.Close();
            ID.Enabled = false;
            Duration.Enabled = false;
            From.Enabled = false;
            To.Enabled = false;
            Save.Enabled = false;
            Cancel.Enabled = false;
            Update.Enabled = true;
            Delete.Enabled = true;
            Add.Enabled = true;
            display();
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            Cleartxtzone();
            if (Inup)
            {
                ID.Enabled = false;
                Duration.Enabled = false;
                From.Enabled = false;
                To.Enabled = false;
                Save.Enabled = false;
                Cancel.Enabled = false;
                Update.Enabled = true;
                Delete.Enabled = true;
                Add.Enabled = true;
            }
            else
            {
                initialstate();
            }
        }
    }
}
