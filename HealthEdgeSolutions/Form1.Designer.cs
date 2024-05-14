namespace HealthEdgeSolutions
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(152, 255, 152);
            pictureBox1.Location = new Point(-3, -8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 578);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(80, 200, 120);
            pictureBox2.Location = new Point(-3, -8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(937, 135);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(80, 200, 120);
            button1.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(40, 175);
            button1.Name = "button1";
            button1.Size = new Size(65, 49);
            button1.TabIndex = 2;
            button1.Text = "Головна";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(80, 200, 120);
            button2.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(40, 245);
            button2.Name = "button2";
            button2.Size = new Size(65, 49);
            button2.TabIndex = 3;
            button2.Text = "Медична картка";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(80, 200, 120);
            button3.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(40, 309);
            button3.Name = "button3";
            button3.Size = new Size(65, 49);
            button3.TabIndex = 4;
            button3.Text = "Лікарі";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(80, 200, 120);
            button4.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(40, 375);
            button4.Name = "button4";
            button4.Size = new Size(65, 49);
            button4.TabIndex = 5;
            button4.Text = "Рахунки";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(80, 200, 120);
            button5.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(40, 447);
            button5.Name = "button5";
            button5.Size = new Size(65, 49);
            button5.TabIndex = 6;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 255, 209);
            ClientSize = new Size(919, 567);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "HealthEdge";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
