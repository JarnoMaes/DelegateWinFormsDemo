using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DelegateWinFormsDemo.Models;

namespace DelegateWinFormsDemo
{
    public delegate string PersonFormat(Person input);
    public partial class Form1 : Form
    {
        PersonFormat proc;
        public Form1()
        {
            InitializeComponent();
        }

        private void AssignToDelegate()
        {
            if (rbOptionOne.Checked)
                proc = Formatters.Default;
            else if (rbOptionTwo.Checked)
                proc = Formatters.LastNameToUpper;
            else if (rbOptionThree.Checked)
                proc = Formatters.FirstNameToLower;
            else if (rbOptionFour.Checked)
                proc = Formatters.FullNameToUpper;
            else
                proc = Formatters.Default;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //lstPerson.DataSource = null;
            lstPerson.Items.Clear();
            foreach (Person person in People.GetPeople())
            {  
                AssignToDelegate();
                lstPerson.Items.Add(person.ToString(proc));
            }
        }
    }
}
