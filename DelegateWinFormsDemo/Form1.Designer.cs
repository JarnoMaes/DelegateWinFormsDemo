
namespace DelegateWinFormsDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstPerson = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbOptionOne = new System.Windows.Forms.RadioButton();
            this.rbOptionTwo = new System.Windows.Forms.RadioButton();
            this.rbOptionThree = new System.Windows.Forms.RadioButton();
            this.rbOptionFour = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPerson
            // 
            this.lstPerson.FormattingEnabled = true;
            this.lstPerson.ItemHeight = 15;
            this.lstPerson.Location = new System.Drawing.Point(252, 100);
            this.lstPerson.Name = "lstPerson";
            this.lstPerson.Size = new System.Drawing.Size(409, 214);
            this.lstPerson.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(428, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOptionFour);
            this.groupBox1.Controls.Add(this.rbOptionThree);
            this.groupBox1.Controls.Add(this.rbOptionTwo);
            this.groupBox1.Controls.Add(this.rbOptionOne);
            this.groupBox1.Location = new System.Drawing.Point(46, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 214);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Possible Options";
            // 
            // rbOptionOne
            // 
            this.rbOptionOne.AutoSize = true;
            this.rbOptionOne.Location = new System.Drawing.Point(0, 22);
            this.rbOptionOne.Name = "rbOptionOne";
            this.rbOptionOne.Size = new System.Drawing.Size(63, 19);
            this.rbOptionOne.TabIndex = 0;
            this.rbOptionOne.TabStop = true;
            this.rbOptionOne.Text = "Default";
            this.rbOptionOne.UseVisualStyleBackColor = true;
            // 
            // rbOptionTwo
            // 
            this.rbOptionTwo.AutoSize = true;
            this.rbOptionTwo.Location = new System.Drawing.Point(0, 68);
            this.rbOptionTwo.Name = "rbOptionTwo";
            this.rbOptionTwo.Size = new System.Drawing.Size(81, 19);
            this.rbOptionTwo.TabIndex = 1;
            this.rbOptionTwo.TabStop = true;
            this.rbOptionTwo.Text = "Last Name";
            this.rbOptionTwo.UseVisualStyleBackColor = true;
            // 
            // rbOptionThree
            // 
            this.rbOptionThree.AutoSize = true;
            this.rbOptionThree.Location = new System.Drawing.Point(0, 113);
            this.rbOptionThree.Name = "rbOptionThree";
            this.rbOptionThree.Size = new System.Drawing.Size(82, 19);
            this.rbOptionThree.TabIndex = 2;
            this.rbOptionThree.TabStop = true;
            this.rbOptionThree.Text = "First Name";
            this.rbOptionThree.UseVisualStyleBackColor = true;
            // 
            // rbOptionFour
            // 
            this.rbOptionFour.AutoSize = true;
            this.rbOptionFour.Location = new System.Drawing.Point(0, 156);
            this.rbOptionFour.Name = "rbOptionFour";
            this.rbOptionFour.Size = new System.Drawing.Size(79, 19);
            this.rbOptionFour.TabIndex = 3;
            this.rbOptionFour.TabStop = true;
            this.rbOptionFour.Text = "Full Name";
            this.rbOptionFour.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstPerson);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPerson;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbOptionFour;
        private System.Windows.Forms.RadioButton rbOptionThree;
        private System.Windows.Forms.RadioButton rbOptionTwo;
        private System.Windows.Forms.RadioButton rbOptionOne;
    }
}

