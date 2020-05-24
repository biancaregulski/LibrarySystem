/*
 * Created by SharpDevelop.
 * User: Bianca
 * Date: 5/23/2020
 * Time: 2:32 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LibrarySystem
{
	partial class SearchBorrower
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.ColumnHeader columnHeaderFirstName;
		private System.Windows.Forms.ColumnHeader columnHeaderDob;
		private System.Windows.Forms.ColumnHeader columnHeaderId;
		private System.Windows.Forms.ListView listViewBorrowers;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.Button buttonShowAll;
		private System.Windows.Forms.MaskedTextBox textBoxLastName;
		private System.Windows.Forms.MaskedTextBox textBoxFirstName;
		private System.Windows.Forms.ContextMenuStrip contextMenuStripBorrowers;
		private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
		
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
			this.components = new System.ComponentModel.Container();
			this.listViewBorrowers = new System.Windows.Forms.ListView();
			this.columnHeaderId = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderFirstName = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderDob = new System.Windows.Forms.ColumnHeader();
			this.contextMenuStripBorrowers = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.labelName = new System.Windows.Forms.Label();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.buttonShowAll = new System.Windows.Forms.Button();
			this.textBoxLastName = new System.Windows.Forms.MaskedTextBox();
			this.textBoxFirstName = new System.Windows.Forms.MaskedTextBox();
			this.contextMenuStripBorrowers.SuspendLayout();
			this.SuspendLayout();
			// 
			// listViewBorrowers
			// 
			this.listViewBorrowers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.columnHeaderId,
			this.columnHeaderFirstName,
			this.columnHeaderDob});
			this.listViewBorrowers.ContextMenuStrip = this.contextMenuStripBorrowers;
			this.listViewBorrowers.FullRowSelect = true;
			this.listViewBorrowers.GridLines = true;
			this.listViewBorrowers.Location = new System.Drawing.Point(12, 72);
			this.listViewBorrowers.MultiSelect = false;
			this.listViewBorrowers.Name = "listViewBorrowers";
			this.listViewBorrowers.Size = new System.Drawing.Size(356, 128);
			this.listViewBorrowers.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.listViewBorrowers.TabIndex = 1;
			this.listViewBorrowers.UseCompatibleStateImageBehavior = false;
			this.listViewBorrowers.View = System.Windows.Forms.View.Details;
			// 
			// columnHeaderId
			// 
			this.columnHeaderId.Text = "ID";
			// 
			// columnHeaderFirstName
			// 
			this.columnHeaderFirstName.Text = "Name";
			this.columnHeaderFirstName.Width = 169;
			// 
			// columnHeaderDob
			// 
			this.columnHeaderDob.Text = "Date of Birth";
			this.columnHeaderDob.Width = 122;
			// 
			// contextMenuStripBorrowers
			// 
			this.contextMenuStripBorrowers.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStripBorrowers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.loginToolStripMenuItem});
			this.contextMenuStripBorrowers.Name = "contextMenuStripBorrowers";
			this.contextMenuStripBorrowers.Size = new System.Drawing.Size(116, 28);
			// 
			// loginToolStripMenuItem
			// 
			this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
			this.loginToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
			this.loginToolStripMenuItem.Text = "Login";
			this.loginToolStripMenuItem.Click += new System.EventHandler(this.LoginToolStripMenuItemClick);
			// 
			// labelName
			// 
			this.labelName.Location = new System.Drawing.Point(12, 15);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(100, 23);
			this.labelName.TabIndex = 16;
			this.labelName.Text = "Name:";
			// 
			// buttonSearch
			// 
			this.buttonSearch.Location = new System.Drawing.Point(293, 40);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(75, 23);
			this.buttonSearch.TabIndex = 17;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.ButtonSearchClick);
			// 
			// buttonShowAll
			// 
			this.buttonShowAll.Location = new System.Drawing.Point(212, 40);
			this.buttonShowAll.Name = "buttonShowAll";
			this.buttonShowAll.Size = new System.Drawing.Size(75, 23);
			this.buttonShowAll.TabIndex = 18;
			this.buttonShowAll.Text = "Show All";
			this.buttonShowAll.UseVisualStyleBackColor = true;
			this.buttonShowAll.Click += new System.EventHandler(this.ButtonShowAllClick);
			// 
			// textBoxLastName
			// 
			this.textBoxLastName.Location = new System.Drawing.Point(268, 12);
			this.textBoxLastName.Name = "textBoxLastName";
			this.textBoxLastName.Size = new System.Drawing.Size(100, 22);
			this.textBoxLastName.TabIndex = 2;
			// 
			// textBoxFirstName
			// 
			this.textBoxFirstName.Location = new System.Drawing.Point(162, 12);
			this.textBoxFirstName.Name = "textBoxFirstName";
			this.textBoxFirstName.Size = new System.Drawing.Size(100, 22);
			this.textBoxFirstName.TabIndex = 1;
			// 
			// SearchBorrower
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(380, 210);
			this.Controls.Add(this.textBoxFirstName);
			this.Controls.Add(this.textBoxLastName);
			this.Controls.Add(this.buttonShowAll);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.listViewBorrowers);
			this.Controls.Add(this.labelName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "SearchBorrower";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SearchBorrower";
			this.contextMenuStripBorrowers.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
