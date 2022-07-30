namespace Practice_4._4
{
    partial class ChangeForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PointColorButton = new System.Windows.Forms.Button();
            this.CurveColorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(129, 146);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(93, 32);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Point Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Curve Color";
            // 
            // PointColorButton
            // 
            this.PointColorButton.BackColor = System.Drawing.Color.Black;
            this.PointColorButton.Location = new System.Drawing.Point(116, 33);
            this.PointColorButton.Name = "PointColorButton";
            this.PointColorButton.Size = new System.Drawing.Size(186, 23);
            this.PointColorButton.TabIndex = 5;
            this.PointColorButton.UseVisualStyleBackColor = false;
            this.PointColorButton.Click += new System.EventHandler(this.pointColorButton_Click);
            // 
            // CurveColorButton
            // 
            this.CurveColorButton.BackColor = System.Drawing.Color.Black;
            this.CurveColorButton.Location = new System.Drawing.Point(116, 94);
            this.CurveColorButton.Name = "CurveColorButton";
            this.CurveColorButton.Size = new System.Drawing.Size(186, 23);
            this.CurveColorButton.TabIndex = 6;
            this.CurveColorButton.UseVisualStyleBackColor = false;
            this.CurveColorButton.Click += new System.EventHandler(this.CurveColorButton_Click);
            // 
            // ChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 190);
            this.Controls.Add(this.CurveColorButton);
            this.Controls.Add(this.PointColorButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okButton);
            this.Name = "ChangeForm";
            this.Text = "ChangeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PointColorButton;
        private System.Windows.Forms.Button CurveColorButton;
    }
}