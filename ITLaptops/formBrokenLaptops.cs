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
	public partial class formBrokenLaptops : Form
	{
		public event EventHandler<int> TotalBrokenLaptopsCountChanged;
		int TotalBrokenLaptopsCount;

		public formBrokenLaptops()
		{
			InitializeComponent();
			TotalBrokenLaptopsCount = Properties.Settings.Default.TotalBrokenLaptops;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			TotalBrokenLaptopsCount += (int)numericValueInput.Value;
			Properties.Settings.Default.TotalBrokenLaptops = TotalBrokenLaptopsCount;

			TotalBrokenLaptopsCountChanged?.Invoke(this, TotalBrokenLaptopsCount);

			Properties.Settings.Default.Save();
			TotalCountBroken.Text = TotalBrokenLaptopsCount.ToString();
			numericValueInput.Value = 0;
		}
		private void btnMinus_Click(object sender, EventArgs e)
		{
			TotalBrokenLaptopsCount -= (int)numericValueInput.Value;
			Properties.Settings.Default.TotalBrokenLaptops = TotalBrokenLaptopsCount;

			TotalBrokenLaptopsCountChanged?.Invoke(this, TotalBrokenLaptopsCount);

			Properties.Settings.Default.Save();
			TotalCountBroken.Text = TotalBrokenLaptopsCount.ToString();
			numericValueInput.Value = 0;
		}

		

		private void btnSet_Click(object sender, EventArgs e)
		{
			TotalBrokenLaptopsCount = (int)numericValueInput.Value;
			Properties.Settings.Default.TotalBrokenLaptops = TotalBrokenLaptopsCount;

			TotalBrokenLaptopsCountChanged?.Invoke(this, TotalBrokenLaptopsCount);

			Properties.Settings.Default.Save();
			TotalCountBroken.Text = TotalBrokenLaptopsCount.ToString();
			numericValueInput.Value = 0;
		}
		private void formBrokenLaptops_Load(object sender, EventArgs e)
		{
			TotalCountBroken.Text = TotalBrokenLaptopsCount.ToString();
		}
	}
}
