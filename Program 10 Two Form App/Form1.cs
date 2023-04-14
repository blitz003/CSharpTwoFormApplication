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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int DormIndex, DormAmount, FinalTotal;

        private void addDormButton_Click(object sender, EventArgs e)
        {
            try
            {
                GetDormCost();
                ShowDormTotal();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void GetDormCost()
        {
            try
            {
                DormIndex = listBox1.SelectedIndex;
                if (DormIndex == 0)
                    DormAmount = 1500;
                else if (DormIndex == 1)
                    DormAmount = 1600;
                else if (DormIndex == 2)
                    DormAmount = 1200;
                else if (DormIndex == 3)
                    DormAmount = 1800;

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void ShowDormTotal()
        {
            try
            {
                dormOutputLabel.Text = DormAmount.ToString("c");
                FinalTotal = MealPlanForm.MPAmount + DormAmount;
                totalOutputLabel.Text = FinalTotal.ToString("c");

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void viewMealPlanButton_Click(object sender, EventArgs e)
        {
            try
            {
                ShowMealPlanForm();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void ShowMealPlanForm()
        {
            try
            {
                MealPlanForm MPForm = new MealPlanForm();
                MPForm.ShowDialog();

                ShowTotals();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void ShowTotals()
        {
            try
            {
                mealPlanOutputLabel.Text = MealPlanForm.MPAmount.ToString("c");
                FinalTotal = MealPlanForm.MPAmount + DormAmount;
                totalOutputLabel.Text = FinalTotal.ToString("c");

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            try
            {
                ClearAll();

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void ClearAll()
        {
            try
            {
                DormAmount = 0;
                dormOutputLabel.Text = "";
                MealPlanForm.MPAmount = 0;
                mealPlanOutputLabel.Text = "";
                FinalTotal = 0;
                totalOutputLabel.Text = "";
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            try
            {
                ExitForm();
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
