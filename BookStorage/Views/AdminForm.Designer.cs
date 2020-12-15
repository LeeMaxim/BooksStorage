namespace BookStorage.Views
{
    partial class AdminForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.bookGridView = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfReleseColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameAutorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(1, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вы вошли как администратор";
            // 
            // bookGridView
            // 
            this.bookGridView.AllowUserToAddRows = false;
            this.bookGridView.AllowUserToDeleteRows = false;
            this.bookGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.nameColumn,
            this.dateOfReleseColumn,
            this.pagesColumn,
            this.fullNameAutorColumn,
            this.genreColumn});
            this.bookGridView.Location = new System.Drawing.Point(12, 21);
            this.bookGridView.MultiSelect = false;
            this.bookGridView.Name = "bookGridView";
            this.bookGridView.ReadOnly = true;
            this.bookGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookGridView.Size = new System.Drawing.Size(776, 355);
            this.bookGridView.TabIndex = 1;
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.HeaderText = "ИД";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            // 
            // nameColumn
            // 
            this.nameColumn.DataPropertyName = "Name";
            this.nameColumn.HeaderText = "Название книги";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // dateOfReleseColumn
            // 
            this.dateOfReleseColumn.DataPropertyName = "DateOfRelese";
            this.dateOfReleseColumn.HeaderText = "Дата выпуска";
            this.dateOfReleseColumn.Name = "dateOfReleseColumn";
            this.dateOfReleseColumn.ReadOnly = true;
            // 
            // pagesColumn
            // 
            this.pagesColumn.DataPropertyName = "Pages";
            this.pagesColumn.HeaderText = "Количество страниц";
            this.pagesColumn.Name = "pagesColumn";
            this.pagesColumn.ReadOnly = true;
            // 
            // fullNameAutorColumn
            // 
            this.fullNameAutorColumn.DataPropertyName = "FullNameAutor";
            this.fullNameAutorColumn.HeaderText = "ФИО";
            this.fullNameAutorColumn.Name = "fullNameAutorColumn";
            this.fullNameAutorColumn.ReadOnly = true;
            // 
            // genreColumn
            // 
            this.genreColumn.DataPropertyName = "Genre";
            this.genreColumn.HeaderText = "Жанр";
            this.genreColumn.Name = "genreColumn";
            this.genreColumn.ReadOnly = true;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(12, 382);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(172, 56);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Редактировать";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(308, 382);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(172, 56);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(616, 382);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(172, 56);
            this.createButton.TabIndex = 4;
            this.createButton.Text = "Создать";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.bookGridView);
            this.Controls.Add(this.label1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView bookGridView;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfReleseColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameAutorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreColumn;
    }
}