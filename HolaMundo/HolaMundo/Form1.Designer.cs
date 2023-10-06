namespace HolaMundo
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
            txtContrasena1 = new TextBox();
            txtContrasena2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnValidar = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtContrasena1
            // 
            txtContrasena1.BackColor = Color.FromArgb(80, 94, 129);
            txtContrasena1.BorderStyle = BorderStyle.None;
            txtContrasena1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtContrasena1.ForeColor = Color.White;
            txtContrasena1.Location = new Point(304, 76);
            txtContrasena1.Name = "txtContrasena1";
            txtContrasena1.Size = new Size(399, 24);
            txtContrasena1.TabIndex = 0;
            // 
            // txtContrasena2
            // 
            txtContrasena2.BackColor = Color.FromArgb(80, 94, 129);
            txtContrasena2.BorderStyle = BorderStyle.None;
            txtContrasena2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtContrasena2.ForeColor = Color.White;
            txtContrasena2.Location = new Point(304, 185);
            txtContrasena2.Name = "txtContrasena2";
            txtContrasena2.Size = new Size(399, 24);
            txtContrasena2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(304, 51);
            label1.Name = "label1";
            label1.Size = new Size(232, 23);
            label1.TabIndex = 2;
            label1.Text = "Ingresa una contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(304, 160);
            label2.Name = "label2";
            label2.Size = new Size(206, 23);
            label2.TabIndex = 3;
            label2.Text = "Repite la contraseña:";
            // 
            // btnValidar
            // 
            btnValidar.BackColor = Color.FromArgb(0, 0, 64);
            btnValidar.Cursor = Cursors.Hand;
            btnValidar.FlatAppearance.BorderSize = 0;
            btnValidar.FlatStyle = FlatStyle.Flat;
            btnValidar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnValidar.ForeColor = Color.White;
            btnValidar.Location = new Point(433, 258);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(142, 33);
            btnValidar.TabIndex = 4;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = false;
            btnValidar.Click += btnValidar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 38, 70);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(266, 331);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.contraseña;
            pictureBox1.Location = new Point(39, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 175);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 59, 104);
            ClientSize = new Size(780, 330);
            Controls.Add(panel1);
            Controls.Add(btnValidar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContrasena2);
            Controls.Add(txtContrasena1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtContrasena1;
        private TextBox txtContrasena2;
        private Label label1;
        private Label label2;
        private Button btnValidar;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}