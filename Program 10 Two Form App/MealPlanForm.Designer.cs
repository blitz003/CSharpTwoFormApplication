
namespace Program_10_Two_Form_App
{
    partial class MealPlanForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.addMealPlanButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a Weekly Meal Plan";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Items.AddRange(new object[] {
            "7 Meals",
            "14 Meals",
            "Unlimited Meals"});
            this.listBox1.Location = new System.Drawing.Point(61, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(254, 120);
            this.listBox1.TabIndex = 0;
            // 
            // addMealPlanButton
            // 
            this.addMealPlanButton.AutoSize = true;
            this.addMealPlanButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addMealPlanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMealPlanButton.Location = new System.Drawing.Point(109, 202);
            this.addMealPlanButton.Name = "addMealPlanButton";
            this.addMealPlanButton.Size = new System.Drawing.Size(179, 39);
            this.addMealPlanButton.TabIndex = 1;
            this.addMealPlanButton.Text = "Add Meal Plan";
            this.addMealPlanButton.UseVisualStyleBackColor = true;
            this.addMealPlanButton.Click += new System.EventHandler(this.addMealPlanButton_Click);
            // 
            // MealPlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 252);
            this.Controls.Add(this.addMealPlanButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "MealPlanForm";
            this.Text = "Meal Plans";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button addMealPlanButton;
    }
}