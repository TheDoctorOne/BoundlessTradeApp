namespace BoundlessTradeApp
{
    partial class WayFinder
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
            this.findTheWayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // findTheWayButton
            // 
            this.findTheWayButton.Location = new System.Drawing.Point(517, 146);
            this.findTheWayButton.Name = "findTheWayButton";
            this.findTheWayButton.Size = new System.Drawing.Size(177, 23);
            this.findTheWayButton.TabIndex = 0;
            this.findTheWayButton.Text = "Find the Path";
            this.findTheWayButton.UseVisualStyleBackColor = true;
            this.findTheWayButton.Click += new System.EventHandler(this.findTheWayButton_Click);
            // 
            // WayFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.findTheWayButton);
            this.Name = "WayFinder";
            this.Text = "WayFinder";
            this.Load += new System.EventHandler(this.WayFinder_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button findTheWayButton;
    }
}