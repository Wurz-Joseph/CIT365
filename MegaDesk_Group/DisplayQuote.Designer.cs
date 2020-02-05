namespace MegaDesk
{
    partial class DisplayQuote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayQuote));
            this.NavMainMenu = new System.Windows.Forms.Button();
            this.quoteTotal = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.shippingCost = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.shippingInput = new System.Windows.Forms.ComboBox();
            this.materialCost = new System.Windows.Forms.Label();
            this.areaCost = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.materialInput = new System.Windows.Forms.ComboBox();
            this.drawerCost = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.drawerInput = new System.Windows.Forms.NumericUpDown();
            this.areaOutput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.depthInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.quoteInput = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateDisplay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.drawerInput)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavMainMenu
            // 
            this.NavMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NavMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.NavMainMenu.Location = new System.Drawing.Point(556, 404);
            this.NavMainMenu.Name = "NavMainMenu";
            this.NavMainMenu.Size = new System.Drawing.Size(232, 34);
            this.NavMainMenu.TabIndex = 2;
            this.NavMainMenu.Text = "Close";
            this.NavMainMenu.UseVisualStyleBackColor = true;
            this.NavMainMenu.Click += new System.EventHandler(this.NavMainMenu_Click);
            // 
            // quoteTotal
            // 
            this.quoteTotal.AutoSize = true;
            this.quoteTotal.BackColor = System.Drawing.Color.Gainsboro;
            this.quoteTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteTotal.ForeColor = System.Drawing.Color.Black;
            this.quoteTotal.Location = new System.Drawing.Point(267, 307);
            this.quoteTotal.Name = "quoteTotal";
            this.quoteTotal.Size = new System.Drawing.Size(13, 13);
            this.quoteTotal.TabIndex = 55;
            this.quoteTotal.Text = "$";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Gainsboro;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(232, 307);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 54;
            this.label13.Text = "Total:";
            // 
            // shippingCost
            // 
            this.shippingCost.AutoSize = true;
            this.shippingCost.BackColor = System.Drawing.Color.Gainsboro;
            this.shippingCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shippingCost.ForeColor = System.Drawing.Color.Black;
            this.shippingCost.Location = new System.Drawing.Point(487, 267);
            this.shippingCost.Name = "shippingCost";
            this.shippingCost.Size = new System.Drawing.Size(13, 13);
            this.shippingCost.TabIndex = 53;
            this.shippingCost.Text = "$";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Gainsboro;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(410, 267);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 52;
            this.label14.Text = "Shipping Cost:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Gainsboro;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(215, 267);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 51;
            this.label12.Text = "Shipping:";
            // 
            // shippingInput
            // 
            this.shippingInput.Enabled = false;
            this.shippingInput.FormattingEnabled = true;
            this.shippingInput.Items.AddRange(new object[] {
            "3 Day",
            "5 Day",
            "7 Day"});
            this.shippingInput.Location = new System.Drawing.Point(270, 262);
            this.shippingInput.Name = "shippingInput";
            this.shippingInput.Size = new System.Drawing.Size(121, 21);
            this.shippingInput.TabIndex = 50;
            // 
            // materialCost
            // 
            this.materialCost.AutoSize = true;
            this.materialCost.BackColor = System.Drawing.Color.Gainsboro;
            this.materialCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCost.ForeColor = System.Drawing.Color.Black;
            this.materialCost.Location = new System.Drawing.Point(487, 228);
            this.materialCost.Name = "materialCost";
            this.materialCost.Size = new System.Drawing.Size(13, 13);
            this.materialCost.TabIndex = 49;
            this.materialCost.Text = "$";
            // 
            // areaCost
            // 
            this.areaCost.AutoSize = true;
            this.areaCost.BackColor = System.Drawing.Color.Gainsboro;
            this.areaCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaCost.ForeColor = System.Drawing.Color.Black;
            this.areaCost.Location = new System.Drawing.Point(267, 158);
            this.areaCost.Name = "areaCost";
            this.areaCost.Size = new System.Drawing.Size(13, 13);
            this.areaCost.TabIndex = 48;
            this.areaCost.Text = "$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(210, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Area Cost:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Gainsboro;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(410, 228);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "Material Cost:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Gainsboro;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(219, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Material:";
            // 
            // materialInput
            // 
            this.materialInput.Enabled = false;
            this.materialInput.FormattingEnabled = true;
            this.materialInput.Location = new System.Drawing.Point(270, 224);
            this.materialInput.Name = "materialInput";
            this.materialInput.Size = new System.Drawing.Size(121, 21);
            this.materialInput.TabIndex = 44;
            // 
            // drawerCost
            // 
            this.drawerCost.Enabled = false;
            this.drawerCost.Location = new System.Drawing.Point(473, 188);
            this.drawerCost.Name = "drawerCost";
            this.drawerCost.Size = new System.Drawing.Size(97, 20);
            this.drawerCost.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Gainsboro;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(447, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Gainsboro;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(398, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "$50.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gainsboro;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(372, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gainsboro;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(217, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Drawers:";
            // 
            // drawerInput
            // 
            this.drawerInput.Enabled = false;
            this.drawerInput.Location = new System.Drawing.Point(270, 187);
            this.drawerInput.Name = "drawerInput";
            this.drawerInput.Size = new System.Drawing.Size(86, 20);
            this.drawerInput.TabIndex = 38;
            this.drawerInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // areaOutput
            // 
            this.areaOutput.AutoSize = true;
            this.areaOutput.BackColor = System.Drawing.Color.Gainsboro;
            this.areaOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaOutput.ForeColor = System.Drawing.Color.Black;
            this.areaOutput.Location = new System.Drawing.Point(492, 123);
            this.areaOutput.Name = "areaOutput";
            this.areaOutput.Size = new System.Drawing.Size(32, 13);
            this.areaOutput.TabIndex = 37;
            this.areaOutput.Text = "Area:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(358, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "*Width:";
            // 
            // widthInput
            // 
            this.widthInput.Enabled = false;
            this.widthInput.Location = new System.Drawing.Point(401, 120);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(86, 20);
            this.widthInput.TabIndex = 35;
            this.widthInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(223, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "*Depth:";
            // 
            // depthInput
            // 
            this.depthInput.Enabled = false;
            this.depthInput.Location = new System.Drawing.Point(270, 120);
            this.depthInput.Name = "depthInput";
            this.depthInput.Size = new System.Drawing.Size(86, 20);
            this.depthInput.TabIndex = 33;
            this.depthInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(228, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Name:";
            // 
            // nameInput
            // 
            this.nameInput.Enabled = false;
            this.nameInput.Location = new System.Drawing.Point(270, 83);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(300, 20);
            this.nameInput.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.quoteInput);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dateDisplay);
            this.panel1.Location = new System.Drawing.Point(142, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 307);
            this.panel1.TabIndex = 56;
            // 
            // quoteInput
            // 
            this.quoteInput.AutoSize = true;
            this.quoteInput.BackColor = System.Drawing.Color.Gainsboro;
            this.quoteInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteInput.ForeColor = System.Drawing.Color.Black;
            this.quoteInput.Location = new System.Drawing.Point(89, 17);
            this.quoteInput.Name = "quoteInput";
            this.quoteInput.Size = new System.Drawing.Size(14, 13);
            this.quoteInput.TabIndex = 58;
            this.quoteInput.Text = "#";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(35, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Quote ID:";
            // 
            // dateDisplay
            // 
            this.dateDisplay.AutoSize = true;
            this.dateDisplay.BackColor = System.Drawing.Color.Gainsboro;
            this.dateDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDisplay.ForeColor = System.Drawing.Color.Black;
            this.dateDisplay.Location = new System.Drawing.Point(368, 17);
            this.dateDisplay.Name = "dateDisplay";
            this.dateDisplay.Size = new System.Drawing.Size(127, 13);
            this.dateDisplay.TabIndex = 57;
            this.dateDisplay.Text = "(\"dddd, dd MMMM yyyy\")";
            this.dateDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.NavMainMenu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.quoteTotal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.shippingCost);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.shippingInput);
            this.Controls.Add(this.materialCost);
            this.Controls.Add(this.areaCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.materialInput);
            this.Controls.Add(this.drawerCost);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.drawerInput);
            this.Controls.Add(this.areaOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.depthInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.NavMainMenu);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DisplayQuote";
            this.Text = "DisplayQuote";
            this.Load += new System.EventHandler(this.DisplayQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drawerInput)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NavMainMenu;
        private System.Windows.Forms.Label quoteTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label shippingCost;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox shippingInput;
        private System.Windows.Forms.Label materialCost;
        private System.Windows.Forms.Label areaCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox materialInput;
        private System.Windows.Forms.TextBox drawerCost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown drawerInput;
        private System.Windows.Forms.Label areaOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox depthInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label dateDisplay;
        private System.Windows.Forms.Label quoteInput;
        private System.Windows.Forms.Label label4;
    }
}