namespace EnDecrypt
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
            this.txtText = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnShannon = new System.Windows.Forms.Button();
            this.btnHuffman = new System.Windows.Forms.Button();
            this.btnHuffDecrypt = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtShannon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChars = new System.Windows.Forms.Button();
            this.grpSave = new System.Windows.Forms.GroupBox();
            this.radioHuffmanSave = new System.Windows.Forms.RadioButton();
            this.radioShannonSave = new System.Windows.Forms.RadioButton();
            this.radioText = new System.Windows.Forms.RadioButton();
            this.groupLoad = new System.Windows.Forms.GroupBox();
            this.radioHuffman = new System.Windows.Forms.RadioButton();
            this.radiotxtLoad = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHuffman = new System.Windows.Forms.TextBox();
            this.listBoxShannon = new System.Windows.Forms.ListBox();
            this.listBoxHuffman = new System.Windows.Forms.ListBox();
            this.ShannonAvg = new System.Windows.Forms.Label();
            this.ShannonEffect = new System.Windows.Forms.Label();
            this.HuffmanEffect = new System.Windows.Forms.Label();
            this.HuffmanAvg = new System.Windows.Forms.Label();
            this.Entropy = new System.Windows.Forms.Label();
            this.richHuffman = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpSave.SuspendLayout();
            this.groupLoad.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(133, 28);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(499, 20);
            this.txtText.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(25, 104);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 48);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnShannon
            // 
            this.btnShannon.Location = new System.Drawing.Point(176, 593);
            this.btnShannon.Name = "btnShannon";
            this.btnShannon.Size = new System.Drawing.Size(87, 48);
            this.btnShannon.TabIndex = 2;
            this.btnShannon.Text = "Кодування Шеннона-Фано";
            this.btnShannon.UseVisualStyleBackColor = true;
            this.btnShannon.Click += new System.EventHandler(this.btnShannon_Click);
            // 
            // btnHuffman
            // 
            this.btnHuffman.Location = new System.Drawing.Point(283, 593);
            this.btnHuffman.Name = "btnHuffman";
            this.btnHuffman.Size = new System.Drawing.Size(89, 48);
            this.btnHuffman.TabIndex = 3;
            this.btnHuffman.Text = "Кодування Хаффмана";
            this.btnHuffman.UseVisualStyleBackColor = true;
            this.btnHuffman.Click += new System.EventHandler(this.btnHuffman_Click);
            // 
            // btnHuffDecrypt
            // 
            this.btnHuffDecrypt.Enabled = false;
            this.btnHuffDecrypt.Location = new System.Drawing.Point(394, 593);
            this.btnHuffDecrypt.Name = "btnHuffDecrypt";
            this.btnHuffDecrypt.Size = new System.Drawing.Size(75, 48);
            this.btnHuffDecrypt.TabIndex = 4;
            this.btnHuffDecrypt.Text = "Декодування Хаффмана";
            this.btnHuffDecrypt.UseVisualStyleBackColor = true;
            this.btnHuffDecrypt.Click += new System.EventHandler(this.btnHuffDecrypt_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(24, 103);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 48);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtShannon
            // 
            this.txtShannon.Location = new System.Drawing.Point(133, 75);
            this.txtShannon.Multiline = true;
            this.txtShannon.Name = "txtShannon";
            this.txtShannon.Size = new System.Drawing.Size(188, 110);
            this.txtShannon.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Текст: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Код Шеннона-Фано:";
            // 
            // btnChars
            // 
            this.btnChars.Enabled = false;
            this.btnChars.Location = new System.Drawing.Point(495, 593);
            this.btnChars.Name = "btnChars";
            this.btnChars.Size = new System.Drawing.Size(86, 48);
            this.btnChars.TabIndex = 9;
            this.btnChars.Text = "Головні характеристики";
            this.btnChars.UseVisualStyleBackColor = true;
            this.btnChars.Click += new System.EventHandler(this.btnChars_Click);
            // 
            // grpSave
            // 
            this.grpSave.Controls.Add(this.radioHuffmanSave);
            this.grpSave.Controls.Add(this.radioShannonSave);
            this.grpSave.Controls.Add(this.radioText);
            this.grpSave.Controls.Add(this.btnSave);
            this.grpSave.Location = new System.Drawing.Point(622, 484);
            this.grpSave.Name = "grpSave";
            this.grpSave.Size = new System.Drawing.Size(125, 157);
            this.grpSave.TabIndex = 10;
            this.grpSave.TabStop = false;
            // 
            // radioHuffmanSave
            // 
            this.radioHuffmanSave.AutoSize = true;
            this.radioHuffmanSave.Location = new System.Drawing.Point(24, 66);
            this.radioHuffmanSave.Name = "radioHuffmanSave";
            this.radioHuffmanSave.Size = new System.Drawing.Size(102, 17);
            this.radioHuffmanSave.TabIndex = 8;
            this.radioHuffmanSave.TabStop = true;
            this.radioHuffmanSave.Text = "Код Хаффмана";
            this.radioHuffmanSave.UseVisualStyleBackColor = true;
            // 
            // radioShannonSave
            // 
            this.radioShannonSave.AutoSize = true;
            this.radioShannonSave.Location = new System.Drawing.Point(24, 42);
            this.radioShannonSave.Name = "radioShannonSave";
            this.radioShannonSave.Size = new System.Drawing.Size(92, 17);
            this.radioShannonSave.TabIndex = 7;
            this.radioShannonSave.TabStop = true;
            this.radioShannonSave.Text = "Код Шеннона";
            this.radioShannonSave.UseVisualStyleBackColor = true;
            // 
            // radioText
            // 
            this.radioText.AutoSize = true;
            this.radioText.Checked = true;
            this.radioText.Location = new System.Drawing.Point(24, 19);
            this.radioText.Name = "radioText";
            this.radioText.Size = new System.Drawing.Size(55, 17);
            this.radioText.TabIndex = 6;
            this.radioText.TabStop = true;
            this.radioText.Text = "Текст";
            this.radioText.UseVisualStyleBackColor = true;
            // 
            // groupLoad
            // 
            this.groupLoad.Controls.Add(this.radioHuffman);
            this.groupLoad.Controls.Add(this.radiotxtLoad);
            this.groupLoad.Controls.Add(this.btnLoad);
            this.groupLoad.Location = new System.Drawing.Point(24, 483);
            this.groupLoad.Name = "groupLoad";
            this.groupLoad.Size = new System.Drawing.Size(127, 158);
            this.groupLoad.TabIndex = 11;
            this.groupLoad.TabStop = false;
            // 
            // radioHuffman
            // 
            this.radioHuffman.AutoSize = true;
            this.radioHuffman.Location = new System.Drawing.Point(25, 57);
            this.radioHuffman.Name = "radioHuffman";
            this.radioHuffman.Size = new System.Drawing.Size(102, 17);
            this.radioHuffman.TabIndex = 4;
            this.radioHuffman.TabStop = true;
            this.radioHuffman.Text = "Код Хаффмана";
            this.radioHuffman.UseVisualStyleBackColor = true;
            // 
            // radiotxtLoad
            // 
            this.radiotxtLoad.AutoSize = true;
            this.radiotxtLoad.Checked = true;
            this.radiotxtLoad.Location = new System.Drawing.Point(25, 34);
            this.radiotxtLoad.Name = "radiotxtLoad";
            this.radiotxtLoad.Size = new System.Drawing.Size(55, 17);
            this.radiotxtLoad.TabIndex = 2;
            this.radiotxtLoad.TabStop = true;
            this.radiotxtLoad.Text = "Текст";
            this.radiotxtLoad.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Код Хаффмана:";
            // 
            // txtHuffman
            // 
            this.txtHuffman.Location = new System.Drawing.Point(491, 75);
            this.txtHuffman.Multiline = true;
            this.txtHuffman.Name = "txtHuffman";
            this.txtHuffman.Size = new System.Drawing.Size(188, 110);
            this.txtHuffman.TabIndex = 12;
            // 
            // listBoxShannon
            // 
            this.listBoxShannon.FormattingEnabled = true;
            this.listBoxShannon.Location = new System.Drawing.Point(133, 215);
            this.listBoxShannon.Name = "listBoxShannon";
            this.listBoxShannon.Size = new System.Drawing.Size(120, 108);
            this.listBoxShannon.TabIndex = 14;
            // 
            // listBoxHuffman
            // 
            this.listBoxHuffman.FormattingEnabled = true;
            this.listBoxHuffman.Location = new System.Drawing.Point(495, 215);
            this.listBoxHuffman.Name = "listBoxHuffman";
            this.listBoxHuffman.Size = new System.Drawing.Size(120, 108);
            this.listBoxHuffman.TabIndex = 15;
            // 
            // ShannonAvg
            // 
            this.ShannonAvg.AutoSize = true;
            this.ShannonAvg.Location = new System.Drawing.Point(143, 435);
            this.ShannonAvg.Name = "ShannonAvg";
            this.ShannonAvg.Size = new System.Drawing.Size(0, 13);
            this.ShannonAvg.TabIndex = 17;
            // 
            // ShannonEffect
            // 
            this.ShannonEffect.AutoSize = true;
            this.ShannonEffect.Location = new System.Drawing.Point(143, 467);
            this.ShannonEffect.Name = "ShannonEffect";
            this.ShannonEffect.Size = new System.Drawing.Size(0, 13);
            this.ShannonEffect.TabIndex = 18;
            // 
            // HuffmanEffect
            // 
            this.HuffmanEffect.AutoSize = true;
            this.HuffmanEffect.Location = new System.Drawing.Point(505, 467);
            this.HuffmanEffect.Name = "HuffmanEffect";
            this.HuffmanEffect.Size = new System.Drawing.Size(0, 13);
            this.HuffmanEffect.TabIndex = 21;
            // 
            // HuffmanAvg
            // 
            this.HuffmanAvg.AutoSize = true;
            this.HuffmanAvg.Location = new System.Drawing.Point(505, 435);
            this.HuffmanAvg.Name = "HuffmanAvg";
            this.HuffmanAvg.Size = new System.Drawing.Size(0, 13);
            this.HuffmanAvg.TabIndex = 20;
            // 
            // Entropy
            // 
            this.Entropy.AutoSize = true;
            this.Entropy.Location = new System.Drawing.Point(342, 403);
            this.Entropy.Name = "Entropy";
            this.Entropy.Size = new System.Drawing.Size(0, 13);
            this.Entropy.TabIndex = 19;
            // 
            // richHuffman
            // 
            this.richHuffman.Enabled = false;
            this.richHuffman.Location = new System.Drawing.Point(495, 347);
            this.richHuffman.Name = "richHuffman";
            this.richHuffman.Size = new System.Drawing.Size(206, 56);
            this.richHuffman.TabIndex = 22;
            this.richHuffman.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Декодування";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 653);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richHuffman);
            this.Controls.Add(this.HuffmanEffect);
            this.Controls.Add(this.HuffmanAvg);
            this.Controls.Add(this.Entropy);
            this.Controls.Add(this.ShannonEffect);
            this.Controls.Add(this.ShannonAvg);
            this.Controls.Add(this.listBoxHuffman);
            this.Controls.Add(this.listBoxShannon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHuffman);
            this.Controls.Add(this.groupLoad);
            this.Controls.Add(this.grpSave);
            this.Controls.Add(this.btnChars);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtShannon);
            this.Controls.Add(this.btnHuffDecrypt);
            this.Controls.Add(this.btnHuffman);
            this.Controls.Add(this.btnShannon);
            this.Controls.Add(this.txtText);
            this.Name = "Form1";
            this.Text = "En/Decrypt";
            this.grpSave.ResumeLayout(false);
            this.grpSave.PerformLayout();
            this.groupLoad.ResumeLayout(false);
            this.groupLoad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnShannon;
        private System.Windows.Forms.Button btnHuffman;
        private System.Windows.Forms.Button btnHuffDecrypt;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtShannon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChars;
        private System.Windows.Forms.GroupBox grpSave;
        private System.Windows.Forms.RadioButton radioShannonSave;
        private System.Windows.Forms.RadioButton radioText;
        private System.Windows.Forms.GroupBox groupLoad;
        private System.Windows.Forms.RadioButton radiotxtLoad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHuffman;
        private System.Windows.Forms.ListBox listBoxShannon;
        private System.Windows.Forms.ListBox listBoxHuffman;
        private System.Windows.Forms.Label ShannonAvg;
        private System.Windows.Forms.Label ShannonEffect;
        private System.Windows.Forms.Label HuffmanEffect;
        private System.Windows.Forms.Label HuffmanAvg;
        private System.Windows.Forms.Label Entropy;
        private System.Windows.Forms.RadioButton radioHuffman;
        private System.Windows.Forms.RadioButton radioHuffmanSave;
        private System.Windows.Forms.RichTextBox richHuffman;
        private System.Windows.Forms.Label label4;
    }
}

