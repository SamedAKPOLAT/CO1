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
    public partial class Form4 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-S6SDE8U\SQLSERVER;Initial Catalog=Sinema;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");
        SqlCommand cmd;
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var query = "Insert Into SALONS (SalonNo,Seats) Values ('"+textBox1.Text+"','"+textBox2.Text+"')";
            cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kayıt Başarıyla Gerçekleşti");

        }
    }
}
