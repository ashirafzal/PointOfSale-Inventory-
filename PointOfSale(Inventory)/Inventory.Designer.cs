namespace PointOfSale_Inventory_
{
    partial class Inventory
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
            this.gradientPanel1 = new PointOfSale_Inventory_.GradientPanel();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.colorBottom = System.Drawing.Color.Teal;
            this.gradientPanel1.colorTop = System.Drawing.Color.Maroon;
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(985, 546);
            this.gradientPanel1.TabIndex = 0;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 546);
            this.Controls.Add(this.gradientPanel1);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
    }
}