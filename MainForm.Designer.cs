namespace MusicCD
{
    partial class MainForm
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
            this.buttonBurn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonCd = new System.Windows.Forms.RadioButton();
            this.radioButtonRw = new System.Windows.Forms.RadioButton();
            this.buttonDownArrow = new System.Windows.Forms.Button();
            this.buttonUpArrow = new System.Windows.Forms.Button();
            this.button_Rip = new System.Windows.Forms.Button();
            this.progressBarCapacity = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.devicesComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelStatusText = new System.Windows.Forms.Label();
            this.statusProgressBar = new System.Windows.Forms.ProgressBar();
            this.progressBarCD = new System.Windows.Forms.ProgressBar();
            this.labelCDProgress = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBurn
            // 
            this.buttonBurn.Location = new System.Drawing.Point(312, 480);
            this.buttonBurn.Name = "buttonBurn";
            this.buttonBurn.Size = new System.Drawing.Size(75, 23);
            this.buttonBurn.TabIndex = 0;
            this.buttonBurn.Text = "Nagraj";
            this.buttonBurn.UseVisualStyleBackColor = true;
            this.buttonBurn.Click += new System.EventHandler(this.buttonBurn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonCd);
            this.groupBox1.Controls.Add(this.radioButtonRw);
            this.groupBox1.Controls.Add(this.buttonDownArrow);
            this.groupBox1.Controls.Add(this.buttonUpArrow);
            this.groupBox1.Controls.Add(this.button_Rip);
            this.groupBox1.Controls.Add(this.progressBarCapacity);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonRemove);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.listBoxFiles);
            this.groupBox1.Location = new System.Drawing.Point(13, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 307);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodane pliki";
            // 
            // radioButtonCd
            // 
            this.radioButtonCd.AutoSize = true;
            this.radioButtonCd.Location = new System.Drawing.Point(581, 224);
            this.radioButtonCd.Name = "radioButtonCd";
            this.radioButtonCd.Size = new System.Drawing.Size(51, 17);
            this.radioButtonCd.TabIndex = 10;
            this.radioButtonCd.TabStop = true;
            this.radioButtonCd.Text = "CD-R";
            this.radioButtonCd.UseVisualStyleBackColor = true;
            // 
            // radioButtonRw
            // 
            this.radioButtonRw.AutoSize = true;
            this.radioButtonRw.Location = new System.Drawing.Point(581, 201);
            this.radioButtonRw.Name = "radioButtonRw";
            this.radioButtonRw.Size = new System.Drawing.Size(62, 17);
            this.radioButtonRw.TabIndex = 9;
            this.radioButtonRw.TabStop = true;
            this.radioButtonRw.Text = "CD-RW";
            this.radioButtonRw.UseVisualStyleBackColor = true;
            // 
            // buttonDownArrow
            // 
            this.buttonDownArrow.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonDownArrow.Location = new System.Drawing.Point(499, 144);
            this.buttonDownArrow.Name = "buttonDownArrow";
            this.buttonDownArrow.Size = new System.Drawing.Size(39, 32);
            this.buttonDownArrow.TabIndex = 8;
            this.buttonDownArrow.Text = "i";
            this.buttonDownArrow.UseVisualStyleBackColor = true;
            this.buttonDownArrow.Click += new System.EventHandler(this.buttonDownArrow_Click);
            // 
            // buttonUpArrow
            // 
            this.buttonUpArrow.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonUpArrow.Location = new System.Drawing.Point(499, 97);
            this.buttonUpArrow.Name = "buttonUpArrow";
            this.buttonUpArrow.Size = new System.Drawing.Size(39, 32);
            this.buttonUpArrow.TabIndex = 7;
            this.buttonUpArrow.Text = "h";
            this.buttonUpArrow.UseVisualStyleBackColor = true;
            this.buttonUpArrow.Click += new System.EventHandler(this.buttonUpArrow_Click);
            // 
            // button_Rip
            // 
            this.button_Rip.Location = new System.Drawing.Point(581, 20);
            this.button_Rip.Name = "button_Rip";
            this.button_Rip.Size = new System.Drawing.Size(95, 32);
            this.button_Rip.TabIndex = 6;
            this.button_Rip.Text = "Zgraj...";
            this.button_Rip.UseVisualStyleBackColor = true;
            this.button_Rip.Click += new System.EventHandler(this.button_Rip_Click);
            // 
            // progressBarCapacity
            // 
            this.progressBarCapacity.Location = new System.Drawing.Point(7, 290);
            this.progressBarCapacity.Name = "progressBarCapacity";
            this.progressBarCapacity.Size = new System.Drawing.Size(649, 11);
            this.progressBarCapacity.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(612, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "700 MB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "0 MB";
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(581, 144);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(95, 31);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.Text = "Usuń...";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(581, 96);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(95, 32);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Dodaj...";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.ItemHeight = 24;
            this.listBoxFiles.Location = new System.Drawing.Point(7, 20);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(486, 244);
            this.listBoxFiles.TabIndex = 0;
            this.listBoxFiles.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxFiles_DrawItem);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Pliki Muzyczne |*.wav;*.mp3;*.ogg;*.flac;*.wma|All Files|*.*";
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.Title = "Select WAV File";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // devicesComboBox
            // 
            this.devicesComboBox.FormattingEnabled = true;
            this.devicesComboBox.Location = new System.Drawing.Point(10, 19);
            this.devicesComboBox.Name = "devicesComboBox";
            this.devicesComboBox.Size = new System.Drawing.Size(483, 21);
            this.devicesComboBox.TabIndex = 2;
            this.devicesComboBox.SelectedIndexChanged += new System.EventHandler(this.devicesComboBox_SelectedIndexChanged);
            this.devicesComboBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.devicesComboBox_Format);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.devicesComboBox);
            this.groupBox2.Location = new System.Drawing.Point(13, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(682, 54);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nagrywarka";
            // 
            // labelStatusText
            // 
            this.labelStatusText.Location = new System.Drawing.Point(10, 425);
            this.labelStatusText.Name = "labelStatusText";
            this.labelStatusText.Size = new System.Drawing.Size(685, 23);
            this.labelStatusText.TabIndex = 4;
            this.labelStatusText.Text = "status";
            this.labelStatusText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusProgressBar
            // 
            this.statusProgressBar.Location = new System.Drawing.Point(13, 451);
            this.statusProgressBar.Name = "statusProgressBar";
            this.statusProgressBar.Size = new System.Drawing.Size(682, 23);
            this.statusProgressBar.TabIndex = 5;
            // 
            // progressBarCD
            // 
            this.progressBarCD.Location = new System.Drawing.Point(13, 399);
            this.progressBarCD.Name = "progressBarCD";
            this.progressBarCD.Size = new System.Drawing.Size(682, 23);
            this.progressBarCD.TabIndex = 7;
            // 
            // labelCDProgress
            // 
            this.labelCDProgress.Location = new System.Drawing.Point(12, 373);
            this.labelCDProgress.Name = "labelCDProgress";
            this.labelCDProgress.Size = new System.Drawing.Size(683, 23);
            this.labelCDProgress.TabIndex = 6;
            this.labelCDProgress.Text = "status";
            this.labelCDProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 515);
            this.Controls.Add(this.progressBarCD);
            this.Controls.Add(this.labelCDProgress);
            this.Controls.Add(this.statusProgressBar);
            this.Controls.Add(this.labelStatusText);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonBurn);
            this.Name = "MainForm";
            this.Text = "MusicCD";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBurn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBarCapacity;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ComboBox devicesComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelStatusText;
        private System.Windows.Forms.ProgressBar statusProgressBar;
        private System.Windows.Forms.ProgressBar progressBarCD;
        private System.Windows.Forms.Label labelCDProgress;
        private System.Windows.Forms.Button button_Rip;
        private System.Windows.Forms.Button buttonDownArrow;
        private System.Windows.Forms.Button buttonUpArrow;
        private System.Windows.Forms.RadioButton radioButtonCd;
        private System.Windows.Forms.RadioButton radioButtonRw;
    }
}

