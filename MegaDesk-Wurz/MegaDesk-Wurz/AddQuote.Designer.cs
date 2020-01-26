namespace MegaDesk_Wurz
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.DepthTextBox = new System.Windows.Forms.TextBox();
            this.DrawersTextBox = new System.Windows.Forms.TextBox();
            this.GenerateQuoteButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RadioButton5Day = new System.Windows.Forms.RadioButton();
            this.RadioButton7Day = new System.Windows.Forms.RadioButton();
            this.RadioButton3Day = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.RadioButtonStandard = new System.Windows.Forms.RadioButton();
            this.MaterialsBox = new System.Windows.Forms.ComboBox();
            this.DeliveryTypeBox = new System.Windows.Forms.GroupBox();
            this.DeliveryTypeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(601, 490);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(101, 40);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Main Menu";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Depth:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Number of Drawers:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(225, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Material:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthTextBox.Location = new System.Drawing.Point(318, 74);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(150, 26);
            this.WidthTextBox.TabIndex = 2;
            this.WidthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WidthTextBox_KeyPress);
            this.WidthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.WidthTextBox_Validating);
            // 
            // DepthTextBox
            // 
            this.DepthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepthTextBox.Location = new System.Drawing.Point(318, 134);
            this.DepthTextBox.Name = "DepthTextBox";
            this.DepthTextBox.Size = new System.Drawing.Size(150, 26);
            this.DepthTextBox.TabIndex = 3;
            this.DepthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DepthTextBox_KeyPress);
            this.DepthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.DepthTextBox_Validating);
            // 
            // DrawersTextBox
            // 
            this.DrawersTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawersTextBox.Location = new System.Drawing.Point(318, 194);
            this.DrawersTextBox.Name = "DrawersTextBox";
            this.DrawersTextBox.Size = new System.Drawing.Size(150, 26);
            this.DrawersTextBox.TabIndex = 4;
            // 
            // GenerateQuoteButton
            // 
            this.GenerateQuoteButton.AutoSize = true;
            this.GenerateQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateQuoteButton.Location = new System.Drawing.Point(313, 490);
            this.GenerateQuoteButton.Name = "GenerateQuoteButton";
            this.GenerateQuoteButton.Size = new System.Drawing.Size(155, 40);
            this.GenerateQuoteButton.TabIndex = 10;
            this.GenerateQuoteButton.Text = "Generate Quote";
            this.GenerateQuoteButton.UseVisualStyleBackColor = true;
            this.GenerateQuoteButton.Click += new System.EventHandler(this.GenerateQuoteButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(318, 16);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(150, 26);
            this.NameTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(152, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Customer Name:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RadioButton5Day
            // 
            this.RadioButton5Day.AutoSize = true;
            this.RadioButton5Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButton5Day.Location = new System.Drawing.Point(6, 81);
            this.RadioButton5Day.Name = "RadioButton5Day";
            this.RadioButton5Day.Size = new System.Drawing.Size(74, 24);
            this.RadioButton5Day.TabIndex = 8;
            this.RadioButton5Day.TabStop = true;
            this.RadioButton5Day.Text = "5 Day";
            this.RadioButton5Day.UseVisualStyleBackColor = true;
            // 
            // RadioButton7Day
            // 
            this.RadioButton7Day.AutoSize = true;
            this.RadioButton7Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButton7Day.Location = new System.Drawing.Point(6, 111);
            this.RadioButton7Day.Name = "RadioButton7Day";
            this.RadioButton7Day.Size = new System.Drawing.Size(74, 24);
            this.RadioButton7Day.TabIndex = 9;
            this.RadioButton7Day.TabStop = true;
            this.RadioButton7Day.Text = "7 Day";
            this.RadioButton7Day.UseVisualStyleBackColor = true;
            // 
            // RadioButton3Day
            // 
            this.RadioButton3Day.AutoSize = true;
            this.RadioButton3Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButton3Day.Location = new System.Drawing.Point(6, 51);
            this.RadioButton3Day.Name = "RadioButton3Day";
            this.RadioButton3Day.Size = new System.Drawing.Size(74, 24);
            this.RadioButton3Day.TabIndex = 7;
            this.RadioButton3Day.TabStop = true;
            this.RadioButton3Day.Text = "3 Day";
            this.RadioButton3Day.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(169, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = " Delivery Type:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RadioButtonStandard
            // 
            this.RadioButtonStandard.AutoSize = true;
            this.RadioButtonStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonStandard.Location = new System.Drawing.Point(6, 24);
            this.RadioButtonStandard.Name = "RadioButtonStandard";
            this.RadioButtonStandard.Size = new System.Drawing.Size(97, 24);
            this.RadioButtonStandard.TabIndex = 6;
            this.RadioButtonStandard.TabStop = true;
            this.RadioButtonStandard.Text = "Standard";
            this.RadioButtonStandard.UseVisualStyleBackColor = true;
            // 
            // MaterialsBox
            // 
            this.MaterialsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialsBox.FormattingEnabled = true;
            this.MaterialsBox.Location = new System.Drawing.Point(318, 260);
            this.MaterialsBox.Name = "MaterialsBox";
            this.MaterialsBox.Size = new System.Drawing.Size(150, 28);
            this.MaterialsBox.Sorted = true;
            this.MaterialsBox.TabIndex = 5;
            // 
            // DeliveryTypeBox
            // 
            this.DeliveryTypeBox.Controls.Add(this.RadioButton3Day);
            this.DeliveryTypeBox.Controls.Add(this.RadioButton5Day);
            this.DeliveryTypeBox.Controls.Add(this.RadioButtonStandard);
            this.DeliveryTypeBox.Controls.Add(this.RadioButton7Day);
            this.DeliveryTypeBox.Location = new System.Drawing.Point(318, 305);
            this.DeliveryTypeBox.Name = "DeliveryTypeBox";
            this.DeliveryTypeBox.Size = new System.Drawing.Size(138, 153);
            this.DeliveryTypeBox.TabIndex = 0;
            this.DeliveryTypeBox.TabStop = false;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 542);
            this.Controls.Add(this.DeliveryTypeBox);
            this.Controls.Add(this.MaterialsBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GenerateQuoteButton);
            this.Controls.Add(this.DrawersTextBox);
            this.Controls.Add(this.DepthTextBox);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.MaximizeBox = false;
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            this.DeliveryTypeBox.ResumeLayout(false);
            this.DeliveryTypeBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox DepthTextBox;
        private System.Windows.Forms.TextBox DrawersTextBox;
        private System.Windows.Forms.Button GenerateQuoteButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton RadioButton5Day;
        private System.Windows.Forms.RadioButton RadioButton7Day;
        private System.Windows.Forms.RadioButton RadioButton3Day;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton RadioButtonStandard;
        private System.Windows.Forms.ComboBox MaterialsBox;
        private System.Windows.Forms.GroupBox DeliveryTypeBox;
    }
}