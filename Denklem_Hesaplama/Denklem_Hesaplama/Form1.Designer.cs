namespace Denklem_Hesaplama
{
    partial class Form1
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelf1 = new System.Windows.Forms.Label();
            this.labelf2 = new System.Windows.Forms.Label();
            this.labelG = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown1.Location = new System.Drawing.Point(34, 37);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Diziyi Random Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(32, 100);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(43, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dizinin Boyutu:";
            // 
            // labelf1
            // 
            this.labelf1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelf1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelf1.Location = new System.Drawing.Point(158, 112);
            this.labelf1.Name = "labelf1";
            this.labelf1.Size = new System.Drawing.Size(118, 19);
            this.labelf1.TabIndex = 4;
            this.labelf1.Text = "F1:";
            // 
            // labelf2
            // 
            this.labelf2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelf2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelf2.Location = new System.Drawing.Point(158, 136);
            this.labelf2.Name = "labelf2";
            this.labelf2.Size = new System.Drawing.Size(118, 20);
            this.labelf2.TabIndex = 5;
            this.labelf2.Text = "F2:";
            // 
            // labelG
            // 
            this.labelG.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelG.Location = new System.Drawing.Point(158, 161);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(118, 19);
            this.labelG.TabIndex = 6;
            this.labelG.Text = "G:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(315, 248);
            this.Controls.Add(this.labelG);
            this.Controls.Add(this.labelf2);
            this.Controls.Add(this.labelf1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Form1";
            this.Text = "Denklem";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelf1;
        private System.Windows.Forms.Label labelf2;
        private System.Windows.Forms.Label labelG;
    }
}

