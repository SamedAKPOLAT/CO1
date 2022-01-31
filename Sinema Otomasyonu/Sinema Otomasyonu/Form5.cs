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
    
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-S6SDE8U\SQLSERVER;Initial Catalog=Sinema;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");
        SqlCommand cmd;

        private void button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            var query = "INSERT INTO SEATS (SeatNumber,CustomerName,SeansID,SalonNo) Values (@params1,@params2,@params3,@params4)";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@params1",textBox4.Text);
            cmd.Parameters.AddWithValue("@params2", textBox2.Text);
            cmd.Parameters.AddWithValue("@params1", textBox3.Text);
            cmd.Parameters.AddWithValue("@params1", textBox1.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
