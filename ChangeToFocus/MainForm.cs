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
    using System.Runtime.InteropServices;
    using System.Threading;
    using System.Windows.Forms;
    using Microsoft.VisualBasic;

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
        /// Shows the window.
        /// </summary>
        /// <returns><c>true</c>, if window was shown, <c>false</c> otherwise.</returns>
        /// <param name="hWnd">H window.</param>
        /// <param name="nCmdShow">N cmd show.</param>
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        /// <summary>
        /// Sets the foreground window.
        /// </summary>
        /// <returns><c>true</c>, if foreground window was set, <c>false</c> otherwise.</returns>
        /// <param name="hWnd">H window.</param>
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        /// <summary>
        /// Gets the window long.
        /// </summary>
        /// <returns>The window long.</returns>
        /// <param name="hWnd">H window.</param>
        /// <param name="nIndex">N index.</param>
        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        /// <summary>
        /// Sets the window position.
        /// </summary>
        /// <returns><c>true</c>, if window position was set, <c>false</c> otherwise.</returns>
        /// <param name="hWnd">H window.</param>
        /// <param name="hWndInsertAfter">H window insert after.</param>
        /// <param name="X">X.</param>
        /// <param name="Y">Y.</param>
        /// <param name="cx">Cx.</param>
        /// <param name="cy">Cy.</param>
        /// <param name="uFlags">U flags.</param>
        [DllImport("user32.dll")]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        /// <summary>
        /// The hwnd topmost.
        /// </summary>
        static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);

        /// <summary>
        /// The hwnd notopmost.
        /// </summary>
        static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);

        /// <summary>
        /// The hwnd top.
        /// </summary>
        static readonly IntPtr HWND_TOP = new IntPtr(0);

        /// <summary>
        /// The swp nosize.
        /// </summary>
        const UInt32 SWP_NOSIZE = 0x0001;

        /// <summary>
        /// The swp nomove.
        /// </summary>
        const UInt32 SWP_NOMOVE = 0x0002;

        /// <summary>
        /// The swp showwindow.
        /// </summary>
        const UInt32 SWP_SHOWWINDOW = 0x0040;

        /// <summary>
        /// The gwl exstyle.
        /// </summary>
        const int GWL_EXSTYLE = -20;

        /// <summary>
        /// The ws ex topmost.
        /// </summary>
        const int WS_EX_TOPMOST = 0x0008;

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
            // Try to parse integer from user input
            if (int.TryParse(Interaction.InputBox("Enter new interval (in milliseconds):", "Set interval", this.processMonitorTimer.Interval.ToString()), out int parsedInt) && parsedInt > 0)
            {
                // Set itnerval
                this.processMonitorTimer.Interval = parsedInt;
            }
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
                // Check for current process
                if (process.Id == Process.GetCurrentProcess().Id)
                {
                    // Skip iteration
                    continue;
                }

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

            // Update monitored count
            this.monitoredToolStripStatusLabel.Text = this.monitoredListView.Items.Count.ToString();
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
            // Check there's something to work with
            if (this.processIdTitleDictionary.Count == 0)
            {
                // Halt flow
                return;
            }

            // Expired IDs list
            List<int> expiredIdsList = new List<int>();

            // Updated IDs list
            List<int> updatedIdsdList = new List<int>();

            // Set process
            Process process = null;

            // Iterate dictionary 
            foreach (var item in this.processIdTitleDictionary)
            {
                // Try to set process by ID
                try
                {
                    // Set process
                    process = Process.GetProcessById(item.Key);
                }
                catch (Exception)
                {
                    // Mark process ID for removal
                    expiredIdsList.Add(item.Key);
                }

                // Compare titles
                if (process != null && process.MainWindowTitle != this.processIdTitleDictionary[item.Key])
                {
                    /* TODO Bring to the fore / focus & activate [Can be improved/optimized] */

                    // TODO Restore [SW_RESTORE]
                    ShowWindow(process.MainWindowHandle, 9);

                    // Set isTopmost flag
                    bool isTopmost = (GetWindowLong(process.MainWindowHandle, GWL_EXSTYLE) & WS_EX_TOPMOST) != 0;

                    // Check for no topmost
                    if (!isTopmost)
                    {
                        // Set window topmost
                        SetWindowPos(process.MainWindowHandle, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_SHOWWINDOW);
                    }

                    // Foreground
                    SetForegroundWindow(process.MainWindowHandle);

                    if (!isTopmost)
                    {
                        // Take topmost away
                        SetWindowPos(process.MainWindowHandle, HWND_NOTOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_SHOWWINDOW);
                    }

                    // Top of z-order
                    SetWindowPos(process.MainWindowHandle, HWND_TOP, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_SHOWWINDOW);

                    // Activate
                    //Interaction.AppActivate(process.Id);

                    // Add to updated ids
                    updatedIdsdList.Add(item.Key);
                }
            }

            // Check if must remove expired processes
            if (expiredIdsList.Count > 0)
            {
                // Iterate
                foreach (var item in expiredIdsList)
                {
                    // Remove from dictionary
                    this.processIdTitleDictionary.Remove(item);

                    // TODO Remove from list view [can be merged with "Iterate listview items" loop below via refactoring]
                    for (int i = this.monitoredListView.Items.Count - 1; i >= 0; i--)
                    {
                        // Check tag
                        if (expiredIdsList.Contains((int)this.monitoredListView.Items[i].Tag))
                        {
                            // Remove the expired item
                            this.monitoredListView.Items[i].Remove();
                        }
                    }
                }
            }

            // Check if must update titles for updated processes
            if (updatedIdsdList.Count > 0)
            {
                // Iterate listview items
                for (int i = 0; i < this.monitoredListView.Items.Count; i++)
                {
                    // Check tag
                    if (updatedIdsdList.Contains((int)this.monitoredListView.Items[i].Tag))
                    {
                        // Update in list view
                        this.monitoredListView.Items[i].SubItems[1].Text = process.MainWindowTitle;

                        // Update in dictionary
                        this.processIdTitleDictionary[(int)this.monitoredListView.Items[i].Tag] = process.MainWindowTitle;
                    }
                }
            }

            // Update monitored count
            this.monitoredToolStripStatusLabel.Text = this.monitoredListView.Items.Count.ToString();

            // Update checked count
            this.checkedToolStripStatusLabel.Text = this.monitoredListView.CheckedItems.Count.ToString();
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

            // Update checked count
            this.checkedToolStripStatusLabel.Text = this.monitoredListView.CheckedItems.Count.ToString();
        }

        /// <summary>
        /// Handles the exit tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Close program        
            this.Close();
        }
    }
}
