using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiaLukashykLab3._1
{

    public partial class Form1 : Form
    {
        int MDIchildFormNumber = 1;
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            closeAllToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            toolbarToolStripMenuItem = new ToolStripMenuItem();
            statusBarToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            insertImageToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            replaceToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            windowToolStripMenuItem = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            tileHorizontalToolStripMenuItem = new ToolStripMenuItem();
            tileVerticalToolStripMenuItem = new ToolStripMenuItem();
            arrangeIconsToolStripMenuItem = new ToolStripMenuItem();
            minimizeAllToolStripMenuItem = new ToolStripMenuItem();
            maximizeAllToolStripMenuItem = new ToolStripMenuItem();
            mdiWindowListItem1 = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            toolStripButton6 = new ToolStripButton();
            toolStripButton7 = new ToolStripButton();
            toolStrip2 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripButton8 = new ToolStripButton();
            toolStripButton9 = new ToolStripButton();
            this.toolStripButton10 = new ToolStripButton();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            toolStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem, editToolStripMenuItem, formatToolStripMenuItem, windowToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(731, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, closeToolStripMenuItem, closeAllToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(179, 34);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(179, 34);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(179, 34);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(179, 34);
            saveAsToolStripMenuItem.Text = "Save as";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(179, 34);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // closeAllToolStripMenuItem
            // 
            closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            closeAllToolStripMenuItem.Size = new Size(179, 34);
            closeAllToolStripMenuItem.Text = "Close all";
            closeAllToolStripMenuItem.Click += closeAllToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(179, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolbarToolStripMenuItem, statusBarToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(65, 29);
            viewToolStripMenuItem.Text = "View";
            // 
            // toolbarToolStripMenuItem
            // 
            toolbarToolStripMenuItem.Name = "toolbarToolStripMenuItem";
            toolbarToolStripMenuItem.Size = new Size(187, 34);
            toolbarToolStripMenuItem.Text = "ToolBar";
            toolbarToolStripMenuItem.Click += toolbarToolStripMenuItem_Click;
            // 
            // statusBarToolStripMenuItem
            // 
            statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            statusBarToolStripMenuItem.Size = new Size(187, 34);
            statusBarToolStripMenuItem.Text = "StatusBar";
            statusBarToolStripMenuItem.Click += statusBarToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, insertImageToolStripMenuItem, searchToolStripMenuItem, replaceToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(58, 29);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.Size = new Size(213, 34);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.Size = new Size(213, 34);
            redoToolStripMenuItem.Text = "Redo";
            redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(213, 34);
            cutToolStripMenuItem.Text = "Cut";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(213, 34);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(213, 34);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // insertImageToolStripMenuItem
            // 
            insertImageToolStripMenuItem.Name = "insertImageToolStripMenuItem";
            insertImageToolStripMenuItem.Size = new Size(213, 34);
            insertImageToolStripMenuItem.Text = "Insert Image";
            insertImageToolStripMenuItem.Click += insertImageToolStripMenuItem_Click;
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(213, 34);
            searchToolStripMenuItem.Text = "Search";
            searchToolStripMenuItem.Click += searchToolStripMenuItem_Click;
            // 
            // replaceToolStripMenuItem
            // 
            replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            replaceToolStripMenuItem.Size = new Size(213, 34);
            replaceToolStripMenuItem.Text = "Replace";
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontToolStripMenuItem, colorToolStripMenuItem });
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(85, 29);
            formatToolStripMenuItem.Text = "Format";
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(157, 34);
            fontToolStripMenuItem.Text = "Font";
            fontToolStripMenuItem.Click += fontToolStripMenuItem_Click;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(157, 34);
            colorToolStripMenuItem.Text = "Color";
            colorToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // windowToolStripMenuItem
            // 
            windowToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cascadeToolStripMenuItem, tileHorizontalToolStripMenuItem, tileVerticalToolStripMenuItem, arrangeIconsToolStripMenuItem, minimizeAllToolStripMenuItem, maximizeAllToolStripMenuItem, mdiWindowListItem1 });
            windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            windowToolStripMenuItem.Size = new Size(94, 29);
            windowToolStripMenuItem.Text = "Window";
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(273, 34);
            cascadeToolStripMenuItem.Text = "Cascade";
            cascadeToolStripMenuItem.Click += cascadeToolStripMenuItem_Click;
            // 
            // tileHorizontalToolStripMenuItem
            // 
            tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            tileHorizontalToolStripMenuItem.Size = new Size(273, 34);
            tileHorizontalToolStripMenuItem.Text = "Tile Horizontal";
            tileHorizontalToolStripMenuItem.Click += tileHorizontalToolStripMenuItem_Click;
            // 
            // tileVerticalToolStripMenuItem
            // 
            tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            tileVerticalToolStripMenuItem.Size = new Size(273, 34);
            tileVerticalToolStripMenuItem.Text = "Tile Vertical";
            tileVerticalToolStripMenuItem.Click += tileVerticalToolStripMenuItem_Click;
            // 
            // arrangeIconsToolStripMenuItem
            // 
            arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            arrangeIconsToolStripMenuItem.Size = new Size(273, 34);
            arrangeIconsToolStripMenuItem.Text = "Arrange Icons";
            arrangeIconsToolStripMenuItem.Click += arrangeIconsToolStripMenuItem_Click;
            // 
            // minimizeAllToolStripMenuItem
            // 
            minimizeAllToolStripMenuItem.Name = "minimizeAllToolStripMenuItem";
            minimizeAllToolStripMenuItem.Size = new Size(273, 34);
            minimizeAllToolStripMenuItem.Text = "Minimize all";
            minimizeAllToolStripMenuItem.Click += minimizeAllToolStripMenuItem_Click;
            // 
            // maximizeAllToolStripMenuItem
            // 
            maximizeAllToolStripMenuItem.Name = "maximizeAllToolStripMenuItem";
            maximizeAllToolStripMenuItem.Size = new Size(273, 34);
            maximizeAllToolStripMenuItem.Text = "Maximize all";
            maximizeAllToolStripMenuItem.Click += maximizeAllToolStripMenuItem_Click;
            // 
            // mdiWindowListItem1
            // 
            mdiWindowListItem1.Name = "mdiWindowListItem1";
            mdiWindowListItem1.Size = new Size(273, 34);
            mdiWindowListItem1.Text = "MdiWindowListItem";
            mdiWindowListItem1.Click += mdiWindowListItemToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(78, 29);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripButton4, toolStripButton5, toolStripButton6, toolStripButton7 });
            toolStrip1.Location = new Point(0, 33);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(731, 34);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(57, 29);
            toolStripButton1.Text = "open";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(51, 29);
            toolStripButton2.Text = "save";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(58, 29);
            toolStripButton3.Text = "undo";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(53, 29);
            toolStripButton4.Text = "redo";
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(40, 29);
            toolStripButton5.Text = "cut";
            toolStripButton5.Click += toolStripButton5_Click;
            // 
            // toolStripButton6
            // 
            toolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton6.Image = (Image)resources.GetObject("toolStripButton6.Image");
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(55, 29);
            toolStripButton6.Text = "copy";
            toolStripButton6.Click += toolStripButton6_Click;
            // 
            // toolStripButton7
            // 
            toolStripButton7.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton7.Image = (Image)resources.GetObject("toolStripButton7.Image");
            toolStripButton7.ImageTransparentColor = Color.Magenta;
            toolStripButton7.Name = "toolStripButton7";
            toolStripButton7.Size = new Size(59, 29);
            toolStripButton7.Text = "paste";
            toolStripButton7.Click += toolStripButton7_Click;
            // 
            // toolStrip2
            // 
            toolStrip2.ImageScalingSize = new Size(24, 24);
            toolStrip2.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripButton8, toolStripButton9, this.toolStripButton10 });
            toolStrip2.Location = new Point(0, 67);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(731, 34);
            toolStrip2.TabIndex = 2;
            toolStrip2.Text = "toolStrip2";
            toolStrip2.ItemClicked += toolStrip2_ItemClicked;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(49, 29);
            toolStripLabel1.Text = "bold";
            toolStripLabel1.Click += toolStripLabel1_Click;
            // 
            // toolStripButton8
            // 
            toolStripButton8.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton8.Image = (Image)resources.GetObject("toolStripButton8.Image");
            toolStripButton8.ImageTransparentColor = Color.Magenta;
            toolStripButton8.Name = "toolStripButton8";
            toolStripButton8.Size = new Size(51, 29);
            toolStripButton8.Text = "italic";
            toolStripButton8.Click += toolStripButton8_Click;
            // 
            // toolStripButton9
            // 
            toolStripButton9.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton9.Image = (Image)resources.GetObject("toolStripButton9.Image");
            toolStripButton9.ImageTransparentColor = Color.Magenta;
            toolStripButton9.Name = "toolStripButton9";
            toolStripButton9.Size = new Size(89, 29);
            toolStripButton9.Text = "underline";
            toolStripButton9.Click += toolStripButton9_Click;
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.toolStripButton10.Image = (Image)resources.GetObject("toolStripButton10.Image");
            this.toolStripButton10.ImageTransparentColor = Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new Size(64, 29);
            this.toolStripButton10.Text = "centre";
            this.toolStripButton10.Click += this.toolStripButton10_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(731, 362);
            Controls.Add(toolStrip2);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            KeyDown += Form1_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
                RichTextBox RichBox = (RichTextBox)activeChild.ActiveControl;
                RichBox.Undo();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                newToolStripMenuItem_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.O)
            {
                openToolStripMenuItem_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                saveToolStripMenuItem_Click(sender, e);
            }
            else if (e.Alt && e.KeyCode == Keys.F4)
            {
                exitToolStripMenuItem_Click(sender, e);
                MessageBox.Show("Alt F4");
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDIChild MDIChildNew = new MDIChild();
            MDIChildNew.MdiParent = this;
            MDIChildNew.Text = "Window #" + MDIchildFormNumber;
            ++MDIchildFormNumber;
            MDIChildNew.Show();
        }

        private void OpenFileInActiveWindow(string fileName)
        {
            // Get the RichTextBox from the active child window (assuming it has one)
            RichTextBox richTextBox = (RichTextBox)this.ActiveMdiChild.ActiveControl;
            if (richTextBox != null)
            {
                richTextBox.LoadFile(fileName);
            }
            else
            {
                // Handle case where active child window doesn't have a RichTextBox
                MessageBox.Show("The active window cannot display rich text files.");
            }
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "RichText Files (*.rtf)|*.rtf|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Check if a child window is already open
                if (this.ActiveMdiChild != null)
                {
                    // Open the file in the active child window
                    OpenFileInActiveWindow(openFileDialog.FileName);
                }
                else
                {
                    // Create a new child window and open the file in it
                    OpenFileInNewWindow(openFileDialog.FileName);
                }
            }
        }

        private void OpenFileInNewWindow(string fileName)
        {
            // Create a new child window
            MDIChild newChild = new MDIChild();
            newChild.MdiParent = this;
            newChild.Text = "Window #" + MDIchildFormNumber;
            ++MDIchildFormNumber;

            // Get the RichTextBox from the new child window
            RichTextBox richTextBox = (RichTextBox)newChild.Controls.Find("richTextBox1", true).FirstOrDefault();
            if (richTextBox != null)
            {
                richTextBox.LoadFile(fileName);
            }
            else
            {
                // Handle case where new child window doesn't have a RichTextBox
                MessageBox.Show("An error occurred while creating the child window.");
            }

            newChild.Show();
        }

        private void SaveAs(Form childForm)
        {
            // Get the RichTextBox from the child window
            RichTextBox richTextBox = (RichTextBox)childForm.Controls.Find("richTextBox1", true).FirstOrDefault();
            if (richTextBox != null)
            {
                // Create a SaveFileDialog object
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                saveFileDialog.Filter = "RichText Files (*.rtf)|*.rtf|All Files (*.*)|*.*";

                // Show the dialog and get the selected file name
                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    // Save the RichTextBox content to the selected file
                    richTextBox.SaveFile(saveFileDialog.FileName);
                }
            }
            else
            {
                // Handle case where child window doesn't have a RichTextBox
                MessageBox.Show("The child window cannot save rich text files.");
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check if an active child window is open
            if (this.ActiveMdiChild != null)
            {
                // Call the SaveAs method with the current file name (if any)
                SaveAs(this.ActiveMdiChild);
            }
            else
            {
                // Handle case where no child window is active
                MessageBox.Show("There is no active window to save.");
            }
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void maximizeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form child in MdiChildren)
            {
                child.WindowState = FormWindowState.Maximized;
            }
        }

        private void minimizeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form child in MdiChildren)
            {
                child.WindowState = FormWindowState.Minimized;
            }
        }

        private void activeWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mdiWindowListItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.MdiWindowListItem = mdiWindowListItem1;
        }

        private void toolbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStrip1.Visible)
            {
                toolStrip1.Visible = false;
            }
            else
            {
                toolStrip1.Visible = true;
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
                RichTextBox RichBox = (RichTextBox)activeChild.ActiveControl;
                RichBox.Copy();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
                RichTextBox RichBox = (RichTextBox)activeChild.ActiveControl;
                RichBox.Paste();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
                RichTextBox RichBox = (RichTextBox)activeChild.ActiveControl;
                RichBox.Cut();
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
                RichTextBox RichBox = (RichTextBox)activeChild.ActiveControl;
                RichBox.Redo();
            }
        }

        private void insertImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Get the active MDI child form
            Form childForm = ActiveMdiChild;

            // Check if a child form is active
            if (childForm == null)
            {
                MessageBox.Show("Please activate a child window to add an image.");
                return;
            }

            // Open a FileDialog to allow users to choose an image file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png;*.gif)|*.bmp;*.jpg;*.jpeg;*.png;*.gif";
            openFileDialog.Title = "Select an Image";

            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Get the selected image file path
                string imagePath = openFileDialog.FileName;

                // Find the RichTextBox control in the child form (replace "richTextBox1" if needed)
                RichTextBox richTextBox = childForm.Controls.OfType<RichTextBox>().FirstOrDefault(rtb => rtb.Name == "richTextBox1");

                if (richTextBox != null)
                {
                    try
                    {
                        // Inform the user that direct image insertion is not supported
                        MessageBox.Show("Direct image insertion is not currently supported. \n" +
                                        "The image path will be copied to the clipboard for reference.");

                        // Copy the image path to the clipboard
                        Clipboard.SetText(imagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error copying image path to clipboard: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The child window doesn't contain a RichTextBox with the name 'richTextBox1'.");
                }
            }
        }


        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private RichTextBox richTextBox1; // Declare the variable
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Get the active MDI child form
            Form childForm = ActiveMdiChild;

            // Check if a child form is active
            if (childForm == null)
            {
                MessageBox.Show("Please activate a child window to change its font.");
                return;
            }

            // Open a FontDialog to allow users to choose font properties
            FontDialog fontDialog = new FontDialog();

            // Optionally set initial font properties before showing the dialog
            // fontDialog.Font = childForm.Controls.OfType<RichTextBox>().FirstOrDefault()?.Font; // Set initial font to current font in a RichTextBox

            if (fontDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Apply the chosen font to all RichTextBox controls in the child form
                foreach (RichTextBox richTextBox in childForm.Controls.OfType<RichTextBox>())
                {
                    richTextBox.Font = fontDialog.Font;
                }
            }
        }

        private AboutForm aboutForm;

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aboutForm == null)
            {
                aboutForm = new AboutForm(); // Create only if it doesn't exist
            }

            aboutForm.ShowDialog(this); // Show as modal dialog, centered on parent
        }
        private Form childForm;

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. Ensure a child window is active
            Form childForm = ActiveMdiChild;
            if (childForm == null)
            {
                MessageBox.Show("Please activate a child window to save its contents.");
                return; // Exit the method early
            }

            // 2. Retrieve the RichTextBox from the active child window
            RichTextBox richTextBox = childForm.Controls.OfType<RichTextBox>().FirstOrDefault(rtb => rtb.Name == "richTextBox1");
            if (richTextBox == null)
            {
                MessageBox.Show("The child window doesn't contain a RichTextBox with the name 'richTextBox1'.");
                return; // Exit the method early
            }

            // 3. Proceed with saving if RichTextBox is found
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "RichText Files (*.rtf)|*.rtf|All Files (*.*)|*.*";

            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    richTextBox.SaveFile(saveFileDialog.FileName);
                    MessageBox.Show("File saved successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Get the active MDI child form
            Form childForm = ActiveMdiChild;

            // Check if a child form is active
            if (childForm == null)
            {
                MessageBox.Show("Please activate a child window to change its text color.");
                return;
            }

            // Open a ColorDialog to allow users to choose a color
            ColorDialog colorDialog = new ColorDialog();

            // Optionally set initial color before showing the dialog
            // colorDialog.Color = childForm.Controls.OfType<RichTextBox>().FirstOrDefault()?.ForeColor; // Set initial color to current color in a RichTextBox

            if (colorDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Apply the chosen color to all RichTextBox controls in the child form
                foreach (RichTextBox richTextBox in childForm.Controls.OfType<RichTextBox>())
                {
                    richTextBox.ForeColor = colorDialog.Color;
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            openToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            undoToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            redoToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            cutToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            copyToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            pasteToolStripMenuItem_Click(sender, e);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            // Get the active MDI child form
            Form childForm = ActiveMdiChild;

            // Check if a child form is active
            if (childForm == null)
            {
                return;
            }

            // Cast the child form to the specific type
            MDIChild myChildForm = childForm as MDIChild;

            if (myChildForm != null)
            {
                // Get the RichTextBox from the child form
                RichTextBox richTextBox = myChildForm.richTextBox1;

                if (richTextBox != null)
                {
                    // Apply bold formatting to the selected text
                    if (richTextBox.SelectionLength > 0)
                    {
                        Font currentFont = richTextBox.SelectionFont;
                        richTextBox.SelectionFont = new Font(currentFont, FontStyle.Bold);
                    }
                }
            }
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStrip2.Visible)
            {
                toolStrip2.Visible = false;
            }
            else
            {
                toolStrip2.Visible = true;
            }
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            // Get the active MDI child form
            Form childForm = ActiveMdiChild;

            // Check if a child form is active
            if (childForm == null)
            {
                return;
            }

            // Cast the child form to the specific type
            MDIChild myChildForm = childForm as MDIChild;

            if (myChildForm != null)
            {
                // Get the RichTextBox from the child form
                RichTextBox richTextBox = myChildForm.richTextBox1;

                if (richTextBox != null)
                {
                    // Apply bold formatting to the selected text
                    if (richTextBox.SelectionLength > 0)
                    {
                        Font currentFont = richTextBox.SelectionFont;
                        richTextBox.SelectionFont = new Font(currentFont, FontStyle.Italic);
                    }
                }
            }
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            // Get the active MDI child form
            Form childForm = ActiveMdiChild;

            // Check if a child form is active
            if (childForm == null)
            {
                return;
            }

            // Cast the child form to the specific type
            MDIChild myChildForm = childForm as MDIChild;

            if (myChildForm != null)
            {
                // Get the RichTextBox from the child form
                RichTextBox richTextBox = myChildForm.richTextBox1;

                if (richTextBox != null)
                {
                    // Apply bold formatting to the selected text
                    if (richTextBox.SelectionLength > 0)
                    {
                        Font currentFont = richTextBox.SelectionFont;
                        richTextBox.SelectionFont = new Font(currentFont, FontStyle.Underline);
                    }
                }
            }
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            // Get the active MDI child form
            Form childForm = ActiveMdiChild;

            // Check if a child form is active
            if (childForm == null)
            {
                return;
            }

            // Cast the child form to the specific type
            MDIChild myChildForm = childForm as MDIChild;

            if (myChildForm != null)
            {
                // Get the RichTextBox from the child form
                RichTextBox richTextBox = myChildForm.richTextBox1;

                if (richTextBox != null)
                {
                    // Apply bold formatting to the selected text
                    if (richTextBox.SelectionLength > 0)
                    {
                        richTextBox.SelectionAlignment = HorizontalAlignment.Center;
                    }
                }
            }
        }
    }
}