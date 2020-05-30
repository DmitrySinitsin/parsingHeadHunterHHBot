namespace HHBot
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
            this.GridView = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_salary_from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_salary_to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_empl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_addr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GridView
            // 
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColName,
            this.Col_salary_from,
            this.Col_salary_to,
            this.Col_empl,
            this.Col_addr,
            this.Col_info});
            this.GridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.GridView.Location = new System.Drawing.Point(0, 0);
            this.GridView.Name = "GridView";
            this.GridView.Size = new System.Drawing.Size(744, 294);
            this.GridView.TabIndex = 3;
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Name";
            this.ColName.Name = "ColName";
            // 
            // Col_salary_from
            // 
            this.Col_salary_from.HeaderText = "salary_min";
            this.Col_salary_from.Name = "Col_salary_from";
            // 
            // Col_salary_to
            // 
            this.Col_salary_to.HeaderText = "salary_max";
            this.Col_salary_to.Name = "Col_salary_to";
            // 
            // Col_empl
            // 
            this.Col_empl.HeaderText = "Employer";
            this.Col_empl.Name = "Col_empl";
            // 
            // Col_addr
            // 
            this.Col_addr.HeaderText = "Address";
            this.Col_addr.Name = "Col_addr";
            // 
            // Col_info
            // 
            this.Col_info.HeaderText = "Info";
            this.Col_info.Name = "Col_info";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(13, 301);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(451, 20);
            this.searchBox.TabIndex = 4;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(615, 301);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(129, 23);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(471, 301);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(0, 13);
            this.labelCount.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 326);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.GridView);
            this.Name = "Form1";
            this.Text = "HH API";
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_salary_from;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_salary_to;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_empl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_addr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_info;
        private System.Windows.Forms.Label labelCount;
    }
}

