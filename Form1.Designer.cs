namespace Task_1
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
            lab_name = new Label();
            lab_age = new Label();
            lab_gender = new Label();
            lab_cousre = new Label();
            lab_addrees = new Label();
            txt_name = new TextBox();
            cmb_address = new ComboBox();
            txt_age = new TextBox();
            chlb_course = new CheckedListBox();
            btn_submit = new Button();
            cmb_gender = new ComboBox();
            SuspendLayout();
            // 
            // lab_name
            // 
            lab_name.AutoSize = true;
            lab_name.Location = new Point(63, 36);
            lab_name.Name = "lab_name";
            lab_name.Size = new Size(56, 20);
            lab_name.TabIndex = 0;
            lab_name.Text = "Name :";
            // 
            // lab_age
            // 
            lab_age.AutoSize = true;
            lab_age.Location = new Point(63, 88);
            lab_age.Name = "lab_age";
            lab_age.Size = new Size(43, 20);
            lab_age.TabIndex = 1;
            lab_age.Text = "Age :";
            // 
            // lab_gender
            // 
            lab_gender.AutoSize = true;
            lab_gender.Location = new Point(55, 149);
            lab_gender.Name = "lab_gender";
            lab_gender.Size = new Size(64, 20);
            lab_gender.TabIndex = 2;
            lab_gender.Text = "Gender :";
            // 
            // lab_cousre
            // 
            lab_cousre.AutoSize = true;
            lab_cousre.Location = new Point(58, 327);
            lab_cousre.Name = "lab_cousre";
            lab_cousre.Size = new Size(61, 20);
            lab_cousre.TabIndex = 3;
            lab_cousre.Text = "Course :";
            // 
            // lab_addrees
            // 
            lab_addrees.AutoSize = true;
            lab_addrees.Location = new Point(50, 212);
            lab_addrees.Name = "lab_addrees";
            lab_addrees.Size = new Size(69, 20);
            lab_addrees.TabIndex = 4;
            lab_addrees.Text = "Address :";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(150, 36);
            txt_name.Name = "txt_name";
            txt_name.PlaceholderText = "Enter your name";
            txt_name.Size = new Size(179, 27);
            txt_name.TabIndex = 5;
            // 
            // cmb_address
            // 
            cmb_address.AutoCompleteCustomSource.AddRange(new string[] { "Male", "Female" });
            cmb_address.FormattingEnabled = true;
            cmb_address.Items.AddRange(new object[] { "mansoura ", "alexandria", "cairo ", "giza", "other" });
            cmb_address.Location = new Point(150, 209);
            cmb_address.Name = "cmb_address";
            cmb_address.Size = new Size(179, 28);
            cmb_address.TabIndex = 6;
            cmb_address.Text = " Choose your City";
            // 
            // txt_age
            // 
            txt_age.Location = new Point(150, 88);
            txt_age.Name = "txt_age";
            txt_age.PlaceholderText = "Enter your age";
            txt_age.Size = new Size(179, 27);
            txt_age.TabIndex = 7;
            // 
            // chlb_course
            // 
            chlb_course.CheckOnClick = true;
            chlb_course.FormattingEnabled = true;
            chlb_course.Items.AddRange(new object[] { "c#", "c++", "python ", "Html", "css", "java" });
            chlb_course.Location = new Point(174, 270);
            chlb_course.Name = "chlb_course";
            chlb_course.Size = new Size(133, 136);
            chlb_course.TabIndex = 8;
            // 
            // btn_submit
            // 
            btn_submit.Location = new Point(150, 462);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(131, 29);
            btn_submit.TabIndex = 9;
            btn_submit.Text = "Submit";
            btn_submit.UseVisualStyleBackColor = true;
            btn_submit.Click += btn_submit_Click;
            // 
            // cmb_gender
            // 
            cmb_gender.FormattingEnabled = true;
            cmb_gender.Items.AddRange(new object[] { "Male", "Female" });
            cmb_gender.Location = new Point(150, 146);
            cmb_gender.Name = "cmb_gender";
            cmb_gender.Size = new Size(179, 28);
            cmb_gender.TabIndex = 10;
            cmb_gender.Text = "Choose your gender";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(465, 535);
            Controls.Add(cmb_gender);
            Controls.Add(btn_submit);
            Controls.Add(chlb_course);
            Controls.Add(txt_age);
            Controls.Add(cmb_address);
            Controls.Add(txt_name);
            Controls.Add(lab_addrees);
            Controls.Add(lab_cousre);
            Controls.Add(lab_gender);
            Controls.Add(lab_age);
            Controls.Add(lab_name);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lab_name;
        private Label lab_age;
        private Label lab_gender;
        private Label lab_cousre;
        private Label lab_addrees;
        private TextBox txt_name;
        private ComboBox cmb_address;
        private TextBox txt_age;
        private CheckedListBox chlb_course;
        private Button btn_submit;
        private ComboBox cmb_gender;
    }
}