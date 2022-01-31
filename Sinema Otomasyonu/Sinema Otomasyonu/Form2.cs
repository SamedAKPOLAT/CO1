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
    public partial class Form2 : Form
    {
        OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-S6SDE8U\SQLSERVER;Initial Catalog=Sinema;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");
        SqlCommand cmd;

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            OpenFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = OpenFileDialog1.FileName;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            var query = "INSERT INTO FILM (FilmName,FilmsDirector,Duration,Poster) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + pictureBox1.Image + "')";
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kayıt Başarıyla Gerçekleşti");


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox3.MaxLength = 8;
            
        }

        
    }
}
