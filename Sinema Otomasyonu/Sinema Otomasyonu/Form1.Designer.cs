namespace Sinema_Otomasyonu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.sinemaDataSet = new Sinema_Otomasyonu.SinemaDataSet();
            this.sinemaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinemaDataSet1 = new Sinema_Otomasyonu.SinemaDataSet1();
            this.sinemaDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(36, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "Film Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(36, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 62);
            this.button2.TabIndex = 0;
            this.button2.Text = "Seans Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(36, 260);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 62);
            this.button3.TabIndex = 0;
            this.button3.Text = "Salon Ekle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(36, 376);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 62);
            this.button4.TabIndex = 0;
            this.button4.Text = "Bilet Sat";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // sinemaDataSet
            // 
            this.sinemaDataSet.DataSetName = "SinemaDataSet";
            this.sinemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sinemaDataSetBindingSource
            // 
            this.sinemaDataSetBindingSource.DataSource = this.sinemaDataSet;
            this.sinemaDataSetBindingSource.Position = 0;
            // 
            // sinemaDataSet1
            // 
            this.sinemaDataSet1.DataSetName = "SinemaDataSet1";
            this.sinemaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sinemaDataSet1BindingSource
            // 
            this.sinemaDataSet1BindingSource.DataSource = this.sinemaDataSet1;
            this.sinemaDataSet1BindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(206, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 313);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sinemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource sinemaDataSetBindingSource;
        private SinemaDataSet sinemaDataSet;
        private System.Windows.Forms.BindingSource sinemaDataSet1BindingSource;
        private SinemaDataSet1 sinemaDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

