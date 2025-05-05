namespace FrmEjercicoN5_SeminarioDeProg
{
    partial class FrasesApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrasesApp));
            txtFrase = new TextBox();
            btnClear = new Button();
            lblResult = new Label();
            lstFrases = new ListBox();
            lblNota = new Label();
            lblFrasesTitulo = new Label();
            lblFrasesEnLista = new Label();
            SuspendLayout();
            // 
            // txtFrase
            // 
            txtFrase.BackColor = Color.Black;
            txtFrase.BorderStyle = BorderStyle.FixedSingle;
            txtFrase.ForeColor = SystemColors.ButtonHighlight;
            txtFrase.Location = new Point(561, 126);
            txtFrase.Name = "txtFrase";
            txtFrase.Size = new Size(227, 23);
            txtFrase.TabIndex = 0;
            txtFrase.TextChanged += txtFrase_TextChanged;
            txtFrase.KeyPress += txtFrase_KeyPress;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Black;
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.FromArgb(255, 192, 128);
            btnClear.Image = (Image)resources.GetObject("btnClear.Image");
            btnClear.ImageAlign = ContentAlignment.BottomCenter;
            btnClear.Location = new Point(169, 301);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(342, 23);
            btnClear.TabIndex = 2;
            btnClear.Text = "Limpiar todo";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.Transparent;
            lblResult.ForeColor = Color.FromArgb(255, 192, 128);
            lblResult.Location = new Point(561, 165);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 1;
            // 
            // lstFrases
            // 
            lstFrases.BackColor = SystemColors.InactiveCaptionText;
            lstFrases.BorderStyle = BorderStyle.FixedSingle;
            lstFrases.ForeColor = Color.FromArgb(255, 192, 128);
            lstFrases.FormattingEnabled = true;
            lstFrases.ItemHeight = 15;
            lstFrases.Location = new Point(169, 126);
            lstFrases.Name = "lstFrases";
            lstFrases.Size = new Size(342, 152);
            lstFrases.TabIndex = 3;
            lstFrases.SelectedIndexChanged += lstFrases_SelectedIndexChanged;
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.BackColor = Color.Transparent;
            lblNota.ForeColor = SystemColors.ButtonHighlight;
            lblNota.Location = new Point(8, 7);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(0, 15);
            lblNota.TabIndex = 4;
            // 
            // lblFrasesTitulo
            // 
            lblFrasesTitulo.AutoSize = true;
            lblFrasesTitulo.BackColor = Color.Transparent;
            lblFrasesTitulo.ForeColor = Color.FromArgb(255, 192, 128);
            lblFrasesTitulo.Location = new Point(561, 102);
            lblFrasesTitulo.Name = "lblFrasesTitulo";
            lblFrasesTitulo.Size = new Size(98, 15);
            lblFrasesTitulo.TabIndex = 5;
            lblFrasesTitulo.Text = "Escriba una frase:";
            // 
            // lblFrasesEnLista
            // 
            lblFrasesEnLista.AutoSize = true;
            lblFrasesEnLista.BackColor = Color.Transparent;
            lblFrasesEnLista.ForeColor = Color.FromArgb(255, 192, 128);
            lblFrasesEnLista.Location = new Point(169, 103);
            lblFrasesEnLista.Name = "lblFrasesEnLista";
            lblFrasesEnLista.Size = new Size(83, 15);
            lblFrasesEnLista.TabIndex = 6;
            lblFrasesEnLista.Text = "Lista de frases:";
            // 
            // FrasesApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(826, 450);
            Controls.Add(lblFrasesEnLista);
            Controls.Add(lblFrasesTitulo);
            Controls.Add(lblNota);
            Controls.Add(lstFrases);
            Controls.Add(lblResult);
            Controls.Add(btnClear);
            Controls.Add(txtFrase);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrasesApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrasesApp";
            FormClosing += FrasesApp_FormClosing;
            FormClosed += FrasesApp_FormClosed;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFrase;
        private Button button1;
        private Button btnClear;
        private Label lblResult;
        private ListBox lstFrases;
        private Label lblNota;
        private Label lblFrasesTitulo;
        private Label lblFrasesEnLista;
    }
}