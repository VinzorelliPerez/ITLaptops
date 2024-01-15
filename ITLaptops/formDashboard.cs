using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITLaptops
{
	public partial class formDashboard : Form
	{
		public int CountUncheckedLaptops = Properties.Settings.Default.TotalUncheckedLaptops;
		public int CountBrokenLaptops = Properties.Settings.Default.TotalBrokenLaptops;
		public int CountWorkingLaptops = Properties.Settings.Default.TotalWorkingLaptops;
		public formDashboard()
		{
			InitializeComponent();
		}
		private void formDashboard_Load(object sender, EventArgs e)
		{
			UpdateCounts();

		}
		public void UncheckedLaptopsCountChanged(object sender, int newCount)
		{
			CountUncheckedLaptops = newCount;
			UpdateCounts();
		}
		public void BrokenLaptopsCountChanged(object sender, int newCount)
		{
			CountBrokenLaptops = newCount;
			UpdateCounts();
		}
		public void WorkingLaptopsCountChanged(object sender, int newCount)
		{
			CountWorkingLaptops = newCount;
			UpdateCounts();
		}
		private void UpdateCounts()
		{
			TotalCountUnchecked.Text = "Total: " + CountUncheckedLaptops.ToString();
			TotalCountBroken.Text = "Total: " + CountBrokenLaptops.ToString();
			TotalCountWorking.Text = "Total: " + CountWorkingLaptops.ToString();
			lblFinalCount.Text = "Total: " + (CountUncheckedLaptops + CountBrokenLaptops + CountWorkingLaptops).ToString();
		}

	}
}
