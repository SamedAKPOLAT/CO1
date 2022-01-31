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

namespace Sinema_Otomasyonu
{
    public partial class Form3 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-S6SDE8U\SQLSERVER;Initial Catalog=Sinema;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");
        SqlCommand cmd;
        SqlCommand cmd2;
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            
            
            var query2 = "INSERT INTO SEANS (FilmID,Date_,StartTime,EndTime,SalonNo) VALUES (@FId,@date,@Stime,@Etime,@SNo) ";
            
            cmd2 = new SqlCommand(query2,conn);
            cmd2.Parameters.AddWithValue("@FId", comboBox1.Text);
            cmd2.Parameters.AddWithValue("@date", dateTimePicker1.Value);
            cmd2.Parameters.AddWithValue("Stime",textBox1.Text);
            cmd2.Parameters.AddWithValue("@Etime",textBox2.Text);
            cmd2.Parameters.AddWithValue("@SNo",comboBox2.Text);
            cmd2.ExecuteNonQuery();
            conn.Close();





        }

        private void Form3_Load(object sender, EventArgs e)
        {
            conn.Open();
            var query = "Select FilmName From FILM ";
            var query2 = "Select SalonNo From SALONS";
            cmd = new SqlCommand(query,conn);
            cmd2 = new SqlCommand(query2,conn);
            SqlDataReader dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["FilmName"]);
            }
            dr.Close();
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox2.Items.Add(dr2["SalonNo"]);
            }
            dr2.Close();
            conn.Close();
        }
    }
}
