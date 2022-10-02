namespace MyLedger
{
    partial class LedgerUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LedgerUI));
            this.readLbl = new System.Windows.Forms.Label();
            this.writeLbl = new System.Windows.Forms.Label();
            this.readBox = new System.Windows.Forms.TextBox();
            this.writeBox = new System.Windows.Forms.TextBox();
            this.previousBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // readLbl
            // 
            this.readLbl.AutoSize = true;
            this.readLbl.BackColor = System.Drawing.Color.Transparent;
            this.readLbl.Font = new System.Drawing.Font("High Tower Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.readLbl.Location = new System.Drawing.Point(399, 55);
            this.readLbl.Name = "readLbl";
            this.readLbl.Size = new System.Drawing.Size(183, 85);
            this.readLbl.TabIndex = 0;
            this.readLbl.Text = "Read";
            // 
            // writeLbl
            // 
            this.writeLbl.AutoSize = true;
            this.writeLbl.BackColor = System.Drawing.Color.Transparent;
            this.writeLbl.Font = new System.Drawing.Font("High Tower Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.writeLbl.Location = new System.Drawing.Point(1273, 55);
            this.writeLbl.Name = "writeLbl";
            this.writeLbl.Size = new System.Drawing.Size(215, 85);
            this.writeLbl.TabIndex = 1;
            this.writeLbl.Text = "Write";
            // 
            // readBox
            // 
            this.readBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readBox.Location = new System.Drawing.Point(170, 159);
            this.readBox.Multiline = true;
            this.readBox.Name = "readBox";
            this.readBox.ReadOnly = true;
            this.readBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.readBox.Size = new System.Drawing.Size(702, 537);
            this.readBox.TabIndex = 2;
            // 
            // writeBox
            // 
            this.writeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.writeBox.Location = new System.Drawing.Point(971, 159);
            this.writeBox.Multiline = true;
            this.writeBox.Name = "writeBox";
            this.writeBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.writeBox.Size = new System.Drawing.Size(702, 537);
            this.writeBox.TabIndex = 3;
            // 
            // previousBtn
            // 
            this.previousBtn.Location = new System.Drawing.Point(166, 717);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(225, 69);
            this.previousBtn.TabIndex = 4;
            this.previousBtn.Text = "Previous";
            this.previousBtn.UseVisualStyleBackColor = true;
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(647, 717);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(225, 69);
            this.nextBtn.TabIndex = 5;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(965, 728);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(708, 69);
            this.submitBtn.TabIndex = 6;
            this.submitBtn.Text = "Submit new Entry";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // LedgerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1877, 867);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.previousBtn);
            this.Controls.Add(this.writeBox);
            this.Controls.Add(this.readBox);
            this.Controls.Add(this.writeLbl);
            this.Controls.Add(this.readLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(1917, 974);
            this.MinimumSize = new System.Drawing.Size(1917, 974);
            this.Name = "LedgerUI";
            this.Text = "MyLedger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label readLbl;
        private Label writeLbl;
        private TextBox readBox;
        private TextBox writeBox;
        private Button previousBtn;
        private Button nextBtn;
        private Button submitBtn;
    }
}