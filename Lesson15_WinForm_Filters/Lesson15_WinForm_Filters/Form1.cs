using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson15_WinForm_Filters
{
    public partial class PersonGeneratorForm : Form
    {
        public PersonGeneratorForm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            int intervalValue = Convert.ToInt32(TimerIntervalNumeric.Value);

            Person person = new Person();
            person.NewPerson(intervalValue);

            PersonSaver personSaver = new PersonSaver();
            ResultTextBox.Text = personSaver.Result;
         

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
