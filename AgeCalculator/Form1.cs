using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtCurrentDate.Text = DateTime.Now.ToString();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int currentDate = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int selectedDate = int.Parse(dateOfBirthPicker.Value.ToString("yyyyMMdd"));
            int ageInYears = (currentDate - selectedDate) / 10000;
            int ageInMonths = ageInYears * 12;
            int ageInDays = ageInMonths * 30;

            txtAgeYears.Text = ageInYears.ToString() + " years";
            txtAgeMonths.Text = ageInMonths.ToString() + " months";
            txtAgeDays.Text = ageInDays.ToString() + " days";
        }

        private void lblCurrentDate_Click(object sender, EventArgs e)
        {

        }
    }
}
