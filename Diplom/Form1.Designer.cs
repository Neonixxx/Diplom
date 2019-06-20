namespace Diplom
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
            this.TaskLabel = new System.Windows.Forms.Label();
            this.NewTaskButton = new System.Windows.Forms.Button();
            this.AnswerTextBox = new System.Windows.Forms.RichTextBox();
            this.CheckAnswerButton = new System.Windows.Forms.Button();
            this.AnswerResultLabel = new System.Windows.Forms.Label();
            this.TaskNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TaskLabel
            // 
            this.TaskLabel.AutoSize = true;
            this.TaskLabel.Location = new System.Drawing.Point(56, 85);
            this.TaskLabel.MaximumSize = new System.Drawing.Size(400, 0);
            this.TaskLabel.Name = "TaskLabel";
            this.TaskLabel.Size = new System.Drawing.Size(57, 13);
            this.TaskLabel.TabIndex = 0;
            this.TaskLabel.Text = "TaskLabel";
            // 
            // NewTaskButton
            // 
            this.NewTaskButton.Location = new System.Drawing.Point(238, 302);
            this.NewTaskButton.Name = "NewTaskButton";
            this.NewTaskButton.Size = new System.Drawing.Size(111, 71);
            this.NewTaskButton.TabIndex = 1;
            this.NewTaskButton.Text = "New task";
            this.NewTaskButton.UseVisualStyleBackColor = true;
            this.NewTaskButton.Click += new System.EventHandler(this.NewTaskButton_Click);
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.Location = new System.Drawing.Point(504, 97);
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(153, 110);
            this.AnswerTextBox.TabIndex = 2;
            this.AnswerTextBox.Text = "";
            // 
            // CheckAnswerButton
            // 
            this.CheckAnswerButton.Location = new System.Drawing.Point(437, 302);
            this.CheckAnswerButton.Name = "CheckAnswerButton";
            this.CheckAnswerButton.Size = new System.Drawing.Size(111, 71);
            this.CheckAnswerButton.TabIndex = 3;
            this.CheckAnswerButton.Text = "Check answer";
            this.CheckAnswerButton.UseVisualStyleBackColor = true;
            this.CheckAnswerButton.Click += new System.EventHandler(this.CheckAnswerButton_Click);
            // 
            // AnswerResultLabel
            // 
            this.AnswerResultLabel.AutoSize = true;
            this.AnswerResultLabel.Location = new System.Drawing.Point(372, 398);
            this.AnswerResultLabel.Name = "AnswerResultLabel";
            this.AnswerResultLabel.Size = new System.Drawing.Size(70, 13);
            this.AnswerResultLabel.TabIndex = 4;
            this.AnswerResultLabel.Text = "Answer result";
            // 
            // TaskNumberLabel
            // 
            this.TaskNumberLabel.AutoSize = true;
            this.TaskNumberLabel.Location = new System.Drawing.Point(56, 53);
            this.TaskNumberLabel.Name = "TaskNumberLabel";
            this.TaskNumberLabel.Size = new System.Drawing.Size(94, 13);
            this.TaskNumberLabel.TabIndex = 5;
            this.TaskNumberLabel.Text = "TaskNumberLabel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TaskNumberLabel);
            this.Controls.Add(this.AnswerResultLabel);
            this.Controls.Add(this.CheckAnswerButton);
            this.Controls.Add(this.AnswerTextBox);
            this.Controls.Add(this.NewTaskButton);
            this.Controls.Add(this.TaskLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TaskLabel;
        private System.Windows.Forms.Button NewTaskButton;
        private System.Windows.Forms.RichTextBox AnswerTextBox;
        private System.Windows.Forms.Button CheckAnswerButton;
        private System.Windows.Forms.Label AnswerResultLabel;
        private System.Windows.Forms.Label TaskNumberLabel;
    }
}

