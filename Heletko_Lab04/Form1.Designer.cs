namespace Heletko_Lab04
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tEncLabel = new System.Windows.Forms.Label();
            this.tTextLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.kGroupBox = new System.Windows.Forms.GroupBox();
            this.kSizeLabel = new System.Windows.Forms.Label();
            this.kSizeTxtLabel = new System.Windows.Forms.Label();
            this.genButton = new System.Windows.Forms.Button();
            this.sKeyButton = new System.Windows.Forms.Button();
            this.oKeyButton = new System.Windows.Forms.Button();
            this.kPathTextBox = new System.Windows.Forms.TextBox();
            this.kLabel = new System.Windows.Forms.Label();
            this.fGroupBox = new System.Windows.Forms.GroupBox();
            this.sFileButton = new System.Windows.Forms.Button();
            this.oFileButton = new System.Windows.Forms.Button();
            this.sFilePathTextBox = new System.Windows.Forms.TextBox();
            this.oFilePathTextBox = new System.Windows.Forms.TextBox();
            this.saveLabel = new System.Windows.Forms.Label();
            this.openLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.kGroupBox.SuspendLayout();
            this.fGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tEncLabel
            // 
            this.tEncLabel.AutoSize = true;
            this.tEncLabel.Location = new System.Drawing.Point(180, 263);
            this.tEncLabel.Name = "tEncLabel";
            this.tEncLabel.Size = new System.Drawing.Size(55, 13);
            this.tEncLabel.TabIndex = 14;
            this.tEncLabel.Text = "00:00.000";
            // 
            // tTextLabel
            // 
            this.tTextLabel.AutoSize = true;
            this.tTextLabel.Location = new System.Drawing.Point(34, 263);
            this.tTextLabel.Name = "tTextLabel";
            this.tTextLabel.Size = new System.Drawing.Size(132, 13);
            this.tTextLabel.TabIndex = 13;
            this.tTextLabel.Text = "Тривалість шифрування:";
            // 
            // startButton
            // 
            this.startButton.BackgroundImage = global::Heletko_Lab04.Properties.Resources.Play_icon;
            this.startButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.startButton.Location = new System.Drawing.Point(355, 244);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(49, 46);
            this.startButton.TabIndex = 12;
            this.toolTip1.SetToolTip(this.startButton, "Старт");
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click_1);
            // 
            // kGroupBox
            // 
            this.kGroupBox.Controls.Add(this.kSizeLabel);
            this.kGroupBox.Controls.Add(this.kSizeTxtLabel);
            this.kGroupBox.Controls.Add(this.genButton);
            this.kGroupBox.Controls.Add(this.sKeyButton);
            this.kGroupBox.Controls.Add(this.oKeyButton);
            this.kGroupBox.Controls.Add(this.kPathTextBox);
            this.kGroupBox.Controls.Add(this.kLabel);
            this.kGroupBox.Location = new System.Drawing.Point(12, 134);
            this.kGroupBox.Name = "kGroupBox";
            this.kGroupBox.Size = new System.Drawing.Size(408, 104);
            this.kGroupBox.TabIndex = 11;
            this.kGroupBox.TabStop = false;
            this.kGroupBox.Text = "Ключ";
            // 
            // kSizeLabel
            // 
            this.kSizeLabel.AutoSize = true;
            this.kSizeLabel.Location = new System.Drawing.Point(33, 69);
            this.kSizeLabel.Name = "kSizeLabel";
            this.kSizeLabel.Size = new System.Drawing.Size(22, 13);
            this.kSizeLabel.TabIndex = 10;
            this.kSizeLabel.Text = "0 б";
            // 
            // kSizeTxtLabel
            // 
            this.kSizeTxtLabel.AutoSize = true;
            this.kSizeTxtLabel.Location = new System.Drawing.Point(6, 52);
            this.kSizeTxtLabel.Name = "kSizeTxtLabel";
            this.kSizeTxtLabel.Size = new System.Drawing.Size(79, 13);
            this.kSizeTxtLabel.TabIndex = 9;
            this.kSizeTxtLabel.Text = "Розмір ключа:";
            // 
            // genButton
            // 
            this.genButton.BackgroundImage = global::Heletko_Lab04.Properties.Resources.love_key;
            this.genButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.genButton.Location = new System.Drawing.Point(142, 52);
            this.genButton.Name = "genButton";
            this.genButton.Size = new System.Drawing.Size(48, 46);
            this.genButton.TabIndex = 7;
            this.toolTip1.SetToolTip(this.genButton, "Згенерувати ключ");
            this.genButton.UseVisualStyleBackColor = true;
            this.genButton.Click += new System.EventHandler(this.genButton_Click);
            // 
            // sKeyButton
            // 
            this.sKeyButton.BackgroundImage = global::Heletko_Lab04.Properties.Resources.Download_Folder_icon;
            this.sKeyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sKeyButton.Location = new System.Drawing.Point(284, 26);
            this.sKeyButton.Name = "sKeyButton";
            this.sKeyButton.Size = new System.Drawing.Size(48, 46);
            this.sKeyButton.TabIndex = 6;
            this.toolTip1.SetToolTip(this.sKeyButton, "Зберегти ключ");
            this.sKeyButton.UseVisualStyleBackColor = true;
            this.sKeyButton.Click += new System.EventHandler(this.sKeyButton_Click);
            // 
            // oKeyButton
            // 
            this.oKeyButton.BackgroundImage = global::Heletko_Lab04.Properties.Resources.Folder_Heart_icon;
            this.oKeyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.oKeyButton.Location = new System.Drawing.Point(344, 26);
            this.oKeyButton.Name = "oKeyButton";
            this.oKeyButton.Size = new System.Drawing.Size(48, 46);
            this.oKeyButton.TabIndex = 5;
            this.toolTip1.SetToolTip(this.oKeyButton, "Завантажити ключ");
            this.oKeyButton.UseVisualStyleBackColor = true;
            this.oKeyButton.Click += new System.EventHandler(this.oKeyButton_Click);
            // 
            // kPathTextBox
            // 
            this.kPathTextBox.Location = new System.Drawing.Point(70, 28);
            this.kPathTextBox.Name = "kPathTextBox";
            this.kPathTextBox.Size = new System.Drawing.Size(208, 20);
            this.kPathTextBox.TabIndex = 3;
            // 
            // kLabel
            // 
            this.kLabel.AutoSize = true;
            this.kLabel.Location = new System.Drawing.Point(22, 31);
            this.kLabel.Name = "kLabel";
            this.kLabel.Size = new System.Drawing.Size(33, 13);
            this.kLabel.TabIndex = 2;
            this.kLabel.Text = "Ключ";
            // 
            // fGroupBox
            // 
            this.fGroupBox.Controls.Add(this.sFileButton);
            this.fGroupBox.Controls.Add(this.oFileButton);
            this.fGroupBox.Controls.Add(this.sFilePathTextBox);
            this.fGroupBox.Controls.Add(this.oFilePathTextBox);
            this.fGroupBox.Controls.Add(this.saveLabel);
            this.fGroupBox.Controls.Add(this.openLabel);
            this.fGroupBox.Location = new System.Drawing.Point(12, 12);
            this.fGroupBox.Name = "fGroupBox";
            this.fGroupBox.Size = new System.Drawing.Size(408, 116);
            this.fGroupBox.TabIndex = 10;
            this.fGroupBox.TabStop = false;
            this.fGroupBox.Text = "Файли";
            // 
            // sFileButton
            // 
            this.sFileButton.Location = new System.Drawing.Point(344, 64);
            this.sFileButton.Name = "sFileButton";
            this.sFileButton.Size = new System.Drawing.Size(48, 39);
            this.sFileButton.TabIndex = 5;
            this.sFileButton.Text = "...";
            this.toolTip1.SetToolTip(this.sFileButton, "Зеберегти файл");
            this.sFileButton.UseVisualStyleBackColor = true;
            this.sFileButton.Click += new System.EventHandler(this.sFileButton_Click);
            // 
            // oFileButton
            // 
            this.oFileButton.Location = new System.Drawing.Point(343, 19);
            this.oFileButton.Name = "oFileButton";
            this.oFileButton.Size = new System.Drawing.Size(48, 39);
            this.oFileButton.TabIndex = 4;
            this.oFileButton.Text = "...";
            this.toolTip1.SetToolTip(this.oFileButton, "Відкрити файл");
            this.oFileButton.UseVisualStyleBackColor = true;
            this.oFileButton.Click += new System.EventHandler(this.oFileButton_Click);
            // 
            // sFilePathTextBox
            // 
            this.sFilePathTextBox.Location = new System.Drawing.Point(70, 70);
            this.sFilePathTextBox.Name = "sFilePathTextBox";
            this.sFilePathTextBox.Size = new System.Drawing.Size(262, 20);
            this.sFilePathTextBox.TabIndex = 3;
            // 
            // oFilePathTextBox
            // 
            this.oFilePathTextBox.Location = new System.Drawing.Point(70, 27);
            this.oFilePathTextBox.Name = "oFilePathTextBox";
            this.oFilePathTextBox.Size = new System.Drawing.Size(262, 20);
            this.oFilePathTextBox.TabIndex = 2;
            // 
            // saveLabel
            // 
            this.saveLabel.AutoSize = true;
            this.saveLabel.Location = new System.Drawing.Point(6, 70);
            this.saveLabel.Name = "saveLabel";
            this.saveLabel.Size = new System.Drawing.Size(54, 13);
            this.saveLabel.TabIndex = 1;
            this.saveLabel.Text = "Зберегти";
            // 
            // openLabel
            // 
            this.openLabel.AutoSize = true;
            this.openLabel.Location = new System.Drawing.Point(6, 30);
            this.openLabel.Name = "openLabel";
            this.openLabel.Size = new System.Drawing.Size(51, 13);
            this.openLabel.TabIndex = 0;
            this.openLabel.Text = "Відкрити";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 298);
            this.Controls.Add(this.tEncLabel);
            this.Controls.Add(this.tTextLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.kGroupBox);
            this.Controls.Add(this.fGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "XOR шифрування файлів";
            this.kGroupBox.ResumeLayout(false);
            this.kGroupBox.PerformLayout();
            this.fGroupBox.ResumeLayout(false);
            this.fGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tEncLabel;
        private System.Windows.Forms.Label tTextLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox kGroupBox;
        private System.Windows.Forms.Label kSizeLabel;
        private System.Windows.Forms.Label kSizeTxtLabel;
        private System.Windows.Forms.Button genButton;
        private System.Windows.Forms.Button sKeyButton;
        private System.Windows.Forms.Button oKeyButton;
        private System.Windows.Forms.TextBox kPathTextBox;
        private System.Windows.Forms.Label kLabel;
        private System.Windows.Forms.GroupBox fGroupBox;
        private System.Windows.Forms.Button sFileButton;
        private System.Windows.Forms.Button oFileButton;
        private System.Windows.Forms.TextBox sFilePathTextBox;
        private System.Windows.Forms.TextBox oFilePathTextBox;
        private System.Windows.Forms.Label saveLabel;
        private System.Windows.Forms.Label openLabel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

