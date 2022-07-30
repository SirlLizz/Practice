namespace Practice_4._2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pointButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.drawClosedCurveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.motionButton = new System.Windows.Forms.Button();
            this.fillCurveButton = new System.Windows.Forms.Button();
            this.drawPolygoneButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pointButton
            // 
            this.pointButton.Location = new System.Drawing.Point(6, 19);
            this.pointButton.Name = "pointButton";
            this.pointButton.Size = new System.Drawing.Size(190, 36);
            this.pointButton.TabIndex = 0;
            this.pointButton.Text = "Point";
            this.pointButton.UseVisualStyleBackColor = true;
            this.pointButton.Click += new System.EventHandler(this.PointButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(6, 61);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(190, 36);
            this.settingsButton.TabIndex = 1;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // drawClosedCurveButton
            // 
            this.drawClosedCurveButton.Location = new System.Drawing.Point(6, 103);
            this.drawClosedCurveButton.Name = "drawClosedCurveButton";
            this.drawClosedCurveButton.Size = new System.Drawing.Size(190, 36);
            this.drawClosedCurveButton.TabIndex = 2;
            this.drawClosedCurveButton.Text = "ClosedCurve";
            this.drawClosedCurveButton.UseVisualStyleBackColor = true;
            this.drawClosedCurveButton.Click += new System.EventHandler(this.DrawClosedCurveButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.motionButton);
            this.groupBox1.Controls.Add(this.pointButton);
            this.groupBox1.Controls.Add(this.fillCurveButton);
            this.groupBox1.Controls.Add(this.drawPolygoneButton);
            this.groupBox1.Controls.Add(this.drawClosedCurveButton);
            this.groupBox1.Controls.Add(this.settingsButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 317);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drawing";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(6, 271);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(190, 36);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // motionButton
            // 
            this.motionButton.Location = new System.Drawing.Point(6, 229);
            this.motionButton.Name = "motionButton";
            this.motionButton.Size = new System.Drawing.Size(190, 36);
            this.motionButton.TabIndex = 3;
            this.motionButton.Text = "Motion";
            this.motionButton.UseVisualStyleBackColor = true;
            // 
            // fillCurveButton
            // 
            this.fillCurveButton.Location = new System.Drawing.Point(6, 187);
            this.fillCurveButton.Name = "fillCurveButton";
            this.fillCurveButton.Size = new System.Drawing.Size(190, 36);
            this.fillCurveButton.TabIndex = 1;
            this.fillCurveButton.Text = "Fill Curve";
            this.fillCurveButton.UseVisualStyleBackColor = true;
            this.fillCurveButton.Click += new System.EventHandler(this.FillCurveButton_Click);
            // 
            // drawPolygoneButton
            // 
            this.drawPolygoneButton.Location = new System.Drawing.Point(6, 145);
            this.drawPolygoneButton.Name = "drawPolygoneButton";
            this.drawPolygoneButton.Size = new System.Drawing.Size(190, 36);
            this.drawPolygoneButton.TabIndex = 0;
            this.drawPolygoneButton.Text = "Polygone";
            this.drawPolygoneButton.UseVisualStyleBackColor = true;
            this.drawPolygoneButton.Click += new System.EventHandler(this.DrawPolygoneButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pointButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button drawClosedCurveButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button fillCurveButton;
        private System.Windows.Forms.Button drawPolygoneButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button motionButton;
    }
}

