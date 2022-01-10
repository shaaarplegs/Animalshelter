namespace AnimalShelter
{
    partial class AdoptionDescriptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdoptionDescriptionForm));
            this.lbAnimals = new System.Windows.Forms.ListBox();
            this.lbType = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbZipCode = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbAnimals
            // 
            this.lbAnimals.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnimals.FormattingEnabled = true;
            this.lbAnimals.HorizontalScrollbar = true;
            this.lbAnimals.ItemHeight = 28;
            this.lbAnimals.Items.AddRange(new object[] {
            "private string customerName;",
            "        private string customerAddress;",
            "        private string customerZipcode;",
            "        private string customerCity;",
            "        private string customerEmail;",
            "        private string customerPhone;",
            "        private DateTime adoptionDate;",
            "        private DateTime adoptionTime;",
            "        private List<Animal> adoptedAnimals;"});
            this.lbAnimals.Location = new System.Drawing.Point(485, 264);
            this.lbAnimals.Name = "lbAnimals";
            this.lbAnimals.ScrollAlwaysVisible = true;
            this.lbAnimals.Size = new System.Drawing.Size(380, 312);
            this.lbAnimals.TabIndex = 0;
            this.lbAnimals.DoubleClick += new System.EventHandler(this.lbAnimals_DoubleClick);
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbType.Location = new System.Drawing.Point(12, 12);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(200, 54);
            this.lbType.TabIndex = 13;
            this.lbType.Text = "Adoption";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(757, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 70);
            this.btnClose.TabIndex = 14;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(478, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 41);
            this.label6.TabIndex = 21;
            this.label6.Text = "Animals";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCity.Location = new System.Drawing.Point(143, 373);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(57, 32);
            this.lbCity.TabIndex = 25;
            this.lbCity.Text = "City";
            // 
            // lbZipCode
            // 
            this.lbZipCode.AutoSize = true;
            this.lbZipCode.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbZipCode.Location = new System.Drawing.Point(143, 303);
            this.lbZipCode.Name = "lbZipCode";
            this.lbZipCode.Size = new System.Drawing.Size(108, 32);
            this.lbZipCode.TabIndex = 24;
            this.lbZipCode.Text = "Zip code";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(143, 222);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(101, 32);
            this.lbAddress.TabIndex = 23;
            this.lbAddress.Text = "Address";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(143, 156);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(80, 32);
            this.lbName.TabIndex = 22;
            this.lbName.Text = "Name";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(143, 452);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(73, 32);
            this.lbEmail.TabIndex = 26;
            this.lbEmail.Text = "Email";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(143, 526);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(84, 32);
            this.lbPhone.TabIndex = 27;
            this.lbPhone.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 526);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 32);
            this.label4.TabIndex = 33;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 32);
            this.label5.TabIndex = 32;
            this.label5.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 32);
            this.label7.TabIndex = 31;
            this.label7.Text = "City";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 32);
            this.label8.TabIndex = 30;
            this.label8.Text = "Zip code";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 32);
            this.label9.TabIndex = 29;
            this.label9.Text = "Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 32);
            this.label10.TabIndex = 28;
            this.label10.Text = "Name";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(479, 102);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(168, 32);
            this.lbDate.TabIndex = 35;
            this.lbDate.Text = "AdoptionDate";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(479, 156);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(169, 32);
            this.lbTime.TabIndex = 34;
            this.lbTime.Text = "AdoptionTime";
            // 
            // AdoptionDescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 609);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbZipCode);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbAnimals);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdoptionDescriptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdoptionDescriptionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAnimals;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbZipCode;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbTime;
    }
}