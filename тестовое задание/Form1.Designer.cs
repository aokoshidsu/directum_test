namespace тестовое_задание
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
            this.minWordCount = new System.Windows.Forms.NumericUpDown();
            this.maxWordCount = new System.Windows.Forms.NumericUpDown();
            this.textMin = new System.Windows.Forms.Label();
            this.textMax = new System.Windows.Forms.Label();
            this.cntFiles = new System.Windows.Forms.NumericUpDown();
            this.fileCount = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.generate = new System.Windows.Forms.Button();
            this.folderShower = new System.Windows.Forms.TextBox();
            this.folderSearcher = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.minWordCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxWordCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cntFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // minWordCount
            // 
            this.minWordCount.Location = new System.Drawing.Point(229, 109);
            this.minWordCount.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minWordCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minWordCount.Name = "minWordCount";
            this.minWordCount.Size = new System.Drawing.Size(117, 20);
            this.minWordCount.TabIndex = 0;
            this.minWordCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // maxWordCount
            // 
            this.maxWordCount.Location = new System.Drawing.Point(229, 150);
            this.maxWordCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.maxWordCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxWordCount.Name = "maxWordCount";
            this.maxWordCount.Size = new System.Drawing.Size(117, 20);
            this.maxWordCount.TabIndex = 1;
            this.maxWordCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textMin
            // 
            this.textMin.AutoSize = true;
            this.textMin.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textMin.Location = new System.Drawing.Point(64, 116);
            this.textMin.Name = "textMin";
            this.textMin.Size = new System.Drawing.Size(145, 14);
            this.textMin.TabIndex = 2;
            this.textMin.Text = "Минимальное кол-во слов";
            // 
            // textMax
            // 
            this.textMax.AutoSize = true;
            this.textMax.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textMax.Location = new System.Drawing.Point(64, 157);
            this.textMax.Name = "textMax";
            this.textMax.Size = new System.Drawing.Size(150, 14);
            this.textMax.TabIndex = 3;
            this.textMax.Text = "Максимальное кол-во слов";
            // 
            // cntFiles
            // 
            this.cntFiles.Location = new System.Drawing.Point(229, 195);
            this.cntFiles.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cntFiles.Name = "cntFiles";
            this.cntFiles.Size = new System.Drawing.Size(117, 20);
            this.cntFiles.TabIndex = 4;
            this.cntFiles.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // fileCount
            // 
            this.fileCount.AutoSize = true;
            this.fileCount.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileCount.Location = new System.Drawing.Point(64, 197);
            this.fileCount.Name = "fileCount";
            this.fileCount.Size = new System.Drawing.Size(160, 14);
            this.fileCount.TabIndex = 5;
            this.fileCount.Text = "Кол-во нужных .docx файлов";
            // 
            // generate
            // 
            this.generate.BackColor = System.Drawing.Color.Black;
            this.generate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.generate.FlatAppearance.BorderSize = 0;
            this.generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generate.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generate.ForeColor = System.Drawing.Color.LemonChiffon;
            this.generate.Location = new System.Drawing.Point(64, 240);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(282, 37);
            this.generate.TabIndex = 6;
            this.generate.Text = "Сгенерировать!";
            this.generate.UseVisualStyleBackColor = false;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // folderShower
            // 
            this.folderShower.Enabled = false;
            this.folderShower.ForeColor = System.Drawing.Color.LightGray;
            this.folderShower.Location = new System.Drawing.Point(64, 69);
            this.folderShower.Name = "folderShower";
            this.folderShower.Size = new System.Drawing.Size(184, 20);
            this.folderShower.TabIndex = 7;
            this.folderShower.Text = "Здесь будет путь до вашей папки";
            // 
            // folderSearcher
            // 
            this.folderSearcher.BackColor = System.Drawing.Color.White;
            this.folderSearcher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.folderSearcher.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.folderSearcher.Location = new System.Drawing.Point(254, 68);
            this.folderSearcher.Name = "folderSearcher";
            this.folderSearcher.Size = new System.Drawing.Size(92, 23);
            this.folderSearcher.TabIndex = 8;
            this.folderSearcher.Text = "Выбор папки...";
            this.folderSearcher.UseVisualStyleBackColor = false;
            this.folderSearcher.Click += new System.EventHandler(this.folderSearcher_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(31, 15);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(364, 33);
            this.title.TabIndex = 9;
            this.title.Text = "Генератор текстовых файлов";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(423, 300);
            this.Controls.Add(this.title);
            this.Controls.Add(this.folderSearcher);
            this.Controls.Add(this.folderShower);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.fileCount);
            this.Controls.Add(this.cntFiles);
            this.Controls.Add(this.textMax);
            this.Controls.Add(this.textMin);
            this.Controls.Add(this.maxWordCount);
            this.Controls.Add(this.minWordCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minWordCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxWordCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cntFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown minWordCount;
        private System.Windows.Forms.NumericUpDown maxWordCount;
        private System.Windows.Forms.Label textMin;
        private System.Windows.Forms.Label textMax;
        private System.Windows.Forms.NumericUpDown cntFiles;
        private System.Windows.Forms.Label fileCount;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.TextBox folderShower;
        private System.Windows.Forms.Button folderSearcher;
        private System.Windows.Forms.Label title;
    }
}

