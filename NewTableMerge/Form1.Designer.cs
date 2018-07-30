namespace NewTableMerge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_Merge = new System.Windows.Forms.Button();
            this.button_Browse = new System.Windows.Forms.Button();
            this.listBox1_excelFile = new System.Windows.Forms.ListBox();
            this.button_Select = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Merge
            // 
            this.button_Merge.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.button_Merge.Location = new System.Drawing.Point(372, 102);
            this.button_Merge.Name = "button_Merge";
            this.button_Merge.Size = new System.Drawing.Size(75, 23);
            this.button_Merge.TabIndex = 0;
            this.button_Merge.Text = "Merge";
            this.button_Merge.UseVisualStyleBackColor = true;
            this.button_Merge.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Browse
            // 
            this.button_Browse.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.button_Browse.Location = new System.Drawing.Point(372, 17);
            this.button_Browse.Name = "button_Browse";
            this.button_Browse.Size = new System.Drawing.Size(75, 23);
            this.button_Browse.TabIndex = 3;
            this.button_Browse.Text = "Browse";
            this.button_Browse.UseVisualStyleBackColor = true;
            this.button_Browse.Click += new System.EventHandler(this.button_Browse_Click);
            // 
            // listBox1_excelFile
            // 
            this.listBox1_excelFile.FormattingEnabled = true;
            this.listBox1_excelFile.Location = new System.Drawing.Point(12, 17);
            this.listBox1_excelFile.Name = "listBox1_excelFile";
            this.listBox1_excelFile.Size = new System.Drawing.Size(341, 537);
            this.listBox1_excelFile.TabIndex = 4;
            // 
            // button_Select
            // 
            this.button_Select.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.button_Select.Location = new System.Drawing.Point(372, 59);
            this.button_Select.Name = "button_Select";
            this.button_Select.Size = new System.Drawing.Size(75, 23);
            this.button_Select.TabIndex = 5;
            this.button_Select.Text = "Select all";
            this.button_Select.UseVisualStyleBackColor = true;
            this.button_Select.Click += new System.EventHandler(this.button_Select_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(471, 579);
            this.Controls.Add(this.button_Select);
            this.Controls.Add(this.listBox1_excelFile);
            this.Controls.Add(this.button_Browse);
            this.Controls.Add(this.button_Merge);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Merge;
        private System.Windows.Forms.Button button_Browse;
        private System.Windows.Forms.ListBox listBox1_excelFile;
        private System.Windows.Forms.Button button_Select;
    }
}

