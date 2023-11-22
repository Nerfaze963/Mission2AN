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
            buttonEditDuree = new Button();
            buttonSuppLia = new Button();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            tbDuree = new TextBox();
            tbAddDuree = new TextBox();
            label8 = new Label();
            label9 = new Label();
            comboBoxPort1 = new ComboBox();
            comboBoxPort2 = new ComboBox();
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
            listBoxSecteurs.SelectedIndexChanged += listBoxSecteurs_SelectedIndexChanged;
            // 
            // listBoxLiaisons
            // 
            listBoxLiaisons.FormattingEnabled = true;
            listBoxLiaisons.ItemHeight = 15;
            listBoxLiaisons.Location = new Point(441, 81);
            listBoxLiaisons.Name = "listBoxLiaisons";
            listBoxLiaisons.Size = new Size(220, 94);
            listBoxLiaisons.TabIndex = 1;
            listBoxLiaisons.SelectedIndexChanged += listBoxLiaisons_SelectedIndexChanged;
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
            label2.Text = "Durée";
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
            label5.Text = "Durée";
            // 
            // button1
            // 
            button1.Location = new Point(186, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 16;
            button1.Text = "Ajouter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonEditDuree
            // 
            buttonEditDuree.Location = new Point(466, 303);
            buttonEditDuree.Name = "buttonEditDuree";
            buttonEditDuree.Size = new Size(75, 23);
            buttonEditDuree.TabIndex = 17;
            buttonEditDuree.Text = "Modifier";
            buttonEditDuree.UseVisualStyleBackColor = true;
            buttonEditDuree.Click += button2_Click;
            // 
            // buttonSuppLia
            // 
            buttonSuppLia.BackColor = Color.White;
            buttonSuppLia.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSuppLia.ForeColor = Color.Black;
            buttonSuppLia.Location = new Point(662, 303);
            buttonSuppLia.Name = "buttonSuppLia";
            buttonSuppLia.Size = new Size(75, 23);
            buttonSuppLia.TabIndex = 18;
            buttonSuppLia.Text = "Supprimer";
            buttonSuppLia.UseVisualStyleBackColor = false;
            buttonSuppLia.Click += buttonSuppLia_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(175, 208);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 19;
            label4.Text = "AJOUTER LIAISON";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(441, 208);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 20;
            label6.Text = "MODIFIER LIAISON";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(651, 208);
            label7.Name = "label7";
            label7.Size = new Size(116, 15);
            label7.TabIndex = 21;
            label7.Text = "SUPPRIMER LIAISON";
            // 
            // tbDuree
            // 
            tbDuree.Location = new Point(448, 261);
            tbDuree.Name = "tbDuree";
            tbDuree.Size = new Size(100, 23);
            tbDuree.TabIndex = 22;
            tbDuree.TextChanged += tbDuree_TextChanged;
            // 
            // tbAddDuree
            // 
            tbAddDuree.Location = new Point(175, 373);
            tbAddDuree.Name = "tbAddDuree";
            tbAddDuree.Size = new Size(100, 23);
            tbAddDuree.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(198, 52);
            label8.Name = "label8";
            label8.Size = new Size(106, 17);
            label8.TabIndex = 24;
            label8.Text = "Liste secteurs";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(466, 50);
            label9.Name = "label9";
            label9.Size = new Size(100, 17);
            label9.TabIndex = 25;
            label9.Text = "Liste liaisons";
            // 
            // comboBoxPort1
            // 
            comboBoxPort1.FormattingEnabled = true;
            comboBoxPort1.Location = new Point(174, 264);
            comboBoxPort1.Name = "comboBoxPort1";
            comboBoxPort1.Size = new Size(121, 23);
            comboBoxPort1.TabIndex = 26;
            // 
            // comboBoxPort2
            // 
            comboBoxPort2.FormattingEnabled = true;
            comboBoxPort2.Location = new Point(174, 319);
            comboBoxPort2.Name = "comboBoxPort2";
            comboBoxPort2.Size = new Size(121, 23);
            comboBoxPort2.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(310, 18);
            label10.Name = "label10";
            label10.Size = new Size(146, 27);
            label10.TabIndex = 28;
            label10.Text = "SICILYLINES";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label10);
            Controls.Add(comboBoxPort2);
            Controls.Add(comboBoxPort1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(tbAddDuree);
            Controls.Add(tbDuree);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(buttonSuppLia);
            Controls.Add(buttonEditDuree);
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
        private Button buttonEditDuree;
        private Button buttonSuppLia;
        private Label label4;
        private Label label6;
        private Label label7;
        private TextBox tbDuree;
        private TextBox tbAddDuree;
        private Label label8;
        private Label label9;
        private ComboBox comboBoxPort1;
        private ComboBox comboBoxPort2;
        private Label label10;
    }
}