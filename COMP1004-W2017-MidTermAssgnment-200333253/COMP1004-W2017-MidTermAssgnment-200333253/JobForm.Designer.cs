namespace COMP1004_W2017_MidTermAssgnment_200333253
{
    partial class JobForm
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
            this.NextButton = new System.Windows.Forms.Button();
            this.JobGroupBox = new System.Windows.Forms.GroupBox();
            this.CultistRadioButton = new System.Windows.Forms.RadioButton();
            this.MagickerRadioButton = new System.Windows.Forms.RadioButton();
            this.RogueRadioButton = new System.Windows.Forms.RadioButton();
            this.SoldierRadioButton = new System.Windows.Forms.RadioButton();
            this.HealthLabel = new System.Windows.Forms.Label();
            this.HealthTextBox = new System.Windows.Forms.TextBox();
            this.JobGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(332, 243);
            this.NextButton.Margin = new System.Windows.Forms.Padding(4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(100, 28);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this._NextButtonClickEventHandler);
            // 
            // JobGroupBox
            // 
            this.JobGroupBox.Controls.Add(this.CultistRadioButton);
            this.JobGroupBox.Controls.Add(this.MagickerRadioButton);
            this.JobGroupBox.Controls.Add(this.RogueRadioButton);
            this.JobGroupBox.Controls.Add(this.SoldierRadioButton);
            this.JobGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobGroupBox.Location = new System.Drawing.Point(32, 39);
            this.JobGroupBox.Name = "JobGroupBox";
            this.JobGroupBox.Size = new System.Drawing.Size(188, 232);
            this.JobGroupBox.TabIndex = 4;
            this.JobGroupBox.TabStop = false;
            this.JobGroupBox.Text = "Select Player Job";
            // 
            // CultistRadioButton
            // 
            this.CultistRadioButton.AutoSize = true;
            this.CultistRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CultistRadioButton.Location = new System.Drawing.Point(39, 180);
            this.CultistRadioButton.Name = "CultistRadioButton";
            this.CultistRadioButton.Size = new System.Drawing.Size(71, 24);
            this.CultistRadioButton.TabIndex = 3;
            this.CultistRadioButton.TabStop = true;
            this.CultistRadioButton.Text = "Cultist";
            this.CultistRadioButton.UseVisualStyleBackColor = true;
            this.CultistRadioButton.CheckedChanged += new System.EventHandler(this._JobRadioButtonEventHandler);
            // 
            // MagickerRadioButton
            // 
            this.MagickerRadioButton.AutoSize = true;
            this.MagickerRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MagickerRadioButton.Location = new System.Drawing.Point(39, 133);
            this.MagickerRadioButton.Name = "MagickerRadioButton";
            this.MagickerRadioButton.Size = new System.Drawing.Size(91, 24);
            this.MagickerRadioButton.TabIndex = 2;
            this.MagickerRadioButton.TabStop = true;
            this.MagickerRadioButton.Text = "Magicker";
            this.MagickerRadioButton.UseVisualStyleBackColor = true;
            this.MagickerRadioButton.CheckedChanged += new System.EventHandler(this._JobRadioButtonEventHandler);
            // 
            // RogueRadioButton
            // 
            this.RogueRadioButton.AutoSize = true;
            this.RogueRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RogueRadioButton.Location = new System.Drawing.Point(39, 91);
            this.RogueRadioButton.Name = "RogueRadioButton";
            this.RogueRadioButton.Size = new System.Drawing.Size(75, 24);
            this.RogueRadioButton.TabIndex = 1;
            this.RogueRadioButton.TabStop = true;
            this.RogueRadioButton.Text = "Rogue";
            this.RogueRadioButton.UseVisualStyleBackColor = true;
            this.RogueRadioButton.CheckedChanged += new System.EventHandler(this._JobRadioButtonEventHandler);
            // 
            // SoldierRadioButton
            // 
            this.SoldierRadioButton.AutoSize = true;
            this.SoldierRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoldierRadioButton.Location = new System.Drawing.Point(39, 47);
            this.SoldierRadioButton.Name = "SoldierRadioButton";
            this.SoldierRadioButton.Size = new System.Drawing.Size(76, 24);
            this.SoldierRadioButton.TabIndex = 0;
            this.SoldierRadioButton.TabStop = true;
            this.SoldierRadioButton.Text = "Soldier";
            this.SoldierRadioButton.UseVisualStyleBackColor = true;
            this.SoldierRadioButton.CheckedChanged += new System.EventHandler(this._JobRadioButtonEventHandler);
            // 
            // HealthLabel
            // 
            this.HealthLabel.AutoSize = true;
            this.HealthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealthLabel.Location = new System.Drawing.Point(252, 39);
            this.HealthLabel.Name = "HealthLabel";
            this.HealthLabel.Size = new System.Drawing.Size(76, 24);
            this.HealthLabel.TabIndex = 5;
            this.HealthLabel.Text = "Health:";
            // 
            // HealthTextBox
            // 
            this.HealthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealthTextBox.Location = new System.Drawing.Point(256, 81);
            this.HealthTextBox.Name = "HealthTextBox";
            this.HealthTextBox.ReadOnly = true;
            this.HealthTextBox.Size = new System.Drawing.Size(176, 29);
            this.HealthTextBox.TabIndex = 6;
            // 
            // JobForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(466, 303);
            this.Controls.Add(this.HealthTextBox);
            this.Controls.Add(this.HealthLabel);
            this.Controls.Add(this.JobGroupBox);
            this.Controls.Add(this.NextButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "JobForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select the Character\'s Job";
            this.JobGroupBox.ResumeLayout(false);
            this.JobGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.GroupBox JobGroupBox;
        private System.Windows.Forms.RadioButton CultistRadioButton;
        private System.Windows.Forms.RadioButton MagickerRadioButton;
        private System.Windows.Forms.RadioButton RogueRadioButton;
        private System.Windows.Forms.RadioButton SoldierRadioButton;
        private System.Windows.Forms.Label HealthLabel;
        private System.Windows.Forms.TextBox HealthTextBox;
    }
}