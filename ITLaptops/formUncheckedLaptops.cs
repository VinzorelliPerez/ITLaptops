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
	public partial class formUncheckedLaptops : Form
	{
		public event EventHandler<int> TotalUncheckedLaptopsCountChanged;
		int TotalUncheckedLaptopsCount;

		public formUncheckedLaptops()
		{
			InitializeComponent();
			TotalUncheckedLaptopsCount = Properties.Settings.Default.TotalUncheckedLaptops;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			TotalUncheckedLaptopsCount += (int)numericValueInput.Value;
			Properties.Settings.Default.TotalUncheckedLaptops = TotalUncheckedLaptopsCount;

			TotalUncheckedLaptopsCountChanged?.Invoke(this, TotalUncheckedLaptopsCount);

			Properties.Settings.Default.Save();
			TotalCountUnchecked.Text = TotalUncheckedLaptopsCount.ToString();
			numericValueInput.Value = 0;
		}
		private void btnMinus_Click(object sender, EventArgs e)
		{
			TotalUncheckedLaptopsCount -= (int)numericValueInput.Value;
			Properties.Settings.Default.TotalUncheckedLaptops = TotalUncheckedLaptopsCount;

			TotalUncheckedLaptopsCountChanged?.Invoke(this, TotalUncheckedLaptopsCount);

			Properties.Settings.Default.Save();
			TotalCountUnchecked.Text = TotalUncheckedLaptopsCount.ToString();
			numericValueInput.Value = 0;
		}

		

		private void btnSet_Click(object sender, EventArgs e)
		{
			TotalUncheckedLaptopsCount = (int)numericValueInput.Value;
			Properties.Settings.Default.TotalUncheckedLaptops = TotalUncheckedLaptopsCount;

			TotalUncheckedLaptopsCountChanged?.Invoke(this, TotalUncheckedLaptopsCount);

			Properties.Settings.Default.Save();
			TotalCountUnchecked.Text = TotalUncheckedLaptopsCount.ToString();
			numericValueInput.Value = 0;
		}
		private void formUncheckedLaptops_Load(object sender, EventArgs e)
		{
			TotalCountUnchecked.Text = TotalUncheckedLaptopsCount.ToString();
		}
	}
}
