namespace WindowsFormsApp1
{
    partial class MainFrame
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
            this.btnGo = new System.Windows.Forms.Button();
            this.wordLabel = new System.Windows.Forms.Label();
            this.textBoxContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblHint1 = new System.Windows.Forms.Label();
            this.lblHint2 = new System.Windows.Forms.Label();
            this.lblHint3 = new System.Windows.Forms.Label();
            this.lettersContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPointsPos = new System.Windows.Forms.Label();
            this.lblCurrentPoints = new System.Windows.Forms.Label();
            this.cbDifficulty = new System.Windows.Forms.CheckBox();
            this.lettersContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(222, 501);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(406, 78);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_click);
            // 
            // wordLabel
            // 
            this.wordLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.wordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wordLabel.AutoSize = true;
            this.wordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordLabel.Location = new System.Drawing.Point(3, 0);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(199, 32);
            this.wordLabel.TabIndex = 4;
            this.wordLabel.Text = "WORD LABEL";
            this.wordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxContainer
            // 
            this.textBoxContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxContainer.AutoSize = true;
            this.textBoxContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.textBoxContainer.Location = new System.Drawing.Point(332, 96);
            this.textBoxContainer.Name = "textBoxContainer";
            this.textBoxContainer.Size = new System.Drawing.Size(0, 0);
            this.textBoxContainer.TabIndex = 5;
            // 
            // lblHint1
            // 
            this.lblHint1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.lblHint1.AutoSize = true;
            this.lblHint1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint1.Location = new System.Drawing.Point(373, 231);
            this.lblHint1.Name = "lblHint1";
            this.lblHint1.Size = new System.Drawing.Size(0, 32);
            this.lblHint1.TabIndex = 6;
            this.lblHint1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHint2
            // 
            this.lblHint2.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.lblHint2.AutoSize = true;
            this.lblHint2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint2.Location = new System.Drawing.Point(373, 304);
            this.lblHint2.Name = "lblHint2";
            this.lblHint2.Size = new System.Drawing.Size(105, 32);
            this.lblHint2.TabIndex = 7;
            this.lblHint2.Text = "Hint #2";
            this.lblHint2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHint3
            // 
            this.lblHint3.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.lblHint3.AutoSize = true;
            this.lblHint3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint3.Location = new System.Drawing.Point(373, 370);
            this.lblHint3.Name = "lblHint3";
            this.lblHint3.Size = new System.Drawing.Size(105, 32);
            this.lblHint3.TabIndex = 8;
            this.lblHint3.Text = "Hint #3";
            this.lblHint3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lettersContainer
            // 
            this.lettersContainer.AutoSize = true;
            this.lettersContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lettersContainer.Controls.Add(this.wordLabel);
            this.lettersContainer.Location = new System.Drawing.Point(332, 12);
            this.lettersContainer.Name = "lettersContainer";
            this.lettersContainer.Size = new System.Drawing.Size(205, 32);
            this.lettersContainer.TabIndex = 10;
            // 
            // lblPointsPos
            // 
            this.lblPointsPos.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.lblPointsPos.AutoSize = true;
            this.lblPointsPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointsPos.Location = new System.Drawing.Point(347, 427);
            this.lblPointsPos.Name = "lblPointsPos";
            this.lblPointsPos.Size = new System.Drawing.Size(156, 25);
            this.lblPointsPos.TabIndex = 11;
            this.lblPointsPos.Text = "Points Possible: ";
            this.lblPointsPos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPointsPos.Click += new System.EventHandler(this.lblPointsPos_Click);
            // 
            // lblCurrentPoints
            // 
            this.lblCurrentPoints.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.lblCurrentPoints.AutoSize = true;
            this.lblCurrentPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPoints.Location = new System.Drawing.Point(354, 465);
            this.lblCurrentPoints.Name = "lblCurrentPoints";
            this.lblCurrentPoints.Size = new System.Drawing.Size(142, 25);
            this.lblCurrentPoints.TabIndex = 12;
            this.lblCurrentPoints.Text = "CurrentPoints: ";
            this.lblCurrentPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCurrentPoints.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbDifficulty
            // 
            this.cbDifficulty.AutoSize = true;
            this.cbDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDifficulty.Location = new System.Drawing.Point(683, 546);
            this.cbDifficulty.Name = "cbDifficulty";
            this.cbDifficulty.Size = new System.Drawing.Size(155, 33);
            this.cbDifficulty.TabIndex = 13;
            this.cbDifficulty.Text = "Hard Mode";
            this.cbDifficulty.UseVisualStyleBackColor = true;
            this.cbDifficulty.CheckedChanged += new System.EventHandler(this.cbDifficulty_CheckedChanged);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 591);
            this.Controls.Add(this.cbDifficulty);
            this.Controls.Add(this.lblCurrentPoints);
            this.Controls.Add(this.lblPointsPos);
            this.Controls.Add(this.lettersContainer);
            this.Controls.Add(this.lblHint3);
            this.Controls.Add(this.lblHint2);
            this.Controls.Add(this.lblHint1);
            this.Controls.Add(this.textBoxContainer);
            this.Controls.Add(this.btnGo);
            this.Name = "MainFrame";
            this.Text = "Word Game";
            this.lettersContainer.ResumeLayout(false);
            this.lettersContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label wordLabel;
        private System.Windows.Forms.FlowLayoutPanel textBoxContainer;
        private System.Windows.Forms.Label lblHint1;
        private System.Windows.Forms.Label lblHint2;
        private System.Windows.Forms.Label lblHint3;
        private System.Windows.Forms.FlowLayoutPanel lettersContainer;
        private System.Windows.Forms.Label lblPointsPos;
        private System.Windows.Forms.Label lblCurrentPoints;
        public System.Windows.Forms.CheckBox cbDifficulty;
    }
}

