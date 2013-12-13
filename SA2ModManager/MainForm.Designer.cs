﻿namespace SA2ModManager
{
    partial class MainForm
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
            System.Windows.Forms.GroupBox groupBox2;
            this.sa2DebugCheckBox = new System.Windows.Forms.CheckBox();
            this.consoleCheckBox = new System.Windows.Forms.CheckBox();
            this.modDescription = new System.Windows.Forms.Label();
            this.modDownButton = new System.Windows.Forms.Button();
            this.modUpButton = new System.Windows.Forms.Button();
            this.modListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saveButton = new System.Windows.Forms.Button();
            this.saveAndPlayButton = new System.Windows.Forms.Button();
            this.installButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.deleteCodeButton = new System.Windows.Forms.Button();
            this.editCodeButton = new System.Windows.Forms.Button();
            this.newCodeButton = new System.Windows.Forms.Button();
            this.codesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.codeDownButton = new System.Windows.Forms.Button();
            this.codeUpButton = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            groupBox2.Controls.Add(this.sa2DebugCheckBox);
            groupBox2.Controls.Add(this.consoleCheckBox);
            groupBox2.Location = new System.Drawing.Point(12, 352);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(360, 50);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Options";
            // 
            // sa2DebugCheckBox
            // 
            this.sa2DebugCheckBox.AutoSize = true;
            this.sa2DebugCheckBox.Location = new System.Drawing.Point(148, 19);
            this.sa2DebugCheckBox.Name = "sa2DebugCheckBox";
            this.sa2DebugCheckBox.Size = new System.Drawing.Size(146, 17);
            this.sa2DebugCheckBox.TabIndex = 1;
            this.sa2DebugCheckBox.Text = "Show SA2 Debug Output";
            this.sa2DebugCheckBox.UseVisualStyleBackColor = true;
            // 
            // consoleCheckBox
            // 
            this.consoleCheckBox.AutoSize = true;
            this.consoleCheckBox.Location = new System.Drawing.Point(6, 19);
            this.consoleCheckBox.Name = "consoleCheckBox";
            this.consoleCheckBox.Size = new System.Drawing.Size(136, 17);
            this.consoleCheckBox.TabIndex = 0;
            this.consoleCheckBox.Text = "Show Console Window";
            this.consoleCheckBox.UseVisualStyleBackColor = true;
            // 
            // modDescription
            // 
            this.modDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modDescription.Location = new System.Drawing.Point(3, 249);
            this.modDescription.Name = "modDescription";
            this.modDescription.Size = new System.Drawing.Size(332, 57);
            this.modDescription.TabIndex = 5;
            this.modDescription.Text = "Description: No mod selected.";
            // 
            // modDownButton
            // 
            this.modDownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modDownButton.AutoSize = true;
            this.modDownButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.modDownButton.Enabled = false;
            this.modDownButton.Location = new System.Drawing.Point(341, 35);
            this.modDownButton.Name = "modDownButton";
            this.modDownButton.Size = new System.Drawing.Size(29, 23);
            this.modDownButton.TabIndex = 2;
            this.modDownButton.Text = "↓";
            this.modDownButton.UseVisualStyleBackColor = true;
            this.modDownButton.Click += new System.EventHandler(this.modDownButton_Click);
            // 
            // modUpButton
            // 
            this.modUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modUpButton.AutoSize = true;
            this.modUpButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.modUpButton.Enabled = false;
            this.modUpButton.Location = new System.Drawing.Point(341, 6);
            this.modUpButton.Name = "modUpButton";
            this.modUpButton.Size = new System.Drawing.Size(29, 23);
            this.modUpButton.TabIndex = 1;
            this.modUpButton.Text = "↑";
            this.modUpButton.UseVisualStyleBackColor = true;
            this.modUpButton.Click += new System.EventHandler(this.modUpButton_Click);
            // 
            // modListView
            // 
            this.modListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modListView.CheckBoxes = true;
            this.modListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.modListView.FullRowSelect = true;
            this.modListView.HideSelection = false;
            this.modListView.Location = new System.Drawing.Point(3, 6);
            this.modListView.MultiSelect = false;
            this.modListView.Name = "modListView";
            this.modListView.Size = new System.Drawing.Size(332, 240);
            this.modListView.TabIndex = 0;
            this.modListView.UseCompatibleStateImageBehavior = false;
            this.modListView.View = System.Windows.Forms.View.Details;
            this.modListView.SelectedIndexChanged += new System.EventHandler(this.modListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 154;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Author";
            this.columnHeader2.Width = 120;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(104, 408);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // saveAndPlayButton
            // 
            this.saveAndPlayButton.AutoSize = true;
            this.saveAndPlayButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveAndPlayButton.Location = new System.Drawing.Point(12, 408);
            this.saveAndPlayButton.Name = "saveAndPlayButton";
            this.saveAndPlayButton.Size = new System.Drawing.Size(86, 23);
            this.saveAndPlayButton.TabIndex = 4;
            this.saveAndPlayButton.Text = "Save and Play";
            this.saveAndPlayButton.UseVisualStyleBackColor = true;
            this.saveAndPlayButton.Click += new System.EventHandler(this.saveAndPlayButton_Click);
            // 
            // installButton
            // 
            this.installButton.AutoSize = true;
            this.installButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.installButton.Location = new System.Drawing.Point(185, 408);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(76, 23);
            this.installButton.TabIndex = 5;
            this.installButton.Text = "Install loader";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(384, 346);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.modDescription);
            this.tabPage1.Controls.Add(this.modListView);
            this.tabPage1.Controls.Add(this.modDownButton);
            this.tabPage1.Controls.Add(this.modUpButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 320);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mods";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.codeDownButton);
            this.tabPage2.Controls.Add(this.codeUpButton);
            this.tabPage2.Controls.Add(this.deleteCodeButton);
            this.tabPage2.Controls.Add(this.editCodeButton);
            this.tabPage2.Controls.Add(this.newCodeButton);
            this.tabPage2.Controls.Add(this.codesCheckedListBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(376, 320);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Codes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // deleteCodeButton
            // 
            this.deleteCodeButton.AutoSize = true;
            this.deleteCodeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteCodeButton.Enabled = false;
            this.deleteCodeButton.Location = new System.Drawing.Point(92, 291);
            this.deleteCodeButton.Name = "deleteCodeButton";
            this.deleteCodeButton.Size = new System.Drawing.Size(48, 23);
            this.deleteCodeButton.TabIndex = 3;
            this.deleteCodeButton.Text = "Delete";
            this.deleteCodeButton.UseVisualStyleBackColor = true;
            this.deleteCodeButton.Visible = false;
            // 
            // editCodeButton
            // 
            this.editCodeButton.AutoSize = true;
            this.editCodeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editCodeButton.Enabled = false;
            this.editCodeButton.Location = new System.Drawing.Point(51, 291);
            this.editCodeButton.Name = "editCodeButton";
            this.editCodeButton.Size = new System.Drawing.Size(35, 23);
            this.editCodeButton.TabIndex = 2;
            this.editCodeButton.Text = "Edit";
            this.editCodeButton.UseVisualStyleBackColor = true;
            this.editCodeButton.Visible = false;
            // 
            // newCodeButton
            // 
            this.newCodeButton.AutoSize = true;
            this.newCodeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.newCodeButton.Location = new System.Drawing.Point(6, 291);
            this.newCodeButton.Name = "newCodeButton";
            this.newCodeButton.Size = new System.Drawing.Size(39, 23);
            this.newCodeButton.TabIndex = 1;
            this.newCodeButton.Text = "New";
            this.newCodeButton.UseVisualStyleBackColor = true;
            this.newCodeButton.Visible = false;
            // 
            // codesCheckedListBox
            // 
            this.codesCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codesCheckedListBox.FormattingEnabled = true;
            this.codesCheckedListBox.Location = new System.Drawing.Point(6, 6);
            this.codesCheckedListBox.Name = "codesCheckedListBox";
            this.codesCheckedListBox.Size = new System.Drawing.Size(329, 274);
            this.codesCheckedListBox.TabIndex = 0;
            this.codesCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.codesCheckedListBox_SelectedIndexChanged);
            // 
            // codeDownButton
            // 
            this.codeDownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.codeDownButton.AutoSize = true;
            this.codeDownButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.codeDownButton.Enabled = false;
            this.codeDownButton.Location = new System.Drawing.Point(341, 35);
            this.codeDownButton.Name = "codeDownButton";
            this.codeDownButton.Size = new System.Drawing.Size(29, 23);
            this.codeDownButton.TabIndex = 5;
            this.codeDownButton.Text = "↓";
            this.codeDownButton.UseVisualStyleBackColor = true;
            this.codeDownButton.Click += new System.EventHandler(this.codeDownButton_Click);
            // 
            // codeUpButton
            // 
            this.codeUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.codeUpButton.AutoSize = true;
            this.codeUpButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.codeUpButton.Enabled = false;
            this.codeUpButton.Location = new System.Drawing.Point(341, 6);
            this.codeUpButton.Name = "codeUpButton";
            this.codeUpButton.Size = new System.Drawing.Size(29, 23);
            this.codeUpButton.TabIndex = 4;
            this.codeUpButton.Text = "↑";
            this.codeUpButton.UseVisualStyleBackColor = true;
            this.codeUpButton.Click += new System.EventHandler(this.codeUpButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(384, 444);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.installButton);
            this.Controls.Add(this.saveAndPlayButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(groupBox2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ShowIcon = false;
            this.Text = "SA2 Mod Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView modListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button modDownButton;
        private System.Windows.Forms.Button modUpButton;
        private System.Windows.Forms.CheckBox consoleCheckBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button saveAndPlayButton;
        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.CheckBox sa2DebugCheckBox;
        private System.Windows.Forms.Label modDescription;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckedListBox codesCheckedListBox;
        private System.Windows.Forms.Button deleteCodeButton;
        private System.Windows.Forms.Button editCodeButton;
        private System.Windows.Forms.Button newCodeButton;
        private System.Windows.Forms.Button codeDownButton;
        private System.Windows.Forms.Button codeUpButton;
    }
}

