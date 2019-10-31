namespace GUI_WindowsForms
{
    partial class FormTraining
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
            this.btnStartTraining = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudTrainingIterations = new System.Windows.Forms.NumericUpDown();
            this.lblPL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDE = new System.Windows.Forms.TextBox();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblVocPath = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnL4 = new System.Windows.Forms.Button();
            this.btnL3 = new System.Windows.Forms.Button();
            this.btnL2 = new System.Windows.Forms.Button();
            this.btnL1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrainingIterations)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartTraining
            // 
            this.btnStartTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStartTraining.Location = new System.Drawing.Point(15, 70);
            this.btnStartTraining.Name = "btnStartTraining";
            this.btnStartTraining.Size = new System.Drawing.Size(173, 40);
            this.btnStartTraining.TabIndex = 0;
            this.btnStartTraining.Text = "Rozpocznij trening";
            this.btnStartTraining.UseVisualStyleBackColor = true;
            this.btnStartTraining.Click += new System.EventHandler(this.btnStartTraining_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "l. powtórzeń";
            // 
            // nudTrainingIterations
            // 
            this.nudTrainingIterations.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudTrainingIterations.Location = new System.Drawing.Point(96, 36);
            this.nudTrainingIterations.Name = "nudTrainingIterations";
            this.nudTrainingIterations.Size = new System.Drawing.Size(91, 20);
            this.nudTrainingIterations.TabIndex = 2;
            this.nudTrainingIterations.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblPL
            // 
            this.lblPL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPL.Location = new System.Drawing.Point(269, 42);
            this.lblPL.Name = "lblPL";
            this.lblPL.Size = new System.Drawing.Size(184, 23);
            this.lblPL.TabIndex = 3;
            this.lblPL.Text = "[PL]:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(269, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "[DE]:";
            // 
            // txtDE
            // 
            this.txtDE.Location = new System.Drawing.Point(314, 94);
            this.txtDE.Name = "txtDE";
            this.txtDE.Size = new System.Drawing.Size(139, 20);
            this.txtDE.TabIndex = 5;
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCorrect.Location = new System.Drawing.Point(507, 94);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(127, 20);
            this.lblCorrect.TabIndex = 6;
            this.lblCorrect.Text = "Poprawność: 0%";
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNext.Location = new System.Drawing.Point(272, 178);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(181, 41);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Następny";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblVocPath
            // 
            this.lblVocPath.AutoSize = true;
            this.lblVocPath.Location = new System.Drawing.Point(272, 13);
            this.lblVocPath.Name = "lblVocPath";
            this.lblVocPath.Size = new System.Drawing.Size(95, 13);
            this.lblVocPath.TabIndex = 8;
            this.lblVocPath.Text = "ścieżka słownika: ";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLast.Location = new System.Drawing.Point(507, 57);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(64, 20);
            this.lblLast.TabIndex = 9;
            this.lblLast.Text = "Ostatni:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(395, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "ß";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnLetter_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(368, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "ü";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnLetter_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(341, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "ö";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnLetter_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(314, 149);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(21, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "ä";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnLetter_Click);
            // 
            // btnL4
            // 
            this.btnL4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnL4.Location = new System.Drawing.Point(395, 120);
            this.btnL4.Name = "btnL4";
            this.btnL4.Size = new System.Drawing.Size(21, 23);
            this.btnL4.TabIndex = 18;
            this.btnL4.Text = "ß";
            this.btnL4.UseVisualStyleBackColor = true;
            this.btnL4.Click += new System.EventHandler(this.btnLetter_Click);
            // 
            // btnL3
            // 
            this.btnL3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnL3.Location = new System.Drawing.Point(368, 120);
            this.btnL3.Name = "btnL3";
            this.btnL3.Size = new System.Drawing.Size(21, 23);
            this.btnL3.TabIndex = 17;
            this.btnL3.Text = "Ü";
            this.btnL3.UseVisualStyleBackColor = true;
            this.btnL3.Click += new System.EventHandler(this.btnLetter_Click);
            // 
            // btnL2
            // 
            this.btnL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnL2.Location = new System.Drawing.Point(341, 120);
            this.btnL2.Name = "btnL2";
            this.btnL2.Size = new System.Drawing.Size(21, 23);
            this.btnL2.TabIndex = 16;
            this.btnL2.Text = "Ö";
            this.btnL2.UseVisualStyleBackColor = true;
            this.btnL2.Click += new System.EventHandler(this.btnLetter_Click);
            // 
            // btnL1
            // 
            this.btnL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnL1.Location = new System.Drawing.Point(314, 120);
            this.btnL1.Name = "btnL1";
            this.btnL1.Size = new System.Drawing.Size(21, 23);
            this.btnL1.TabIndex = 15;
            this.btnL1.Text = "Ä";
            this.btnL1.UseVisualStyleBackColor = true;
            this.btnL1.Click += new System.EventHandler(this.btnLetter_Click);
            // 
            // FormTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 248);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnL4);
            this.Controls.Add(this.btnL3);
            this.Controls.Add(this.btnL2);
            this.Controls.Add(this.btnL1);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblVocPath);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.txtDE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPL);
            this.Controls.Add(this.nudTrainingIterations);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartTraining);
            this.MaximumSize = new System.Drawing.Size(1000, 500);
            this.MinimumSize = new System.Drawing.Size(832, 226);
            this.Name = "FormTraining";
            this.Text = "German Vocabulary Trainer (autor: Marek Dzięcioł) ";
            this.Load += new System.EventHandler(this.FormTraining_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTrainingIterations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartTraining;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudTrainingIterations;
        private System.Windows.Forms.Label lblPL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDE;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblVocPath;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnL4;
        private System.Windows.Forms.Button btnL3;
        private System.Windows.Forms.Button btnL2;
        private System.Windows.Forms.Button btnL1;
    }
}

