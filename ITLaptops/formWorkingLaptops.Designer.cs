namespace ITLaptops
{
	partial class formWorkingLaptops
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
			panel2 = new Panel();
			numericValueInput = new NumericUpDown();
			btnSet = new Button();
			btnAdd = new Button();
			btnMinus = new Button();
			panel1 = new Panel();
			TotalCountWorking = new Label();
			label1 = new Label();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numericValueInput).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(37, 42, 64);
			panel2.Controls.Add(numericValueInput);
			panel2.Controls.Add(btnSet);
			panel2.Controls.Add(btnAdd);
			panel2.Controls.Add(btnMinus);
			panel2.Location = new Point(50, 136);
			panel2.Name = "panel2";
			panel2.Size = new Size(258, 247);
			panel2.TabIndex = 6;
			// 
			// numericValueInput
			// 
			numericValueInput.BackColor = Color.FromArgb(37, 42, 64);
			numericValueInput.Font = new Font("Nirmala UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			numericValueInput.ForeColor = Color.White;
			numericValueInput.Location = new Point(38, 25);
			numericValueInput.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
			numericValueInput.Name = "numericValueInput";
			numericValueInput.Size = new Size(176, 35);
			numericValueInput.TabIndex = 2;
			// 
			// btnSet
			// 
			btnSet.BackColor = Color.FromArgb(46, 51, 73);
			btnSet.FlatAppearance.BorderSize = 0;
			btnSet.FlatStyle = FlatStyle.Flat;
			btnSet.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnSet.ForeColor = Color.White;
			btnSet.Location = new Point(36, 176);
			btnSet.Name = "btnSet";
			btnSet.Size = new Size(176, 49);
			btnSet.TabIndex = 5;
			btnSet.Text = "Set";
			btnSet.UseVisualStyleBackColor = false;
			btnSet.Click += btnSet_Click;
			// 
			// btnAdd
			// 
			btnAdd.BackColor = Color.FromArgb(46, 51, 73);
			btnAdd.FlatAppearance.BorderSize = 0;
			btnAdd.FlatStyle = FlatStyle.Flat;
			btnAdd.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnAdd.ForeColor = Color.White;
			btnAdd.Location = new Point(36, 66);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(176, 49);
			btnAdd.TabIndex = 3;
			btnAdd.Text = "Add";
			btnAdd.UseVisualStyleBackColor = false;
			btnAdd.Click += btnAdd_Click;
			// 
			// btnMinus
			// 
			btnMinus.BackColor = Color.FromArgb(46, 51, 73);
			btnMinus.FlatAppearance.BorderSize = 0;
			btnMinus.FlatStyle = FlatStyle.Flat;
			btnMinus.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnMinus.ForeColor = Color.White;
			btnMinus.Location = new Point(36, 121);
			btnMinus.Name = "btnMinus";
			btnMinus.Size = new Size(176, 49);
			btnMinus.TabIndex = 4;
			btnMinus.Text = "Minus";
			btnMinus.UseVisualStyleBackColor = false;
			btnMinus.Click += btnMinus_Click;
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(37, 42, 64);
			panel1.Controls.Add(TotalCountWorking);
			panel1.Controls.Add(label1);
			panel1.Location = new Point(50, 23);
			panel1.Name = "panel1";
			panel1.Size = new Size(258, 107);
			panel1.TabIndex = 5;
			// 
			// TotalCountWorking
			// 
			TotalCountWorking.Anchor = AnchorStyles.Top;
			TotalCountWorking.AutoSize = true;
			TotalCountWorking.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold, GraphicsUnit.Point);
			TotalCountWorking.ForeColor = Color.FromArgb(0, 146, 249);
			TotalCountWorking.Location = new Point(65, 51);
			TotalCountWorking.Name = "TotalCountWorking";
			TotalCountWorking.Size = new Size(117, 32);
			TotalCountWorking.TabIndex = 1;
			TotalCountWorking.Text = "Total: 0";
			TotalCountWorking.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top;
			label1.AutoSize = true;
			label1.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = Color.White;
			label1.Location = new Point(56, 10);
			label1.Name = "label1";
			label1.Size = new Size(155, 25);
			label1.TabIndex = 0;
			label1.Text = "Working Laptops";
			// 
			// formWorkingLaptops
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(46, 51, 73);
			ClientSize = new Size(800, 450);
			Controls.Add(panel2);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "formWorkingLaptops";
			Text = "formWorkingLaptops";
			Load += formWorkingLaptops_Load;
			panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)numericValueInput).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel2;
		private NumericUpDown numericValueInput;
		private Button btnSet;
		private Button btnAdd;
		private Button btnMinus;
		private Panel panel1;
		private Label TotalCountWorking;
		private Label label1;
	}
}