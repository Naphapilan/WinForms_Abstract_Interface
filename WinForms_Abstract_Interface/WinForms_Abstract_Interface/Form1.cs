using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Abstract_Interface
{
    public partial class Form1 : Form
    {
        List<Student> cSsharpStudent; 
        List<Student> pythonStudent;
        public Form1()
        {
            InitializeComponent();

            this.cSsharpStudent = new List<Student>();
            this.pythonStudent = new List<Student>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Name = this.textBoxName.Text;
            student.LastName = this.textBoxLastname.Text;

            this.cSsharpStudent.Add(student);
            displayStudentData();

        }

        private void Form1_Load(object sender, EventArgs e)
        {    
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void DisplaystudentData_TextChanged(object sender, EventArgs e)
        {
            displayStudentData();
        }
        private void displayStudentData()
        {
            //โชว์สถานะที่แถบแสดงสถานะ(Displaystydentdata)
            this.DisplaystudentData.Text = "Student in C# course ; "
                + this.cSsharpStudent.Count + "\r\n"
                + "Student in Python course : "
                + this.pythonStudent.Count;

        }

        private void buttonpy_Click(object sender, EventArgs e)
        {

            Student student = new Student();
            student.Name = this.textBoxName.Text;
            student.LastName = this.textBoxLastname.Text;

            this.pythonStudent.Add(student);
            displayStudentData();
        }
    }
}
