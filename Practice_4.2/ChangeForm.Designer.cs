namespace Practice_4._2
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
            this.trackBarPoint = new System.Windows.Forms.TrackBar();
            this.trackBarCurve = new System.Windows.Forms.TrackBar();
            this.okButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCurve)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarPoint
            // 
            this.trackBarPoint.Location = new System.Drawing.Point(138, 36);
            this.trackBarPoint.Maximum = 12;
            this.trackBarPoint.Minimum = 1;
            this.trackBarPoint.Name = "trackBarPoint";
            this.trackBarPoint.Size = new System.Drawing.Size(192, 45);
            this.trackBarPoint.TabIndex = 0;
            this.trackBarPoint.Value = 1;
            this.trackBarPoint.Scroll += new System.EventHandler(this.TrackBarPoint_Scroll);
            // 
            // trackBarCurve
            // 
            this.trackBarCurve.Location = new System.Drawing.Point(138, 97);
            this.trackBarCurve.Maximum = 12;
            this.trackBarCurve.Minimum = 1;
            this.trackBarCurve.Name = "trackBarCurve";
            this.trackBarCurve.Size = new System.Drawing.Size(192, 45);
            this.trackBarCurve.TabIndex = 1;
            this.trackBarCurve.Value = 1;
            this.trackBarCurve.Scroll += new System.EventHandler(this.TrackBarCurve_Scroll);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(116, 148);
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
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Point Radius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Curve Thickness";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "1";
            // 
            // ChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 190);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.trackBarCurve);
            this.Controls.Add(this.trackBarPoint);
            this.Name = "ChangeForm";
            this.Text = "ChangeForm";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCurve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarPoint;
        private System.Windows.Forms.TrackBar trackBarCurve;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}