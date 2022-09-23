namespace Exam1ExtraCredit
{
    partial class BookView
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
            this.uxPageForward = new System.Windows.Forms.Button();
            this.uxPageBackward = new System.Windows.Forms.Button();
            this.uxPageNumberUpDown = new System.Windows.Forms.NumericUpDown();
            this.uxJumpToPageLabel = new System.Windows.Forms.Label();
            this.uxPageJumpButton = new System.Windows.Forms.Button();
            this.uxBookTextBox = new System.Windows.Forms.RichTextBox();
            this.uxAddBookmarkButton = new System.Windows.Forms.Button();
            this.uxRemoveBookMark = new System.Windows.Forms.Button();
            this.uxBookmarks = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uxBookmarkListBox = new System.Windows.Forms.ListBox();
            this.uxBookmarkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxPageNumberUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // uxPageForward
            // 
            this.uxPageForward.Location = new System.Drawing.Point(445, 362);
            this.uxPageForward.Name = "uxPageForward";
            this.uxPageForward.Size = new System.Drawing.Size(143, 65);
            this.uxPageForward.TabIndex = 0;
            this.uxPageForward.Text = "Page Forward";
            this.uxPageForward.UseVisualStyleBackColor = true;
            this.uxPageForward.Click += new System.EventHandler(this.uxPageForward_Click);
            // 
            // uxPageBackward
            // 
            this.uxPageBackward.Location = new System.Drawing.Point(61, 361);
            this.uxPageBackward.Name = "uxPageBackward";
            this.uxPageBackward.Size = new System.Drawing.Size(146, 65);
            this.uxPageBackward.TabIndex = 1;
            this.uxPageBackward.Text = "Page Backward";
            this.uxPageBackward.UseVisualStyleBackColor = true;
            this.uxPageBackward.Click += new System.EventHandler(this.uxPageBackward_Click);
            // 
            // uxPageNumberUpDown
            // 
            this.uxPageNumberUpDown.Location = new System.Drawing.Point(232, 404);
            this.uxPageNumberUpDown.Name = "uxPageNumberUpDown";
            this.uxPageNumberUpDown.Size = new System.Drawing.Size(120, 22);
            this.uxPageNumberUpDown.TabIndex = 2;
            // 
            // uxJumpToPageLabel
            // 
            this.uxJumpToPageLabel.AutoSize = true;
            this.uxJumpToPageLabel.Location = new System.Drawing.Point(229, 385);
            this.uxJumpToPageLabel.Name = "uxJumpToPageLabel";
            this.uxJumpToPageLabel.Size = new System.Drawing.Size(100, 16);
            this.uxJumpToPageLabel.TabIndex = 3;
            this.uxJumpToPageLabel.Text = "Page to jump to";
            // 
            // uxPageJumpButton
            // 
            this.uxPageJumpButton.Location = new System.Drawing.Point(358, 404);
            this.uxPageJumpButton.Name = "uxPageJumpButton";
            this.uxPageJumpButton.Size = new System.Drawing.Size(46, 23);
            this.uxPageJumpButton.TabIndex = 4;
            this.uxPageJumpButton.Text = "Go";
            this.uxPageJumpButton.UseVisualStyleBackColor = true;
            this.uxPageJumpButton.Click += new System.EventHandler(this.uxPageJumpButton_Click);
            // 
            // uxBookTextBox
            // 
            this.uxBookTextBox.Location = new System.Drawing.Point(61, 34);
            this.uxBookTextBox.Name = "uxBookTextBox";
            this.uxBookTextBox.Size = new System.Drawing.Size(527, 308);
            this.uxBookTextBox.TabIndex = 5;
            this.uxBookTextBox.Text = "";
            // 
            // uxAddBookmarkButton
            // 
            this.uxAddBookmarkButton.Location = new System.Drawing.Point(626, 196);
            this.uxAddBookmarkButton.Name = "uxAddBookmarkButton";
            this.uxAddBookmarkButton.Size = new System.Drawing.Size(126, 70);
            this.uxAddBookmarkButton.TabIndex = 6;
            this.uxAddBookmarkButton.Text = "Add\r\nBookmark\r\n\r\n";
            this.uxAddBookmarkButton.UseVisualStyleBackColor = true;
            this.uxAddBookmarkButton.Click += new System.EventHandler(this.uxAddBookmarkButton_Click);
            // 
            // uxRemoveBookMark
            // 
            this.uxRemoveBookMark.Location = new System.Drawing.Point(626, 272);
            this.uxRemoveBookMark.Name = "uxRemoveBookMark";
            this.uxRemoveBookMark.Size = new System.Drawing.Size(126, 70);
            this.uxRemoveBookMark.TabIndex = 7;
            this.uxRemoveBookMark.Text = "Remove\r\nBookmark\r\n\r\n";
            this.uxRemoveBookMark.UseVisualStyleBackColor = true;
            this.uxRemoveBookMark.Click += new System.EventHandler(this.uxRemoveBookMark_Click);
            // 
            // uxBookmarks
            // 
            this.uxBookmarks.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.uxBookmarks.Name = "uxBookmarks";
            this.uxBookmarks.Size = new System.Drawing.Size(61, 4);
            this.uxBookmarks.Text = "Bookmarks";
            // 
            // uxBookmarkListBox
            // 
            this.uxBookmarkListBox.FormattingEnabled = true;
            this.uxBookmarkListBox.ItemHeight = 16;
            this.uxBookmarkListBox.Location = new System.Drawing.Point(626, 67);
            this.uxBookmarkListBox.Name = "uxBookmarkListBox";
            this.uxBookmarkListBox.Size = new System.Drawing.Size(126, 116);
            this.uxBookmarkListBox.TabIndex = 9;
            // 
            // uxBookmarkLabel
            // 
            this.uxBookmarkLabel.AutoSize = true;
            this.uxBookmarkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBookmarkLabel.Location = new System.Drawing.Point(637, 34);
            this.uxBookmarkLabel.Name = "uxBookmarkLabel";
            this.uxBookmarkLabel.Size = new System.Drawing.Size(93, 20);
            this.uxBookmarkLabel.TabIndex = 10;
            this.uxBookmarkLabel.Text = "Bookmarks\r\n";
            // 
            // BookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.uxBookmarkLabel);
            this.Controls.Add(this.uxBookmarkListBox);
            this.Controls.Add(this.uxRemoveBookMark);
            this.Controls.Add(this.uxAddBookmarkButton);
            this.Controls.Add(this.uxBookTextBox);
            this.Controls.Add(this.uxPageJumpButton);
            this.Controls.Add(this.uxJumpToPageLabel);
            this.Controls.Add(this.uxPageNumberUpDown);
            this.Controls.Add(this.uxPageBackward);
            this.Controls.Add(this.uxPageForward);
            this.Name = "BookView";
            this.Text = "BookView";
            ((System.ComponentModel.ISupportInitialize)(this.uxPageNumberUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxPageForward;
        private System.Windows.Forms.Button uxPageBackward;
        private System.Windows.Forms.NumericUpDown uxPageNumberUpDown;
        private System.Windows.Forms.Label uxJumpToPageLabel;
        private System.Windows.Forms.Button uxPageJumpButton;
        private System.Windows.Forms.RichTextBox uxBookTextBox;
        private System.Windows.Forms.Button uxAddBookmarkButton;
        private System.Windows.Forms.Button uxRemoveBookMark;
        private System.Windows.Forms.ContextMenuStrip uxBookmarks;
        private System.Windows.Forms.ListBox uxBookmarkListBox;
        private System.Windows.Forms.Label uxBookmarkLabel;
    }
}