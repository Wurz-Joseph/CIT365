namespace MegaDesk
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.NavAddQuote = new System.Windows.Forms.Button();
            this.NavViewQuotes = new System.Windows.Forms.Button();
            this.navSearchQuotes = new System.Windows.Forms.Button();
            this.navExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NavAddQuote
            // 
            this.NavAddQuote.BackColor = System.Drawing.Color.Transparent;
            this.NavAddQuote.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.NavAddQuote.Location = new System.Drawing.Point(26, 18);
            this.NavAddQuote.Name = "NavAddQuote";
            this.NavAddQuote.Size = new System.Drawing.Size(222, 42);
            this.NavAddQuote.TabIndex = 0;
            this.NavAddQuote.Text = "Add New Quote";
            this.NavAddQuote.UseVisualStyleBackColor = false;
            this.NavAddQuote.Click += new System.EventHandler(this.navAddQuote_Click);
            // 
            // NavViewQuotes
            // 
            this.NavViewQuotes.BackColor = System.Drawing.Color.Transparent;
            this.NavViewQuotes.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.NavViewQuotes.Location = new System.Drawing.Point(26, 66);
            this.NavViewQuotes.Name = "NavViewQuotes";
            this.NavViewQuotes.Size = new System.Drawing.Size(222, 42);
            this.NavViewQuotes.TabIndex = 1;
            this.NavViewQuotes.Text = "View Quotes";
            this.NavViewQuotes.UseVisualStyleBackColor = false;
            this.NavViewQuotes.Click += new System.EventHandler(this.NavViewQuotes_Click);
            // 
            // navSearchQuotes
            // 
            this.navSearchQuotes.BackColor = System.Drawing.Color.Transparent;
            this.navSearchQuotes.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.navSearchQuotes.Location = new System.Drawing.Point(26, 114);
            this.navSearchQuotes.Name = "navSearchQuotes";
            this.navSearchQuotes.Size = new System.Drawing.Size(222, 42);
            this.navSearchQuotes.TabIndex = 2;
            this.navSearchQuotes.Text = "Search Quotes";
            this.navSearchQuotes.UseVisualStyleBackColor = false;
            this.navSearchQuotes.Click += new System.EventHandler(this.navSearchQuotes_Click);
            // 
            // navExit
            // 
            this.navExit.BackColor = System.Drawing.Color.Transparent;
            this.navExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.navExit.Location = new System.Drawing.Point(26, 162);
            this.navExit.Name = "navExit";
            this.navExit.Size = new System.Drawing.Size(222, 42);
            this.navExit.TabIndex = 3;
            this.navExit.Text = "Exit";
            this.navExit.UseVisualStyleBackColor = false;
            this.navExit.Click += new System.EventHandler(this.navExit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.navExit);
            this.Controls.Add(this.navSearchQuotes);
            this.Controls.Add(this.NavViewQuotes);
            this.Controls.Add(this.NavAddQuote);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NavAddQuote;
        private System.Windows.Forms.Button NavViewQuotes;
        private System.Windows.Forms.Button navSearchQuotes;
        private System.Windows.Forms.Button navExit;
    }
}

