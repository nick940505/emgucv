namespace Emgu.CV.UI
{
    partial class ImageBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picturePanel = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.helloWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationStackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageProperty1 = new Emgu.CV.UI.ImageProperty();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.picturePanel.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picturePanel
            // 
            this.picturePanel.Controls.Add(this.splitContainer1);
            this.picturePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picturePanel.Location = new System.Drawing.Point(0, 0);
            this.picturePanel.Name = "picturePanel";
            this.picturePanel.Size = new System.Drawing.Size(150, 150);
            this.picturePanel.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.imageProperty1);
            this.splitContainer1.Size = new System.Drawing.Size(150, 150);
            this.splitContainer1.SplitterDistance = 83;
            this.splitContainer1.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(150, 83);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helloWorldToolStripMenuItem,
            this.operationsToolStripMenuItem,
            this.operationStackToolStripMenuItem,
            this.propertyToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 92);
            // 
            // helloWorldToolStripMenuItem
            // 
            this.helloWorldToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImageToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.helloWorldToolStripMenuItem.Name = "helloWorldToolStripMenuItem";
            this.helloWorldToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.helloWorldToolStripMenuItem.Text = "File";
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.loadImageToolStripMenuItem.Text = "Load Image";
            this.loadImageToolStripMenuItem.Click += new System.EventHandler(this.loadImageToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.operationsToolStripMenuItem.Text = "Operations";
            // 
            // operationStackToolStripMenuItem
            // 
            this.operationStackToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.operationStackToolStripMenuItem.Name = "operationStackToolStripMenuItem";
            this.operationStackToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.operationStackToolStripMenuItem.Text = "Operation Stack ";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // propertyToolStripMenuItem
            // 
            this.propertyToolStripMenuItem.Name = "propertyToolStripMenuItem";
            this.propertyToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.propertyToolStripMenuItem.Text = "Property";
            this.propertyToolStripMenuItem.Click += new System.EventHandler(this.propertyToolStripMenuItem_Click);
            // 
            // imageProperty1
            // 
            this.imageProperty1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageProperty1.Location = new System.Drawing.Point(0, 0);
            this.imageProperty1.Name = "imageProperty1";
            this.imageProperty1.Size = new System.Drawing.Size(150, 63);
            this.imageProperty1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image Files (*.jpg; *.bmp;*.png)|*.jpg;*.bmp;*.png|All Files(*.*)|*.*";
            // 
            // ImageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picturePanel);
            this.Name = "ImageBox";
            this.picturePanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel picturePanel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helloWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationStackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStripMenuItem propertyToolStripMenuItem;
        private Emgu.CV.UI.ImageProperty imageProperty1;

    }
}