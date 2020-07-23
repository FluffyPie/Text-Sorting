namespace Text_Sorting
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.MainTextbox = new System.Windows.Forms.TextBox();
            this.ProceedButton = new Guna.UI.WinForms.GunaButton();
            this.OpenFile = new Guna.UI.WinForms.GunaButton();
            this.ClipboardButton = new Guna.UI.WinForms.GunaButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.CloseButton = new Guna.UI.WinForms.GunaCircleButton();
            this.MinimizeButton = new Guna.UI.WinForms.GunaCircleButton();
            this.ClearButton = new Guna.UI.WinForms.GunaButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // MainTextbox
            // 
            this.MainTextbox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainTextbox.Location = new System.Drawing.Point(12, 25);
            this.MainTextbox.Multiline = true;
            this.MainTextbox.Name = "MainTextbox";
            this.MainTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MainTextbox.Size = new System.Drawing.Size(298, 384);
            this.MainTextbox.TabIndex = 0;
            // 
            // ProceedButton
            // 
            this.ProceedButton.AnimationHoverSpeed = 0.07F;
            this.ProceedButton.AnimationSpeed = 0.03F;
            this.ProceedButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(102)))), ((int)(((byte)(221)))));
            this.ProceedButton.BorderColor = System.Drawing.Color.Black;
            this.ProceedButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ProceedButton.FocusedColor = System.Drawing.Color.Empty;
            this.ProceedButton.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProceedButton.ForeColor = System.Drawing.Color.White;
            this.ProceedButton.Image = null;
            this.ProceedButton.ImageSize = new System.Drawing.Size(20, 20);
            this.ProceedButton.Location = new System.Drawing.Point(12, 498);
            this.ProceedButton.Name = "ProceedButton";
            this.ProceedButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ProceedButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ProceedButton.OnHoverForeColor = System.Drawing.Color.White;
            this.ProceedButton.OnHoverImage = null;
            this.ProceedButton.OnPressedColor = System.Drawing.Color.Black;
            this.ProceedButton.Size = new System.Drawing.Size(298, 40);
            this.ProceedButton.TabIndex = 1;
            this.ProceedButton.Text = "Sort";
            this.ProceedButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProceedButton.Click += new System.EventHandler(this.ProceedButton_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.AnimationHoverSpeed = 0.07F;
            this.OpenFile.AnimationSpeed = 0.03F;
            this.OpenFile.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(102)))), ((int)(((byte)(221)))));
            this.OpenFile.BorderColor = System.Drawing.Color.Black;
            this.OpenFile.DialogResult = System.Windows.Forms.DialogResult.None;
            this.OpenFile.FocusedColor = System.Drawing.Color.Empty;
            this.OpenFile.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenFile.ForeColor = System.Drawing.Color.White;
            this.OpenFile.Image = null;
            this.OpenFile.ImageSize = new System.Drawing.Size(20, 20);
            this.OpenFile.Location = new System.Drawing.Point(12, 455);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.OpenFile.OnHoverBorderColor = System.Drawing.Color.Black;
            this.OpenFile.OnHoverForeColor = System.Drawing.Color.White;
            this.OpenFile.OnHoverImage = null;
            this.OpenFile.OnPressedColor = System.Drawing.Color.Black;
            this.OpenFile.Size = new System.Drawing.Size(147, 40);
            this.OpenFile.TabIndex = 2;
            this.OpenFile.Text = "Open File";
            this.OpenFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // ClipboardButton
            // 
            this.ClipboardButton.AnimationHoverSpeed = 0.07F;
            this.ClipboardButton.AnimationSpeed = 0.03F;
            this.ClipboardButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(102)))), ((int)(((byte)(221)))));
            this.ClipboardButton.BorderColor = System.Drawing.Color.Black;
            this.ClipboardButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ClipboardButton.FocusedColor = System.Drawing.Color.Empty;
            this.ClipboardButton.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClipboardButton.ForeColor = System.Drawing.Color.White;
            this.ClipboardButton.Image = null;
            this.ClipboardButton.ImageSize = new System.Drawing.Size(20, 20);
            this.ClipboardButton.Location = new System.Drawing.Point(165, 455);
            this.ClipboardButton.Name = "ClipboardButton";
            this.ClipboardButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ClipboardButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ClipboardButton.OnHoverForeColor = System.Drawing.Color.White;
            this.ClipboardButton.OnHoverImage = null;
            this.ClipboardButton.OnPressedColor = System.Drawing.Color.Black;
            this.ClipboardButton.Size = new System.Drawing.Size(145, 40);
            this.ClipboardButton.TabIndex = 3;
            this.ClipboardButton.Text = "Ctrl+C";
            this.ClipboardButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClipboardButton.Click += new System.EventHandler(this.Clipboard_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(40)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(322, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "MainMenuStrip";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.menuStrip1;
            // 
            // CloseButton
            // 
            this.CloseButton.Animated = true;
            this.CloseButton.AnimationHoverSpeed = 0.07F;
            this.CloseButton.AnimationSpeed = 0.03F;
            this.CloseButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))));
            this.CloseButton.BorderColor = System.Drawing.Color.Black;
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CloseButton.FocusedColor = System.Drawing.Color.Empty;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Image = null;
            this.CloseButton.ImageSize = new System.Drawing.Size(52, 52);
            this.CloseButton.Location = new System.Drawing.Point(295, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))));
            this.CloseButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CloseButton.OnHoverForeColor = System.Drawing.Color.White;
            this.CloseButton.OnHoverImage = null;
            this.CloseButton.OnPressedColor = System.Drawing.Color.Black;
            this.CloseButton.Size = new System.Drawing.Size(15, 15);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Animated = true;
            this.MinimizeButton.AnimationHoverSpeed = 0.07F;
            this.MinimizeButton.AnimationSpeed = 0.03F;
            this.MinimizeButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(213)))), ((int)(((byte)(110)))));
            this.MinimizeButton.BorderColor = System.Drawing.Color.Black;
            this.MinimizeButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.MinimizeButton.FocusedColor = System.Drawing.Color.Empty;
            this.MinimizeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.Image = null;
            this.MinimizeButton.ImageSize = new System.Drawing.Size(52, 52);
            this.MinimizeButton.Location = new System.Drawing.Point(264, 4);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(110)))));
            this.MinimizeButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.MinimizeButton.OnHoverForeColor = System.Drawing.Color.White;
            this.MinimizeButton.OnHoverImage = null;
            this.MinimizeButton.OnPressedColor = System.Drawing.Color.Black;
            this.MinimizeButton.Size = new System.Drawing.Size(15, 15);
            this.MinimizeButton.TabIndex = 5;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.AnimationHoverSpeed = 0.07F;
            this.ClearButton.AnimationSpeed = 0.03F;
            this.ClearButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(102)))), ((int)(((byte)(221)))));
            this.ClearButton.BorderColor = System.Drawing.Color.Black;
            this.ClearButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ClearButton.FocusedColor = System.Drawing.Color.Empty;
            this.ClearButton.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Image = null;
            this.ClearButton.ImageSize = new System.Drawing.Size(20, 20);
            this.ClearButton.Location = new System.Drawing.Point(12, 415);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ClearButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ClearButton.OnHoverForeColor = System.Drawing.Color.White;
            this.ClearButton.OnHoverImage = null;
            this.ClearButton.OnPressedColor = System.Drawing.Color.Black;
            this.ClearButton.Size = new System.Drawing.Size(298, 34);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear";
            this.ClearButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(322, 569);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.ClipboardButton);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.ProceedButton);
            this.Controls.Add(this.MainTextbox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Sorting";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.TextBox MainTextbox;
        private Guna.UI.WinForms.GunaButton ProceedButton;
        private Guna.UI.WinForms.GunaButton ClipboardButton;
        private Guna.UI.WinForms.GunaButton OpenFile;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaCircleButton CloseButton;
        private Guna.UI.WinForms.GunaCircleButton MinimizeButton;
        private Guna.UI.WinForms.GunaButton ClearButton;
    }
}