namespace StringsFinder
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.chkIgnoreCase = new System.Windows.Forms.CheckBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.btnStartFind = new System.Windows.Forms.Button();
            this.lsbWords = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDirectoryPath = new System.Windows.Forms.TextBox();
            this.lsbFiles = new System.Windows.Forms.ListBox();
            this.btnByDefault = new System.Windows.Forms.Button();
            this.btnChooseDirectory = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkIgnoreCase
            // 
            this.chkIgnoreCase.AutoSize = true;
            this.chkIgnoreCase.Location = new System.Drawing.Point(6, 19);
            this.chkIgnoreCase.Name = "chkIgnoreCase";
            this.chkIgnoreCase.Size = new System.Drawing.Size(124, 17);
            this.chkIgnoreCase.TabIndex = 0;
            this.chkIgnoreCase.Text = "Учитывать регистр";
            this.chkIgnoreCase.UseVisualStyleBackColor = true;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // ofd
            // 
            this.ofd.DefaultExt = "*.txt";
            this.ofd.FileName = "openFileDialog1";
            this.ofd.Filter = "Текстовые файлы|*.txt";
            this.ofd.RestoreDirectory = true;
            // 
            // btnStartFind
            // 
            this.btnStartFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartFind.Location = new System.Drawing.Point(767, 421);
            this.btnStartFind.Name = "btnStartFind";
            this.btnStartFind.Size = new System.Drawing.Size(166, 90);
            this.btnStartFind.TabIndex = 7;
            this.btnStartFind.Text = "Начать поиск";
            this.btnStartFind.UseVisualStyleBackColor = true;
            this.btnStartFind.Click += new System.EventHandler(this.btnStartFind_Click);
            // 
            // lsbWords
            // 
            this.lsbWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbWords.FormattingEnabled = true;
            this.lsbWords.HorizontalScrollbar = true;
            this.lsbWords.Location = new System.Drawing.Point(3, 16);
            this.lsbWords.Name = "lsbWords";
            this.lsbWords.Size = new System.Drawing.Size(459, 290);
            this.lsbWords.TabIndex = 5;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkIgnoreCase);
            this.groupBox5.Location = new System.Drawing.Point(462, 412);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(299, 99);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Настройки";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.btnChooseFile);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtFilePath);
            this.groupBox3.Location = new System.Drawing.Point(462, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(480, 393);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Выбранный файл со словами";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lsbWords);
            this.groupBox4.Location = new System.Drawing.Point(9, 78);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(465, 309);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Слова в файле";
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(305, 23);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(169, 23);
            this.btnChooseFile.TabIndex = 4;
            this.btnChooseFile.Text = "Выбрать файл";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Путь:";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(46, 52);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(406, 20);
            this.txtFilePath.TabIndex = 2;
            this.txtFilePath.Text = "C:\\Users\\LegendarHome\\Desktop\\для_теста\\файл_со_словами\\слова.txt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Путь:";
            // 
            // txtDirectoryPath
            // 
            this.txtDirectoryPath.Location = new System.Drawing.Point(53, 53);
            this.txtDirectoryPath.Name = "txtDirectoryPath";
            this.txtDirectoryPath.Size = new System.Drawing.Size(366, 20);
            this.txtDirectoryPath.TabIndex = 0;
            this.txtDirectoryPath.Text = "C:\\Users\\LegendarHome\\Desktop\\для_теста";
            // 
            // lsbFiles
            // 
            this.lsbFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbFiles.FormattingEnabled = true;
            this.lsbFiles.HorizontalScrollbar = true;
            this.lsbFiles.Location = new System.Drawing.Point(3, 16);
            this.lsbFiles.Name = "lsbFiles";
            this.lsbFiles.Size = new System.Drawing.Size(426, 405);
            this.lsbFiles.TabIndex = 0;
            // 
            // btnByDefault
            // 
            this.btnByDefault.Location = new System.Drawing.Point(153, 24);
            this.btnByDefault.Name = "btnByDefault";
            this.btnByDefault.Size = new System.Drawing.Size(114, 23);
            this.btnByDefault.TabIndex = 4;
            this.btnByDefault.Text = "По умолчанию";
            this.btnByDefault.UseVisualStyleBackColor = true;
            this.btnByDefault.Click += new System.EventHandler(this.btnByDefault_Click);
            // 
            // btnChooseDirectory
            // 
            this.btnChooseDirectory.Location = new System.Drawing.Point(273, 24);
            this.btnChooseDirectory.Name = "btnChooseDirectory";
            this.btnChooseDirectory.Size = new System.Drawing.Size(169, 23);
            this.btnChooseDirectory.TabIndex = 3;
            this.btnChooseDirectory.Text = "Выбрать каталог";
            this.btnChooseDirectory.UseVisualStyleBackColor = true;
            this.btnChooseDirectory.Click += new System.EventHandler(this.btnChooseDirectory_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsbFiles);
            this.groupBox2.Location = new System.Drawing.Point(10, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 424);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Файлы каталога, в которых будет произведен поиск";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnByDefault);
            this.groupBox1.Controls.Add(this.btnChooseDirectory);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDirectoryPath);
            this.groupBox1.Location = new System.Drawing.Point(7, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 509);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Каталог поиска";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 527);
            this.Controls.Add(this.btnStartFind);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск слов в файлах";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkIgnoreCase;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Button btnStartFind;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lsbWords;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnByDefault;
        private System.Windows.Forms.Button btnChooseDirectory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lsbFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDirectoryPath;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.FolderBrowserDialog fbd;
    }
}

