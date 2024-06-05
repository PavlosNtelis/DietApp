namespace DietApp
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
            name = new TextBox();
            register = new Button();
            surname = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            sex = new ComboBox();
            goal = new ComboBox();
            label8 = new Label();
            checkBox1 = new CheckBox();
            age = new NumericUpDown();
            height = new NumericUpDown();
            weight = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)age).BeginInit();
            ((System.ComponentModel.ISupportInitialize)height).BeginInit();
            ((System.ComponentModel.ISupportInitialize)weight).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 21);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Όνομα";
            // 
            // name
            // 
            name.Location = new Point(138, 21);
            name.Name = "name";
            name.Size = new Size(100, 23);
            name.TabIndex = 1;
            // 
            // register
            // 
            register.BackgroundImageLayout = ImageLayout.None;
            register.Location = new Point(317, 321);
            register.Name = "register";
            register.Size = new Size(148, 76);
            register.TabIndex = 0;
            register.Text = "Εγγραφή";
            register.UseVisualStyleBackColor = true;
            register.Click += register_Click;
            // 
            // surname
            // 
            surname.Location = new Point(138, 63);
            surname.Name = "surname";
            surname.Size = new Size(100, 23);
            surname.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 66);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 2;
            label2.Text = "Επίθετο";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 112);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 4;
            label3.Text = "Ηλικία";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 163);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 6;
            label4.Text = "Φύλο";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(436, 29);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 8;
            label5.Text = "Ύψος";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(436, 66);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 10;
            label6.Text = "Βάρος";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(436, 115);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 12;
            label7.Text = "Στόχος";
            // 
            // sex
            // 
            sex.FormattingEnabled = true;
            sex.Items.AddRange(new object[] { "Άνδρας", "Γυναίκα", "Άλλο" });
            sex.Location = new Point(138, 160);
            sex.Name = "sex";
            sex.Size = new Size(121, 23);
            sex.TabIndex = 16;
            // 
            // goal
            // 
            goal.FormattingEnabled = true;
            goal.Items.AddRange(new object[] { "Απώλεια βάρους ", "Αύξηση βάρους", "Διατήρηση βάρους" });
            goal.Location = new Point(519, 109);
            goal.Name = "goal";
            goal.Size = new Size(121, 23);
            goal.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(436, 163);
            label8.Name = "label8";
            label8.Size = new Size(113, 15);
            label8.TabIndex = 18;
            label8.Text = "Αύξηση μυικότητας";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(574, 164);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 19;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // age
            // 
            age.Location = new Point(138, 112);
            age.Name = "age";
            age.Size = new Size(120, 23);
            age.TabIndex = 20;
            // 
            // height
            // 
            height.Location = new Point(519, 29);
            height.Name = "height";
            height.Size = new Size(120, 23);
            height.TabIndex = 21;
            // 
            // weight
            // 
            weight.Location = new Point(519, 66);
            weight.Name = "weight";
            weight.Size = new Size(120, 23);
            weight.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 481);
            Controls.Add(weight);
            Controls.Add(height);
            Controls.Add(age);
            Controls.Add(checkBox1);
            Controls.Add(label8);
            Controls.Add(goal);
            Controls.Add(sex);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(surname);
            Controls.Add(label2);
            Controls.Add(register);
            Controls.Add(name);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)age).EndInit();
            ((System.ComponentModel.ISupportInitialize)height).EndInit();
            ((System.ComponentModel.ISupportInitialize)weight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox name;
        private Button register;
        private TextBox surname;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox sex;
        private ComboBox goal;
        private Label label8;
        private CheckBox checkBox1;
        private NumericUpDown age;
        private NumericUpDown height;
        private NumericUpDown weight;
    }
}
