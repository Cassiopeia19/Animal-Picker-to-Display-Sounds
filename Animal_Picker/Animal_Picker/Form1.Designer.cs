namespace FinalPart2
{
    partial class Form1
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
            this.Reset = new System.Windows.Forms.Button();
            this.Animals = new System.Windows.Forms.Label();
            this.listBoxItem = new System.Windows.Forms.ListBox();
            this.listBoxIndex = new System.Windows.Forms.ListBox();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.btnGetItem = new System.Windows.Forms.Button();
            this.btnGetIndex = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Reset.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(276, 346);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(103, 37);
            this.Reset.TabIndex = 2;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click_1);
            // 
            // Animals
            // 
            this.Animals.AutoSize = true;
            this.Animals.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animals.Location = new System.Drawing.Point(40, 43);
            this.Animals.Name = "Animals";
            this.Animals.Size = new System.Drawing.Size(142, 36);
            this.Animals.TabIndex = 3;
            this.Animals.Text = "Animals";
            // 
            // listBoxItem
            // 
            this.listBoxItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listBoxItem.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxItem.FormattingEnabled = true;
            this.listBoxItem.ItemHeight = 25;
            this.listBoxItem.Location = new System.Drawing.Point(227, 97);
            this.listBoxItem.Name = "listBoxItem";
            this.listBoxItem.Size = new System.Drawing.Size(247, 179);
            this.listBoxItem.TabIndex = 5;
            this.listBoxItem.SelectedIndexChanged += new System.EventHandler(this.listBoxItem_SelectedIndexChanged);
            // 
            // listBoxIndex
            // 
            this.listBoxIndex.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listBoxIndex.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxIndex.FormattingEnabled = true;
            this.listBoxIndex.ItemHeight = 24;
            this.listBoxIndex.Location = new System.Drawing.Point(497, 97);
            this.listBoxIndex.Name = "listBoxIndex";
            this.listBoxIndex.Size = new System.Drawing.Size(252, 172);
            this.listBoxIndex.TabIndex = 7;
            this.listBoxIndex.SelectedIndexChanged += new System.EventHandler(this.listBoxIndex_SelectedIndexChanged);
            // 
            // checkedListBox
            // 
            this.checkedListBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.checkedListBox.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Items.AddRange(new object[] {
            "Cat",
            "Cow",
            "Duck",
            "Pig",
            "Rooster"});
            this.checkedListBox.Location = new System.Drawing.Point(46, 97);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(136, 172);
            this.checkedListBox.TabIndex = 8;
            this.checkedListBox.ThreeDCheckBoxes = true;
            this.checkedListBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_SelectedIndexChanged_1);
            // 
            // btnGetItem
            // 
            this.btnGetItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnGetItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGetItem.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetItem.Location = new System.Drawing.Point(227, 39);
            this.btnGetItem.Name = "btnGetItem";
            this.btnGetItem.Size = new System.Drawing.Size(247, 51);
            this.btnGetItem.TabIndex = 9;
            this.btnGetItem.Text = "Get Animal Name(s)";
            this.btnGetItem.UseVisualStyleBackColor = false;
            this.btnGetItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGetIndex
            // 
            this.btnGetIndex.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnGetIndex.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGetIndex.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetIndex.Location = new System.Drawing.Point(497, 39);
            this.btnGetIndex.Name = "btnGetIndex";
            this.btnGetIndex.Size = new System.Drawing.Size(252, 50);
            this.btnGetIndex.TabIndex = 10;
            this.btnGetIndex.Text = "Get Animal Sound(s)";
            this.btnGetIndex.UseVisualStyleBackColor = false;
            this.btnGetIndex.Click += new System.EventHandler(this.btnGetIndex_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Exit.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(438, 346);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(96, 37);
            this.Exit.TabIndex = 11;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(855, 507);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.btnGetIndex);
            this.Controls.Add(this.btnGetItem);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.listBoxIndex);
            this.Controls.Add(this.listBoxItem);
            this.Controls.Add(this.Animals);
            this.Controls.Add(this.Reset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label Animals;
        private System.Windows.Forms.ListBox listBoxItem;
        private System.Windows.Forms.ListBox listBoxIndex;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Button btnGetItem;
        private System.Windows.Forms.Button btnGetIndex;
        private System.Windows.Forms.Button Exit;
    }
}

