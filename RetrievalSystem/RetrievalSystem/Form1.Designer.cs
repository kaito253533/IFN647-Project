namespace RetrievalSystem
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
            this.lbl_CollectionPath = new System.Windows.Forms.Label();
            this.txt_CollectionPath = new System.Windows.Forms.TextBox();
            this.btn_CollectionPath = new System.Windows.Forms.Button();
            this.lbl_IndexPath = new System.Windows.Forms.Label();
            this.txt_IndexPath = new System.Windows.Forms.TextBox();
            this.btn_IndexPath = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_IndexingTime = new System.Windows.Forms.Label();
            this.btn_GenerateIndex = new System.Windows.Forms.Button();
            this.lbl_IndexingTimeName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalDocs = new System.Windows.Forms.Label();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.ddl_Fields = new System.Windows.Forms.ComboBox();
            this.lbl_SearchType = new System.Windows.Forms.Label();
            this.ddl_Type = new System.Windows.Forms.ComboBox();
            this.lbl_SearchingTime = new System.Windows.Forms.Label();
            this.lbl_ProcessTimeForSearch = new System.Windows.Forms.Label();
            this.lv_Result = new System.Windows.Forms.ListView();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_InformationNeeds = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_FileName = new System.Windows.Forms.TextBox();
            this.lbl_FileName = new System.Windows.Forms.Label();
            this.lbl_Warning = new System.Windows.Forms.Label();
            this.lbl_Saving = new System.Windows.Forms.Label();
            this.btn_SaveBrowse = new System.Windows.Forms.Button();
            this.lbl_ExportPath = new System.Windows.Forms.Label();
            this.txt_Saving = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_CollectionPath
            // 
            this.lbl_CollectionPath.AutoSize = true;
            this.lbl_CollectionPath.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_CollectionPath.Location = new System.Drawing.Point(161, 35);
            this.lbl_CollectionPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CollectionPath.Name = "lbl_CollectionPath";
            this.lbl_CollectionPath.Size = new System.Drawing.Size(106, 17);
            this.lbl_CollectionPath.TabIndex = 0;
            this.lbl_CollectionPath.Text = "Collection Path:";
            // 
            // txt_CollectionPath
            // 
            this.txt_CollectionPath.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_CollectionPath.Location = new System.Drawing.Point(273, 29);
            this.txt_CollectionPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_CollectionPath.Name = "txt_CollectionPath";
            this.txt_CollectionPath.Size = new System.Drawing.Size(325, 22);
            this.txt_CollectionPath.TabIndex = 1;
            // 
            // btn_CollectionPath
            // 
            this.btn_CollectionPath.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_CollectionPath.Location = new System.Drawing.Point(608, 28);
            this.btn_CollectionPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_CollectionPath.Name = "btn_CollectionPath";
            this.btn_CollectionPath.Size = new System.Drawing.Size(100, 28);
            this.btn_CollectionPath.TabIndex = 2;
            this.btn_CollectionPath.Text = "Browse";
            this.btn_CollectionPath.UseVisualStyleBackColor = false;
            this.btn_CollectionPath.Click += new System.EventHandler(this.btn_CollectionPath_Click);
            // 
            // lbl_IndexPath
            // 
            this.lbl_IndexPath.AutoSize = true;
            this.lbl_IndexPath.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_IndexPath.Location = new System.Drawing.Point(161, 61);
            this.lbl_IndexPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_IndexPath.Name = "lbl_IndexPath";
            this.lbl_IndexPath.Size = new System.Drawing.Size(78, 17);
            this.lbl_IndexPath.TabIndex = 3;
            this.lbl_IndexPath.Text = "Index Path:";
            // 
            // txt_IndexPath
            // 
            this.txt_IndexPath.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_IndexPath.Location = new System.Drawing.Point(273, 58);
            this.txt_IndexPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_IndexPath.Name = "txt_IndexPath";
            this.txt_IndexPath.Size = new System.Drawing.Size(325, 22);
            this.txt_IndexPath.TabIndex = 4;
            // 
            // btn_IndexPath
            // 
            this.btn_IndexPath.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_IndexPath.Location = new System.Drawing.Point(608, 58);
            this.btn_IndexPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_IndexPath.Name = "btn_IndexPath";
            this.btn_IndexPath.Size = new System.Drawing.Size(100, 28);
            this.btn_IndexPath.TabIndex = 5;
            this.btn_IndexPath.Text = "Browse";
            this.btn_IndexPath.UseVisualStyleBackColor = false;
            this.btn_IndexPath.Click += new System.EventHandler(this.btn_IndexPath_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_IndexingTime);
            this.panel1.Controls.Add(this.btn_GenerateIndex);
            this.panel1.Controls.Add(this.lbl_IndexingTimeName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_CollectionPath);
            this.panel1.Controls.Add(this.btn_IndexPath);
            this.panel1.Controls.Add(this.lbl_IndexPath);
            this.panel1.Controls.Add(this.txt_IndexPath);
            this.panel1.Controls.Add(this.lbl_CollectionPath);
            this.panel1.Controls.Add(this.txt_CollectionPath);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(182, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 155);
            this.panel1.TabIndex = 6;
            // 
            // lbl_IndexingTime
            // 
            this.lbl_IndexingTime.AutoSize = true;
            this.lbl_IndexingTime.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_IndexingTime.Location = new System.Drawing.Point(872, 126);
            this.lbl_IndexingTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_IndexingTime.Name = "lbl_IndexingTime";
            this.lbl_IndexingTime.Size = new System.Drawing.Size(38, 17);
            this.lbl_IndexingTime.TabIndex = 9;
            this.lbl_IndexingTime.Text = "0 ms";
            // 
            // btn_GenerateIndex
            // 
            this.btn_GenerateIndex.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_GenerateIndex.Location = new System.Drawing.Point(381, 88);
            this.btn_GenerateIndex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_GenerateIndex.Name = "btn_GenerateIndex";
            this.btn_GenerateIndex.Size = new System.Drawing.Size(100, 28);
            this.btn_GenerateIndex.TabIndex = 8;
            this.btn_GenerateIndex.Text = "Index";
            this.btn_GenerateIndex.UseVisualStyleBackColor = false;
            this.btn_GenerateIndex.Click += new System.EventHandler(this.btn_GenerateIndex_Click);
            // 
            // lbl_IndexingTimeName
            // 
            this.lbl_IndexingTimeName.AutoSize = true;
            this.lbl_IndexingTimeName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_IndexingTimeName.Location = new System.Drawing.Point(722, 126);
            this.lbl_IndexingTimeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_IndexingTimeName.Name = "lbl_IndexingTimeName";
            this.lbl_IndexingTimeName.Size = new System.Drawing.Size(154, 17);
            this.lbl_IndexingTimeName.TabIndex = 7;
            this.lbl_IndexingTimeName.Text = "Indexing Process Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Indexing";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Menu;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblTotalDocs);
            this.panel2.Controls.Add(this.btn_Next);
            this.panel2.Controls.Add(this.btn_Previous);
            this.panel2.Controls.Add(this.ddl_Fields);
            this.panel2.Controls.Add(this.lbl_SearchType);
            this.panel2.Controls.Add(this.ddl_Type);
            this.panel2.Controls.Add(this.lbl_SearchingTime);
            this.panel2.Controls.Add(this.lbl_ProcessTimeForSearch);
            this.panel2.Controls.Add(this.lv_Result);
            this.panel2.Controls.Add(this.lbl_Result);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblSearch);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_InformationNeeds);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(182, 354);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(927, 407);
            this.panel2.TabIndex = 7;
            // 
            // lblTotalDocs
            // 
            this.lblTotalDocs.AutoSize = true;
            this.lblTotalDocs.Location = new System.Drawing.Point(587, 415);
            this.lblTotalDocs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalDocs.Name = "lblTotalDocs";
            this.lblTotalDocs.Size = new System.Drawing.Size(50, 17);
            this.lblTotalDocs.TabIndex = 17;
            this.lblTotalDocs.Text = "0 docs";
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(822, 429);
            this.btn_Next.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(100, 28);
            this.btn_Next.TabIndex = 16;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Previous
            // 
            this.btn_Previous.Location = new System.Drawing.Point(707, 429);
            this.btn_Previous.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(100, 28);
            this.btn_Previous.TabIndex = 15;
            this.btn_Previous.Text = "Previous";
            this.btn_Previous.UseVisualStyleBackColor = true;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // ddl_Fields
            // 
            this.ddl_Fields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_Fields.FormattingEnabled = true;
            this.ddl_Fields.Items.AddRange(new object[] {
            "Title",
            "Author",
            "Bibliographic",
            "Words"});
            this.ddl_Fields.Location = new System.Drawing.Point(397, 54);
            this.ddl_Fields.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ddl_Fields.Name = "ddl_Fields";
            this.ddl_Fields.Size = new System.Drawing.Size(160, 24);
            this.ddl_Fields.TabIndex = 14;
            // 
            // lbl_SearchType
            // 
            this.lbl_SearchType.AutoSize = true;
            this.lbl_SearchType.Location = new System.Drawing.Point(96, 62);
            this.lbl_SearchType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SearchType.Name = "lbl_SearchType";
            this.lbl_SearchType.Size = new System.Drawing.Size(108, 17);
            this.lbl_SearchType.TabIndex = 13;
            this.lbl_SearchType.Text = "Searching Type";
            // 
            // ddl_Type
            // 
            this.ddl_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_Type.FormattingEnabled = true;
            this.ddl_Type.Items.AddRange(new object[] {
            "Single Term",
            "Muti-Term"});
            this.ddl_Type.Location = new System.Drawing.Point(228, 54);
            this.ddl_Type.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ddl_Type.Name = "ddl_Type";
            this.ddl_Type.Size = new System.Drawing.Size(160, 24);
            this.ddl_Type.TabIndex = 12;
            this.ddl_Type.SelectedIndexChanged += new System.EventHandler(this.Type_Click);
            // 
            // lbl_SearchingTime
            // 
            this.lbl_SearchingTime.AutoSize = true;
            this.lbl_SearchingTime.Location = new System.Drawing.Point(773, 113);
            this.lbl_SearchingTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SearchingTime.Name = "lbl_SearchingTime";
            this.lbl_SearchingTime.Size = new System.Drawing.Size(38, 17);
            this.lbl_SearchingTime.TabIndex = 11;
            this.lbl_SearchingTime.Text = "0 ms";
            // 
            // lbl_ProcessTimeForSearch
            // 
            this.lbl_ProcessTimeForSearch.AutoSize = true;
            this.lbl_ProcessTimeForSearch.Location = new System.Drawing.Point(605, 113);
            this.lbl_ProcessTimeForSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ProcessTimeForSearch.Name = "lbl_ProcessTimeForSearch";
            this.lbl_ProcessTimeForSearch.Size = new System.Drawing.Size(166, 17);
            this.lbl_ProcessTimeForSearch.TabIndex = 10;
            this.lbl_ProcessTimeForSearch.Text = "Searching Process Time:";
            // 
            // lv_Result
            // 
            this.lv_Result.Location = new System.Drawing.Point(29, 139);
            this.lv_Result.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lv_Result.Name = "lv_Result";
            this.lv_Result.Size = new System.Drawing.Size(892, 242);
            this.lv_Result.TabIndex = 9;
            this.lv_Result.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Location = new System.Drawing.Point(96, 118);
            this.lbl_Result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(55, 17);
            this.lbl_Result.TabIndex = 8;
            this.lbl_Result.Text = "Results";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(401, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Searching";
            // 
            // lblSearch
            // 
            this.lblSearch.Location = new System.Drawing.Point(381, 86);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(100, 28);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search";
            this.lblSearch.UseVisualStyleBackColor = true;
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Information Needs";
            // 
            // txt_InformationNeeds
            // 
            this.txt_InformationNeeds.Location = new System.Drawing.Point(228, 22);
            this.txt_InformationNeeds.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_InformationNeeds.Name = "txt_InformationNeeds";
            this.txt_InformationNeeds.Size = new System.Drawing.Size(559, 22);
            this.txt_InformationNeeds.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Menu;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txt_FileName);
            this.panel3.Controls.Add(this.lbl_FileName);
            this.panel3.Controls.Add(this.lbl_Warning);
            this.panel3.Controls.Add(this.lbl_Saving);
            this.panel3.Controls.Add(this.btn_SaveBrowse);
            this.panel3.Controls.Add(this.lbl_ExportPath);
            this.panel3.Controls.Add(this.txt_Saving);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(182, 234);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(927, 116);
            this.panel3.TabIndex = 8;
            // 
            // txt_FileName
            // 
            this.txt_FileName.Location = new System.Drawing.Point(288, 59);
            this.txt_FileName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_FileName.Name = "txt_FileName";
            this.txt_FileName.Size = new System.Drawing.Size(325, 22);
            this.txt_FileName.TabIndex = 10;
            // 
            // lbl_FileName
            // 
            this.lbl_FileName.AutoSize = true;
            this.lbl_FileName.Location = new System.Drawing.Point(176, 63);
            this.lbl_FileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_FileName.Name = "lbl_FileName";
            this.lbl_FileName.Size = new System.Drawing.Size(69, 17);
            this.lbl_FileName.TabIndex = 9;
            this.lbl_FileName.Text = "Filename:";
            // 
            // lbl_Warning
            // 
            this.lbl_Warning.AutoSize = true;
            this.lbl_Warning.ForeColor = System.Drawing.Color.Red;
            this.lbl_Warning.Location = new System.Drawing.Point(11, 91);
            this.lbl_Warning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Warning.Name = "lbl_Warning";
            this.lbl_Warning.Size = new System.Drawing.Size(446, 17);
            this.lbl_Warning.TabIndex = 8;
            this.lbl_Warning.Text = "Warning: After search is started, you are not able to change the path.";
            // 
            // lbl_Saving
            // 
            this.lbl_Saving.AutoSize = true;
            this.lbl_Saving.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Saving.Location = new System.Drawing.Point(410, -2);
            this.lbl_Saving.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Saving.Name = "lbl_Saving";
            this.lbl_Saving.Size = new System.Drawing.Size(52, 18);
            this.lbl_Saving.TabIndex = 7;
            this.lbl_Saving.Text = "Saving";
            // 
            // btn_SaveBrowse
            // 
            this.btn_SaveBrowse.Location = new System.Drawing.Point(623, 19);
            this.btn_SaveBrowse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SaveBrowse.Name = "btn_SaveBrowse";
            this.btn_SaveBrowse.Size = new System.Drawing.Size(100, 28);
            this.btn_SaveBrowse.TabIndex = 2;
            this.btn_SaveBrowse.Text = "Browse";
            this.btn_SaveBrowse.UseVisualStyleBackColor = true;
            this.btn_SaveBrowse.Click += new System.EventHandler(this.btn_SaveBrowse_Click);
            // 
            // lbl_ExportPath
            // 
            this.lbl_ExportPath.AutoSize = true;
            this.lbl_ExportPath.Location = new System.Drawing.Point(176, 26);
            this.lbl_ExportPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ExportPath.Name = "lbl_ExportPath";
            this.lbl_ExportPath.Size = new System.Drawing.Size(104, 17);
            this.lbl_ExportPath.TabIndex = 0;
            this.lbl_ExportPath.Text = "Choose a path:";
            // 
            // txt_Saving
            // 
            this.txt_Saving.Location = new System.Drawing.Point(288, 20);
            this.txt_Saving.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Saving.Name = "txt_Saving";
            this.txt_Saving.Size = new System.Drawing.Size(325, 22);
            this.txt_Saving.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1206, 785);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Kingsland University Retrieval System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_CollectionPath;
        private System.Windows.Forms.TextBox txt_CollectionPath;
        private System.Windows.Forms.Button btn_CollectionPath;
        private System.Windows.Forms.Label lbl_IndexPath;
        private System.Windows.Forms.TextBox txt_IndexPath;
        private System.Windows.Forms.Button btn_IndexPath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_GenerateIndex;
        private System.Windows.Forms.Label lbl_IndexingTime;
        private System.Windows.Forms.Label lbl_IndexingTimeName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button lblSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_InformationNeeds;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.ListView lv_Result;
        private System.Windows.Forms.Label lbl_SearchingTime;
        private System.Windows.Forms.Label lbl_ProcessTimeForSearch;
        private System.Windows.Forms.Label lbl_SearchType;
        private System.Windows.Forms.ComboBox ddl_Type;
        private System.Windows.Forms.ComboBox ddl_Fields;
        private System.Windows.Forms.Label lblTotalDocs;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_Saving;
        private System.Windows.Forms.Button btn_SaveBrowse;
        private System.Windows.Forms.Label lbl_ExportPath;
        private System.Windows.Forms.TextBox txt_Saving;
        private System.Windows.Forms.Label lbl_Warning;
        private System.Windows.Forms.TextBox txt_FileName;
        private System.Windows.Forms.Label lbl_FileName;
    }
}

