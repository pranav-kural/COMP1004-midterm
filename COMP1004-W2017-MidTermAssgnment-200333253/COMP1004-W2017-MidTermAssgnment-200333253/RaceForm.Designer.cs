namespace COMP1004_W2017_MidTermAssgnment_200333253
{
    partial class RaceForm
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
            this.RacialBonusLabel = new System.Windows.Forms.Label();
            this.RacialBonusTextBox = new System.Windows.Forms.TextBox();
            this.RaceGroupBox = new System.Windows.Forms.GroupBox();
            this.HalflingRadioButton = new System.Windows.Forms.RadioButton();
            this.ElfRadioButton = new System.Windows.Forms.RadioButton();
            this.DwarfRadioButton = new System.Windows.Forms.RadioButton();
            this.HumanRadioButton = new System.Windows.Forms.RadioButton();
            this.CharacterPictureBox = new System.Windows.Forms.PictureBox();
            this.RaceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(525, 465);
            this.NextButton.Margin = new System.Windows.Forms.Padding(4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(100, 28);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this._NextButtonClickEventHandler);
            // 
            // RacialBonusLabel
            // 
            this.RacialBonusLabel.AutoSize = true;
            this.RacialBonusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RacialBonusLabel.Location = new System.Drawing.Point(236, 366);
            this.RacialBonusLabel.Name = "RacialBonusLabel";
            this.RacialBonusLabel.Size = new System.Drawing.Size(115, 20);
            this.RacialBonusLabel.TabIndex = 6;
            this.RacialBonusLabel.Text = "Racial Bonus";
            // 
            // RacialBonusTextBox
            // 
            this.RacialBonusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RacialBonusTextBox.Location = new System.Drawing.Point(242, 400);
            this.RacialBonusTextBox.Name = "RacialBonusTextBox";
            this.RacialBonusTextBox.Size = new System.Drawing.Size(287, 26);
            this.RacialBonusTextBox.TabIndex = 7;
            // 
            // RaceGroupBox
            // 
            this.RaceGroupBox.Controls.Add(this.HalflingRadioButton);
            this.RaceGroupBox.Controls.Add(this.ElfRadioButton);
            this.RaceGroupBox.Controls.Add(this.DwarfRadioButton);
            this.RaceGroupBox.Controls.Add(this.HumanRadioButton);
            this.RaceGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.RaceGroupBox.Location = new System.Drawing.Point(12, 74);
            this.RaceGroupBox.Name = "RaceGroupBox";
            this.RaceGroupBox.Size = new System.Drawing.Size(220, 272);
            this.RaceGroupBox.TabIndex = 8;
            this.RaceGroupBox.TabStop = false;
            this.RaceGroupBox.Text = "Select Player Race";
            // 
            // HalflingRadioButton
            // 
            this.HalflingRadioButton.AutoSize = true;
            this.HalflingRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HalflingRadioButton.Location = new System.Drawing.Point(23, 203);
            this.HalflingRadioButton.Name = "HalflingRadioButton";
            this.HalflingRadioButton.Size = new System.Drawing.Size(88, 24);
            this.HalflingRadioButton.TabIndex = 3;
            this.HalflingRadioButton.TabStop = true;
            this.HalflingRadioButton.Text = "Halfling";
            this.HalflingRadioButton.UseVisualStyleBackColor = true;
            this.HalflingRadioButton.CheckedChanged += new System.EventHandler(this._RaceRadioButtonEventHandler);
            // 
            // ElfRadioButton
            // 
            this.ElfRadioButton.AutoSize = true;
            this.ElfRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElfRadioButton.Location = new System.Drawing.Point(23, 150);
            this.ElfRadioButton.Name = "ElfRadioButton";
            this.ElfRadioButton.Size = new System.Drawing.Size(49, 24);
            this.ElfRadioButton.TabIndex = 2;
            this.ElfRadioButton.TabStop = true;
            this.ElfRadioButton.Text = "Elf";
            this.ElfRadioButton.UseVisualStyleBackColor = true;
            this.ElfRadioButton.CheckedChanged += new System.EventHandler(this._RaceRadioButtonEventHandler);
            // 
            // DwarfRadioButton
            // 
            this.DwarfRadioButton.AutoSize = true;
            this.DwarfRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DwarfRadioButton.Location = new System.Drawing.Point(23, 99);
            this.DwarfRadioButton.Name = "DwarfRadioButton";
            this.DwarfRadioButton.Size = new System.Drawing.Size(74, 24);
            this.DwarfRadioButton.TabIndex = 1;
            this.DwarfRadioButton.TabStop = true;
            this.DwarfRadioButton.Text = "Dwarf";
            this.DwarfRadioButton.UseVisualStyleBackColor = true;
            this.DwarfRadioButton.CheckedChanged += new System.EventHandler(this._RaceRadioButtonEventHandler);
            // 
            // HumanRadioButton
            // 
            this.HumanRadioButton.AutoSize = true;
            this.HumanRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HumanRadioButton.Location = new System.Drawing.Point(23, 44);
            this.HumanRadioButton.Name = "HumanRadioButton";
            this.HumanRadioButton.Size = new System.Drawing.Size(84, 24);
            this.HumanRadioButton.TabIndex = 0;
            this.HumanRadioButton.Text = "Human";
            this.HumanRadioButton.UseVisualStyleBackColor = true;
            this.HumanRadioButton.CheckedChanged += new System.EventHandler(this._RaceRadioButtonEventHandler);
            // 
            // CharacterPictureBox
            // 
            this.CharacterPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CharacterPictureBox.Location = new System.Drawing.Point(239, 84);
            this.CharacterPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.CharacterPictureBox.Name = "CharacterPictureBox";
            this.CharacterPictureBox.Size = new System.Drawing.Size(290, 262);
            this.CharacterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CharacterPictureBox.TabIndex = 5;
            this.CharacterPictureBox.TabStop = false;
            // 
            // RaceForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(641, 508);
            this.Controls.Add(this.RaceGroupBox);
            this.Controls.Add(this.RacialBonusTextBox);
            this.Controls.Add(this.RacialBonusLabel);
            this.Controls.Add(this.CharacterPictureBox);
            this.Controls.Add(this.NextButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Character Race";
            this.RaceGroupBox.ResumeLayout(false);
            this.RaceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox CharacterPictureBox;
        internal System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label RacialBonusLabel;
        private System.Windows.Forms.TextBox RacialBonusTextBox;
        private System.Windows.Forms.GroupBox RaceGroupBox;
        private System.Windows.Forms.RadioButton HalflingRadioButton;
        private System.Windows.Forms.RadioButton ElfRadioButton;
        private System.Windows.Forms.RadioButton DwarfRadioButton;
        private System.Windows.Forms.RadioButton HumanRadioButton;
    }
}