namespace DotaUtility
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            MakeScreen = new Button();
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            dotaUtilityToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // MakeScreen
            // 
            MakeScreen.Location = new Point(691, 18);
            MakeScreen.Name = "MakeScreen";
            MakeScreen.Size = new Size(80, 36);
            MakeScreen.TabIndex = 0;
            MakeScreen.Text = "&L";
            MakeScreen.UseVisualStyleBackColor = true;
            MakeScreen.Click += MakeScreen_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "DotaUtility";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseClick += notifyIcon1_MouseClick;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { dotaUtilityToolStripMenuItem, exitToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(151, 52);
            // 
            // dotaUtilityToolStripMenuItem
            // 
            dotaUtilityToolStripMenuItem.Name = "dotaUtilityToolStripMenuItem";
            dotaUtilityToolStripMenuItem.Size = new Size(150, 24);
            dotaUtilityToolStripMenuItem.Text = "DotaUtility";
            dotaUtilityToolStripMenuItem.Click += dotaUtilityToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(150, 24);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MakeScreen);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            ShowInTaskbar = false;
            Text = "DotaUtility";
            FormClosing += Form1_FormClosing;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button MakeScreen;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem dotaUtilityToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}