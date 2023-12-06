namespace Task_1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_inf0 = new Button();
            richbox_read = new RichTextBox();
            SuspendLayout();
            // 
            // btn_inf0
            // 
            btn_inf0.BackColor = SystemColors.ControlLightLight;
            btn_inf0.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_inf0.Location = new Point(110, 211);
            btn_inf0.Name = "btn_inf0";
            btn_inf0.Size = new Size(163, 63);
            btn_inf0.TabIndex = 0;
            btn_inf0.Text = "Show information";
            btn_inf0.UseVisualStyleBackColor = false;
            btn_inf0.Click += btn_inf0_Click;
            // 
            // richbox_read
            // 
            richbox_read.Location = new Point(51, 42);
            richbox_read.Name = "richbox_read";
            richbox_read.Size = new Size(304, 138);
            richbox_read.TabIndex = 1;
            richbox_read.Text = "";
            richbox_read.TextChanged += richbox_read_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.windows_background_1___Copy;
            ClientSize = new Size(416, 337);
            Controls.Add(richbox_read);
            Controls.Add(btn_inf0);
            KeyPreview = true;
            Name = "Form2";
            Text = "Form2";
            KeyDown += Form2_KeyDown;
            ResumeLayout(false);
        }




        #endregion

        private Button btn_inf0;
        private RichTextBox richbox_read;
    }
}