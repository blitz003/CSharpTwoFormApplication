
namespace Program_10_Two_Form_App
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalOutputLabel = new System.Windows.Forms.Label();
            this.mealPlanOutputLabel = new System.Windows.Forms.Label();
            this.dormOutputLabel = new System.Windows.Forms.Label();
            this.addDormButton = new System.Windows.Forms.Button();
            this.viewMealPlanButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Items.AddRange(new object[] {
            "Allen Hall",
            "Pike Hall",
            "Farthing Hall",
            "University Suites"});
            this.listBox1.Location = new System.Drawing.Point(32, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(227, 149);
            this.listBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 209);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a Dormitory";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dormOutputLabel);
            this.groupBox2.Controls.Add(this.mealPlanOutputLabel);
            this.groupBox2.Controls.Add(this.totalOutputLabel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(325, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 209);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Charges for the Semester";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dormitory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Meal Plan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total";
            // 
            // totalOutputLabel
            // 
            this.totalOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalOutputLabel.Location = new System.Drawing.Point(178, 153);
            this.totalOutputLabel.Name = "totalOutputLabel";
            this.totalOutputLabel.Size = new System.Drawing.Size(135, 29);
            this.totalOutputLabel.TabIndex = 5;
            this.totalOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mealPlanOutputLabel
            // 
            this.mealPlanOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mealPlanOutputLabel.Location = new System.Drawing.Point(178, 90);
            this.mealPlanOutputLabel.Name = "mealPlanOutputLabel";
            this.mealPlanOutputLabel.Size = new System.Drawing.Size(135, 29);
            this.mealPlanOutputLabel.TabIndex = 6;
            this.mealPlanOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dormOutputLabel
            // 
            this.dormOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dormOutputLabel.Location = new System.Drawing.Point(178, 33);
            this.dormOutputLabel.Name = "dormOutputLabel";
            this.dormOutputLabel.Size = new System.Drawing.Size(135, 29);
            this.dormOutputLabel.TabIndex = 7;
            this.dormOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addDormButton
            // 
            this.addDormButton.AutoSize = true;
            this.addDormButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addDormButton.BackColor = System.Drawing.SystemColors.Control;
            this.addDormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDormButton.Location = new System.Drawing.Point(12, 250);
            this.addDormButton.Name = "addDormButton";
            this.addDormButton.Size = new System.Drawing.Size(176, 39);
            this.addDormButton.TabIndex = 8;
            this.addDormButton.Text = "Add Dormitory";
            this.addDormButton.UseVisualStyleBackColor = false;
            this.addDormButton.Click += new System.EventHandler(this.addDormButton_Click);
            // 
            // viewMealPlanButton
            // 
            this.viewMealPlanButton.AutoSize = true;
            this.viewMealPlanButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.viewMealPlanButton.BackColor = System.Drawing.SystemColors.Control;
            this.viewMealPlanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewMealPlanButton.Location = new System.Drawing.Point(237, 250);
            this.viewMealPlanButton.Name = "viewMealPlanButton";
            this.viewMealPlanButton.Size = new System.Drawing.Size(201, 39);
            this.viewMealPlanButton.TabIndex = 9;
            this.viewMealPlanButton.Text = "View Meal Plans";
            this.viewMealPlanButton.UseVisualStyleBackColor = false;
            this.viewMealPlanButton.Click += new System.EventHandler(this.viewMealPlanButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.AutoSize = true;
            this.resetButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resetButton.BackColor = System.Drawing.SystemColors.Control;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(488, 250);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(86, 39);
            this.resetButton.TabIndex = 10;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exitButton.BackColor = System.Drawing.SystemColors.Control;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(623, 250);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(62, 39);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 311);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.viewMealPlanButton);
            this.Controls.Add(this.addDormButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Dorm and Meal Plan Calculator by India Gonzales";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dormOutputLabel;
        private System.Windows.Forms.Label mealPlanOutputLabel;
        private System.Windows.Forms.Label totalOutputLabel;
        private System.Windows.Forms.Button addDormButton;
        private System.Windows.Forms.Button viewMealPlanButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
    }
}

