namespace ProvaGestioneCinemaWF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            btnPulisci = new Button();
            txtAnno = new TextBox();
            txtNumAttori = new TextBox();
            label4 = new Label();
            btnAggiungi = new Button();
            label3 = new Label();
            txtRegista = new TextBox();
            label2 = new Label();
            txtTitolo = new TextBox();
            btnModifica = new Button();
            btnElimina = new Button();
            dataGridView1 = new DataGridView();
            Titolo = new DataGridViewTextBoxColumn();
            Regista = new DataGridViewTextBoxColumn();
            Anno = new DataGridViewTextBoxColumn();
            Attori = new DataGridViewTextBoxColumn();
            btnSalva = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel2 = new Panel();
            btnVisualizza = new Button();
            label5 = new Label();
            tabPage2 = new TabPage();
            panel3 = new Panel();
            label12 = new Label();
            button2 = new Button();
            label11 = new Label();
            label7 = new Label();
            button3 = new Button();
            button5 = new Button();
            button1 = new Button();
            btnEsci = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            tabPage2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 15);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 0;
            label1.Text = "Titolo";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnPulisci);
            panel1.Controls.Add(txtAnno);
            panel1.Controls.Add(txtNumAttori);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnAggiungi);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtRegista);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtTitolo);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(33, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(532, 158);
            panel1.TabIndex = 1;
            // 
            // btnPulisci
            // 
            btnPulisci.Location = new Point(382, 81);
            btnPulisci.Name = "btnPulisci";
            btnPulisci.Size = new Size(136, 29);
            btnPulisci.TabIndex = 12;
            btnPulisci.Text = "Pulisci Campi";
            btnPulisci.UseVisualStyleBackColor = true;
            btnPulisci.Click += btnPulisci_Click;
            // 
            // txtAnno
            // 
            txtAnno.Location = new Point(149, 78);
            txtAnno.Name = "txtAnno";
            txtAnno.Size = new Size(80, 27);
            txtAnno.TabIndex = 5;
            // 
            // txtNumAttori
            // 
            txtNumAttori.Location = new Point(149, 111);
            txtNumAttori.Name = "txtNumAttori";
            txtNumAttori.Size = new Size(80, 27);
            txtNumAttori.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 114);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 6;
            label4.Text = "Numeri dei Attori";
            // 
            // btnAggiungi
            // 
            btnAggiungi.Location = new Point(382, 43);
            btnAggiungi.Name = "btnAggiungi";
            btnAggiungi.Size = new Size(136, 29);
            btnAggiungi.TabIndex = 9;
            btnAggiungi.Text = "Aggiungi Film";
            btnAggiungi.UseVisualStyleBackColor = true;
            btnAggiungi.Click += btnAggiungi_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 81);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 4;
            label3.Text = "Anno di Uscita";
            // 
            // txtRegista
            // 
            txtRegista.Location = new Point(149, 45);
            txtRegista.Name = "txtRegista";
            txtRegista.Size = new Size(188, 27);
            txtRegista.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 48);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 2;
            label2.Text = "Regista";
            // 
            // txtTitolo
            // 
            txtTitolo.Location = new Point(149, 12);
            txtTitolo.Name = "txtTitolo";
            txtTitolo.Size = new Size(188, 27);
            txtTitolo.TabIndex = 1;
            // 
            // btnModifica
            // 
            btnModifica.Location = new Point(27, 15);
            btnModifica.Name = "btnModifica";
            btnModifica.Size = new Size(136, 29);
            btnModifica.TabIndex = 10;
            btnModifica.Text = "Modifica Film";
            btnModifica.UseVisualStyleBackColor = true;
            btnModifica.Click += btnModifica_Click;
            // 
            // btnElimina
            // 
            btnElimina.Location = new Point(27, 81);
            btnElimina.Name = "btnElimina";
            btnElimina.Size = new Size(136, 29);
            btnElimina.TabIndex = 11;
            btnElimina.Text = "Elimina Film";
            btnElimina.UseVisualStyleBackColor = true;
            btnElimina.Click += btnElimina_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Titolo, Regista, Anno, Attori });
            dataGridView1.Location = new Point(33, 233);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(765, 262);
            dataGridView1.TabIndex = 12;
            // 
            // Titolo
            // 
            Titolo.HeaderText = "Titolo";
            Titolo.MinimumWidth = 6;
            Titolo.Name = "Titolo";
            // 
            // Regista
            // 
            Regista.HeaderText = "Regista";
            Regista.MinimumWidth = 6;
            Regista.Name = "Regista";
            // 
            // Anno
            // 
            Anno.HeaderText = "Anno di Uscita";
            Anno.MinimumWidth = 6;
            Anno.Name = "Anno";
            // 
            // Attori
            // 
            Attori.HeaderText = "Attori";
            Attori.MinimumWidth = 6;
            Attori.Name = "Attori";
            // 
            // btnSalva
            // 
            btnSalva.Location = new Point(27, 114);
            btnSalva.Name = "btnSalva";
            btnSalva.Size = new Size(136, 29);
            btnSalva.TabIndex = 13;
            btnSalva.Text = "Salva";
            btnSalva.UseVisualStyleBackColor = true;
            btnSalva.Click += btnSalva_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(840, 558);
            tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(832, 525);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Menu Principale";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnVisualizza);
            panel2.Controls.Add(btnModifica);
            panel2.Controls.Add(btnElimina);
            panel2.Controls.Add(btnSalva);
            panel2.Location = new Point(611, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(187, 158);
            panel2.TabIndex = 15;
            // 
            // btnVisualizza
            // 
            btnVisualizza.Location = new Point(27, 48);
            btnVisualizza.Name = "btnVisualizza";
            btnVisualizza.Size = new Size(136, 29);
            btnVisualizza.TabIndex = 14;
            btnVisualizza.Text = "Dettagli Film";
            btnVisualizza.UseVisualStyleBackColor = true;
            btnVisualizza.Click += btnVisualizza_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 18);
            label5.Name = "label5";
            label5.Size = new Size(216, 20);
            label5.TabIndex = 14;
            label5.Text = "Inserire le informazioni del film";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(button1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(832, 525);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "About";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label12);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button5);
            panel3.Location = new Point(6, 144);
            panel3.Name = "panel3";
            panel3.Size = new Size(820, 164);
            panel3.TabIndex = 5;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(143, 64);
            label12.Name = "label12";
            label12.Size = new Size(299, 20);
            label12.TabIndex = 10;
            label12.Text = "Applicazione windows Form & OOP Avanzata";
            // 
            // button2
            // 
            button2.Location = new Point(16, 13);
            button2.Name = "button2";
            button2.Size = new Size(121, 29);
            button2.TabIndex = 6;
            button2.Text = "Descrizione";
            button2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(143, 110);
            label11.Name = "label11";
            label11.Size = new Size(113, 20);
            label11.TabIndex = 5;
            label11.Text = "Singh Arshdeep";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(143, 17);
            label7.Name = "label7";
            label7.Size = new Size(502, 20);
            label7.TabIndex = 2;
            label7.Text = "Un'applicazione per la gestione e organizzazione di una collezione di film.";
            // 
            // button3
            // 
            button3.Location = new Point(16, 106);
            button3.Name = "button3";
            button3.Size = new Size(121, 29);
            button3.TabIndex = 7;
            button3.Text = "Sviluppato Da";
            button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(16, 60);
            button5.Name = "button5";
            button5.Size = new Size(121, 29);
            button5.TabIndex = 9;
            button5.Text = "Versione";
            button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(311, 29);
            button1.Name = "button1";
            button1.Size = new Size(203, 79);
            button1.TabIndex = 0;
            button1.Text = "About CinemaApp   ";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnEsci
            // 
            btnEsci.Location = new Point(712, 576);
            btnEsci.Name = "btnEsci";
            btnEsci.Size = new Size(136, 29);
            btnEsci.TabIndex = 14;
            btnEsci.Text = "Esci";
            btnEsci.UseVisualStyleBackColor = true;
            btnEsci.Click += btnEsci_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 613);
            Controls.Add(btnEsci);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel2.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox txtAnno;
        private Label label3;
        private TextBox txtRegista;
        private Label label2;
        private TextBox txtTitolo;
        private TextBox txtNumAttori;
        private Label label4;
        private Button btnAggiungi;
        private Button btnModifica;
        private Button btnElimina;
        private Button btnPulisci;
        private DataGridView dataGridView1;
        private Button btnSalva;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel2;
        private Label label5;
        private DataGridViewTextBoxColumn Titolo;
        private DataGridViewTextBoxColumn Regista;
        private DataGridViewTextBoxColumn Anno;
        private DataGridViewTextBoxColumn Attori;
        private Button btnEsci;
        private Button button1;
        private Label label7;
        private Panel panel3;
        private Button button3;
        private Button button2;
        private Label label12;
        private Label label11;
        private Button button5;
        private Button btnVisualizza;
    }
}