using System;
using System.Windows.Forms;
using Core;

namespace Diplom
{
    public partial class Form1 : Form
    {
        private readonly TaskService _taskService = new TaskService();

        public Form1()
        {
            InitializeComponent();

            UpdateData();

            AnswerResultLabel.Text = "";
        }

        private void UpdateData()
        {
            TaskLabel.Text = _taskService.GetTaskString();
            AnswerTextBox.Text = "";
            TaskNumberLabel.Text = $"Задача {_taskService.CurrentTaskNumber}.";
        }

        private void NewTaskButton_Click(object sender, EventArgs e)
        {
            _taskService.GoToNextTask();
            UpdateData();

            AnswerResultLabel.Text = "";
        }

        private void CheckAnswerButton_Click(object sender, EventArgs e)
        {
            var result = _taskService.CheckResult(AnswerTextBox.Text);
            AnswerResultLabel.Text = result
                ? "Правильно"
                : "Неправильно";
        }
    }
}
