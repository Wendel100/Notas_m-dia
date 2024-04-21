namespace Aula_media_Notas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btncalcular = new Button();
            text1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            text4 = new TextBox();
            text3 = new TextBox();
            text2 = new TextBox();
            text5 = new TextBox();
            btnlimpar = new Button();
            text6 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btncalcular
            // 
            btncalcular.BackColor = SystemColors.ActiveCaption;
            btncalcular.Font = new Font("Roboto Bk", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncalcular.ForeColor = Color.Black;
            btncalcular.Location = new Point(197, 186);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(75, 22);
            btncalcular.TabIndex = 0;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = false;
            btncalcular.Click += btncalcular_Click;
            // 
            // text1
            // 
            text1.BackColor = SystemColors.WindowFrame;
            text1.BorderStyle = BorderStyle.FixedSingle;
            text1.Font = new Font("Roboto", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text1.ForeColor = SystemColors.MenuHighlight;
            text1.Location = new Point(172, 108);
            text1.Name = "text1";
            text1.Size = new Size(56, 23);
            text1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Roboto Cn", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(234, 111);
            label2.Name = "label2";
            label2.Size = new Size(20, 14);
            label2.TabIndex = 3;
            label2.Text = "N2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Roboto Cn", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(144, 151);
            label3.Name = "label3";
            label3.Size = new Size(20, 14);
            label3.TabIndex = 4;
            label3.Text = "N3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Roboto Cn", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(234, 151);
            label4.Name = "label4";
            label4.Size = new Size(20, 14);
            label4.TabIndex = 5;
            label4.Text = "N4";
            // 
            // text4
            // 
            text4.BackColor = SystemColors.WindowFrame;
            text4.BorderStyle = BorderStyle.FixedSingle;
            text4.Font = new Font("Roboto", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text4.ForeColor = SystemColors.MenuHighlight;
            text4.Location = new Point(262, 144);
            text4.Name = "text4";
            text4.Size = new Size(56, 23);
            text4.TabIndex = 6;
            // 
            // text3
            // 
            text3.BackColor = SystemColors.WindowFrame;
            text3.BorderStyle = BorderStyle.FixedSingle;
            text3.Font = new Font("Roboto", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text3.ForeColor = SystemColors.MenuHighlight;
            text3.Location = new Point(172, 144);
            text3.Name = "text3";
            text3.Size = new Size(56, 23);
            text3.TabIndex = 7;
            // 
            // text2
            // 
            text2.BackColor = SystemColors.WindowFrame;
            text2.BorderStyle = BorderStyle.FixedSingle;
            text2.Font = new Font("Roboto", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text2.ForeColor = SystemColors.MenuHighlight;
            text2.Location = new Point(260, 108);
            text2.Name = "text2";
            text2.Size = new Size(56, 23);
            text2.TabIndex = 8;
            text2.TextChanged += text2_TextChanged;
            // 
            // text5
            // 
            text5.BackColor = SystemColors.WindowFrame;
            text5.BorderStyle = BorderStyle.FixedSingle;
            text5.Font = new Font("Futura Md BT", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text5.ForeColor = SystemColors.MenuHighlight;
            text5.Location = new Point(187, 216);
            text5.Name = "text5";
            text5.Size = new Size(100, 23);
            text5.TabIndex = 9;
            text5.TextChanged += text5_TextChanged;
            // 
            // btnlimpar
            // 
            btnlimpar.BackColor = SystemColors.ActiveCaption;
            btnlimpar.Font = new Font("Roboto Bk", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnlimpar.Location = new Point(12, 291);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(75, 22);
            btnlimpar.TabIndex = 11;
            btnlimpar.Text = "limpar";
            btnlimpar.UseVisualStyleBackColor = false;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // text6
            // 
            text6.AutoSize = true;
            text6.BackColor = SystemColors.WindowFrame;
            text6.Font = new Font("Roboto Bk", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text6.ForeColor = SystemColors.ButtonHighlight;
            text6.Location = new Point(189, 258);
            text6.Name = "text6";
            text6.Size = new Size(14, 19);
            text6.TabIndex = 14;
            text6.Text = ":";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(0, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(461, 333);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Roboto Cn", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(144, 110);
            label1.Name = "label1";
            label1.Size = new Size(20, 14);
            label1.TabIndex = 2;
            label1.Text = "N1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Futura Md BT", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.BlueViolet;
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.Location = new Point(108, 47);
            label5.Name = "label5";
            label5.Size = new Size(238, 35);
            label5.TabIndex = 17;
            label5.Text = "Média de notas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(455, 315);
            Controls.Add(label5);
            Controls.Add(text6);
            Controls.Add(btnlimpar);
            Controls.Add(text5);
            Controls.Add(text2);
            Controls.Add(text3);
            Controls.Add(text4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(text1);
            Controls.Add(btncalcular);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Progaming";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncalcular;
        private TextBox text1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox text4;
        private TextBox text3;
        private TextBox text2;
        private TextBox text5;
        private Button btnlimpar;
        private Label text6;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label5;
    }
}
