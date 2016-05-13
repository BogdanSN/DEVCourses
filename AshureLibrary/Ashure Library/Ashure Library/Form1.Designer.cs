namespace Ashure_Library
{
    partial class AshureLibraryForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AshureLibraryForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findAudioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extendedSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToCurrentPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToNewPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadPlaylistButton = new System.Windows.Forms.Button();
            this.SaveCurrentPlaylistButton = new System.Windows.Forms.Button();
            this.SaveAsPlaylistButton = new System.Windows.Forms.Button();
            this.ExportPlaylistButton = new System.Windows.Forms.Button();
            this.FindAudioButton = new System.Windows.Forms.Button();
            this.CurrentListView = new System.Windows.Forms.ListView();
            this.ColumnTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.RemoveButton = new System.Windows.Forms.Button();
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip7 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip8 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip9 = new System.Windows.Forms.ToolTip(this.components);
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.FindSongTextBox = new System.Windows.Forms.TextBox();
            this.conMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddNewFileContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearPlaylistToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.FindSongButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.conMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(232, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findAudioToolStripMenuItem,
            this.saveToPlaylistToolStripMenuItem,
            this.loadPlToolStripMenuItem,
            this.exportPlaylistToolStripMenuItem,
            this.clearPlaylistToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // findAudioToolStripMenuItem
            // 
            this.findAudioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simpleSearchToolStripMenuItem,
            this.extendedSearchToolStripMenuItem});
            this.findAudioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("findAudioToolStripMenuItem.Image")));
            this.findAudioToolStripMenuItem.Name = "findAudioToolStripMenuItem";
            this.findAudioToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.findAudioToolStripMenuItem.Text = "Find Audio";
            // 
            // simpleSearchToolStripMenuItem
            // 
            this.simpleSearchToolStripMenuItem.Name = "simpleSearchToolStripMenuItem";
            this.simpleSearchToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.simpleSearchToolStripMenuItem.Text = "Simple Search";
            // 
            // extendedSearchToolStripMenuItem
            // 
            this.extendedSearchToolStripMenuItem.Name = "extendedSearchToolStripMenuItem";
            this.extendedSearchToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.extendedSearchToolStripMenuItem.Text = "Extended Search";
            this.extendedSearchToolStripMenuItem.Click += new System.EventHandler(this.extendedSearchToolStripMenuItem_Click);
            // 
            // saveToPlaylistToolStripMenuItem
            // 
            this.saveToPlaylistToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToCurrentPlaylistToolStripMenuItem,
            this.saveToNewPlaylistToolStripMenuItem});
            this.saveToPlaylistToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToPlaylistToolStripMenuItem.Image")));
            this.saveToPlaylistToolStripMenuItem.Name = "saveToPlaylistToolStripMenuItem";
            this.saveToPlaylistToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.saveToPlaylistToolStripMenuItem.Text = "Save Playlist";
            // 
            // saveToCurrentPlaylistToolStripMenuItem
            // 
            this.saveToCurrentPlaylistToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToCurrentPlaylistToolStripMenuItem.Image")));
            this.saveToCurrentPlaylistToolStripMenuItem.Name = "saveToCurrentPlaylistToolStripMenuItem";
            this.saveToCurrentPlaylistToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.saveToCurrentPlaylistToolStripMenuItem.Text = "Save to current Playlist";
            // 
            // saveToNewPlaylistToolStripMenuItem
            // 
            this.saveToNewPlaylistToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToNewPlaylistToolStripMenuItem.Image")));
            this.saveToNewPlaylistToolStripMenuItem.Name = "saveToNewPlaylistToolStripMenuItem";
            this.saveToNewPlaylistToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.saveToNewPlaylistToolStripMenuItem.Text = "Save to new Playlist";
            // 
            // loadPlToolStripMenuItem
            // 
            this.loadPlToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loadPlToolStripMenuItem.Image")));
            this.loadPlToolStripMenuItem.Name = "loadPlToolStripMenuItem";
            this.loadPlToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.loadPlToolStripMenuItem.Text = "Load Playlist";
            // 
            // exportPlaylistToolStripMenuItem
            // 
            this.exportPlaylistToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exportPlaylistToolStripMenuItem.Image")));
            this.exportPlaylistToolStripMenuItem.Name = "exportPlaylistToolStripMenuItem";
            this.exportPlaylistToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.exportPlaylistToolStripMenuItem.Text = "Export Playlist";
            // 
            // clearPlaylistToolStripMenuItem
            // 
            this.clearPlaylistToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clearPlaylistToolStripMenuItem.Image")));
            this.clearPlaylistToolStripMenuItem.Name = "clearPlaylistToolStripMenuItem";
            this.clearPlaylistToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.clearPlaylistToolStripMenuItem.Text = "Clear Playlist";
            this.clearPlaylistToolStripMenuItem.Click += new System.EventHandler(this.clearPlaylistToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("closeToolStripMenuItem.Image")));
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // LoadPlaylistButton
            // 
            this.LoadPlaylistButton.Image = ((System.Drawing.Image)(resources.GetObject("LoadPlaylistButton.Image")));
            this.LoadPlaylistButton.Location = new System.Drawing.Point(48, 27);
            this.LoadPlaylistButton.Name = "LoadPlaylistButton";
            this.LoadPlaylistButton.Size = new System.Drawing.Size(30, 26);
            this.LoadPlaylistButton.TabIndex = 1;
            this.toolTip1.SetToolTip(this.LoadPlaylistButton, "Load Playlist");
            this.LoadPlaylistButton.UseVisualStyleBackColor = true;
            this.LoadPlaylistButton.Click += new System.EventHandler(this.LoadPlaylistButton_Click);
            // 
            // SaveCurrentPlaylistButton
            // 
            this.SaveCurrentPlaylistButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveCurrentPlaylistButton.Image")));
            this.SaveCurrentPlaylistButton.Location = new System.Drawing.Point(84, 27);
            this.SaveCurrentPlaylistButton.Name = "SaveCurrentPlaylistButton";
            this.SaveCurrentPlaylistButton.Size = new System.Drawing.Size(29, 26);
            this.SaveCurrentPlaylistButton.TabIndex = 2;
            this.toolTip2.SetToolTip(this.SaveCurrentPlaylistButton, "Save to current Playlist");
            this.SaveCurrentPlaylistButton.UseVisualStyleBackColor = true;
            this.SaveCurrentPlaylistButton.Click += new System.EventHandler(this.SaveCurrentPlaylistButton_Click);
            // 
            // SaveAsPlaylistButton
            // 
            this.SaveAsPlaylistButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveAsPlaylistButton.Image")));
            this.SaveAsPlaylistButton.Location = new System.Drawing.Point(120, 27);
            this.SaveAsPlaylistButton.Name = "SaveAsPlaylistButton";
            this.SaveAsPlaylistButton.Size = new System.Drawing.Size(29, 26);
            this.SaveAsPlaylistButton.TabIndex = 3;
            this.toolTip3.SetToolTip(this.SaveAsPlaylistButton, "Save to a new Playlist");
            this.SaveAsPlaylistButton.UseVisualStyleBackColor = true;
            this.SaveAsPlaylistButton.Click += new System.EventHandler(this.SaveToNewPlaylistButton_Click);
            // 
            // ExportPlaylistButton
            // 
            this.ExportPlaylistButton.Image = ((System.Drawing.Image)(resources.GetObject("ExportPlaylistButton.Image")));
            this.ExportPlaylistButton.Location = new System.Drawing.Point(155, 27);
            this.ExportPlaylistButton.Name = "ExportPlaylistButton";
            this.ExportPlaylistButton.Size = new System.Drawing.Size(31, 26);
            this.ExportPlaylistButton.TabIndex = 4;
            this.toolTip4.SetToolTip(this.ExportPlaylistButton, "Export Playlist");
            this.ExportPlaylistButton.UseVisualStyleBackColor = true;
            // 
            // FindAudioButton
            // 
            this.FindAudioButton.Image = ((System.Drawing.Image)(resources.GetObject("FindAudioButton.Image")));
            this.FindAudioButton.Location = new System.Drawing.Point(12, 27);
            this.FindAudioButton.Name = "FindAudioButton";
            this.FindAudioButton.Size = new System.Drawing.Size(31, 26);
            this.FindAudioButton.TabIndex = 5;
            this.toolTip5.SetToolTip(this.FindAudioButton, "Find a new Audio");
            this.FindAudioButton.UseVisualStyleBackColor = true;
            this.FindAudioButton.Click += new System.EventHandler(this.FindAudioButton_Click);
            // 
            // CurrentListView
            // 
            this.CurrentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnTitle,
            this.ColumnLocation});
            this.CurrentListView.HideSelection = false;
            this.CurrentListView.Location = new System.Drawing.Point(12, 84);
            this.CurrentListView.Name = "CurrentListView";
            this.CurrentListView.Size = new System.Drawing.Size(210, 236);
            this.CurrentListView.TabIndex = 6;
            this.CurrentListView.UseCompatibleStateImageBehavior = false;
            this.CurrentListView.View = System.Windows.Forms.View.Details;
            this.CurrentListView.SelectedIndexChanged += new System.EventHandler(this.CurrentListView_SelectedIndexChanged);
            this.CurrentListView.DoubleClick += new System.EventHandler(this.CurrentListView_DoubleClick);
            this.CurrentListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CurrentListView_MouseClick);
            // 
            // ColumnTitle
            // 
            this.ColumnTitle.Text = "Title";
            this.ColumnTitle.Width = 142;
            // 
            // ColumnLocation
            // 
            this.ColumnLocation.Text = "Location";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveButton.Image")));
            this.RemoveButton.Location = new System.Drawing.Point(192, 27);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(30, 26);
            this.RemoveButton.TabIndex = 8;
            this.toolTip6.SetToolTip(this.RemoveButton, "Remove current file form the Playlist");
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(12, 324);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(210, 60);
            this.mediaPlayer.TabIndex = 7;
            // 
            // FindSongTextBox
            // 
            this.FindSongTextBox.Location = new System.Drawing.Point(13, 58);
            this.FindSongTextBox.Name = "FindSongTextBox";
            this.FindSongTextBox.Size = new System.Drawing.Size(173, 20);
            this.FindSongTextBox.TabIndex = 9;
            // 
            // conMenu
            // 
            this.conMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewFileContextMenu,
            this.removeSelectedToolStripMenuItem,
            this.clearPlaylistToolStripMenuItem1});
            this.conMenu.Name = "conMenu";
            this.conMenu.Size = new System.Drawing.Size(164, 70);
            // 
            // AddNewFileContextMenu
            // 
            this.AddNewFileContextMenu.Name = "AddNewFileContextMenu";
            this.AddNewFileContextMenu.Size = new System.Drawing.Size(163, 22);
            this.AddNewFileContextMenu.Text = "Add  a new file";
            // 
            // removeSelectedToolStripMenuItem
            // 
            this.removeSelectedToolStripMenuItem.Name = "removeSelectedToolStripMenuItem";
            this.removeSelectedToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.removeSelectedToolStripMenuItem.Text = "Remove selected";
            // 
            // clearPlaylistToolStripMenuItem1
            // 
            this.clearPlaylistToolStripMenuItem1.Name = "clearPlaylistToolStripMenuItem1";
            this.clearPlaylistToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.clearPlaylistToolStripMenuItem1.Text = "Clear Playlist";
            // 
            // FindSongButton
            // 
            this.FindSongButton.Image = ((System.Drawing.Image)(resources.GetObject("FindSongButton.Image")));
            this.FindSongButton.Location = new System.Drawing.Point(192, 58);
            this.FindSongButton.Name = "FindSongButton";
            this.FindSongButton.Size = new System.Drawing.Size(28, 20);
            this.FindSongButton.TabIndex = 10;
            this.FindSongButton.UseVisualStyleBackColor = true;
            this.FindSongButton.Click += new System.EventHandler(this.FindSongButton_Click);
            // 
            // AshureLibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 390);
            this.Controls.Add(this.FindSongButton);
            this.Controls.Add(this.FindSongTextBox);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.mediaPlayer);
            this.Controls.Add(this.CurrentListView);
            this.Controls.Add(this.FindAudioButton);
            this.Controls.Add(this.ExportPlaylistButton);
            this.Controls.Add(this.SaveAsPlaylistButton);
            this.Controls.Add(this.SaveCurrentPlaylistButton);
            this.Controls.Add(this.LoadPlaylistButton);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AshureLibraryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ashure Library";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.conMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findAudioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadPlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToCurrentPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToNewPlaylistToolStripMenuItem;
        private System.Windows.Forms.Button LoadPlaylistButton;
        private System.Windows.Forms.Button SaveCurrentPlaylistButton;
        private System.Windows.Forms.Button SaveAsPlaylistButton;
        private System.Windows.Forms.Button ExportPlaylistButton;
        private System.Windows.Forms.Button FindAudioButton;
        private System.Windows.Forms.ListView CurrentListView;
        private System.Windows.Forms.ColumnHeader ColumnTitle;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.ToolTip toolTip7;
        private System.Windows.Forms.ToolTip toolTip8;
        private System.Windows.Forms.ToolTip toolTip9;
        private System.Windows.Forms.ColumnHeader ColumnLocation;
        private System.Windows.Forms.ToolStripMenuItem clearPlaylistToolStripMenuItem;
        private System.Windows.Forms.TextBox FindSongTextBox;
        private System.Windows.Forms.ToolStripMenuItem simpleSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extendedSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNewFileContextMenu;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearPlaylistToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip conMenu;
        private System.Windows.Forms.Button FindSongButton;
    }
}

