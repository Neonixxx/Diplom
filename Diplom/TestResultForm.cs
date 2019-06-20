using System.Windows.Forms;
using Core;

namespace Diplom
{
    public partial class TestResultForm : Form
    {
        public TestResultForm()
        {
            InitializeComponent();
        }

        public void ShowTestResult(StudentInfo studentInfo, TestResult testResult)
        {
            StudentInfoLabel.Text = studentInfo.ToString();
            DateLabel.Text = testResult.Date.ToShortDateString();
            var tasksCount = testResult.TaskResults.Count;
            TaskCountLabel.Text = tasksCount.ToString();
            SuccessTasksCountLabel.Text = FormatCountString(testResult.SuccessTasksCount, tasksCount);
            FailedTaksCountLabel.Text = FormatCountString(testResult.FailedTasksCount, tasksCount);
            TimeSpentLabel.Text = testResult.Elapsed.ToString(@"mm\:ss");

            ShowDialog();
        }

        private string FormatCountString(int count, int maxCount)
            => $"{count} ({((double) count / maxCount).ToPercent(1)})";
    }
}
