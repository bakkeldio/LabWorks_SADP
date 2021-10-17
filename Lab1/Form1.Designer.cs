
namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Result = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.secondNumber = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.operationSign = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Result.Location = new System.Drawing.Point(341, 289);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(150, 34);
            this.Result.TabIndex = 2;
            this.Result.Text = " Итого";
            this.Result.UseVisualStyleBackColor = true;
            this.Result.Click += new System.EventHandler(this.show_result);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Первое число";
            // 
            // firstNumber
            // 
            this.firstNumber.Location = new System.Drawing.Point(341, 111);
            this.firstNumber.Name = "firstNumber";
            this.firstNumber.Size = new System.Drawing.Size(150, 23);
            this.firstNumber.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Второе число";
            // 
            // secondNumber
            // 
            this.secondNumber.Location = new System.Drawing.Point(341, 183);
            this.secondNumber.Name = "secondNumber";
            this.secondNumber.Size = new System.Drawing.Size(150, 23);
            this.secondNumber.TabIndex = 6;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(341, 342);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(150, 23);
            this.resultTextBox.TabIndex = 10;
            // 
            // operationSign
            // 
            this.operationSign.Location = new System.Drawing.Point(341, 246);
            this.operationSign.Name = "operationSign";
            this.operationSign.Size = new System.Drawing.Size(150, 23);
            this.operationSign.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Знак операции";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(876, 504);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.operationSign);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.secondNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Result);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox secondNumber;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.TextBox operationSign;
        private System.Windows.Forms.Label label3;
    }
}

