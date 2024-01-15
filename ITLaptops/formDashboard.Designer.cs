namespace ITLaptops
{
	partial class formDashboard
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
			if (disposing && (components != null))
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
			panel1 = new Panel();
			TotalCountUnchecked = new Label();
			label1 = new Label();
			panel2 = new Panel();
			TotalCountBroken = new Label();
			label3 = new Label();
			panel3 = new Panel();
			TotalCountWorking = new Label();
			label5 = new Label();
			panel4 = new Panel();
			lblFinalCount = new Label();
			label7 = new Label();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			panel3.SuspendLayout();
			panel4.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(37, 42, 64);
			panel1.Controls.Add(TotalCountUnchecked);
			panel1.Controls.Add(label1);
			panel1.Location = new Point(71, 12);
			panel1.Name = "panel1";
			panel1.Size = new Size(258, 130);
			panel1.TabIndex = 0;
			// 
			// TotalCountUnchecked
			// 
			TotalCountUnchecked.Anchor = AnchorStyles.Top;
			TotalCountUnchecked.AutoSize = true;
			TotalCountUnchecked.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold, GraphicsUnit.Point);
			TotalCountUnchecked.ForeColor = Color.FromArgb(0, 146, 249);
			TotalCountUnchecked.Location = new Point(57, 56);
			TotalCountUnchecked.Name = "TotalCountUnchecked";
			TotalCountUnchecked.Size = new Size(117, 32);
			TotalCountUnchecked.TabIndex = 1;
			TotalCountUnchecked.Text = "Total: 0";
			TotalCountUnchecked.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top;
			label1.AutoSize = true;
			label1.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = Color.White;
			label1.Location = new Point(32, 7);
			label1.Name = "label1";
			label1.Size = new Size(176, 25);
			label1.TabIndex = 0;
			label1.Text = "Unchecked Laptops";
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(37, 42, 64);
			panel2.Controls.Add(TotalCountBroken);
			panel2.Controls.Add(label3);
			panel2.Location = new Point(71, 161);
			panel2.Name = "panel2";
			panel2.Size = new Size(258, 130);
			panel2.TabIndex = 2;
			// 
			// TotalCountBroken
			// 
			TotalCountBroken.Anchor = AnchorStyles.Top;
			TotalCountBroken.AutoSize = true;
			TotalCountBroken.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold, GraphicsUnit.Point);
			TotalCountBroken.ForeColor = Color.FromArgb(0, 146, 249);
			TotalCountBroken.Location = new Point(57, 48);
			TotalCountBroken.Name = "TotalCountBroken";
			TotalCountBroken.Size = new Size(117, 32);
			TotalCountBroken.TabIndex = 1;
			TotalCountBroken.Text = "Total: 0";
			TotalCountBroken.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Top;
			label3.AutoSize = true;
			label3.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label3.ForeColor = Color.White;
			label3.Location = new Point(45, 9);
			label3.Name = "label3";
			label3.Size = new Size(142, 25);
			label3.TabIndex = 0;
			label3.Text = "Broken Laptops";
			// 
			// panel3
			// 
			panel3.BackColor = Color.FromArgb(37, 42, 64);
			panel3.Controls.Add(TotalCountWorking);
			panel3.Controls.Add(label5);
			panel3.Location = new Point(377, 12);
			panel3.Name = "panel3";
			panel3.Size = new Size(258, 130);
			panel3.TabIndex = 3;
			// 
			// TotalCountWorking
			// 
			TotalCountWorking.Anchor = AnchorStyles.Top;
			TotalCountWorking.AutoSize = true;
			TotalCountWorking.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold, GraphicsUnit.Point);
			TotalCountWorking.ForeColor = Color.FromArgb(0, 146, 249);
			TotalCountWorking.Location = new Point(57, 53);
			TotalCountWorking.Name = "TotalCountWorking";
			TotalCountWorking.Size = new Size(117, 32);
			TotalCountWorking.TabIndex = 1;
			TotalCountWorking.Text = "Total: 0";
			TotalCountWorking.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			label5.Anchor = AnchorStyles.Top;
			label5.AutoSize = true;
			label5.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label5.ForeColor = Color.White;
			label5.Location = new Point(45, 11);
			label5.Name = "label5";
			label5.RightToLeft = RightToLeft.No;
			label5.Size = new Size(155, 25);
			label5.TabIndex = 0;
			label5.Text = "Working Laptops";
			// 
			// panel4
			// 
			panel4.BackColor = Color.FromArgb(37, 42, 64);
			panel4.Controls.Add(lblFinalCount);
			panel4.Controls.Add(label7);
			panel4.Location = new Point(377, 161);
			panel4.Name = "panel4";
			panel4.Size = new Size(258, 130);
			panel4.TabIndex = 3;
			// 
			// lblFinalCount
			// 
			lblFinalCount.Anchor = AnchorStyles.Top;
			lblFinalCount.AutoSize = true;
			lblFinalCount.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold, GraphicsUnit.Point);
			lblFinalCount.ForeColor = Color.FromArgb(192, 0, 0);
			lblFinalCount.Location = new Point(57, 48);
			lblFinalCount.Name = "lblFinalCount";
			lblFinalCount.Size = new Size(117, 32);
			lblFinalCount.TabIndex = 1;
			lblFinalCount.Text = "Total: 0";
			lblFinalCount.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			label7.Anchor = AnchorStyles.Top;
			label7.AutoSize = true;
			label7.Font = new Font("Nirmala UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			label7.ForeColor = Color.White;
			label7.Location = new Point(57, 3);
			label7.Name = "label7";
			label7.Size = new Size(136, 32);
			label7.TabIndex = 0;
			label7.Text = "Final Count";
			// 
			// formDashboard
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(46, 51, 73);
			ClientSize = new Size(733, 477);
			Controls.Add(panel4);
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "formDashboard";
			Text = "formDashboard";
			Load += formDashboard_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Label TotalCountUnchecked;
		private Label label1;
		private Panel panel2;
		private Label TotalCountBroken;
		private Label label3;
		private Panel panel3;
		private Label TotalCountWorking;
		private Label label5;
		private Panel panel4;
		private Label lblFinalCount;
		private Label label7;
	}
}