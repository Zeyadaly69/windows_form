using System;
using System.Windows.Forms;
using System.IO;

namespace Task_1
{
    public partial class Form2 : Form
    {
        public string name;
        public int age;
        public string address;
        public string gender;
        public CheckedListBox ch = new CheckedListBox();

        public Form2(string name, int age, string gender, string address, CheckedListBox c)
        {
            InitializeComponent();
            this.name = name;
            this.age = age;
            this.ch = c;
            this.address = address;
            this.gender = gender;
        }

        private void btn_inf0_Click(object sender, EventArgs e)
        {
            string data = "";

            if (ch.CheckedItems.Count >= 1)
            {
                string t = "";
                foreach (var item in ch.CheckedItems)
                {
                    t += item + "  ";
                }

                data = $"Name is {name}\nAge is {age}\nGender is {gender}\nCity is {address}\nCourses: {t}";
            }
            else
            {
                data = $"Name is {name}\nAge is {age}\nGender is {gender}\nCity is {address}\nCourses: {ch.CheckedItems}";
            }

            // Clear the content of the file before writing new information
            File.WriteAllText("my_data.txt", "");

            // Write the message to the file "my_data.txt"
            using (StreamWriter writer = new StreamWriter("my_data.txt", true))
            {
                writer.WriteLine(data);
            }

            // Read the contents of the file and set it to the RichTextBox
            ReadFileAndSetContent("my_data.txt");
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Read the contents of the file and set it to the RichTextBox
            ReadFileAndSetContent("my_data.txt");
        }

        private void ReadFileAndSetContent(string filePath)
        {
            try
            {
                // Read the contents of the file using FileStream and StreamReader
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    // Set the RichTextBox text to the content of the file
                    richbox_read.Text = streamReader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void richbox_read_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
