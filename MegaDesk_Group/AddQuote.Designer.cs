namespace MegaDesk
{
    partial class AddQuote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuote));
            this.NavMainMenu = new System.Windows.Forms.Button();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.depthInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.areaOutput = new System.Windows.Forms.Label();
            this.drawerInput = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.drawerCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.materialInput = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.areaCost = new System.Windows.Forms.Label();
            this.materialCost = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.shippingInput = new System.Windows.Forms.ComboBox();
            this.shippingCost = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.quoteTotal = new System.Windows.Forms.Label();
            this.submitQuote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.drawerInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // NavMainMenu
            // 
            this.NavMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NavMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.NavMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.NavMainMenu.Location = new System.Drawing.Point(556, 404);
            this.NavMainMenu.Name = "NavMainMenu";
            this.NavMainMenu.Size = new System.Drawing.Size(232, 34);
            this.NavMainMenu.TabIndex = 1;
            this.NavMainMenu.Text = "Close";
            this.NavMainMenu.UseVisualStyleBackColor = false;
            this.NavMainMenu.Click += new System.EventHandler(this.NavMainMenu_Click);
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(249, 88);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(300, 20);
            this.nameInput.TabIndex = 2;
            this.nameInput.Validating += new System.ComponentModel.CancelEventHandler(this.NameInput_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(207, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(202, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "*Depth:";
            // 
            // depthInput
            // 
            this.depthInput.Location = new System.Drawing.Point(249, 125);
            this.depthInput.Name = "depthInput";
            this.depthInput.Size = new System.Drawing.Size(86, 20);
            this.depthInput.TabIndex = 4;
            this.depthInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.depthInput.Validating += new System.ComponentModel.CancelEventHandler(this.DepthInput_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(337, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "*Width:";
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(380, 125);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(86, 20);
            this.widthInput.TabIndex = 6;
            this.widthInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.widthInput.Validating += new System.ComponentModel.CancelEventHandler(this.WidthInput_Validating);
            // 
            // areaOutput
            // 
            this.areaOutput.AutoSize = true;
            this.areaOutput.BackColor = System.Drawing.Color.Transparent;
            this.areaOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaOutput.ForeColor = System.Drawing.Color.Black;
            this.areaOutput.Location = new System.Drawing.Point(471, 128);
            this.areaOutput.Name = "areaOutput";
            this.areaOutput.Size = new System.Drawing.Size(32, 13);
            this.areaOutput.TabIndex = 8;
            this.areaOutput.Text = "Area:";
            // 
            // drawerInput
            // 
            this.drawerInput.Location = new System.Drawing.Point(249, 192);
            this.drawerInput.Name = "drawerInput";
            this.drawerInput.Size = new System.Drawing.Size(86, 20);
            this.drawerInput.TabIndex = 9;
            this.drawerInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.drawerInput.ValueChanged += new System.EventHandler(this.DrawerInput_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(196, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Drawers:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(351, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(377, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "$50.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(426, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "=";
            // 
            // drawerCost
            // 
            this.drawerCost.Enabled = false;
            this.drawerCost.Location = new System.Drawing.Point(452, 193);
            this.drawerCost.Name = "drawerCost";
            this.drawerCost.Size = new System.Drawing.Size(97, 20);
            this.drawerCost.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(147, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(402, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "*Desk sizes range from 12x24 to 48x96.  Any measurements outside of this range wi" +
    "ll be adjusted";
            // 
            // materialInput
            // 
            this.materialInput.DataSource = this.bindingSource1;
            this.materialInput.FormattingEnabled = true;
            this.materialInput.Location = new System.Drawing.Point(249, 229);
            this.materialInput.Name = "materialInput";
            this.materialInput.Size = new System.Drawing.Size(121, 21);
            this.materialInput.TabIndex = 19;
            this.materialInput.Validating += new System.ComponentModel.CancelEventHandler(this.MaterialInput_Validating);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(MegaDesk.Desk);
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(198, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Material:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(389, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Material Cost:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(189, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Area Cost:";
            // 
            // areaCost
            // 
            this.areaCost.AutoSize = true;
            this.areaCost.BackColor = System.Drawing.Color.Transparent;
            this.areaCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaCost.ForeColor = System.Drawing.Color.Black;
            this.areaCost.Location = new System.Drawing.Point(246, 163);
            this.areaCost.Name = "areaCost";
            this.areaCost.Size = new System.Drawing.Size(13, 13);
            this.areaCost.TabIndex = 23;
            this.areaCost.Text = "$";
            // 
            // materialCost
            // 
            this.materialCost.AutoSize = true;
            this.materialCost.BackColor = System.Drawing.Color.Transparent;
            this.materialCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCost.ForeColor = System.Drawing.Color.Black;
            this.materialCost.Location = new System.Drawing.Point(466, 233);
            this.materialCost.Name = "materialCost";
            this.materialCost.Size = new System.Drawing.Size(13, 13);
            this.materialCost.TabIndex = 24;
            this.materialCost.Text = "$";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(194, 272);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Shipping:";
            // 
            // shippingInput
            // 
            this.shippingInput.FormattingEnabled = true;
            this.shippingInput.Items.AddRange(new object[] {
            "3 Day",
            "5 Day",
            "7 Day"});
            this.shippingInput.Location = new System.Drawing.Point(249, 267);
            this.shippingInput.Name = "shippingInput";
            this.shippingInput.Size = new System.Drawing.Size(121, 21);
            this.shippingInput.TabIndex = 25;
            this.shippingInput.Validating += new System.ComponentModel.CancelEventHandler(this.ShippingInput_Validating);
            // 
            // shippingCost
            // 
            this.shippingCost.AutoSize = true;
            this.shippingCost.BackColor = System.Drawing.Color.Transparent;
            this.shippingCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shippingCost.ForeColor = System.Drawing.Color.Black;
            this.shippingCost.Location = new System.Drawing.Point(466, 272);
            this.shippingCost.Name = "shippingCost";
            this.shippingCost.Size = new System.Drawing.Size(13, 13);
            this.shippingCost.TabIndex = 28;
            this.shippingCost.Text = "$";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(389, 272);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Shipping Cost:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(211, 312);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Total:";
            // 
            // quoteTotal
            // 
            this.quoteTotal.AutoSize = true;
            this.quoteTotal.BackColor = System.Drawing.Color.Transparent;
            this.quoteTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteTotal.ForeColor = System.Drawing.Color.Black;
            this.quoteTotal.Location = new System.Drawing.Point(246, 312);
            this.quoteTotal.Name = "quoteTotal";
            this.quoteTotal.Size = new System.Drawing.Size(13, 13);
            this.quoteTotal.TabIndex = 30;
            this.quoteTotal.Text = "$";
            // 
            // submitQuote
            // 
            this.submitQuote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submitQuote.BackColor = System.Drawing.Color.Transparent;
            this.submitQuote.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.submitQuote.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.submitQuote.FlatAppearance.BorderSize = 0;
            this.submitQuote.ForeColor = System.Drawing.Color.Black;
            this.submitQuote.Location = new System.Drawing.Point(284, 345);
            this.submitQuote.Margin = new System.Windows.Forms.Padding(0);
            this.submitQuote.Name = "submitQuote";
            this.submitQuote.Size = new System.Drawing.Size(232, 34);
            this.submitQuote.TabIndex = 32;
            this.submitQuote.Text = "Submit";
            this.submitQuote.UseVisualStyleBackColor = false;
            this.submitQuote.Click += new System.EventHandler(this.SubmitQuote_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.NavMainMenu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.submitQuote);
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
            this.Controls.Add(this.label4);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)(this.drawerInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NavMainMenu;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox depthInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.Label areaOutput;
        private System.Windows.Forms.NumericUpDown drawerInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox drawerCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox materialInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label areaCost;
        private System.Windows.Forms.Label materialCost;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox shippingInput;
        private System.Windows.Forms.Label shippingCost;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label quoteTotal;
        private System.Windows.Forms.Button submitQuote;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}