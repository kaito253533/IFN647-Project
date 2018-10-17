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
            this.lbl_Result = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_InformationNeeds = new System.Windows.Forms.TextBox();
            this.lv_Result = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_CollectionPath
            // 
            this.lbl_CollectionPath.AutoSize = true;
            this.lbl_CollectionPath.Location = new System.Drawing.Point(3, 22);
            this.lbl_CollectionPath.Name = "lbl_CollectionPath";
            this.lbl_CollectionPath.Size = new System.Drawing.Size(81, 13);
            this.lbl_CollectionPath.TabIndex = 0;
            this.lbl_CollectionPath.Text = "Collection Path:";
            // 
            // txt_CollectionPath
            // 
            this.txt_CollectionPath.Location = new System.Drawing.Point(87, 17);
            this.txt_CollectionPath.Name = "txt_CollectionPath";
            this.txt_CollectionPath.Size = new System.Drawing.Size(245, 20);
            this.txt_CollectionPath.TabIndex = 1;
            // 
            // btn_CollectionPath
            // 
            this.btn_CollectionPath.Location = new System.Drawing.Point(338, 16);
            this.btn_CollectionPath.Name = "btn_CollectionPath";
            this.btn_CollectionPath.Size = new System.Drawing.Size(75, 23);
            this.btn_CollectionPath.TabIndex = 2;
            this.btn_CollectionPath.Text = "Browse";
            this.btn_CollectionPath.UseVisualStyleBackColor = true;
            this.btn_CollectionPath.Click += new System.EventHandler(this.btn_CollectionPath_Click);
            // 
            // lbl_IndexPath
            // 
            this.lbl_IndexPath.AutoSize = true;
            this.lbl_IndexPath.Location = new System.Drawing.Point(3, 43);
            this.lbl_IndexPath.Name = "lbl_IndexPath";
            this.lbl_IndexPath.Size = new System.Drawing.Size(61, 13);
            this.lbl_IndexPath.TabIndex = 3;
            this.lbl_IndexPath.Text = "Index Path:";
            // 
            // txt_IndexPath
            // 
            this.txt_IndexPath.Location = new System.Drawing.Point(87, 41);
            this.txt_IndexPath.Name = "txt_IndexPath";
            this.txt_IndexPath.Size = new System.Drawing.Size(245, 20);
            this.txt_IndexPath.TabIndex = 4;
            // 
            // btn_IndexPath
            // 
            this.btn_IndexPath.Location = new System.Drawing.Point(338, 41);
            this.btn_IndexPath.Name = "btn_IndexPath";
            this.btn_IndexPath.Size = new System.Drawing.Size(75, 23);
            this.btn_IndexPath.TabIndex = 5;
            this.btn_IndexPath.Text = "Browse";
            this.btn_IndexPath.UseVisualStyleBackColor = true;
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
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 96);
            this.panel1.TabIndex = 6;
            // 
            // lbl_IndexingTime
            // 
            this.lbl_IndexingTime.AutoSize = true;
            this.lbl_IndexingTime.Location = new System.Drawing.Point(500, 79);
            this.lbl_IndexingTime.Name = "lbl_IndexingTime";
            this.lbl_IndexingTime.Size = new System.Drawing.Size(29, 13);
            this.lbl_IndexingTime.TabIndex = 9;
            this.lbl_IndexingTime.Text = "0 ms";
            // 
            // btn_GenerateIndex
            // 
            this.btn_GenerateIndex.Location = new System.Drawing.Point(615, 69);
            this.btn_GenerateIndex.Name = "btn_GenerateIndex";
            this.btn_GenerateIndex.Size = new System.Drawing.Size(75, 23);
            this.btn_GenerateIndex.TabIndex = 8;
            this.btn_GenerateIndex.Text = "Index";
            this.btn_GenerateIndex.UseVisualStyleBackColor = true;
            this.btn_GenerateIndex.Click += new System.EventHandler(this.btn_GenerateIndex_Click);
            // 
            // lbl_IndexingTimeName
            // 
            this.lbl_IndexingTimeName.AutoSize = true;
            this.lbl_IndexingTimeName.Location = new System.Drawing.Point(420, 79);
            this.lbl_IndexingTimeName.Name = "lbl_IndexingTimeName";
            this.lbl_IndexingTimeName.Size = new System.Drawing.Size(74, 13);
            this.lbl_IndexingTimeName.TabIndex = 7;
            this.lbl_IndexingTimeName.Text = "Process Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Indexing";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Menu;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lv_Result);
            this.panel2.Controls.Add(this.lbl_Result);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblSearch);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_InformationNeeds);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(12, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(696, 290);
            this.panel2.TabIndex = 7;
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Location = new System.Drawing.Point(3, 45);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(37, 13);
            this.lbl_Result.TabIndex = 8;
            this.lbl_Result.Text = "Result";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Searching";
            // 
            // lblSearch
            // 
            this.lblSearch.Location = new System.Drawing.Point(615, 15);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(75, 23);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search";
            this.lblSearch.UseVisualStyleBackColor = true;
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Information Needs";
            // 
            // txt_InformationNeeds
            // 
            this.txt_InformationNeeds.Location = new System.Drawing.Point(102, 18);
            this.txt_InformationNeeds.Name = "txt_InformationNeeds";
            this.txt_InformationNeeds.Size = new System.Drawing.Size(507, 20);
            this.txt_InformationNeeds.TabIndex = 1;
            // 
            // lv_Result
            // 
            this.lv_Result.Location = new System.Drawing.Point(6, 62);
            this.lv_Result.Name = "lv_Result";
            this.lv_Result.Size = new System.Drawing.Size(670, 210);
            this.lv_Result.TabIndex = 9;
            this.lv_Result.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 560);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Kingsland University Retrieval System";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
    }
}

