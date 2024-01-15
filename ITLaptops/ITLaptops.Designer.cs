namespace ITLaptops
{
	partial class ITLaptops
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
			pnlNav = new Panel();
			btnCredits = new Button();
			btnHelp = new Button();
			btnWorkingLaptop = new Button();
			btnBrokenLaptops = new Button();
			btnUncheckedLaptops = new Button();
			btnDashboard = new Button();
			panel2 = new Panel();
			label4 = new Label();
			label2 = new Label();
			pictureBox1 = new PictureBox();
			PnlFormLoader = new Panel();
			btnCloseApplication = new Button();
			lblTitle = new Label();
			pnlNav.SuspendLayout();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pnlNav
			// 
			pnlNav.BackColor = Color.FromArgb(24, 30, 53);
			pnlNav.Controls.Add(btnCredits);
			pnlNav.Controls.Add(btnHelp);
			pnlNav.Controls.Add(btnWorkingLaptop);
			pnlNav.Controls.Add(btnBrokenLaptops);
			pnlNav.Controls.Add(btnUncheckedLaptops);
			pnlNav.Controls.Add(btnDashboard);
			pnlNav.Controls.Add(panel2);
			pnlNav.Dock = DockStyle.Left;
			pnlNav.Location = new Point(0, 0);
			pnlNav.Name = "pnlNav";
			pnlNav.Size = new Size(186, 577);
			pnlNav.TabIndex = 9;
			// 
			// btnCredits
			// 
			btnCredits.Dock = DockStyle.Top;
			btnCredits.FlatAppearance.BorderSize = 0;
			btnCredits.FlatStyle = FlatStyle.Flat;
			btnCredits.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			btnCredits.ForeColor = Color.FromArgb(0, 126, 249);
			btnCredits.Location = new Point(0, 372);
			btnCredits.Name = "btnCredits";
			btnCredits.Size = new Size(186, 42);
			btnCredits.TabIndex = 7;
			btnCredits.Text = "Credits";
			btnCredits.TextImageRelation = TextImageRelation.TextBeforeImage;
			btnCredits.UseVisualStyleBackColor = true;
			btnCredits.Click += btnCredits_Click;
			// 
			// btnHelp
			// 
			btnHelp.Dock = DockStyle.Top;
			btnHelp.FlatAppearance.BorderSize = 0;
			btnHelp.FlatStyle = FlatStyle.Flat;
			btnHelp.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			btnHelp.ForeColor = Color.FromArgb(0, 126, 249);
			btnHelp.Location = new Point(0, 330);
			btnHelp.Name = "btnHelp";
			btnHelp.Size = new Size(186, 42);
			btnHelp.TabIndex = 6;
			btnHelp.Text = "Help";
			btnHelp.TextImageRelation = TextImageRelation.TextBeforeImage;
			btnHelp.UseVisualStyleBackColor = true;
			btnHelp.Click += btnHelp_Click;
			// 
			// btnWorkingLaptop
			// 
			btnWorkingLaptop.Dock = DockStyle.Top;
			btnWorkingLaptop.FlatAppearance.BorderSize = 0;
			btnWorkingLaptop.FlatStyle = FlatStyle.Flat;
			btnWorkingLaptop.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			btnWorkingLaptop.ForeColor = Color.FromArgb(0, 126, 249);
			btnWorkingLaptop.Location = new Point(0, 288);
			btnWorkingLaptop.Name = "btnWorkingLaptop";
			btnWorkingLaptop.Size = new Size(186, 42);
			btnWorkingLaptop.TabIndex = 5;
			btnWorkingLaptop.Text = "Working Laptops";
			btnWorkingLaptop.TextImageRelation = TextImageRelation.TextBeforeImage;
			btnWorkingLaptop.UseVisualStyleBackColor = true;
			btnWorkingLaptop.Click += btnWorkingLaptop_Click;
			// 
			// btnBrokenLaptops
			// 
			btnBrokenLaptops.Dock = DockStyle.Top;
			btnBrokenLaptops.FlatAppearance.BorderSize = 0;
			btnBrokenLaptops.FlatStyle = FlatStyle.Flat;
			btnBrokenLaptops.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			btnBrokenLaptops.ForeColor = Color.FromArgb(0, 126, 249);
			btnBrokenLaptops.Location = new Point(0, 246);
			btnBrokenLaptops.Name = "btnBrokenLaptops";
			btnBrokenLaptops.Size = new Size(186, 42);
			btnBrokenLaptops.TabIndex = 4;
			btnBrokenLaptops.Text = "Broken Laptops";
			btnBrokenLaptops.TextImageRelation = TextImageRelation.TextBeforeImage;
			btnBrokenLaptops.UseVisualStyleBackColor = true;
			btnBrokenLaptops.Click += btnBrokenLaptops_Click;
			// 
			// btnUncheckedLaptops
			// 
			btnUncheckedLaptops.Dock = DockStyle.Top;
			btnUncheckedLaptops.FlatAppearance.BorderSize = 0;
			btnUncheckedLaptops.FlatStyle = FlatStyle.Flat;
			btnUncheckedLaptops.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			btnUncheckedLaptops.ForeColor = Color.FromArgb(0, 126, 249);
			btnUncheckedLaptops.Location = new Point(0, 204);
			btnUncheckedLaptops.Name = "btnUncheckedLaptops";
			btnUncheckedLaptops.Size = new Size(186, 42);
			btnUncheckedLaptops.TabIndex = 2;
			btnUncheckedLaptops.Text = "Unchecked Laptops";
			btnUncheckedLaptops.TextImageRelation = TextImageRelation.TextBeforeImage;
			btnUncheckedLaptops.UseVisualStyleBackColor = true;
			btnUncheckedLaptops.Click += btnUncheckedLaptops_Click;
			// 
			// btnDashboard
			// 
			btnDashboard.Dock = DockStyle.Top;
			btnDashboard.FlatAppearance.BorderSize = 0;
			btnDashboard.FlatStyle = FlatStyle.Flat;
			btnDashboard.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			btnDashboard.ForeColor = Color.FromArgb(0, 126, 249);
			btnDashboard.Location = new Point(0, 162);
			btnDashboard.Name = "btnDashboard";
			btnDashboard.Size = new Size(186, 42);
			btnDashboard.TabIndex = 1;
			btnDashboard.Text = "Dashboard";
			btnDashboard.TextImageRelation = TextImageRelation.TextBeforeImage;
			btnDashboard.UseVisualStyleBackColor = true;
			btnDashboard.Click += btnDashboard_Click;
			// 
			// panel2
			// 
			panel2.Controls.Add(label4);
			panel2.Controls.Add(label2);
			panel2.Controls.Add(pictureBox1);
			panel2.Dock = DockStyle.Top;
			panel2.Location = new Point(0, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(186, 162);
			panel2.TabIndex = 0;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Comic Sans MS", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
			label4.ForeColor = Color.FromArgb(158, 161, 178);
			label4.Location = new Point(49, 129);
			label4.Name = "label4";
			label4.Size = new Size(90, 13);
			label4.TabIndex = 2;
			label4.Text = "By Vinzorelli Perez";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.FromArgb(0, 126, 249);
			label2.Location = new Point(60, 99);
			label2.Name = "label2";
			label2.Size = new Size(68, 19);
			label2.TabIndex = 1;
			label2.Text = "InfoTech";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources._8ba09ccf_d5d2_454e_a661_9952926db28c;
			pictureBox1.Location = new Point(60, 22);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(63, 63);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// PnlFormLoader
			// 
			PnlFormLoader.Dock = DockStyle.Bottom;
			PnlFormLoader.Location = new Point(186, 100);
			PnlFormLoader.Name = "PnlFormLoader";
			PnlFormLoader.Size = new Size(765, 477);
			PnlFormLoader.TabIndex = 11;
			// 
			// btnCloseApplication
			// 
			btnCloseApplication.AutoSize = true;
			btnCloseApplication.BackColor = Color.FromArgb(46, 51, 73);
			btnCloseApplication.FlatAppearance.BorderSize = 0;
			btnCloseApplication.FlatStyle = FlatStyle.Flat;
			btnCloseApplication.ForeColor = Color.White;
			btnCloseApplication.Location = new Point(904, 22);
			btnCloseApplication.Name = "btnCloseApplication";
			btnCloseApplication.Size = new Size(27, 27);
			btnCloseApplication.TabIndex = 12;
			btnCloseApplication.Text = "X";
			btnCloseApplication.TextAlign = ContentAlignment.MiddleRight;
			btnCloseApplication.UseVisualStyleBackColor = false;
			btnCloseApplication.Click += btnCloseApplication_Click;
			// 
			// lblTitle
			// 
			lblTitle.AutoSize = true;
			lblTitle.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold, GraphicsUnit.Point);
			lblTitle.ForeColor = Color.FromArgb(158, 161, 176);
			lblTitle.Location = new Point(192, 38);
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size(162, 32);
			lblTitle.TabIndex = 10;
			lblTitle.Text = "Dashboard";
			lblTitle.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// ITLaptops
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(46, 51, 73);
			ClientSize = new Size(951, 577);
			Controls.Add(lblTitle);
			Controls.Add(btnCloseApplication);
			Controls.Add(PnlFormLoader);
			Controls.Add(pnlNav);
			Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
			FormBorderStyle = FormBorderStyle.None;
			Name = "ITLaptops";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "ITLaptops";
			pnlNav.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Panel pnlNav;
		private Panel panel2;
		private Label label4;
		private Label label2;
		private PictureBox pictureBox1;
		private Button btnDashboard;
		private Button btnWorkingLaptops;
		private Button btnWorkingLaptop;
		private Button btnBrokenLaptops;
		private Button btnUncheckedLaptops;
		private Button btnHelp;
		private Button btnCredits;
		private Panel PnlFormLoader;
		private Button btnCloseApplication;
		private Label lblTitle;
	}
}