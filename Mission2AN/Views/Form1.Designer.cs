namespace Mission2AN
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
            listBoxSecteurs = new ListBox();
            listBoxLiaisons = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label10 = new Label();
            SuspendLayout();
            // 
            // listBoxSecteurs
            // 
            listBoxSecteurs.FormattingEnabled = true;
            listBoxSecteurs.ItemHeight = 15;
            listBoxSecteurs.Location = new Point(175, 81);
            listBoxSecteurs.Name = "listBoxSecteurs";
            listBoxSecteurs.Size = new Size(120, 94);
            listBoxSecteurs.TabIndex = 0;
            listBoxSecteurs.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBoxLiaisons
            // 
            listBoxLiaisons.FormattingEnabled = true;
            listBoxLiaisons.ItemHeight = 15;
            listBoxLiaisons.Location = new Point(441, 81);
            listBoxLiaisons.Name = "listBoxLiaisons";
            listBoxLiaisons.Size = new Size(120, 94);
            listBoxLiaisons.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(186, 243);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 6;
            label1.Text = "Port d'arrivée";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(480, 243);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 7;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(186, 301);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 10;
            label3.Text = "Port de départ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(207, 355);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 14;
            label5.Text = "label5";
            // 
            // button1
            // 
            button1.Location = new Point(186, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 16;
            button1.Text = "Ajouter";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(466, 303);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 17;
            button2.Text = "Modifier";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(662, 303);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 18;
            button3.Text = "Supprimer";
            button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(175, 208);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 19;
            label4.Text = "AJOUTER LIAISON";
            label4.Click += label4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(441, 208);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 20;
            label6.Text = "MODIFIER LIAISON";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(651, 208);
            label7.Name = "label7";
            label7.Size = new Size(116, 15);
            label7.TabIndex = 21;
            label7.Text = "SUPPRIMER LIAISON";
            label7.Click += label7_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(448, 261);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 22;
            textBox4.TextChanged += textBox4_TextChanged_1;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(175, 373);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(198, 52);
            label8.Name = "label8";
            label8.Size = new Size(77, 15);
            label8.TabIndex = 24;
            label8.Text = "Liste secteurs";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(466, 52);
            label9.Name = "label9";
            label9.Size = new Size(73, 15);
            label9.TabIndex = 25;
            label9.Text = "Liste liaisons";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(174, 264);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 26;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(174, 319);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(337, 18);
            label10.Name = "label10";
            label10.Size = new Size(69, 15);
            label10.TabIndex = 28;
            label10.Text = "SICILYLINES";
            label10.Click += label10_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label10);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxLiaisons);
            Controls.Add(listBoxSecteurs);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxSecteurs;
        private ListBox listBoxLiaisons;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label4;
        private Label label6;
        private Label label7;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label8;
        private Label label9;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label10;
    }
}