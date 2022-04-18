
namespace MEPHI_Library
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
            this.books_GridView = new System.Windows.Forms.DataGridView();
            this.addBook_btn = new System.Windows.Forms.Button();
            this.editBook_btn = new System.Windows.Forms.Button();
            this.deleteBook_btn = new System.Windows.Forms.Button();
            this.saveBooks_btn = new System.Windows.Forms.Button();
            this.loadBooks_btn = new System.Windows.Forms.Button();
            this.sort_comboBox = new System.Windows.Forms.ComboBox();
            this.saveLoadState = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.books_GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // books_GridView
            // 
            this.books_GridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.books_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.books_GridView.Location = new System.Drawing.Point(12, 12);
            this.books_GridView.Name = "books_GridView";
            this.books_GridView.ReadOnly = true;
            this.books_GridView.RowHeadersVisible = false;
            this.books_GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.books_GridView.Size = new System.Drawing.Size(557, 252);
            this.books_GridView.TabIndex = 0;
            // 
            // addBook_btn
            // 
            this.addBook_btn.Location = new System.Drawing.Point(12, 284);
            this.addBook_btn.Name = "addBook_btn";
            this.addBook_btn.Size = new System.Drawing.Size(75, 23);
            this.addBook_btn.TabIndex = 1;
            this.addBook_btn.Text = "ДОБАВИТЬ";
            this.addBook_btn.UseVisualStyleBackColor = true;
            this.addBook_btn.Click += new System.EventHandler(this.addBook_btn_Click);
            // 
            // editBook_btn
            // 
            this.editBook_btn.Location = new System.Drawing.Point(93, 284);
            this.editBook_btn.Name = "editBook_btn";
            this.editBook_btn.Size = new System.Drawing.Size(84, 23);
            this.editBook_btn.TabIndex = 2;
            this.editBook_btn.Text = "ИЗМЕНИТЬ";
            this.editBook_btn.UseVisualStyleBackColor = true;
            this.editBook_btn.Click += new System.EventHandler(this.editBook_btn_Click);
            // 
            // deleteBook_btn
            // 
            this.deleteBook_btn.Location = new System.Drawing.Point(183, 284);
            this.deleteBook_btn.Name = "deleteBook_btn";
            this.deleteBook_btn.Size = new System.Drawing.Size(75, 23);
            this.deleteBook_btn.TabIndex = 3;
            this.deleteBook_btn.Text = "УДАЛИТЬ";
            this.deleteBook_btn.UseVisualStyleBackColor = true;
            this.deleteBook_btn.Click += new System.EventHandler(this.deleteBook_btn_Click);
            // 
            // saveBooks_btn
            // 
            this.saveBooks_btn.Location = new System.Drawing.Point(482, 284);
            this.saveBooks_btn.Name = "saveBooks_btn";
            this.saveBooks_btn.Size = new System.Drawing.Size(87, 23);
            this.saveBooks_btn.TabIndex = 4;
            this.saveBooks_btn.Text = "СОХРАНИТЬ";
            this.saveBooks_btn.UseVisualStyleBackColor = true;
            this.saveBooks_btn.Click += new System.EventHandler(this.saveBooks_btn_Click);
            // 
            // loadBooks_btn
            // 
            this.loadBooks_btn.Location = new System.Drawing.Point(482, 313);
            this.loadBooks_btn.Name = "loadBooks_btn";
            this.loadBooks_btn.Size = new System.Drawing.Size(87, 23);
            this.loadBooks_btn.TabIndex = 5;
            this.loadBooks_btn.Text = "ЗАГРУЗИТЬ";
            this.loadBooks_btn.UseVisualStyleBackColor = true;
            this.loadBooks_btn.Click += new System.EventHandler(this.loadBooks_btn_Click);
            // 
            // sort_comboBox
            // 
            this.sort_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sort_comboBox.FormattingEnabled = true;
            this.sort_comboBox.Location = new System.Drawing.Point(12, 315);
            this.sort_comboBox.Name = "sort_comboBox";
            this.sort_comboBox.Size = new System.Drawing.Size(121, 21);
            this.sort_comboBox.TabIndex = 6;
            this.sort_comboBox.TextChanged += new System.EventHandler(this.sort_comboBox_TextChanged);
            // 
            // saveLoadState
            // 
            this.saveLoadState.AutoSize = true;
            this.saveLoadState.Location = new System.Drawing.Point(298, 289);
            this.saveLoadState.MaximumSize = new System.Drawing.Size(180, 0);
            this.saveLoadState.Name = "saveLoadState";
            this.saveLoadState.Size = new System.Drawing.Size(0, 13);
            this.saveLoadState.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 357);
            this.Controls.Add(this.saveLoadState);
            this.Controls.Add(this.sort_comboBox);
            this.Controls.Add(this.loadBooks_btn);
            this.Controls.Add(this.saveBooks_btn);
            this.Controls.Add(this.deleteBook_btn);
            this.Controls.Add(this.editBook_btn);
            this.Controls.Add(this.addBook_btn);
            this.Controls.Add(this.books_GridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.books_GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView books_GridView;
        private System.Windows.Forms.Button addBook_btn;
        private System.Windows.Forms.Button editBook_btn;
        private System.Windows.Forms.Button deleteBook_btn;
        private System.Windows.Forms.Button saveBooks_btn;
        private System.Windows.Forms.Button loadBooks_btn;
        private System.Windows.Forms.ComboBox sort_comboBox;
        private System.Windows.Forms.Label saveLoadState;
    }
}

