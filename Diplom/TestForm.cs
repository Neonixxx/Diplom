using System;
using System.Windows.Forms;
using Core;

namespace Diplom
{
    public partial class TestForm : Form
    {
        private readonly TaskService _taskService = new TaskService();
        private DateTime StartDate;

        public TestForm()
        {
            InitializeComponent();
        }

        public TestResult StartTest()
        {
            StartDate = DateTime.Now;
            UpdateData();

            ShowDialog();

            var testResult = _taskService.GetTestResult();
            testResult.Date = StartDate;
            testResult.Elapsed = StartDate - DateTime.Now;

            return testResult;
        }

        private void UpdateData()
        {
            TaskLabel.Text = _taskService.GetTaskString();
            AnswerTextBox.Text = "";
            TaskNumberLabel.Text = $"Задача {_taskService.CurrentTaskNumber}.";
        }

        private void NextTaskButton_Click(object sender, EventArgs e)
        {
            _taskService.SaveResult(AnswerTextBox.Text);

            if (_taskService.GoToNextTask())
            {
                Close();
                return;
            }

            UpdateData();
        }
    }
}
