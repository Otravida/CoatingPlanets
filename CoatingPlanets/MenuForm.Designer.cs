namespace CoatingPlanets
{
    partial class MenuForm
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
            this.recordsButton = new System.Windows.Forms.Button();
            this.chamberButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // recordsButton
            // 
            this.recordsButton.Location = new System.Drawing.Point(12, 177);
            this.recordsButton.Name = "recordsButton";
            this.recordsButton.Size = new System.Drawing.Size(221, 66);
            this.recordsButton.TabIndex = 0;
            this.recordsButton.Text = "Add Parts / Tooling";
            this.recordsButton.UseVisualStyleBackColor = true;
            this.recordsButton.Click += new System.EventHandler(this.recordsButton_Click);
            // 
            // chamberButton
            // 
            this.chamberButton.Location = new System.Drawing.Point(12, 12);
            this.chamberButton.Name = "chamberButton";
            this.chamberButton.Size = new System.Drawing.Size(221, 95);
            this.chamberButton.TabIndex = 0;
            this.chamberButton.Text = "Plan Chambers";
            this.chamberButton.Click += new System.EventHandler(this.chamberButton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 255);
            this.Controls.Add(this.chamberButton);
            this.Controls.Add(this.recordsButton);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button recordsButton;
        private System.Windows.Forms.Button chamberButton;
    }
}