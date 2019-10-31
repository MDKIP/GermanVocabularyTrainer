namespace GUI_WindowsForms
{
    partial class FormAddWord
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
            this.lblPath = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPLVal = new System.Windows.Forms.TextBox();
            this.txtDEVal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.btnL1 = new System.Windows.Forms.Button();
            this.btnL2 = new System.Windows.Forms.Button();
            this.btnL3 = new System.Windows.Forms.Button();
            this.btnL4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPath.Location = new System.Drawing.Point(94, 14);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(94, 13);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "Ścieżka słownika:";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(13, 9);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "Zmień";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wartość PL";
            // 
            // txtPLVal
            // 
            this.txtPLVal.Location = new System.Drawing.Point(97, 50);
            this.txtPLVal.Name = "txtPLVal";
            this.txtPLVal.Size = new System.Drawing.Size(169, 20);
            this.txtPLVal.TabIndex = 3;
            // 
            // txtDEVal
            // 
            this.txtDEVal.Location = new System.Drawing.Point(356, 50);
            this.txtDEVal.Name = "txtDEVal";
            this.txtDEVal.Size = new System.Drawing.Size(169, 20);
            this.txtDEVal.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(272, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Wartość DE";
            // 
            // btnAddWord
            // 
            this.btnAddWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddWord.Location = new System.Drawing.Point(13, 100);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(189, 36);
            this.btnAddWord.TabIndex = 6;
            this.btnAddWord.Text = "Dodaj";
            this.btnAddWord.UseVisualStyleBackColor = true;
            this.btnAddWord.Click += new System.EventHandler(this.btnAddWord_Click);
            // 
            // btnL1
            // 
            this.btnL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnL1.Location = new System.Drawing.Point(356, 77);
            this.btnL1.Name = "btnL1";
            this.btnL1.Size = new System.Drawing.Size(21, 23);
            this.btnL1.TabIndex = 7;
            this.btnL1.Text = "Ä";
            this.btnL1.UseVisualStyleBackColor = true;
            this.btnL1.Click += new System.EventHandler(this.btnLetter_Click);
            // 
            // btnL2
            // 
            this.btnL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnL2.Location = new System.Drawing.Point(383, 77);
            this.btnL2.Name = "btnL2";
            this.btnL2.Size = new System.Drawing.Size(21, 23);
            this.btnL2.TabIndex = 8;
            this.btnL2.Text = "Ö";
            this.btnL2.UseVisualStyleBackColor = true;
            this.btnL2.Click += new System.EventHandler(this.btnLetter_Click);
            // 
            // btnL3
            // 
            this.btnL3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnL3.Location = new System.Drawing.Point(410, 77);
            this.btnL3.Name = "btnL3";
            this.btnL3.Size = new System.Drawing.Size(21, 23);
            this.btnL3.TabIndex = 9;
            this.btnL3.Text = "Ü";
            this.btnL3.UseVisualStyleBackColor = true;
            this.btnL3.Click += new System.EventHandler(this.btnLetter_Click);
            // 
            // btnL4
            // 
            this.btnL4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnL4.Location = new System.Drawing.Point(437, 77);
            this.btnL4.Name = "btnL4";
            this.btnL4.Size = new System.Drawing.Size(21, 23);
            this.btnL4.TabIndex = 10;
            this.btnL4.Text = "ß";
            this.btnL4.UseVisualStyleBackColor = true;
            this.btnL4.Click += new System.EventHandler(this.btnLetter_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(437, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "ß";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnLetter_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(410, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "ü";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnLetter_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(383, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "ö";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnLetter_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(356, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(21, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "ä";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnLetter_Click);
            // 
            // FormAddWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 148);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnL4);
            this.Controls.Add(this.btnL3);
            this.Controls.Add(this.btnL2);
            this.Controls.Add(this.btnL1);
            this.Controls.Add(this.btnAddWord);
            this.Controls.Add(this.txtDEVal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPLVal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lblPath);
            this.Name = "FormAddWord";
            this.Text = "Dodaj słowo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPLVal;
        private System.Windows.Forms.TextBox txtDEVal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.Button btnL1;
        private System.Windows.Forms.Button btnL2;
        private System.Windows.Forms.Button btnL3;
        private System.Windows.Forms.Button btnL4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}