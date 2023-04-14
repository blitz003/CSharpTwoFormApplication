using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_10_Two_Form_App
{
    public partial class MealPlanForm : Form
    {
        public MealPlanForm()
        {
            InitializeComponent();
        }

        int MPIndex;
        public static int MPAmount;

        private void addMealPlanButton_Click(object sender, EventArgs e)
        {
            try
            {
                GetMealCost();
                ExitForm();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void GetMealCost()
        {
            try
            {
                MPIndex = listBox1.SelectedIndex;
                if (MPIndex == 0)
                    MPAmount = 560;             
                else if (MPIndex == 1)
                    MPAmount = 1095;
                else if (MPIndex == 2)
                    MPAmount = 1500;
            }
            catch (Exception)
            {

                throw;
            }
        }      
        private void ExitForm()
        {
            try
            {
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
