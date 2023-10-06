using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopingLabTask3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CalculateCaloriesBurned();
        }

        private void CalculateCaloriesBurned()
        { 
            listBoxCaloriesBurned.Items.Clear();
            

            double caloriesPerMinute = 3.9;

            for (int minutes = 10; minutes <= 30; minutes += 5)
            {
                double caloriesBurned = caloriesPerMinute * minutes;
                listBoxCaloriesBurned.Items.Add($"After {minutes} minutes: {caloriesBurned} calories");

            }
        }

        private void listBoxCaloriesBurned_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
