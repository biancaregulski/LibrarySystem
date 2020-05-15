namespace LibrarySystem
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label restrictionsLabel;
		private System.Windows.Forms.Label dobValue;
		private System.Windows.Forms.Label nameValue;
		private System.Windows.Forms.Label dobLabel;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Label restrictionsValue;
		private System.Windows.Forms.ListView booksListView;
		private System.Windows.Forms.ColumnHeader titleColumnHeader;
		private System.Windows.Forms.ColumnHeader authorColumnHeader;
		private System.Windows.Forms.ColumnHeader checkoutDateColumnHeader;
		private System.Windows.Forms.ColumnHeader returnDateColumnHeader;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.restrictionsValue = new System.Windows.Forms.Label();
            this.restrictionsLabel = new System.Windows.Forms.Label();
            this.dobValue = new System.Windows.Forms.Label();
            this.nameValue = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.booksListView = new System.Windows.Forms.ListView();
            this.titleColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.authorColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkoutDateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.returnDateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Show Borrower:";
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(6, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Notification message";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Borrower ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.restrictionsValue);
            this.groupBox2.Controls.Add(this.restrictionsLabel);
            this.groupBox2.Controls.Add(this.dobValue);
            this.groupBox2.Controls.Add(this.nameValue);
            this.groupBox2.Controls.Add(this.dobLabel);
            this.groupBox2.Controls.Add(this.nameLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 106);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Borrower Information:";
            // 
            // restrictionsValue
            // 
            this.restrictionsValue.Location = new System.Drawing.Point(158, 73);
            this.restrictionsValue.Name = "restrictionsValue";
            this.restrictionsValue.Size = new System.Drawing.Size(100, 23);
            this.restrictionsValue.TabIndex = 5;
            this.restrictionsValue.Text = "label7";
            // 
            // restrictionsLabel
            // 
            this.restrictionsLabel.Location = new System.Drawing.Point(7, 72);
            this.restrictionsLabel.Name = "restrictionsLabel";
            this.restrictionsLabel.Size = new System.Drawing.Size(100, 21);
            this.restrictionsLabel.TabIndex = 4;
            this.restrictionsLabel.Text = "Restrictions:";
            // 
            // dobValue
            // 
            this.dobValue.Location = new System.Drawing.Point(158, 49);
            this.dobValue.Name = "dobValue";
            this.dobValue.Size = new System.Drawing.Size(178, 23);
            this.dobValue.TabIndex = 3;
            this.dobValue.Text = "label5";
            // 
            // nameValue
            // 
            this.nameValue.Location = new System.Drawing.Point(158, 26);
            this.nameValue.Name = "nameValue";
            this.nameValue.Size = new System.Drawing.Size(178, 23);
            this.nameValue.TabIndex = 2;
            this.nameValue.Text = "label4";
            // 
            // dobLabel
            // 
            this.dobLabel.Location = new System.Drawing.Point(7, 49);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(100, 23);
            this.dobLabel.TabIndex = 1;
            this.dobLabel.Text = "DOB:";
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(7, 26);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(100, 23);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // booksListView
            // 
            this.booksListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.titleColumnHeader,
            this.authorColumnHeader,
            this.checkoutDateColumnHeader,
            this.returnDateColumnHeader});
            this.booksListView.FullRowSelect = true;
            this.booksListView.GridLines = true;
            this.booksListView.HideSelection = false;
            this.booksListView.Location = new System.Drawing.Point(12, 221);
            this.booksListView.Name = "booksListView";
            this.booksListView.Size = new System.Drawing.Size(714, 128);
            this.booksListView.TabIndex = 2;
            this.booksListView.UseCompatibleStateImageBehavior = false;
            this.booksListView.View = System.Windows.Forms.View.Details;
            // 
            // titleColumnHeader
            // 
            this.titleColumnHeader.Text = "Title";
            this.titleColumnHeader.Width = 231;
            // 
            // authorColumnHeader
            // 
            this.authorColumnHeader.Text = "Author";
            this.authorColumnHeader.Width = 212;
            // 
            // checkoutDateColumnHeader
            // 
            this.checkoutDateColumnHeader.Text = "Checkout Date";
            this.checkoutDateColumnHeader.Width = 140;
            // 
            // returnDateColumnHeader
            // 
            this.returnDateColumnHeader.Text = "Return Date";
            this.returnDateColumnHeader.Width = 127;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(374, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 113);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Checkout:";
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(7, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Notification message";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "No. weeks:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(160, 51);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(186, 22);
            this.textBox3.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(271, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(160, 23);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 22);
            this.textBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Book ID:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(374, 131);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(352, 80);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Return:";
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(6, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Notification message";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(271, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(161, 22);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(185, 22);
            this.textBox4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Book ID:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 359);
            this.Controls.Add(this.booksListView);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Borrower";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

		}
	}
}
