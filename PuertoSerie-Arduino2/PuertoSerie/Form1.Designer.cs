namespace PuertoSerie
{
    partial class frmSerie
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
            cmbPuertos = new ComboBox();
            btnConectar = new Button();
            label2 = new Label();
            rtbLog = new RichTextBox();
            txtEnviar = new TextBox();
            btnEnviar = new Button();
            btnActualizar = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            lbl_Grados = new Label();
            lbl_Estado = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbPuertos_Salida = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(103, 21);
            label1.TabIndex = 0;
            label1.Text = "Puerto Serie";
            // 
            // cmbPuertos
            // 
            cmbPuertos.FormattingEnabled = true;
            cmbPuertos.Location = new Point(12, 55);
            cmbPuertos.Name = "cmbPuertos";
            cmbPuertos.Size = new Size(84, 23);
            cmbPuertos.TabIndex = 1;
            // 
            // btnConectar
            // 
            btnConectar.BackgroundImageLayout = ImageLayout.Stretch;
            btnConectar.ForeColor = Color.Black;
            btnConectar.Location = new Point(337, 33);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(75, 23);
            btnConectar.TabIndex = 2;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 3;
            // 
            // rtbLog
            // 
            rtbLog.BackColor = SystemColors.MenuHighlight;
            rtbLog.BorderStyle = BorderStyle.None;
            rtbLog.ForeColor = Color.White;
            rtbLog.Location = new Point(29, 288);
            rtbLog.Name = "rtbLog";
            rtbLog.Size = new Size(188, 133);
            rtbLog.TabIndex = 4;
            rtbLog.Text = "";
            // 
            // txtEnviar
            // 
            txtEnviar.Location = new Point(12, 441);
            txtEnviar.Name = "txtEnviar";
            txtEnviar.Size = new Size(400, 23);
            txtEnviar.TabIndex = 5;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(427, 440);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 6;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(427, 33);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 7;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Location = new Point(434, 272);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 18);
            panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox1.BackgroundImage = Properties.Resources.termometro_blanco1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(249, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(376, 339);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 0, 0, 0);
            label3.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 74);
            label3.Name = "label3";
            label3.Size = new Size(231, 47);
            label3.TabIndex = 11;
            label3.Text = "Temperatura";
            // 
            // lbl_Grados
            // 
            lbl_Grados.AutoSize = true;
            lbl_Grados.BackColor = Color.FromArgb(0, 0, 0, 0);
            lbl_Grados.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Grados.ForeColor = Color.White;
            lbl_Grados.Location = new Point(29, 121);
            lbl_Grados.Name = "lbl_Grados";
            lbl_Grados.Size = new Size(108, 128);
            lbl_Grados.TabIndex = 12;
            lbl_Grados.Text = "n";
            lbl_Grados.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Estado
            // 
            lbl_Estado.AutoSize = true;
            lbl_Estado.BackColor = Color.FromArgb(0, 0, 0, 0);
            lbl_Estado.ForeColor = Color.White;
            lbl_Estado.Location = new Point(110, 262);
            lbl_Estado.Name = "lbl_Estado";
            lbl_Estado.Size = new Size(42, 15);
            lbl_Estado.TabIndex = 13;
            lbl_Estado.Text = "estado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 0, 0, 0);
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(12, 32);
            label4.Name = "label4";
            label4.Size = new Size(63, 21);
            label4.TabIndex = 15;
            label4.Text = "Entrada";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 0, 0, 0);
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(137, 32);
            label5.Name = "label5";
            label5.Size = new Size(52, 21);
            label5.TabIndex = 16;
            label5.Text = "Salida";
            // 
            // cmbPuertos_Salida
            // 
            cmbPuertos_Salida.FormattingEnabled = true;
            cmbPuertos_Salida.Location = new Point(137, 54);
            cmbPuertos_Salida.Name = "cmbPuertos_Salida";
            cmbPuertos_Salida.Size = new Size(80, 23);
            cmbPuertos_Salida.TabIndex = 17;
            // 
            // frmSerie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            BackgroundImage = Properties.Resources.Rectangle_4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(514, 476);
            Controls.Add(cmbPuertos_Salida);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lbl_Estado);
            Controls.Add(lbl_Grados);
            Controls.Add(label3);
            Controls.Add(btnActualizar);
            Controls.Add(btnEnviar);
            Controls.Add(txtEnviar);
            Controls.Add(rtbLog);
            Controls.Add(label2);
            Controls.Add(btnConectar);
            Controls.Add(cmbPuertos);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "frmSerie";
            Text = "Puerto Serie";
            Load += frmSerie_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbPuertos;
        private Button btnConectar;
        private Label label2;
        private RichTextBox rtbLog;
        private TextBox txtEnviar;
        private Button btnEnviar;
        private Button btnActualizar;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label lbl_Grados;
        private Label lbl_Estado;
        private Label label4;
        private Label label5;
        private ComboBox cmbPuertos_Salida;
    }
}
