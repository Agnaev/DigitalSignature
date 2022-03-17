namespace DigitalSignature
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.signButton = new System.Windows.Forms.Button();
            this.checkSignButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_p = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_q = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_d = new System.Windows.Forms.TextBox();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.sourceFilePathTextBox = new System.Windows.Forms.TextBox();
            this.signFilePathTextBox = new System.Windows.Forms.TextBox();
            this.sourceFileButton = new System.Windows.Forms.Button();
            this.signFileButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.h0 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.h0)).BeginInit();
            this.SuspendLayout();
            // 
            // signButton
            // 
            this.signButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.signButton.Location = new System.Drawing.Point(32, 272);
            this.signButton.Margin = new System.Windows.Forms.Padding(4);
            this.signButton.Name = "signButton";
            this.signButton.Size = new System.Drawing.Size(276, 59);
            this.signButton.TabIndex = 1;
            this.signButton.Text = "Подписать";
            this.signButton.UseVisualStyleBackColor = true;
            this.signButton.Click += new System.EventHandler(this.ButtonEncrypt_Click);
            // 
            // checkSignButton
            // 
            this.checkSignButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkSignButton.Location = new System.Drawing.Point(713, 272);
            this.checkSignButton.Margin = new System.Windows.Forms.Padding(4);
            this.checkSignButton.Name = "checkSignButton";
            this.checkSignButton.Size = new System.Drawing.Size(276, 59);
            this.checkSignButton.TabIndex = 2;
            this.checkSignButton.Text = "Проверить подлинность подписи";
            this.checkSignButton.UseVisualStyleBackColor = true;
            this.checkSignButton.Click += new System.EventHandler(this.ButtonDecipher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(27, 217);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "p =";
            // 
            // textBox_p
            // 
            this.textBox_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_p.Location = new System.Drawing.Point(76, 213);
            this.textBox_p.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_p.Name = "textBox_p";
            this.textBox_p.Size = new System.Drawing.Size(99, 30);
            this.textBox_p.TabIndex = 4;
            this.textBox_p.Text = "101";
            this.textBox_p.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(176, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "q =";
            // 
            // textBox_q
            // 
            this.textBox_q.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_q.Location = new System.Drawing.Point(225, 213);
            this.textBox_q.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_q.Name = "textBox_q";
            this.textBox_q.Size = new System.Drawing.Size(81, 30);
            this.textBox_q.TabIndex = 6;
            this.textBox_q.Text = "103";
            this.textBox_q.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(91, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Простые числа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(708, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "d =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(857, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "n =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(771, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Секретный ключ";
            // 
            // textBox_d
            // 
            this.textBox_d.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_d.Location = new System.Drawing.Point(757, 213);
            this.textBox_d.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_d.Name = "textBox_d";
            this.textBox_d.Size = new System.Drawing.Size(91, 30);
            this.textBox_d.TabIndex = 11;
            this.textBox_d.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_n
            // 
            this.textBox_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_n.Location = new System.Drawing.Point(907, 213);
            this.textBox_n.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(81, 30);
            this.textBox_n.TabIndex = 12;
            this.textBox_n.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sourceFilePathTextBox
            // 
            this.sourceFilePathTextBox.Enabled = false;
            this.sourceFilePathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.sourceFilePathTextBox.Location = new System.Drawing.Point(16, 27);
            this.sourceFilePathTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sourceFilePathTextBox.Name = "sourceFilePathTextBox";
            this.sourceFilePathTextBox.Size = new System.Drawing.Size(764, 28);
            this.sourceFilePathTextBox.TabIndex = 13;
            // 
            // signFilePathTextBox
            // 
            this.signFilePathTextBox.Enabled = false;
            this.signFilePathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.signFilePathTextBox.Location = new System.Drawing.Point(16, 98);
            this.signFilePathTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.signFilePathTextBox.Name = "signFilePathTextBox";
            this.signFilePathTextBox.Size = new System.Drawing.Size(764, 28);
            this.signFilePathTextBox.TabIndex = 14;
            // 
            // sourceFileButton
            // 
            this.sourceFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.sourceFileButton.Location = new System.Drawing.Point(789, 25);
            this.sourceFileButton.Margin = new System.Windows.Forms.Padding(4);
            this.sourceFileButton.Name = "sourceFileButton";
            this.sourceFileButton.Size = new System.Drawing.Size(200, 36);
            this.sourceFileButton.TabIndex = 15;
            this.sourceFileButton.Text = "Исходный файл";
            this.sourceFileButton.UseVisualStyleBackColor = true;
            this.sourceFileButton.Click += new System.EventHandler(this.SourceFileButton_Click);
            // 
            // signFileButton
            // 
            this.signFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.signFileButton.Location = new System.Drawing.Point(795, 98);
            this.signFileButton.Margin = new System.Windows.Forms.Padding(4);
            this.signFileButton.Name = "signFileButton";
            this.signFileButton.Size = new System.Drawing.Size(200, 37);
            this.signFileButton.TabIndex = 16;
            this.signFileButton.Text = "Файл с подписью";
            this.signFileButton.UseVisualStyleBackColor = true;
            this.signFileButton.Click += new System.EventHandler(this.SignFileButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(385, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "H0 = ";
            // 
            // h0
            // 
            this.h0.Location = new System.Drawing.Point(451, 217);
            this.h0.Name = "h0";
            this.h0.Size = new System.Drawing.Size(120, 22);
            this.h0.TabIndex = 18;
            this.h0.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 358);
            this.Controls.Add(this.h0);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.signFileButton);
            this.Controls.Add(this.sourceFileButton);
            this.Controls.Add(this.signFilePathTextBox);
            this.Controls.Add(this.sourceFilePathTextBox);
            this.Controls.Add(this.textBox_n);
            this.Controls.Add(this.textBox_d);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_q);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_p);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkSignButton);
            this.Controls.Add(this.signButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Digital signature";
            ((System.ComponentModel.ISupportInitialize)(this.h0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signButton;
        private System.Windows.Forms.Button checkSignButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_p;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_q;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_d;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.TextBox sourceFilePathTextBox;
        private System.Windows.Forms.TextBox signFilePathTextBox;
        private System.Windows.Forms.Button sourceFileButton;
        private System.Windows.Forms.Button signFileButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown h0;
    }
}

