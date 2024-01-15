using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITLaptops
{
	public partial class formWorkingLaptops : Form
	{
		public event EventHandler<int> TotalWorkingLaptopsCountChanged;
		int TotalWorkingLaptopsCount;

		public formWorkingLaptops()
		{
			InitializeComponent();
			TotalWorkingLaptopsCount = Properties.Settings.Default.TotalWorkingLaptops;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			TotalWorkingLaptopsCount += (int)numericValueInput.Value;
			Properties.Settings.Default.TotalWorkingLaptops = TotalWorkingLaptopsCount;

			TotalWorkingLaptopsCountChanged?.Invoke(this, TotalWorkingLaptopsCount);

			Properties.Settings.Default.Save();
			TotalCountWorking.Text = TotalWorkingLaptopsCount.ToString();
			numericValueInput.Value = 0;
		}
		private void btnMinus_Click(object sender, EventArgs e)
		{
			TotalWorkingLaptopsCount -= (int)numericValueInput.Value;
			Properties.Settings.Default.TotalWorkingLaptops = TotalWorkingLaptopsCount;

			TotalWorkingLaptopsCountChanged?.Invoke(this, TotalWorkingLaptopsCount);

			Properties.Settings.Default.Save();
			TotalCountWorking.Text = TotalWorkingLaptopsCount.ToString();
			numericValueInput.Value = 0;
		}



		private void btnSet_Click(object sender, EventArgs e)
		{
			TotalWorkingLaptopsCount = (int)numericValueInput.Value;
			Properties.Settings.Default.TotalWorkingLaptops = TotalWorkingLaptopsCount;

			TotalWorkingLaptopsCountChanged?.Invoke(this, TotalWorkingLaptopsCount);

			Properties.Settings.Default.Save();
			TotalCountWorking.Text = TotalWorkingLaptopsCount.ToString();
			numericValueInput.Value = 0;
		}

		private void formWorkingLaptops_Load(object sender, EventArgs e)
		{
			TotalCountWorking.Text = TotalWorkingLaptopsCount.ToString();
		}

	}
}
