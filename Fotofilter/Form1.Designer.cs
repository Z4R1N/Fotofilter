namespace Fotofilter
{
    partial class MainWIndow
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
            this.pbChangedImage = new System.Windows.Forms.PictureBox();
            this.brnOpen = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arkivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avslutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skiftaFärgkanalerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackAndWhiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertColorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorLvlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.RtrackBar = new System.Windows.Forms.TrackBar();
            this.GtrackBar = new System.Windows.Forms.TrackBar();
            this.BtrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pbChangedImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RtrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GtrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pbChangedImage
            // 
            this.pbChangedImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbChangedImage.Location = new System.Drawing.Point(0, 28);
            this.pbChangedImage.Name = "pbChangedImage";
            this.pbChangedImage.Size = new System.Drawing.Size(532, 650);
            this.pbChangedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChangedImage.TabIndex = 0;
            this.pbChangedImage.TabStop = false;
            // 
            // brnOpen
            // 
            this.brnOpen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.brnOpen.Location = new System.Drawing.Point(0, 678);
            this.brnOpen.Name = "brnOpen";
            this.brnOpen.Size = new System.Drawing.Size(732, 25);
            this.brnOpen.TabIndex = 1;
            this.brnOpen.Text = "Open Picture...";
            this.brnOpen.UseVisualStyleBackColor = true;
            this.brnOpen.Click += new System.EventHandler(this.brnOpen_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkivToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(732, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arkivToolStripMenuItem
            // 
            this.arkivToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avslutaToolStripMenuItem});
            this.arkivToolStripMenuItem.Name = "arkivToolStripMenuItem";
            this.arkivToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.arkivToolStripMenuItem.Text = "Arkiv";
            // 
            // avslutaToolStripMenuItem
            // 
            this.avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
            this.avslutaToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.avslutaToolStripMenuItem.Text = "Avsluta";
            this.avslutaToolStripMenuItem.Click += new System.EventHandler(this.avslutaToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.skiftaFärgkanalerToolStripMenuItem,
            this.blackAndWhiteToolStripMenuItem,
            this.invertColorsToolStripMenuItem,
            this.colorLvlToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // skiftaFärgkanalerToolStripMenuItem
            // 
            this.skiftaFärgkanalerToolStripMenuItem.Name = "skiftaFärgkanalerToolStripMenuItem";
            this.skiftaFärgkanalerToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.skiftaFärgkanalerToolStripMenuItem.Text = "FilterNr1";
            this.skiftaFärgkanalerToolStripMenuItem.Click += new System.EventHandler(this.FilterNr1ToolStripMenuItem_Click);
            // 
            // blackAndWhiteToolStripMenuItem
            // 
            this.blackAndWhiteToolStripMenuItem.Name = "blackAndWhiteToolStripMenuItem";
            this.blackAndWhiteToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.blackAndWhiteToolStripMenuItem.Text = "Monochrome";
            this.blackAndWhiteToolStripMenuItem.Click += new System.EventHandler(this.blackAndWhiteToolStripMenuItem_Click);
            // 
            // invertColorsToolStripMenuItem
            // 
            this.invertColorsToolStripMenuItem.Name = "invertColorsToolStripMenuItem";
            this.invertColorsToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.invertColorsToolStripMenuItem.Text = "Invert colors";
            this.invertColorsToolStripMenuItem.Click += new System.EventHandler(this.invertColorsToolStripMenuItem_Click);
            // 
            // colorLvlToolStripMenuItem
            // 
            this.colorLvlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem});
            this.colorLvlToolStripMenuItem.Name = "colorLvlToolStripMenuItem";
            this.colorLvlToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.colorLvlToolStripMenuItem.Text = "Color lvl";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // SidePanel
            // 
            this.SidePanel.Controls.Add(this.pbImage);
            this.SidePanel.Controls.Add(this.RtrackBar);
            this.SidePanel.Controls.Add(this.GtrackBar);
            this.SidePanel.Controls.Add(this.BtrackBar);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.SidePanel.Location = new System.Drawing.Point(532, 28);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(200, 650);
            this.SidePanel.TabIndex = 3;
            // 
            // pbImage
            // 
            this.pbImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbImage.Location = new System.Drawing.Point(0, 0);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(200, 200);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 3;
            this.pbImage.TabStop = false;
            // 
            // RtrackBar
            // 
            this.RtrackBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RtrackBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RtrackBar.Location = new System.Drawing.Point(0, 482);
            this.RtrackBar.Name = "RtrackBar";
            this.RtrackBar.Size = new System.Drawing.Size(200, 56);
            this.RtrackBar.TabIndex = 2;
            this.RtrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // GtrackBar
            // 
            this.GtrackBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GtrackBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GtrackBar.Location = new System.Drawing.Point(0, 538);
            this.GtrackBar.Name = "GtrackBar";
            this.GtrackBar.Size = new System.Drawing.Size(200, 56);
            this.GtrackBar.TabIndex = 1;
            this.GtrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // BtrackBar
            // 
            this.BtrackBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtrackBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtrackBar.Location = new System.Drawing.Point(0, 594);
            this.BtrackBar.Name = "BtrackBar";
            this.BtrackBar.Size = new System.Drawing.Size(200, 56);
            this.BtrackBar.TabIndex = 0;
            this.BtrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // MainWIndow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 703);
            this.Controls.Add(this.pbChangedImage);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.brnOpen);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWIndow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbChangedImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SidePanel.ResumeLayout(false);
            this.SidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RtrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GtrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbChangedImage;
        private System.Windows.Forms.Button brnOpen;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arkivToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avslutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skiftaFärgkanalerToolStripMenuItem;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.TrackBar RtrackBar;
        private System.Windows.Forms.TrackBar GtrackBar;
        private System.Windows.Forms.TrackBar BtrackBar;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.ToolStripMenuItem blackAndWhiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorLvlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertColorsToolStripMenuItem;
    }
}

