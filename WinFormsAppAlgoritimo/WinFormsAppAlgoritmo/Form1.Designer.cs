namespace WinFormsAppAlgoritmo
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
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(27, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(761, 238);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de conta";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 39);
            textBox1.TabIndex = 0;
            textBox1.Text = "1234";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(266, 73);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(214, 39);
            textBox2.TabIndex = 1;
            textBox2.Text = "Kauane";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 45);
            label1.Name = "label1";
            label1.Size = new Size(201, 32);
            label1.TabIndex = 2;
            label1.Text = "Numero da conta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(266, 45);
            label2.Name = "label2";
            label2.Size = new Size(180, 32);
            label2.TabIndex = 3;
            label2.Text = "Titular da conta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(266, 130);
            label3.Name = "label3";
            label3.Size = new Size(160, 32);
            label3.TabIndex = 7;
            label3.Text = "Tipo da conta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 130);
            label4.Name = "label4";
            label4.Size = new Size(172, 32);
            label4.TabIndex = 6;
            label4.Text = "Saldo da conta";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(266, 158);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(214, 39);
            textBox3.TabIndex = 5;
            textBox3.Text = "corrente";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(6, 158);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(226, 39);
            textBox4.TabIndex = 4;
            textBox4.Text = "9999";
            textBox4.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}
