// <copyright file="MainForm.cs" company="PublicDomain.is">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>

namespace ChangeToFocus
{
    // Directives
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// The process identifier title dictionary.
        /// </summary>
        Dictionary<int, string> processIdTitleDictionary = new Dictionary<int, string>();


        /// <summary>
        /// Initializes a new instance of the <see cref="T:ChangeToFocus.MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();
        }

        /// <summary>
        /// Handles the set interval tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSetIntervalToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the options tool strip menu item drop down item clicked.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOptionsToolStripMenuItemDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the new tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the free releases public domainis tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnFreeReleasesPublicDomainisToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the original thread donation codercom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOriginalThreadDonationCodercomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the source code githubcom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSourceCodeGithubcomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the about tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the refresh list button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnRefreshListButtonClick(object sender, EventArgs e)
        {
            // Prevent drawing
            this.monitoredListView.BeginUpdate();

            // Clear dictionary
            this.processIdTitleDictionary.Clear();

            // Clear listview
            this.monitoredListView.Items.Clear();

            // Set processes array
            Process[] processes = Process.GetProcesses();

            // Iterate
            foreach (Process process in processes)
            {
                // Check there's something to work with
                if (process.MainWindowTitle.Trim().Length > 0)
                {
                    // Set listview item
                    ListViewItem listViewItem = new ListViewItem(new[] { process.Id.ToString(), process.MainWindowTitle })
                    {
                        // Set tag
                        Tag = process.Id
                    };

                    // Add to listview
                    this.monitoredListView.Items.Add(listViewItem);
                }
            }

            // Resize the columns by contents
            this.monitoredListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            // Resume drawing
            this.monitoredListView.EndUpdate();
        }

        /// <summary>
        /// Handles the start stop monitoring button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnStartStopMonitoringButtonClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the main form load.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMainFormLoad(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the main form form closing.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the process monitor timer tick.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnProcessMonitorTimerTick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the monitored list view item checked.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMonitoredListViewItemChecked(object sender, ItemCheckedEventArgs e)
        {
            // Set process id
            int checkedProcessId = (int)e.Item.Tag;

            // Test checked state
            if (e.Item.Checked)
            {
                // Add to dictionary
                this.processIdTitleDictionary.Add(checkedProcessId, Process.GetProcessById(checkedProcessId).MainWindowTitle);
            }
            else
            {
                // Remove when unchecked
                this.processIdTitleDictionary.Remove(checkedProcessId);
            }
        }

        /// <summary>
        /// Handles the exit tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }
    }
}
