namespace DayOrganizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.FileBrowser = new System.Windows.Forms.OpenFileDialog();
            this.ChooseFile = new System.Windows.Forms.Button();
            this.FileName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DayPanel = new System.Windows.Forms.Panel();
            this.time14 = new System.Windows.Forms.Label();
            this.time22 = new System.Windows.Forms.Label();
            this.time18 = new System.Windows.Forms.Label();
            this.time20 = new System.Windows.Forms.Label();
            this.time16 = new System.Windows.Forms.Label();
            this.time0 = new System.Windows.Forms.Label();
            this.time10 = new System.Windows.Forms.Label();
            this.time12 = new System.Windows.Forms.Label();
            this.time8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DateNext = new System.Windows.Forms.Button();
            this.DatePrev = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuggestionPanel = new System.Windows.Forms.Panel();
            this.ColorPicker2 = new System.Windows.Forms.Panel();
            this.SelectedLabel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ColorPicker = new System.Windows.Forms.Panel();
            this.TaskPanel = new System.Windows.Forms.Panel();
            this.Suggestions = new System.Windows.Forms.Label();
            this.AddSuggest = new System.Windows.Forms.Button();
            this.RemSuggest = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Sort = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.DayPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuggestionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChooseFile
            // 
            this.ChooseFile.BackColor = System.Drawing.Color.Gray;
            this.ChooseFile.FlatAppearance.BorderSize = 0;
            this.ChooseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseFile.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.ChooseFile.Location = new System.Drawing.Point(126, 11);
            this.ChooseFile.Name = "ChooseFile";
            this.ChooseFile.Size = new System.Drawing.Size(103, 23);
            this.ChooseFile.TabIndex = 8;
            this.ChooseFile.Text = "Choose File";
            this.ChooseFile.UseVisualStyleBackColor = false;
            this.ChooseFile.Click += new System.EventHandler(this.ChooseFile_Click);
            // 
            // FileName
            // 
            this.FileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileName.Location = new System.Drawing.Point(18, 51);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(257, 20);
            this.FileName.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.DayPanel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.FileName);
            this.panel1.Controls.Add(this.ChooseFile);
            this.panel1.Location = new System.Drawing.Point(9, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(291, 623);
            this.panel1.TabIndex = 19;
            // 
            // DayPanel
            // 
            this.DayPanel.Controls.Add(this.time14);
            this.DayPanel.Controls.Add(this.time22);
            this.DayPanel.Controls.Add(this.time18);
            this.DayPanel.Controls.Add(this.time20);
            this.DayPanel.Controls.Add(this.time16);
            this.DayPanel.Controls.Add(this.time0);
            this.DayPanel.Controls.Add(this.time10);
            this.DayPanel.Controls.Add(this.time12);
            this.DayPanel.Controls.Add(this.time8);
            this.DayPanel.Location = new System.Drawing.Point(55, 145);
            this.DayPanel.Name = "DayPanel";
            this.DayPanel.Size = new System.Drawing.Size(220, 472);
            this.DayPanel.TabIndex = 15;
            // 
            // time14
            // 
            this.time14.AllowDrop = true;
            this.time14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.time14.Location = new System.Drawing.Point(10, 161);
            this.time14.MaximumSize = new System.Drawing.Size(200, 100);
            this.time14.MinimumSize = new System.Drawing.Size(200, 40);
            this.time14.Name = "time14";
            this.time14.Size = new System.Drawing.Size(200, 40);
            this.time14.TabIndex = 23;
            this.time14.Text = "label6";
            this.time14.DragDrop += new System.Windows.Forms.DragEventHandler(this.LabelDragDrop);
            this.time14.DragOver += new System.Windows.Forms.DragEventHandler(this.LabelDragOver);
            // 
            // time22
            // 
            this.time22.AllowDrop = true;
            this.time22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.time22.Location = new System.Drawing.Point(10, 370);
            this.time22.MaximumSize = new System.Drawing.Size(200, 100);
            this.time22.MinimumSize = new System.Drawing.Size(200, 40);
            this.time22.Name = "time22";
            this.time22.Size = new System.Drawing.Size(200, 40);
            this.time22.TabIndex = 22;
            this.time22.Text = "label6";
            this.time22.DragDrop += new System.Windows.Forms.DragEventHandler(this.LabelDragDrop);
            this.time22.DragOver += new System.Windows.Forms.DragEventHandler(this.LabelDragOver);
            // 
            // time18
            // 
            this.time18.AllowDrop = true;
            this.time18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.time18.Location = new System.Drawing.Point(11, 266);
            this.time18.MaximumSize = new System.Drawing.Size(200, 100);
            this.time18.MinimumSize = new System.Drawing.Size(200, 40);
            this.time18.Name = "time18";
            this.time18.Size = new System.Drawing.Size(200, 40);
            this.time18.TabIndex = 21;
            this.time18.Text = "label6";
            this.time18.DragDrop += new System.Windows.Forms.DragEventHandler(this.LabelDragDrop);
            this.time18.DragOver += new System.Windows.Forms.DragEventHandler(this.LabelDragOver);
            // 
            // time20
            // 
            this.time20.AllowDrop = true;
            this.time20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.time20.Location = new System.Drawing.Point(10, 318);
            this.time20.MaximumSize = new System.Drawing.Size(200, 100);
            this.time20.MinimumSize = new System.Drawing.Size(200, 40);
            this.time20.Name = "time20";
            this.time20.Size = new System.Drawing.Size(200, 40);
            this.time20.TabIndex = 20;
            this.time20.Text = "label6";
            this.time20.DragDrop += new System.Windows.Forms.DragEventHandler(this.LabelDragDrop);
            this.time20.DragOver += new System.Windows.Forms.DragEventHandler(this.LabelDragOver);
            // 
            // time16
            // 
            this.time16.AllowDrop = true;
            this.time16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.time16.Location = new System.Drawing.Point(10, 212);
            this.time16.MaximumSize = new System.Drawing.Size(200, 100);
            this.time16.MinimumSize = new System.Drawing.Size(200, 40);
            this.time16.Name = "time16";
            this.time16.Size = new System.Drawing.Size(200, 40);
            this.time16.TabIndex = 19;
            this.time16.Text = "label6";
            this.time16.DragDrop += new System.Windows.Forms.DragEventHandler(this.LabelDragDrop);
            this.time16.DragOver += new System.Windows.Forms.DragEventHandler(this.LabelDragOver);
            // 
            // time0
            // 
            this.time0.AllowDrop = true;
            this.time0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.time0.Location = new System.Drawing.Point(10, 423);
            this.time0.MaximumSize = new System.Drawing.Size(200, 100);
            this.time0.MinimumSize = new System.Drawing.Size(200, 40);
            this.time0.Name = "time0";
            this.time0.Size = new System.Drawing.Size(200, 40);
            this.time0.TabIndex = 18;
            this.time0.Text = "label6";
            this.time0.DragDrop += new System.Windows.Forms.DragEventHandler(this.LabelDragDrop);
            this.time0.DragOver += new System.Windows.Forms.DragEventHandler(this.LabelDragOver);
            // 
            // time10
            // 
            this.time10.AllowDrop = true;
            this.time10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.time10.Location = new System.Drawing.Point(10, 62);
            this.time10.MaximumSize = new System.Drawing.Size(200, 100);
            this.time10.MinimumSize = new System.Drawing.Size(200, 40);
            this.time10.Name = "time10";
            this.time10.Size = new System.Drawing.Size(200, 40);
            this.time10.TabIndex = 17;
            this.time10.Text = "l";
            this.time10.DragDrop += new System.Windows.Forms.DragEventHandler(this.LabelDragDrop);
            this.time10.DragOver += new System.Windows.Forms.DragEventHandler(this.LabelDragOver);
            // 
            // time12
            // 
            this.time12.AllowDrop = true;
            this.time12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.time12.Location = new System.Drawing.Point(10, 112);
            this.time12.MaximumSize = new System.Drawing.Size(200, 100);
            this.time12.MinimumSize = new System.Drawing.Size(200, 40);
            this.time12.Name = "time12";
            this.time12.Size = new System.Drawing.Size(200, 40);
            this.time12.TabIndex = 16;
            this.time12.Text = "l";
            this.time12.DragDrop += new System.Windows.Forms.DragEventHandler(this.LabelDragDrop);
            this.time12.DragOver += new System.Windows.Forms.DragEventHandler(this.LabelDragOver);
            // 
            // time8
            // 
            this.time8.AllowDrop = true;
            this.time8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.time8.Location = new System.Drawing.Point(11, 10);
            this.time8.MaximumSize = new System.Drawing.Size(200, 100);
            this.time8.MinimumSize = new System.Drawing.Size(200, 40);
            this.time8.Name = "time8";
            this.time8.Size = new System.Drawing.Size(200, 40);
            this.time8.TabIndex = 15;
            this.time8.Text = "label6";
            this.time8.DragDrop += new System.Windows.Forms.DragEventHandler(this.LabelDragDrop);
            this.time8.DragOver += new System.Windows.Forms.DragEventHandler(this.LabelDragOver);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(15, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 429);
            this.label3.TabIndex = 14;
            this.label3.Text = "8:00\r\n\r\n\r\n\r\n10:00\r\n\r\n\r\n\r\n12:00\r\n\r\n\r\n\r\n14:00\r\n\r\n\r\n\r\n16:00\r\n\r\n\r\n\r\n18:00\r\n\r\n\r\n\r\n20:0" +
    "0\r\n\r\n\r\n\r\n22:00\r\n\r\n\r\n\r\n0:00";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DateNext);
            this.panel4.Controls.Add(this.DatePrev);
            this.panel4.Controls.Add(this.dateLabel);
            this.panel4.Location = new System.Drawing.Point(68, 91);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(198, 48);
            this.panel4.TabIndex = 10;
            // 
            // DateNext
            // 
            this.DateNext.BackColor = System.Drawing.Color.Gray;
            this.DateNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DateNext.BackgroundImage")));
            this.DateNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DateNext.FlatAppearance.BorderSize = 0;
            this.DateNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DateNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateNext.Location = new System.Drawing.Point(159, 5);
            this.DateNext.Name = "DateNext";
            this.DateNext.Size = new System.Drawing.Size(36, 36);
            this.DateNext.TabIndex = 15;
            this.DateNext.UseVisualStyleBackColor = false;
            this.DateNext.Click += new System.EventHandler(this.DateNext_Click);
            // 
            // DatePrev
            // 
            this.DatePrev.BackColor = System.Drawing.Color.Gray;
            this.DatePrev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DatePrev.BackgroundImage")));
            this.DatePrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DatePrev.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.DatePrev.FlatAppearance.BorderSize = 0;
            this.DatePrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DatePrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePrev.Location = new System.Drawing.Point(5, 5);
            this.DatePrev.Margin = new System.Windows.Forms.Padding(5);
            this.DatePrev.Name = "DatePrev";
            this.DatePrev.Size = new System.Drawing.Size(36, 36);
            this.DatePrev.TabIndex = 14;
            this.DatePrev.UseVisualStyleBackColor = false;
            this.DatePrev.Click += new System.EventHandler(this.DatePrev_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateLabel.Location = new System.Drawing.Point(54, 15);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(89, 20);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "28.01.2021";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(14, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "To-Do-List";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.SuggestionPanel);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(1200, 641);
            this.panel3.TabIndex = 21;
            // 
            // SuggestionPanel
            // 
            this.SuggestionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.SuggestionPanel.Controls.Add(this.button1);
            this.SuggestionPanel.Controls.Add(this.Sort);
            this.SuggestionPanel.Controls.Add(this.ColorPicker2);
            this.SuggestionPanel.Controls.Add(this.SelectedLabel);
            this.SuggestionPanel.Controls.Add(this.label1);
            this.SuggestionPanel.Controls.Add(this.ColorPicker);
            this.SuggestionPanel.Controls.Add(this.TaskPanel);
            this.SuggestionPanel.Controls.Add(this.Suggestions);
            this.SuggestionPanel.Controls.Add(this.AddSuggest);
            this.SuggestionPanel.Controls.Add(this.RemSuggest);
            this.SuggestionPanel.Location = new System.Drawing.Point(312, 9);
            this.SuggestionPanel.Margin = new System.Windows.Forms.Padding(6);
            this.SuggestionPanel.Name = "SuggestionPanel";
            this.SuggestionPanel.Padding = new System.Windows.Forms.Padding(3);
            this.SuggestionPanel.Size = new System.Drawing.Size(879, 623);
            this.SuggestionPanel.TabIndex = 20;
            // 
            // ColorPicker2
            // 
            this.ColorPicker2.AllowDrop = true;
            this.ColorPicker2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorPicker2.Location = new System.Drawing.Point(32, 393);
            this.ColorPicker2.Name = "ColorPicker2";
            this.ColorPicker2.Size = new System.Drawing.Size(40, 40);
            this.ColorPicker2.TabIndex = 17;
            this.ColorPicker2.Click += new System.EventHandler(this.ColorPicker2_Click);
            this.ColorPicker2.DragDrop += new System.Windows.Forms.DragEventHandler(this.ColorPicker2_DragDrop);
            this.ColorPicker2.DragOver += new System.Windows.Forms.DragEventHandler(this.ColorPicker2_DragOver);
            // 
            // SelectedLabel
            // 
            this.SelectedLabel.Location = new System.Drawing.Point(6, 325);
            this.SelectedLabel.Multiline = true;
            this.SelectedLabel.Name = "SelectedLabel";
            this.SelectedLabel.Size = new System.Drawing.Size(93, 62);
            this.SelectedLabel.TabIndex = 18;
            this.SelectedLabel.TextChanged += new System.EventHandler(this.SelectedLabel_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(6, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Selected:";
            // 
            // ColorPicker
            // 
            this.ColorPicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorPicker.Location = new System.Drawing.Point(27, 91);
            this.ColorPicker.Name = "ColorPicker";
            this.ColorPicker.Size = new System.Drawing.Size(50, 50);
            this.ColorPicker.TabIndex = 16;
            this.ColorPicker.Click += new System.EventHandler(this.ColorPicker_Click);
            // 
            // TaskPanel
            // 
            this.TaskPanel.Location = new System.Drawing.Point(105, 11);
            this.TaskPanel.Name = "TaskPanel";
            this.TaskPanel.Size = new System.Drawing.Size(768, 606);
            this.TaskPanel.TabIndex = 15;
            // 
            // Suggestions
            // 
            this.Suggestions.AutoSize = true;
            this.Suggestions.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suggestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Suggestions.Location = new System.Drawing.Point(11, 8);
            this.Suggestions.Name = "Suggestions";
            this.Suggestions.Size = new System.Drawing.Size(88, 19);
            this.Suggestions.TabIndex = 6;
            this.Suggestions.Text = "Suggestions";
            // 
            // AddSuggest
            // 
            this.AddSuggest.BackColor = System.Drawing.Color.Gray;
            this.AddSuggest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddSuggest.BackgroundImage")));
            this.AddSuggest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddSuggest.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.AddSuggest.FlatAppearance.BorderSize = 0;
            this.AddSuggest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSuggest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSuggest.Location = new System.Drawing.Point(15, 38);
            this.AddSuggest.Name = "AddSuggest";
            this.AddSuggest.Size = new System.Drawing.Size(36, 36);
            this.AddSuggest.TabIndex = 10;
            this.AddSuggest.UseVisualStyleBackColor = false;
            this.AddSuggest.Click += new System.EventHandler(this.AddSuggest_Click);
            // 
            // RemSuggest
            // 
            this.RemSuggest.BackColor = System.Drawing.Color.Gray;
            this.RemSuggest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemSuggest.BackgroundImage")));
            this.RemSuggest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RemSuggest.FlatAppearance.BorderSize = 0;
            this.RemSuggest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemSuggest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemSuggest.Location = new System.Drawing.Point(63, 38);
            this.RemSuggest.Name = "RemSuggest";
            this.RemSuggest.Size = new System.Drawing.Size(36, 36);
            this.RemSuggest.TabIndex = 13;
            this.RemSuggest.UseVisualStyleBackColor = false;
            this.RemSuggest.Click += new System.EventHandler(this.RemSuggest_Click);
            // 
            // Sort
            // 
            this.Sort.BackColor = System.Drawing.Color.Gray;
            this.Sort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Sort.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Sort.FlatAppearance.BorderSize = 0;
            this.Sort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sort.Location = new System.Drawing.Point(15, 159);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(67, 40);
            this.Sort.TabIndex = 19;
            this.Sort.Text = "Sort by Color";
            this.Sort.UseVisualStyleBackColor = false;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(15, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 40);
            this.button1.TabIndex = 20;
            this.button1.Text = "Sort by Name";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.ClientSize = new System.Drawing.Size(1224, 665);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Helpful Apps";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.DayPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.SuggestionPanel.ResumeLayout(false);
            this.SuggestionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        private System.Windows.Forms.Button ChooseFile;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.OpenFileDialog FileBrowser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel SuggestionPanel;
        private System.Windows.Forms.Label Suggestions;
        private System.Windows.Forms.Button AddSuggest;
        private System.Windows.Forms.Button RemSuggest;
        private System.Windows.Forms.Panel DayPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button DatePrev;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label time8;
        private System.Windows.Forms.Label time14;
        private System.Windows.Forms.Label time22;
        private System.Windows.Forms.Label time18;
        private System.Windows.Forms.Label time20;
        private System.Windows.Forms.Label time16;
        private System.Windows.Forms.Label time0;
        private System.Windows.Forms.Label time10;
        private System.Windows.Forms.Label time12;
        private System.Windows.Forms.Button DateNext;
        private System.Windows.Forms.Panel TaskPanel;
        private System.Windows.Forms.Panel ColorPicker;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel ColorPicker2;
        private System.Windows.Forms.TextBox SelectedLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Sort;
        private System.Windows.Forms.Button button1;
    }
}

