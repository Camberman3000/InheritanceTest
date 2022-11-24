namespace InheritanceTest
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
            this.buttonDisplayName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDogName = new System.Windows.Forms.TextBox();
            this.tbDogBreed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDisplayName
            // 
            this.buttonDisplayName.Location = new System.Drawing.Point(304, 81);
            this.buttonDisplayName.Name = "buttonDisplayName";
            this.buttonDisplayName.Size = new System.Drawing.Size(205, 61);
            this.buttonDisplayName.TabIndex = 0;
            this.buttonDisplayName.Text = "Get dog info";
            this.buttonDisplayName.UseVisualStyleBackColor = true;
            this.buttonDisplayName.Click += new System.EventHandler(this.buttonDisplayName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name: ";
            // 
            // tbDogName
            // 
            this.tbDogName.Location = new System.Drawing.Point(359, 198);
            this.tbDogName.Name = "tbDogName";
            this.tbDogName.ReadOnly = true;
            this.tbDogName.Size = new System.Drawing.Size(150, 31);
            this.tbDogName.TabIndex = 2;
            // 
            // tbDogBreed
            // 
            this.tbDogBreed.Location = new System.Drawing.Point(359, 235);
            this.tbDogBreed.Name = "tbDogBreed";
            this.tbDogBreed.ReadOnly = true;
            this.tbDogBreed.Size = new System.Drawing.Size(150, 31);
            this.tbDogBreed.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Breed: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbDogBreed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDogName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDisplayName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonDisplayName;
        private Label label1;
        private TextBox tbDogName;
        private TextBox tbDogBreed;
        private Label label2;
    }
}