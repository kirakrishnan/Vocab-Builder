namespace VocabBuilder
{
    partial class VocabManagerForm
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
            this.components = new System.ComponentModel.Container();
            this.btnExitApp = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSpelling = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelFields = new System.Windows.Forms.Button();
            this.tbMeaning = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSentence = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgView2 = new System.Windows.Forms.DataGridView();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.notebase3BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.notebase3DataSet = new VocabBuilder.notebase3DataSet();
            this.notebase3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Last = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.notebase3TableAdapter = new VocabBuilder.notebase3DataSetTableAdapters.notebase3TableAdapter();
            this.btnDelete_Flash_table_entry = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notebase3BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notebase3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notebase3BindingSource)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExitApp
            // 
            this.btnExitApp.Location = new System.Drawing.Point(15, 49);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(345, 23);
            this.btnExitApp.TabIndex = 13;
            this.btnExitApp.Text = "Exit Application";
            this.btnExitApp.UseVisualStyleBackColor = true;
            this.btnExitApp.Click += new System.EventHandler(this.btnExitApp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SlateBlue;
            this.label5.Location = new System.Drawing.Point(13, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(348, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Enter information of a word (DetailsView)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Word :";
            // 
            // tbSpelling
            // 
            this.tbSpelling.Location = new System.Drawing.Point(84, 66);
            this.tbSpelling.Name = "tbSpelling";
            this.tbSpelling.Size = new System.Drawing.Size(132, 20);
            this.tbSpelling.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Meaning :";
            // 
            // btnCancelFields
            // 
            this.btnCancelFields.Location = new System.Drawing.Point(172, 208);
            this.btnCancelFields.Name = "btnCancelFields";
            this.btnCancelFields.Size = new System.Drawing.Size(167, 22);
            this.btnCancelFields.TabIndex = 14;
            this.btnCancelFields.Text = "Cancel";
            this.btnCancelFields.UseVisualStyleBackColor = true;
            this.btnCancelFields.Click += new System.EventHandler(this.btnCancelFields_Click);
            // 
            // tbMeaning
            // 
            this.tbMeaning.Location = new System.Drawing.Point(84, 101);
            this.tbMeaning.Name = "tbMeaning";
            this.tbMeaning.Size = new System.Drawing.Size(148, 20);
            this.tbMeaning.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sentence :";
            // 
            // tbSentence
            // 
            this.tbSentence.Location = new System.Drawing.Point(84, 135);
            this.tbSentence.Name = "tbSentence";
            this.tbSentence.Size = new System.Drawing.Size(162, 20);
            this.tbSentence.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(17, 208);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 22);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.SlateBlue;
            this.Search.Location = new System.Drawing.Point(10, 20);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(132, 24);
            this.Search.TabIndex = 11;
            this.Search.Text = "Search a word";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(13, 52);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(95, 20);
            this.tbSearch.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnShow);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbSpelling);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnCancelFields);
            this.panel2.Controls.Add(this.tbMeaning);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbSentence);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Location = new System.Drawing.Point(674, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 289);
            this.panel2.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(276, 63);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(17, 247);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(155, 23);
            this.btnShow.TabIndex = 17;
            this.btnShow.Text = "Turn Words On";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(276, 142);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch1
            // 
            this.btnSearch1.Location = new System.Drawing.Point(114, 50);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.Size = new System.Drawing.Size(75, 23);
            this.btnSearch1.TabIndex = 12;
            this.btnSearch1.Text = "Search";
            this.btnSearch1.UseVisualStyleBackColor = true;
            this.btnSearch1.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.Search);
            this.panel4.Controls.Add(this.tbSearch);
            this.panel4.Controls.Add(this.btnSearch1);
            this.panel4.Location = new System.Drawing.Point(20, 371);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(206, 86);
            this.panel4.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SlateBlue;
            this.label4.Location = new System.Drawing.Point(8, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Display all words (CompleteView)";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dgView2);
            this.panel1.Controls.Add(this.dgView);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(20, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 321);
            this.panel1.TabIndex = 32;
            // 
            // dgView2
            // 
            this.dgView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView2.Location = new System.Drawing.Point(13, 168);
            this.dgView2.Name = "dgView2";
            this.dgView2.Size = new System.Drawing.Size(617, 146);
            this.dgView2.TabIndex = 35;
            // 
            // dgView
            // 
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Location = new System.Drawing.Point(14, 41);
            this.dgView.Name = "dgView";
            this.dgView.Size = new System.Drawing.Size(616, 121);
            this.dgView.TabIndex = 8;
            this.dgView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellContentClick_1);
            // 
            // notebase3BindingSource1
            // 
            this.notebase3BindingSource1.DataMember = "notebase3";
            this.notebase3BindingSource1.DataSource = this.notebase3DataSet;
            // 
            // notebase3DataSet
            // 
            this.notebase3DataSet.DataSetName = "notebase3DataSet";
            this.notebase3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notebase3BindingSource
            // 
            this.notebase3BindingSource.DataMember = "notebase3";
            this.notebase3BindingSource.DataSource = this.notebase3DataSet;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.btnDelete_Flash_table_entry);
            this.panel5.Controls.Add(this.lblTime);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.Header);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Location = new System.Drawing.Point(12, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1050, 484);
            this.panel5.TabIndex = 31;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTime.Location = new System.Drawing.Point(721, 27);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 20);
            this.lblTime.TabIndex = 34;
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Header.Location = new System.Drawing.Point(322, 16);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(330, 25);
            this.Header.TabIndex = 32;
            this.Header.Text = "Vocabulary Management System";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.Last);
            this.panel3.Controls.Add(this.btnNext);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.btnFirst);
            this.panel3.Controls.Add(this.btnExitApp);
            this.panel3.Location = new System.Drawing.Point(676, 371);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(367, 86);
            this.panel3.TabIndex = 30;
            // 
            // Last
            // 
            this.Last.Location = new System.Drawing.Point(269, 20);
            this.Last.Name = "Last";
            this.Last.Size = new System.Drawing.Size(75, 23);
            this.Last.TabIndex = 17;
            this.Last.Text = "Last";
            this.Last.UseVisualStyleBackColor = true;
            this.Last.Click += new System.EventHandler(this.Last_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(187, 20);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(97, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Previous";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(15, 20);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 14;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.button2_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(245, 66);
            this.Title.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(307, 25);
            this.Title.TabIndex = 30;
            this.Title.Text = " Vocabulary Management System";
            // 
            // notebase3TableAdapter
            // 
            this.notebase3TableAdapter.ClearBeforeFill = true;
            // 
            // btnDelete_Flash_table_entry
            // 
            this.btnDelete_Flash_table_entry.Location = new System.Drawing.Point(243, 371);
            this.btnDelete_Flash_table_entry.Name = "btnDelete_Flash_table_entry";
            this.btnDelete_Flash_table_entry.Size = new System.Drawing.Size(147, 23);
            this.btnDelete_Flash_table_entry.TabIndex = 35;
            this.btnDelete_Flash_table_entry.Text = "Delete from Flash table";
            this.btnDelete_Flash_table_entry.UseVisualStyleBackColor = true;
            this.btnDelete_Flash_table_entry.Click += new System.EventHandler(this.btnDelete_Flash_table_entry_Click);
            // 
            // VocabManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 519);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.Title);
            this.Name = "VocabManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vocabulary Management System";
            this.Load += new System.EventHandler(this.VocabManagerForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.VocabManagerForm_Paint);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notebase3BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notebase3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notebase3BindingSource)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Button btnExitApp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSpelling;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelFields;
        private System.Windows.Forms.TextBox tbMeaning;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSentence;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblTime;
        private notebase3DataSet notebase3DataSet;
        private System.Windows.Forms.BindingSource notebase3BindingSource;
        private notebase3DataSetTableAdapters.notebase3TableAdapter notebase3TableAdapter;
        private System.Windows.Forms.BindingSource notebase3BindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Last;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgView2;
        private System.Windows.Forms.Button btnDelete_Flash_table_entry;
    }
}

