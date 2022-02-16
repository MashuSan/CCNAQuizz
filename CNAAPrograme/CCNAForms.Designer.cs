
namespace CNAAPrograme
{
    partial class CCNAForms
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
            this._question = new System.Windows.Forms.Label();
            this._evaluateButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // _question
            // 
            this._question.AutoSize = true;
            this._question.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._question.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this._question.Location = new System.Drawing.Point(40, 31);
            this._question.Name = "_question";
            this._question.Size = new System.Drawing.Size(62, 31);
            this._question.TabIndex = 0;
            this._question.Text = "label1";
            this._question.UseCompatibleTextRendering = true;
            // 
            // _evaluateButton
            // 
            this._evaluateButton.Location = new System.Drawing.Point(328, 407);
            this._evaluateButton.Name = "_evaluateButton";
            this._evaluateButton.Size = new System.Drawing.Size(163, 40);
            this._evaluateButton.TabIndex = 2;
            this._evaluateButton.Text = "Vyhodnotiť";
            this._evaluateButton.UseVisualStyleBackColor = true;
            this._evaluateButton.Click += new System.EventHandler(this._evaluateButton_Click);
            // 
            // panel1
            // 
            this.panel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panel1.Location = new System.Drawing.Point(40, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 302);
            this.panel1.TabIndex = 3;
            // 
            // CCNAForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 474);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._evaluateButton);
            this.Controls.Add(this._question);
            this.Name = "CCNAForms";
            this.Text = "CCNAForms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _question;
        private System.Windows.Forms.Button _evaluateButton;
        private System.Windows.Forms.FlowLayoutPanel panel1;
    }
}