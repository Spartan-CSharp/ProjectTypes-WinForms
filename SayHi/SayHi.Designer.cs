namespace SayHi
{
	partial class SayHi
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
			if ( disposing && (components != null) )
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
			this.firstNameLabel = new System.Windows.Forms.Label();
			this.firstNameTextBox = new System.Windows.Forms.TextBox();
			this.lastNameLabel = new System.Windows.Forms.Label();
			this.lastNameTextBox = new System.Windows.Forms.TextBox();
			this.sayHiButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// firstNameLabel
			// 
			this.firstNameLabel.AutoSize = true;
			this.firstNameLabel.Location = new System.Drawing.Point(50, 50);
			this.firstNameLabel.Name = "firstNameLabel";
			this.firstNameLabel.Size = new System.Drawing.Size(130, 32);
			this.firstNameLabel.TabIndex = 0;
			this.firstNameLabel.Text = "First Name";
			// 
			// firstNameTextBox
			// 
			this.firstNameTextBox.Location = new System.Drawing.Point(186, 47);
			this.firstNameTextBox.Name = "firstNameTextBox";
			this.firstNameTextBox.Size = new System.Drawing.Size(300, 39);
			this.firstNameTextBox.TabIndex = 1;
			// 
			// lastNameLabel
			// 
			this.lastNameLabel.AutoSize = true;
			this.lastNameLabel.Location = new System.Drawing.Point(50, 120);
			this.lastNameLabel.Name = "lastNameLabel";
			this.lastNameLabel.Size = new System.Drawing.Size(127, 32);
			this.lastNameLabel.TabIndex = 0;
			this.lastNameLabel.Text = "Last Name";
			// 
			// lastNameTextBox
			// 
			this.lastNameTextBox.Location = new System.Drawing.Point(186, 117);
			this.lastNameTextBox.Name = "lastNameTextBox";
			this.lastNameTextBox.Size = new System.Drawing.Size(300, 39);
			this.lastNameTextBox.TabIndex = 2;
			// 
			// sayHiButton
			// 
			this.sayHiButton.Location = new System.Drawing.Point(186, 187);
			this.sayHiButton.Name = "sayHiButton";
			this.sayHiButton.Size = new System.Drawing.Size(300, 39);
			this.sayHiButton.TabIndex = 3;
			this.sayHiButton.Text = "Say Hi!";
			this.sayHiButton.UseVisualStyleBackColor = true;
			this.sayHiButton.Click += new System.EventHandler(this.SayHiButton_Click);
			// 
			// SayHi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(656, 273);
			this.Controls.Add(this.sayHiButton);
			this.Controls.Add(this.lastNameTextBox);
			this.Controls.Add(this.lastNameLabel);
			this.Controls.Add(this.firstNameTextBox);
			this.Controls.Add(this.firstNameLabel);
			this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
			this.Name = "SayHi";
			this.Text = "Say Hi!";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label firstNameLabel;
		private System.Windows.Forms.TextBox firstNameTextBox;
		private System.Windows.Forms.Label lastNameLabel;
		private System.Windows.Forms.TextBox lastNameTextBox;
		private System.Windows.Forms.Button sayHiButton;
	}
}

