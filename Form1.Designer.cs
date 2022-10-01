
namespace Calculator
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
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonPercent = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonZnak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOne
            // 
            this.buttonOne.Location = new System.Drawing.Point(12, 240);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(51, 51);
            this.buttonOne.TabIndex = 0;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = true;
            this.buttonOne.Click += new System.EventHandler(this.buttonOne_Click);
            // 
            // buttonTwo
            // 
            this.buttonTwo.Location = new System.Drawing.Point(69, 240);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(51, 51);
            this.buttonTwo.TabIndex = 1;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = true;
            this.buttonTwo.Click += new System.EventHandler(this.buttonTwo_Click);
            // 
            // buttonThree
            // 
            this.buttonThree.Location = new System.Drawing.Point(126, 240);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(51, 51);
            this.buttonThree.TabIndex = 2;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = true;
            this.buttonThree.Click += new System.EventHandler(this.buttonThree_Click);
            // 
            // buttonFour
            // 
            this.buttonFour.Location = new System.Drawing.Point(12, 183);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(51, 51);
            this.buttonFour.TabIndex = 3;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = true;
            this.buttonFour.Click += new System.EventHandler(this.buttonFour_Click);
            // 
            // buttonFive
            // 
            this.buttonFive.Location = new System.Drawing.Point(69, 183);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(51, 51);
            this.buttonFive.TabIndex = 4;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = true;
            this.buttonFive.Click += new System.EventHandler(this.buttonFive_Click);
            // 
            // buttonSix
            // 
            this.buttonSix.Location = new System.Drawing.Point(126, 183);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(51, 51);
            this.buttonSix.TabIndex = 5;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = true;
            this.buttonSix.Click += new System.EventHandler(this.buttonSix_Click);
            // 
            // buttonSeven
            // 
            this.buttonSeven.Location = new System.Drawing.Point(12, 126);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(51, 51);
            this.buttonSeven.TabIndex = 6;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = true;
            this.buttonSeven.Click += new System.EventHandler(this.buttonSeven_Click);
            // 
            // buttonEight
            // 
            this.buttonEight.Location = new System.Drawing.Point(69, 126);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(51, 51);
            this.buttonEight.TabIndex = 7;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = true;
            this.buttonEight.Click += new System.EventHandler(this.buttonEight_Click);
            // 
            // buttonNine
            // 
            this.buttonNine.Location = new System.Drawing.Point(126, 126);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(51, 51);
            this.buttonNine.TabIndex = 8;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = true;
            this.buttonNine.Click += new System.EventHandler(this.buttonNine_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 51);
            this.textBox1.TabIndex = 9;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 69);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(51, 51);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(69, 69);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(51, 51);
            this.buttonDel.TabIndex = 12;
            this.buttonDel.Text = "<-";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonPercent
            // 
            this.buttonPercent.Location = new System.Drawing.Point(126, 69);
            this.buttonPercent.Name = "buttonPercent";
            this.buttonPercent.Size = new System.Drawing.Size(51, 51);
            this.buttonPercent.TabIndex = 13;
            this.buttonPercent.Text = "%";
            this.buttonPercent.UseVisualStyleBackColor = true;
            this.buttonPercent.Click += new System.EventHandler(this.buttonPercent_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(183, 69);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(51, 51);
            this.buttonPlus.TabIndex = 14;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(183, 126);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(51, 51);
            this.buttonMinus.TabIndex = 15;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(183, 183);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(51, 51);
            this.buttonMultiply.TabIndex = 16;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Location = new System.Drawing.Point(183, 240);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(51, 51);
            this.buttonDivide.TabIndex = 17;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // buttonZero
            // 
            this.buttonZero.Location = new System.Drawing.Point(12, 297);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(51, 51);
            this.buttonZero.TabIndex = 18;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = true;
            this.buttonZero.Click += new System.EventHandler(this.buttonZero_Click);
            // 
            // buttonPoint
            // 
            this.buttonPoint.Location = new System.Drawing.Point(126, 297);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(51, 51);
            this.buttonPoint.TabIndex = 19;
            this.buttonPoint.Text = ".";
            this.buttonPoint.UseVisualStyleBackColor = true;
            this.buttonPoint.Click += new System.EventHandler(this.buttonPoint_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(183, 297);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(51, 51);
            this.buttonResult.TabIndex = 20;
            this.buttonResult.Text = "=";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 21;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonZnak
            // 
            this.buttonZnak.Location = new System.Drawing.Point(69, 297);
            this.buttonZnak.Name = "buttonZnak";
            this.buttonZnak.Size = new System.Drawing.Size(51, 51);
            this.buttonZnak.TabIndex = 22;
            this.buttonZnak.Text = "+ or -";
            this.buttonZnak.UseVisualStyleBackColor = true;
            this.buttonZnak.Click += new System.EventHandler(this.buttonZnak_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 358);
            this.Controls.Add(this.buttonZnak);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.buttonPoint);
            this.Controls.Add(this.buttonZero);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonPercent);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonNine);
            this.Controls.Add(this.buttonEight);
            this.Controls.Add(this.buttonSeven);
            this.Controls.Add(this.buttonSix);
            this.Controls.Add(this.buttonFive);
            this.Controls.Add(this.buttonFour);
            this.Controls.Add(this.buttonThree);
            this.Controls.Add(this.buttonTwo);
            this.Controls.Add(this.buttonOne);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.Button buttonNine;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonPercent;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Button buttonPoint;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonZnak;
    }
}

