using System;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string n = txt_name.Text;
            int g = int.Parse(txt_age.Text);
            string a = cmb_address.Text;
            string gen = cmb_gender.Text;

            // Create a string with the information
            string information = $"Name: {n}\nAge: {g}\nGender: {gen}\nCity: {a}\n";

            // Append selected courses to the information string
            information += "Courses: ";
            foreach (var item in chlb_course.CheckedItems)
            {
                information += item + " ";
            }

            // Save the information to the file "my_data.txt"
            File.WriteAllText("my_data.txt", information);

            MessageBox.Show("The information has been saved");

            // Open Form2 with the information
            Form2 f = new Form2(n, g, gen, a, chlb_course);
            f.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
