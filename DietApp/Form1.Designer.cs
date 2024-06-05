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
            button1 = new Button();
            surname = new TextBox();
            label2 = new Label();
            age = new TextBox();
            label3 = new Label();
            height = new TextBox();
            label4 = new Label();
            weight = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            sex = new ComboBox();
            goal = new ComboBox();
            label8 = new Label();
            checkBox1 = new CheckBox();
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
            // button1
            // 
            button1.Location = new Point(317, 321);
            button1.Name = "button1";
            button1.Size = new Size(148, 76);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
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
            // age
            // 
            age.Location = new Point(138, 112);
            age.Name = "age";
            age.Size = new Size(100, 23);
            age.TabIndex = 5;
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
            // height
            // 
            height.Location = new Point(547, 21);
            height.Name = "height";
            height.Size = new Size(100, 23);
            height.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 166);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 6;
            label4.Text = "Φύλο";
            // 
            // weight
            // 
            weight.Location = new Point(547, 63);
            weight.Name = "weight";
            weight.Size = new Size(100, 23);
            weight.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(440, 29);
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
            label7.Location = new Point(440, 115);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 12;
            label7.Text = "Στόχος";
            // 
            // sex
            // 
            sex.FormattingEnabled = true;
            sex.Items.AddRange(new object[] { "Άνδρας", "Γυναίκα", "Άλλο" });
            sex.Location = new Point(138, 163);
            sex.Name = "sex";
            sex.Size = new Size(121, 23);
            sex.TabIndex = 16;
            // 
            // goal
            // 
            goal.FormattingEnabled = true;
            goal.Items.AddRange(new object[] { "Απώλεια βάρους ", "Αύξηση βάρους", "Διατήρηση βάρους" });
            goal.Location = new Point(547, 112);
            goal.Name = "goal";
            goal.Size = new Size(121, 23);
            goal.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(440, 171);
            label8.Name = "label8";
            label8.Size = new Size(113, 15);
            label8.TabIndex = 18;
            label8.Text = "Αύξηση μυικότητας";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(574, 172);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 19;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 481);
            Controls.Add(checkBox1);
            Controls.Add(label8);
            Controls.Add(goal);
            Controls.Add(sex);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(weight);
            Controls.Add(label5);
            Controls.Add(height);
            Controls.Add(label4);
            Controls.Add(age);
            Controls.Add(label3);
            Controls.Add(surname);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(name);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox name;
        private Button button1;
        private TextBox surname;
        private Label label2;
        private TextBox age;
        private Label label3;
        private TextBox height;
        private Label label4;
        private TextBox weight;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox sex;
        private ComboBox goal;
        private Label label8;
        private CheckBox checkBox1;
    }
}
