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
		private System.Windows.Forms.GroupBox groupBoxSearch;
		
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
			this.groupBoxSearch = new System.Windows.Forms.GroupBox();
			this.SuspendLayout();
			// 
			// groupBoxSearch
			// 
			this.groupBoxSearch.Location = new System.Drawing.Point(13, 13);
			this.groupBoxSearch.Name = "groupBoxSearch";
			this.groupBoxSearch.Size = new System.Drawing.Size(281, 100);
			this.groupBoxSearch.TabIndex = 0;
			this.groupBoxSearch.TabStop = false;
			this.groupBoxSearch.Text = "Search by:";
			// 
			// SearchBorrower
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(306, 255);
			this.Controls.Add(this.groupBoxSearch);
			this.Name = "SearchBorrower";
			this.Text = "SearchBorrower";
			this.ResumeLayout(false);

		}
	}
}
