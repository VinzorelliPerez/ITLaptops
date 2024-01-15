using System.Security.Permissions;
using System.Runtime.InteropServices;

namespace ITLaptops
{
	public partial class ITLaptops : Form
	{
		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
		private static extern IntPtr CreateRoundRectRgn(
			int nLeftRect,
			int nTopRect,
			int nRightRect,
			int nBottomRect,
			int nWidthEllipse,
			int nHeightEllipse
			);
		List<Button> btnList = new List<Button>();
		formDashboard formDashboard_Var = new formDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
		formUncheckedLaptops formUncheckedLaptops_var = new formUncheckedLaptops() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
		formBrokenLaptops formBrokenLaptops_var = new formBrokenLaptops() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
		formWorkingLaptops formWorkingLaptops_var = new formWorkingLaptops() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

		private void CreateSubMenu(string ITitle, System.Windows.Forms.Form iForm)
		{
			lblTitle.Text = ITitle;
			this.PnlFormLoader.Controls.Clear();

			iForm.FormBorderStyle = FormBorderStyle.None;
			this.PnlFormLoader.Controls.Add(iForm);
			iForm.Show();
		}
		private void CreateBoxRect(Button buttonObj)
		{
			foreach (Button button in btnList)
			{
				button.BackColor = Color.FromArgb(24, 30, 53);
			}
			pnlNav.Height = buttonObj.Height;
			pnlNav.Top = buttonObj.Top;
			pnlNav.Left = buttonObj.Left;
			buttonObj.BackColor = Color.FromArgb(46, 51, 73);
		}
		public ITLaptops()
		{
			InitializeComponent();

			Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
			pnlNav.Height = btnDashboard.Height;
			pnlNav.Top = btnDashboard.Top;
			pnlNav.Left = btnDashboard.Left;
			btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

			CreateSubMenu("Dashboard", formDashboard_Var);

			btnList.Add(btnDashboard);
			btnList.Add(btnUncheckedLaptops);
			btnList.Add(btnBrokenLaptops);
			btnList.Add(btnWorkingLaptop);
			btnList.Add(btnHelp);
			btnList.Add(btnCredits);
		}



		private void btnDashboard_Click(object sender, EventArgs e)
		{
			CreateBoxRect(btnDashboard);
			CreateSubMenu("Dashboard", formDashboard_Var);

		}
		private void btnUncheckedLaptops_Click(object sender, EventArgs e)
		{
			CreateBoxRect(btnUncheckedLaptops);
			CreateSubMenu("Unchecked Laptops", formUncheckedLaptops_var);
			formUncheckedLaptops_var.TotalUncheckedLaptopsCountChanged += formDashboard_Var.UncheckedLaptopsCountChanged;
		}

		private void btnBrokenLaptops_Click(object sender, EventArgs e)
		{
			CreateBoxRect(btnBrokenLaptops);
			CreateSubMenu("Broken Laptops", formBrokenLaptops_var);
			formBrokenLaptops_var.TotalBrokenLaptopsCountChanged += formDashboard_Var.BrokenLaptopsCountChanged;
		}


		private void btnWorkingLaptop_Click(object sender, EventArgs e)
		{
			CreateBoxRect(btnWorkingLaptop);
			CreateSubMenu("Working Laptops", formWorkingLaptops_var);
			formWorkingLaptops_var.TotalWorkingLaptopsCountChanged += formDashboard_Var.WorkingLaptopsCountChanged;
		}

		private void btnHelp_Click(object sender, EventArgs e)
		{
			CreateBoxRect(btnHelp);
		}

		private void btnCredits_Click(object sender, EventArgs e)
		{
			CreateBoxRect(btnCredits);
		}

		private void btnCloseApplication_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		// No new code

	}
}