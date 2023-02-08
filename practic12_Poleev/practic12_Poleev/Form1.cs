using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practic12_Poleev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student stud = new Student();            
            stud.name = textBox1.Text;
            stud.rost = (int)numericUpDown1.Value;
            MessageBox.Show(string.Format($"Студент: {stud.name} \nрост: {stud.rost} \nвес: {stud.GetEat()}"));
            stud.SetEat(1);
            MessageBox.Show(string.Format("Студент: {0} \nрост: {1} \nвес: {2}", stud.name, stud.rost, stud.GetEat()));
            stud.SetEat(5);
            MessageBox.Show(string.Format($"Студент: {stud.name} \nсъедено еды: 5 кг \nрост: {stud.rost}  \nвес: {stud.GetEat()}"));
        }
    }
}
