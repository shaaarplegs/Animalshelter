namespace AnimalShelter
{
    partial class SelectAnimals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectAnimals));
            this.lbDiscount = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbAvailableAnimals = new System.Windows.Forms.ListBox();
            this.lbSelectedAnimals = new System.Windows.Forms.ListBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnRemoveChoice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSortOnDescending = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscount.Location = new System.Drawing.Point(12, 29);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(270, 45);
            this.lbDiscount.TabIndex = 22;
            this.lbDiscount.Text = "Available animals";
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Segoe UI", 19.8F);
            this.btnDone.Location = new System.Drawing.Point(846, 568);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(198, 61);
            this.btnDone.TabIndex = 23;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(936, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 70);
            this.btnClose.TabIndex = 24;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbAvailableAnimals
            // 
            this.lbAvailableAnimals.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAvailableAnimals.FormattingEnabled = true;
            this.lbAvailableAnimals.ItemHeight = 41;
            this.lbAvailableAnimals.Location = new System.Drawing.Point(12, 107);
            this.lbAvailableAnimals.Name = "lbAvailableAnimals";
            this.lbAvailableAnimals.Size = new System.Drawing.Size(463, 455);
            this.lbAvailableAnimals.TabIndex = 25;
            this.lbAvailableAnimals.DoubleClick += new System.EventHandler(this.lbAvailableAnimals_DoubleClick);
            // 
            // lbSelectedAnimals
            // 
            this.lbSelectedAnimals.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lbSelectedAnimals.FormattingEnabled = true;
            this.lbSelectedAnimals.ItemHeight = 41;
            this.lbSelectedAnimals.Location = new System.Drawing.Point(598, 107);
            this.lbSelectedAnimals.Name = "lbSelectedAnimals";
            this.lbSelectedAnimals.Size = new System.Drawing.Size(446, 455);
            this.lbSelectedAnimals.TabIndex = 26;
            this.lbSelectedAnimals.DoubleClick += new System.EventHandler(this.lbSelectedAnimals_DoubleClick);
            // 
            // btnMove
            // 
            this.btnMove.Font = new System.Drawing.Font("Segoe UI", 19.8F);
            this.btnMove.Location = new System.Drawing.Point(481, 216);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(111, 61);
            this.btnMove.TabIndex = 27;
            this.btnMove.Text = ">>";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnRemoveChoice
            // 
            this.btnRemoveChoice.Font = new System.Drawing.Font("Segoe UI", 19.8F);
            this.btnRemoveChoice.Location = new System.Drawing.Point(481, 397);
            this.btnRemoveChoice.Name = "btnRemoveChoice";
            this.btnRemoveChoice.Size = new System.Drawing.Size(111, 61);
            this.btnRemoveChoice.TabIndex = 28;
            this.btnRemoveChoice.Text = "<<";
            this.btnRemoveChoice.UseVisualStyleBackColor = true;
            this.btnRemoveChoice.Click += new System.EventHandler(this.btnRemoveChoice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(590, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 45);
            this.label1.TabIndex = 29;
            this.label1.Text = "Selected animals";
            // 
            // btnSortOnDescending
            // 
            this.btnSortOnDescending.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortOnDescending.Location = new System.Drawing.Point(30, 568);
            this.btnSortOnDescending.Name = "btnSortOnDescending";
            this.btnSortOnDescending.Size = new System.Drawing.Size(427, 61);
            this.btnSortOnDescending.TabIndex = 30;
            this.btnSortOnDescending.Text = "Sort on age in descending";
            this.btnSortOnDescending.UseVisualStyleBackColor = true;
            this.btnSortOnDescending.Click += new System.EventHandler(this.btnSortOnDescending_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Teal;
            this.label27.Location = new System.Drawing.Point(12, 79);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(394, 25);
            this.label27.TabIndex = 31;
            this.label27.Text = "Double click on animal to check info in detail.";
            // 
            // SelectAnimals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1056, 636);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.btnSortOnDescending);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveChoice);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.lbSelectedAnimals);
            this.Controls.Add(this.lbAvailableAnimals);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lbDiscount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectAnimals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectAnimals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lbAvailableAnimals;
        private System.Windows.Forms.ListBox lbSelectedAnimals;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnRemoveChoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSortOnDescending;
        private System.Windows.Forms.Label label27;
    }
}