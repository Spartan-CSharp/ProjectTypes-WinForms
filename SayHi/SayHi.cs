using System;
using System.Windows.Forms;

namespace SayHi
{
	public partial class SayHi : Form
	{
		public SayHi()
		{
			InitializeComponent();
		}

		private void SayHiButton_Click(object sender, EventArgs e)
		{
			if ( string.IsNullOrWhiteSpace(firstNameTextBox.Text) && string.IsNullOrWhiteSpace(lastNameTextBox.Text) )
			{
				_ = MessageBox.Show("You must enter both a First Name and a Last Name to Say Hi!", "First Name and Last Name Blank", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				_ = firstNameTextBox.Focus();
			}
			else if ( string.IsNullOrWhiteSpace(firstNameTextBox.Text) )
			{
				_ = MessageBox.Show("You must enter both a First Name to Say Hi!", "First Name Blank", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				_ = firstNameTextBox.Focus();
			}
			else if ( string.IsNullOrWhiteSpace(lastNameTextBox.Text) )
			{
				_ = MessageBox.Show("You must enter a Last Name to Say Hi!", "Last Name Blank", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				_ = lastNameTextBox.Focus();
			}
			else
			{
				_ = MessageBox.Show($"Hi {firstNameTextBox.Text} {lastNameTextBox.Text}!", "Hi there!", MessageBoxButtons.OK, MessageBoxIcon.None);
				firstNameTextBox.Text = "";
				lastNameTextBox.Text = "";
				_ = firstNameTextBox.Focus();
			}
		}
	}
}
