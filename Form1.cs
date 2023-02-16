using System;
using System.IO;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace Programming_project
{
    public partial class Employeedatemanager : Form
    {
        public Employeedatemanager()
        {
            InitializeComponent();
        }

        private void ReadBtn_Click(object sender, EventArgs e)
        {
            var loc = readtxtbox1.Text;

            if (!File.Exists(loc))
            {
                MessageBox.Show("Incorrect location entered, Please enter a valid file location");
                return;
            }

            var file_read = File.ReadAllText(loc);

            file_read = file_read.Replace(";", " ");

            Readrichtxtbox1.Text = file_read;
        }

        private void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Employees\\" + FirstNameTb.Text + ";" + LastNameTb.Text);
            sw.WriteLine(label1.Text + ";" + FirstNameTb.Text);
            sw.WriteLine(label2.Text + ";" + LastNameTb.Text);
            sw.WriteLine(label3.Text + ";" + GenderCb.Text);
            sw.WriteLine(label4.Text + ";" + AddressTb.Text);
            sw.Close();
            MessageBox.Show("Employee added sucessfully");
        }

        private void SelectFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog OF = new OpenFileDialog();
            OF.Filter = "txt files (*.txt)|*.txt|All Files (*.*)|*.*";
            if(OF.ShowDialog() == DialogResult.OK)
            {
                readtxtbox1.Text = OF.FileName;
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var del = readtxtbox1.Text;

            if (File.Exists(del))
            {
                File.Delete(del);

                MessageBox.Show("Employee data deleted sucessfully");
            }

            else MessageBox.Show("Incorrect location entered, Please enter a valid file location");
            return;
        }

        private void Employeedatemanager_Load(object sender, EventArgs e)
        {

        }
    }
}
