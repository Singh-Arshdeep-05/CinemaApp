namespace ProvaGestioneCinemaWF
{
    partial class ModificaFilmForm
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
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            btnAggiungiAttore = new Button();
            btnModificaAttore = new Button();
            btnRimuoviAttore = new Button();
            dataGridViewAttori = new DataGridView();
            Attore = new DataGridViewTextBoxColumn();
            label5 = new Label();
            txtAnnoM = new TextBox();
            label4 = new Label();
            txtRegistaM = new TextBox();
            label3 = new Label();
            txtTitoloM = new TextBox();
            label2 = new Label();
            btnSalvaModifiche = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttori).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(154, 15);
            label1.TabIndex = 0;
            label1.Text = "Inserisci i dati da modificare";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dataGridViewAttori);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtAnnoM);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtRegistaM);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtTitoloM);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(10, 24);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(555, 258);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnAggiungiAttore);
            panel2.Controls.Add(btnModificaAttore);
            panel2.Controls.Add(btnRimuoviAttore);
            panel2.Location = new Point(370, 83);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(168, 94);
            panel2.TabIndex = 13;
            // 
            // btnAggiungiAttore
            // 
            btnAggiungiAttore.Location = new Point(21, 10);
            btnAggiungiAttore.Margin = new Padding(3, 2, 3, 2);
            btnAggiungiAttore.Name = "btnAggiungiAttore";
            btnAggiungiAttore.Size = new Size(128, 22);
            btnAggiungiAttore.TabIndex = 9;
            btnAggiungiAttore.Text = "Aggiungere Attore";
            btnAggiungiAttore.UseVisualStyleBackColor = true;
            btnAggiungiAttore.Click += btnAggiungiAttore_Click;
            // 
            // btnModificaAttore
            // 
            btnModificaAttore.Location = new Point(21, 36);
            btnModificaAttore.Margin = new Padding(3, 2, 3, 2);
            btnModificaAttore.Name = "btnModificaAttore";
            btnModificaAttore.Size = new Size(128, 22);
            btnModificaAttore.TabIndex = 12;
            btnModificaAttore.Text = "Modifica Attore";
            btnModificaAttore.UseVisualStyleBackColor = true;
            btnModificaAttore.Click += btnModificaAttore_Click;
            // 
            // btnRimuoviAttore
            // 
            btnRimuoviAttore.Location = new Point(21, 62);
            btnRimuoviAttore.Margin = new Padding(3, 2, 3, 2);
            btnRimuoviAttore.Name = "btnRimuoviAttore";
            btnRimuoviAttore.Size = new Size(128, 22);
            btnRimuoviAttore.TabIndex = 11;
            btnRimuoviAttore.Text = "Rimuovi Attore";
            btnRimuoviAttore.UseVisualStyleBackColor = true;
            btnRimuoviAttore.Click += btnRimuoviAttore_Click;
            // 
            // dataGridViewAttori
            // 
            dataGridViewAttori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAttori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAttori.Columns.AddRange(new DataGridViewColumn[] { Attore });
            dataGridViewAttori.Location = new Point(108, 83);
            dataGridViewAttori.Margin = new Padding(3, 2, 3, 2);
            dataGridViewAttori.Name = "dataGridViewAttori";
            dataGridViewAttori.RowHeadersWidth = 51;
            dataGridViewAttori.RowTemplate.Height = 29;
            dataGridViewAttori.Size = new Size(242, 164);
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
            label5.Location = new Point(3, 86);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 6;
            label5.Text = "Attori";
            // 
            // txtAnnoM
            // 
            txtAnnoM.Location = new Point(108, 58);
            txtAnnoM.Margin = new Padding(3, 2, 3, 2);
            txtAnnoM.Name = "txtAnnoM";
            txtAnnoM.Size = new Size(89, 23);
            txtAnnoM.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 61);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 4;
            label4.Text = "Anno di Uscita";
            // 
            // txtRegistaM
            // 
            txtRegistaM.Location = new Point(108, 34);
            txtRegistaM.Margin = new Padding(3, 2, 3, 2);
            txtRegistaM.Name = "txtRegistaM";
            txtRegistaM.Size = new Size(242, 23);
            txtRegistaM.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 36);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Regista";
            // 
            // txtTitoloM
            // 
            txtTitoloM.Location = new Point(108, 8);
            txtTitoloM.Margin = new Padding(3, 2, 3, 2);
            txtTitoloM.Name = "txtTitoloM";
            txtTitoloM.Size = new Size(242, 23);
            txtTitoloM.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 11);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 0;
            label2.Text = "Titolo";
            // 
            // btnSalvaModifiche
            // 
            btnSalvaModifiche.Location = new Point(438, 286);
            btnSalvaModifiche.Margin = new Padding(3, 2, 3, 2);
            btnSalvaModifiche.Name = "btnSalvaModifiche";
            btnSalvaModifiche.Size = new Size(128, 22);
            btnSalvaModifiche.TabIndex = 2;
            btnSalvaModifiche.Text = "Salva Modifiche";
            btnSalvaModifiche.UseVisualStyleBackColor = true;
            btnSalvaModifiche.Click += btnSalvaModifiche_Click;
            // 
            // ModificaFilmForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 314);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(btnSalvaModifiche);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ModificaFilmForm";
            Text = "ModificaFilmForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttori).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label5;
        private TextBox txtAnnoM;
        private Label label4;
        private TextBox txtRegistaM;
        private Label label3;
        private TextBox txtTitoloM;
        private Label label2;
        private Button btnSalvaModifiche;
        private Button btnAggiungiAttore;
        private DataGridView dataGridViewAttori;
        private Button btnRimuoviAttore;
        private Button btnModificaAttore;
        private DataGridViewTextBoxColumn Attore;
        private Panel panel2;
    }
}