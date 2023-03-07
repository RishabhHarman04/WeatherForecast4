namespace WindowsFormsApp5
{
    partial class SettingForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.checkedListBoxCities = new System.Windows.Forms.CheckedListBox();
            this.numericUpDownTime = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(291, 474);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 35);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // checkedListBoxCities
            // 
            this.checkedListBoxCities.FormattingEnabled = true;
            this.checkedListBoxCities.Location = new System.Drawing.Point(37, 256);
            this.checkedListBoxCities.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkedListBoxCities.Name = "checkedListBoxCities";
            this.checkedListBoxCities.Size = new System.Drawing.Size(178, 142);
            this.checkedListBoxCities.TabIndex = 1;
            // 
            // numericUpDownTime
            // 
            this.numericUpDownTime.Location = new System.Drawing.Point(457, 316);
            this.numericUpDownTime.Name = "numericUpDownTime";
            this.numericUpDownTime.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownTime.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cities";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(420, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Time (in sec)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(270, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Settings";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownTime);
            this.Controls.Add(this.checkedListBoxCities);
            this.Controls.Add(this.btnSave);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SettingForm";
            this.Text = "SettingForm";
            this.Load += new System.EventHandler(this.SettingForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckedListBox checkedListBoxCities;
        private System.Windows.Forms.NumericUpDown numericUpDownTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}