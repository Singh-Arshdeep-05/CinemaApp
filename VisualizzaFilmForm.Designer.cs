namespace ProvaGestioneCinemaWF
{
    partial class VisualizzaFilmForm
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
            panel1 = new Panel();
            dataGridViewAttori = new DataGridView();
            Attore = new DataGridViewTextBoxColumn();
            label5 = new Label();
            txtAnnoV = new TextBox();
            label4 = new Label();
            txtRegistaV = new TextBox();
            label3 = new Label();
            txtTitoloV = new TextBox();
            label2 = new Label();
            lbToString = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttori).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dataGridViewAttori);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtAnnoV);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtRegistaV);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtTitoloV);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(425, 343);
            panel1.TabIndex = 4;
            // 
            // dataGridViewAttori
            // 
            dataGridViewAttori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAttori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAttori.Columns.AddRange(new DataGridViewColumn[] { Attore });
            dataGridViewAttori.Location = new Point(123, 111);
            dataGridViewAttori.Name = "dataGridViewAttori";
            dataGridViewAttori.RowHeadersWidth = 51;
            dataGridViewAttori.RowTemplate.Height = 29;
            dataGridViewAttori.Size = new Size(277, 219);
            dataGridViewAttori.TabIndex = 10;
            // 
            // Attore
            // 
            Attore.HeaderText = "Attori";
            Attore.MinimumWidth = 6;
            Attore.Name = "Attore";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 115);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 6;
            label5.Text = "Attori";
            // 
            // txtAnnoV
            // 
            txtAnnoV.Location = new Point(123, 77);
            txtAnnoV.Name = "txtAnnoV";
            txtAnnoV.Size = new Size(101, 27);
            txtAnnoV.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 81);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 4;
            label4.Text = "Anno di Uscita";
            // 
            // txtRegistaV
            // 
            txtRegistaV.Location = new Point(123, 45);
            txtRegistaV.Name = "txtRegistaV";
            txtRegistaV.Size = new Size(276, 27);
            txtRegistaV.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 48);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 2;
            label3.Text = "Regista";
            // 
            // txtTitoloV
            // 
            txtTitoloV.Location = new Point(123, 11);
            txtTitoloV.Name = "txtTitoloV";
            txtTitoloV.Size = new Size(276, 27);
            txtTitoloV.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 15);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 0;
            label2.Text = "Titolo";
            // 
            // lbToString
            // 
            lbToString.AutoSize = true;
            lbToString.Location = new Point(16, 9);
            lbToString.Name = "lbToString";
            lbToString.Size = new Size(120, 20);
            lbToString.TabIndex = 5;
            lbToString.Text = "Dettagli del Film";
            // 
            // VisualizzaFilmForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 412);
            Controls.Add(lbToString);
            Controls.Add(panel1);
            Name = "VisualizzaFilmForm";
            Text = "VisualizzaFilmForm";
            Load += VisualizzaFilmForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttori).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridViewAttori;
        private DataGridViewTextBoxColumn Attore;
        private Label label5;
        private TextBox txtAnnoV;
        private Label label4;
        private TextBox txtRegistaV;
        private Label label3;
        private TextBox txtTitoloV;
        private Label label2;
        private Label lbToString;
    }
}