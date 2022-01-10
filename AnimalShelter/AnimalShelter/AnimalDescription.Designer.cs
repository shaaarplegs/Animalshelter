namespace AnimalShelter
{
    partial class AnimalDescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimalDescription));
            this.btnClose = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(651, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 70);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(137, 98);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(80, 32);
            this.lbName.TabIndex = 10;
            this.lbName.Text = "Name";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAge.Location = new System.Drawing.Point(137, 200);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(58, 32);
            this.lbAge.TabIndex = 11;
            this.lbAge.Text = "Age";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbType.Location = new System.Drawing.Point(19, 9);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(113, 54);
            this.lbType.TabIndex = 12;
            this.lbType.Text = "Type";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.Location = new System.Drawing.Point(137, 317);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(95, 32);
            this.lbGender.TabIndex = 13;
            this.lbGender.Text = "Gender";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.Location = new System.Drawing.Point(137, 409);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(58, 32);
            this.lbSize.TabIndex = 14;
            this.lbSize.Text = "Size";
            this.lbSize.Visible = false;
            // 
            // lbDescription
            // 
            this.lbDescription.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.ForeColor = System.Drawing.Color.Gray;
            this.lbDescription.Location = new System.Drawing.Point(314, 154);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(445, 288);
            this.lbDescription.TabIndex = 15;
            this.lbDescription.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 41);
            this.label1.TabIndex = 19;
            this.label1.Text = "Size:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 41);
            this.label2.TabIndex = 18;
            this.label2.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 41);
            this.label4.TabIndex = 17;
            this.label4.Text = "Age:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 41);
            this.label5.TabIndex = 16;
            this.label5.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(314, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 41);
            this.label6.TabIndex = 20;
            this.label6.Text = "Description:";
            // 
            // AnimalDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 451);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnimalDescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnimalDescription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}