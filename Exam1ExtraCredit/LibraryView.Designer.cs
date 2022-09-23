namespace Exam1ExtraCredit
{
    partial class LibraryView
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
            this.uxOpenBookButton = new System.Windows.Forms.Button();
            this.uxSyncButton = new System.Windows.Forms.Button();
            this.uxListOfBooks = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // uxOpenBookButton
            // 
            this.uxOpenBookButton.Enabled = false;
            this.uxOpenBookButton.Location = new System.Drawing.Point(299, 304);
            this.uxOpenBookButton.Name = "uxOpenBookButton";
            this.uxOpenBookButton.Size = new System.Drawing.Size(123, 47);
            this.uxOpenBookButton.TabIndex = 0;
            this.uxOpenBookButton.Text = "Open Book";
            this.uxOpenBookButton.UseVisualStyleBackColor = true;
            this.uxOpenBookButton.Click += new System.EventHandler(this.uxOpenBookButton_Click);
            // 
            // uxSyncButton
            // 
            this.uxSyncButton.Location = new System.Drawing.Point(153, 304);
            this.uxSyncButton.Name = "uxSyncButton";
            this.uxSyncButton.Size = new System.Drawing.Size(115, 47);
            this.uxSyncButton.TabIndex = 1;
            this.uxSyncButton.Text = "Sync To Cloud";
            this.uxSyncButton.UseVisualStyleBackColor = true;
            this.uxSyncButton.Click += new System.EventHandler(this.uxSyncButton_Click);
            // 
            // uxListOfBooks
            // 
            this.uxListOfBooks.FormattingEnabled = true;
            this.uxListOfBooks.ItemHeight = 16;
            this.uxListOfBooks.Location = new System.Drawing.Point(153, 50);
            this.uxListOfBooks.Name = "uxListOfBooks";
            this.uxListOfBooks.Size = new System.Drawing.Size(269, 228);
            this.uxListOfBooks.TabIndex = 2;
            this.uxListOfBooks.SelectedIndexChanged += new System.EventHandler(this.uxListOfBooks_SelectedIndexChanged);
            // 
            // LibraryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 450);
            this.Controls.Add(this.uxListOfBooks);
            this.Controls.Add(this.uxSyncButton);
            this.Controls.Add(this.uxOpenBookButton);
            this.Name = "LibraryView";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxOpenBookButton;
        private System.Windows.Forms.Button uxSyncButton;
        private System.Windows.Forms.ListBox uxListOfBooks;
    }
}

