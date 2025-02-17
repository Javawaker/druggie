namespace Druggie
{
    partial class FormInstruction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInstruction));
            this.textBoxInstruction = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxInstruction
            // 
            this.textBoxInstruction.BackColor = System.Drawing.Color.White;
            this.textBoxInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInstruction.Location = new System.Drawing.Point(50, 50);
            this.textBoxInstruction.Multiline = true;
            this.textBoxInstruction.Name = "textBoxInstruction";
            this.textBoxInstruction.ReadOnly = true;
            this.textBoxInstruction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInstruction.Size = new System.Drawing.Size(1432, 753);
            this.textBoxInstruction.TabIndex = 0;
            // 
            // FormInstruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Druggie.Properties.Resources.pattern_2;
            this.ClientSize = new System.Drawing.Size(1532, 853);
            this.Controls.Add(this.textBoxInstruction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormInstruction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Druggie";
            this.Load += new System.EventHandler(this.FormInstruction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInstruction;
    }
}