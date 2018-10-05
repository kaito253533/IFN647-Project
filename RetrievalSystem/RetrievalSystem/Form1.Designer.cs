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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_GenerateIndex = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.panel1.Controls.Add(this.btn_GenerateIndex);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_CollectionPath);
            this.panel1.Controls.Add(this.btn_IndexPath);
            this.panel1.Controls.Add(this.lbl_IndexPath);
            this.panel1.Controls.Add(this.txt_IndexPath);
            this.panel1.Controls.Add(this.lbl_CollectionPath);
            this.panel1.Controls.Add(this.txt_CollectionPath);
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 96);
            this.panel1.TabIndex = 6;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 262);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Kingsland University Retrieval System";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}

