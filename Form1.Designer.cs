namespace Practica__23_vsed
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
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            btn1 = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(69, 38);
            label1.Name = "label1";
            label1.Size = new Size(442, 21);
            label1.TabIndex = 0;
            label1.Text = "Este Programa suma los numeros capturados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(69, 99);
            label2.Name = "label2";
            label2.Size = new Size(219, 21);
            label2.TabIndex = 1;
            label2.Text = "introduce un Numero";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(294, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 29);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(150, 232);
            label3.Name = "label3";
            label3.Size = new Size(217, 21);
            label3.TabIndex = 3;
            label3.Text = "La suma de todos son:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(373, 232);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 29);
            textBox2.TabIndex = 4;
            // 
            // btn1
            // 
            btn1.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.Location = new Point(437, 95);
            btn1.Name = "btn1";
            btn1.Size = new Size(94, 39);
            btn1.TabIndex = 5;
            btn1.Text = "Añadir";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(39, 242);
            button2.Name = "button2";
            button2.Size = new Size(88, 47);
            button2.TabIndex = 6;
            button2.Text = "Sumar numeros";
            button2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(585, 78);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(162, 319);
            listBox1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(btn1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Button btn1;
        private Button button2;
        private ListBox listBox1;
    }
}