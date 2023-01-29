
namespace ChangeToFocus
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.setIntervalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.freeReleasesPublicDomainisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.originalThreadDonationCodercomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sourceCodeGithubcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
			this.monitoredTextToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.monitoredToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.checkedTextToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.checkedToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.refreshListButton = new System.Windows.Forms.Button();
			this.startStopMonitoringButton = new System.Windows.Forms.Button();
			this.monitoredListView = new System.Windows.Forms.ListView();
			this.idColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.titleColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.checkToFocusLabel = new System.Windows.Forms.Label();
			this.processMonitorTimer = new System.Windows.Forms.Timer(this.components);
			this.mainMenuStrip.SuspendLayout();
			this.mainStatusStrip.SuspendLayout();
			this.mainTableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.toolsToolStripMenuItem,
									this.helpToolStripMenuItem});
			this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.Size = new System.Drawing.Size(284, 24);
			this.mainMenuStrip.TabIndex = 59;
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.newToolStripMenuItem,
									this.toolStripSeparator3,
									this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
			this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.newToolStripMenuItem.Text = "&New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.OnNewToolStripMenuItemClick);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(138, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExitToolStripMenuItemClick);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.customizeToolStripMenuItem,
									this.optionsToolStripMenuItem});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.toolsToolStripMenuItem.Text = "&Tools";
			// 
			// customizeToolStripMenuItem
			// 
			this.customizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.setIntervalToolStripMenuItem});
			this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
			this.customizeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
			this.customizeToolStripMenuItem.Text = "&Customize";
			// 
			// setIntervalToolStripMenuItem
			// 
			this.setIntervalToolStripMenuItem.Name = "setIntervalToolStripMenuItem";
			this.setIntervalToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.setIntervalToolStripMenuItem.Text = "&Set interval";
			this.setIntervalToolStripMenuItem.Click += new System.EventHandler(this.OnSetIntervalToolStripMenuItemClick);
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.alwaysOnTopToolStripMenuItem});
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
			this.optionsToolStripMenuItem.Text = "&Options";
			this.optionsToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnOptionsToolStripMenuItemDropDownItemClicked);
			// 
			// alwaysOnTopToolStripMenuItem
			// 
			this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
			this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
			this.alwaysOnTopToolStripMenuItem.Text = "&Always on top";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.freeReleasesPublicDomainisToolStripMenuItem,
									this.originalThreadDonationCodercomToolStripMenuItem,
									this.sourceCodeGithubcomToolStripMenuItem,
									this.toolStripSeparator2,
									this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// freeReleasesPublicDomainisToolStripMenuItem
			// 
			this.freeReleasesPublicDomainisToolStripMenuItem.Name = "freeReleasesPublicDomainisToolStripMenuItem";
			this.freeReleasesPublicDomainisToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
			this.freeReleasesPublicDomainisToolStripMenuItem.Text = "&Free Releases @ PublicDomain.is";
			this.freeReleasesPublicDomainisToolStripMenuItem.Click += new System.EventHandler(this.OnFreeReleasesPublicDomainisToolStripMenuItemClick);
			// 
			// originalThreadDonationCodercomToolStripMenuItem
			// 
			this.originalThreadDonationCodercomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("originalThreadDonationCodercomToolStripMenuItem.Image")));
			this.originalThreadDonationCodercomToolStripMenuItem.Name = "originalThreadDonationCodercomToolStripMenuItem";
			this.originalThreadDonationCodercomToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
			this.originalThreadDonationCodercomToolStripMenuItem.Text = "&Original thread @ DonationCoder.com";
			this.originalThreadDonationCodercomToolStripMenuItem.Click += new System.EventHandler(this.OnOriginalThreadDonationCodercomToolStripMenuItemClick);
			// 
			// sourceCodeGithubcomToolStripMenuItem
			// 
			this.sourceCodeGithubcomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sourceCodeGithubcomToolStripMenuItem.Image")));
			this.sourceCodeGithubcomToolStripMenuItem.Name = "sourceCodeGithubcomToolStripMenuItem";
			this.sourceCodeGithubcomToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
			this.sourceCodeGithubcomToolStripMenuItem.Text = "&Source code @ Github.com";
			this.sourceCodeGithubcomToolStripMenuItem.Click += new System.EventHandler(this.OnSourceCodeGithubcomToolStripMenuItemClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(275, 6);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
			this.aboutToolStripMenuItem.Text = "&About...";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnAboutToolStripMenuItemClick);
			// 
			// mainStatusStrip
			// 
			this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.monitoredTextToolStripStatusLabel,
									this.monitoredToolStripStatusLabel,
									this.checkedTextToolStripStatusLabel,
									this.checkedToolStripStatusLabel});
			this.mainStatusStrip.Location = new System.Drawing.Point(0, 321);
			this.mainStatusStrip.Name = "mainStatusStrip";
			this.mainStatusStrip.Size = new System.Drawing.Size(284, 22);
			this.mainStatusStrip.SizingGrip = false;
			this.mainStatusStrip.TabIndex = 58;
			// 
			// monitoredTextToolStripStatusLabel
			// 
			this.monitoredTextToolStripStatusLabel.Name = "monitoredTextToolStripStatusLabel";
			this.monitoredTextToolStripStatusLabel.Size = new System.Drawing.Size(66, 17);
			this.monitoredTextToolStripStatusLabel.Text = "Monitored:";
			// 
			// monitoredToolStripStatusLabel
			// 
			this.monitoredToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.monitoredToolStripStatusLabel.Name = "monitoredToolStripStatusLabel";
			this.monitoredToolStripStatusLabel.Size = new System.Drawing.Size(14, 17);
			this.monitoredToolStripStatusLabel.Text = "0";
			// 
			// checkedTextToolStripStatusLabel
			// 
			this.checkedTextToolStripStatusLabel.Name = "checkedTextToolStripStatusLabel";
			this.checkedTextToolStripStatusLabel.Size = new System.Drawing.Size(56, 17);
			this.checkedTextToolStripStatusLabel.Text = "Checked:";
			// 
			// checkedToolStripStatusLabel
			// 
			this.checkedToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.checkedToolStripStatusLabel.Name = "checkedToolStripStatusLabel";
			this.checkedToolStripStatusLabel.Size = new System.Drawing.Size(14, 17);
			this.checkedToolStripStatusLabel.Text = "0";
			// 
			// mainTableLayoutPanel
			// 
			this.mainTableLayoutPanel.ColumnCount = 1;
			this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.mainTableLayoutPanel.Controls.Add(this.refreshListButton, 0, 0);
			this.mainTableLayoutPanel.Controls.Add(this.startStopMonitoringButton, 0, 3);
			this.mainTableLayoutPanel.Controls.Add(this.monitoredListView, 0, 2);
			this.mainTableLayoutPanel.Controls.Add(this.checkToFocusLabel, 0, 1);
			this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
			this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
			this.mainTableLayoutPanel.RowCount = 4;
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.mainTableLayoutPanel.Size = new System.Drawing.Size(284, 297);
			this.mainTableLayoutPanel.TabIndex = 60;
			// 
			// refreshListButton
			// 
			this.refreshListButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.refreshListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.refreshListButton.Location = new System.Drawing.Point(3, 3);
			this.refreshListButton.Name = "refreshListButton";
			this.refreshListButton.Size = new System.Drawing.Size(278, 24);
			this.refreshListButton.TabIndex = 3;
			this.refreshListButton.Text = "&Refresh list";
			this.refreshListButton.UseVisualStyleBackColor = true;
			this.refreshListButton.Click += new System.EventHandler(this.OnRefreshListButtonClick);
			// 
			// startStopMonitoringButton
			// 
			this.startStopMonitoringButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.startStopMonitoringButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startStopMonitoringButton.ForeColor = System.Drawing.Color.Green;
			this.startStopMonitoringButton.Location = new System.Drawing.Point(3, 260);
			this.startStopMonitoringButton.Name = "startStopMonitoringButton";
			this.startStopMonitoringButton.Size = new System.Drawing.Size(278, 34);
			this.startStopMonitoringButton.TabIndex = 0;
			this.startStopMonitoringButton.Text = "&Start monitoring";
			this.startStopMonitoringButton.UseVisualStyleBackColor = true;
			this.startStopMonitoringButton.Click += new System.EventHandler(this.OnStartStopMonitoringButtonClick);
			// 
			// monitoredListView
			// 
			this.monitoredListView.CheckBoxes = true;
			this.monitoredListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.idColumnHeader,
									this.titleColumnHeader});
			this.monitoredListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.monitoredListView.FullRowSelect = true;
			this.monitoredListView.GridLines = true;
			this.monitoredListView.Location = new System.Drawing.Point(3, 58);
			this.monitoredListView.Name = "monitoredListView";
			this.monitoredListView.Size = new System.Drawing.Size(278, 196);
			this.monitoredListView.TabIndex = 2;
			this.monitoredListView.UseCompatibleStateImageBehavior = false;
			this.monitoredListView.View = System.Windows.Forms.View.Details;
			// 
			// idColumnHeader
			// 
			this.idColumnHeader.Text = "ID";
			// 
			// titleColumnHeader
			// 
			this.titleColumnHeader.Text = "Title";
			this.titleColumnHeader.Width = 211;
			// 
			// checkToFocusLabel
			// 
			this.checkToFocusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkToFocusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkToFocusLabel.Location = new System.Drawing.Point(3, 30);
			this.checkToFocusLabel.Name = "checkToFocusLabel";
			this.checkToFocusLabel.Size = new System.Drawing.Size(278, 25);
			this.checkToFocusLabel.TabIndex = 1;
			this.checkToFocusLabel.Text = "&Check to focus on change:";
			this.checkToFocusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 343);
			this.Controls.Add(this.mainTableLayoutPanel);
			this.Controls.Add(this.mainMenuStrip);
			this.Controls.Add(this.mainStatusStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Change to focus";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnMainFormFormClosing);
			this.Load += new System.EventHandler(this.OnMainFormLoad);
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.mainStatusStrip.ResumeLayout(false);
			this.mainStatusStrip.PerformLayout();
			this.mainTableLayoutPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ColumnHeader titleColumnHeader;
		private System.Windows.Forms.ColumnHeader idColumnHeader;
		private System.Windows.Forms.ToolStripStatusLabel checkedToolStripStatusLabel;
		private System.Windows.Forms.ToolStripStatusLabel checkedTextToolStripStatusLabel;
		private System.Windows.Forms.Label checkToFocusLabel;
		private System.Windows.Forms.ListView monitoredListView;
		private System.Windows.Forms.Timer processMonitorTimer;
		private System.Windows.Forms.Button startStopMonitoringButton;
		private System.Windows.Forms.Button refreshListButton;
		private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
		private System.Windows.Forms.ToolStripMenuItem setIntervalToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel monitoredToolStripStatusLabel;
		private System.Windows.Forms.ToolStripStatusLabel monitoredTextToolStripStatusLabel;
		private System.Windows.Forms.StatusStrip mainStatusStrip;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem sourceCodeGithubcomToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem originalThreadDonationCodercomToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem freeReleasesPublicDomainisToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip mainMenuStrip;
	}
}
