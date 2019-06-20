namespace Diplom
{
    partial class TestForm
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
            this.TaskLabel = new System.Windows.Forms.Label();
            this.AnswerTextBox = new System.Windows.Forms.RichTextBox();
            this.NextTaskButton = new System.Windows.Forms.Button();
            this.TaskNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TaskLabel
            // 
            this.TaskLabel.AutoSize = true;
            this.TaskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.TaskLabel.Location = new System.Drawing.Point(75, 110);
            this.TaskLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TaskLabel.MaximumSize = new System.Drawing.Size(533, 0);
            this.TaskLabel.Name = "TaskLabel";
            this.TaskLabel.Size = new System.Drawing.Size(112, 25);
            this.TaskLabel.TabIndex = 0;
            this.TaskLabel.Text = "TaskLabel";
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.Location = new System.Drawing.Point(667, 65);
            this.AnswerTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(205, 147);
            this.AnswerTextBox.TabIndex = 2;
            this.AnswerTextBox.Text = "";
            // 
            // NextTaskButton
            // 
            this.NextTaskButton.Location = new System.Drawing.Point(667, 266);
            this.NextTaskButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NextTaskButton.Name = "NextTaskButton";
            this.NextTaskButton.Size = new System.Drawing.Size(207, 66);
            this.NextTaskButton.TabIndex = 3;
            this.NextTaskButton.Text = "Следующая задача";
            this.NextTaskButton.UseVisualStyleBackColor = true;
            this.NextTaskButton.Click += new System.EventHandler(this.NextTaskButton_Click);
            // 
            // TaskNumberLabel
            // 
            this.TaskNumberLabel.AutoSize = true;
            this.TaskNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.TaskNumberLabel.Location = new System.Drawing.Point(75, 65);
            this.TaskNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TaskNumberLabel.Name = "TaskNumberLabel";
            this.TaskNumberLabel.Size = new System.Drawing.Size(247, 32);
            this.TaskNumberLabel.TabIndex = 5;
            this.TaskNumberLabel.Text = "TaskNumberLabel";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 395);
            this.Controls.Add(this.TaskNumberLabel);
            this.Controls.Add(this.NextTaskButton);
            this.Controls.Add(this.AnswerTextBox);
            this.Controls.Add(this.TaskLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TestForm";
            this.Text = "Тестирование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TaskLabel;
        private System.Windows.Forms.RichTextBox AnswerTextBox;
        private System.Windows.Forms.Button NextTaskButton;
        private System.Windows.Forms.Label TaskNumberLabel;
    }
}

