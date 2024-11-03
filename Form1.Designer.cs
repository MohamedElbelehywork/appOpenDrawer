
namespace appOpenDrawer
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
            this.btnOpenDrawer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenDrawer
            // 
            this.btnOpenDrawer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOpenDrawer.FlatAppearance.BorderSize = 0;
            this.btnOpenDrawer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenDrawer.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenDrawer.Location = new System.Drawing.Point(12, 12);
            this.btnOpenDrawer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnOpenDrawer.Name = "btnOpenDrawer";
            this.btnOpenDrawer.Size = new System.Drawing.Size(234, 88);
            this.btnOpenDrawer.TabIndex = 0;
            this.btnOpenDrawer.Text = "فتح الدرج";
            this.btnOpenDrawer.UseVisualStyleBackColor = false;
            this.btnOpenDrawer.Click += new System.EventHandler(this.btnOpenDrawer_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnOpenDrawer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(258, 111);
            this.Controls.Add(this.btnOpenDrawer);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "فتح درج النقدية";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenDrawer;
    }
}

