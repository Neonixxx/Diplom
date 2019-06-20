using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class StartForm : Form
    {
        private TestForm _testForm;

        private char[] _russianSymbols =
        {
            'а', 'б', 'в', 'г', 'д', 'е', 'ё',
            'ж', 'з', 'и', 'й', 'к', 'л', 'м',
            'н', 'о', 'п', 'р', 'с', 'т', 'у',
            'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ',
            'ы', 'ь', 'э', 'ю', 'я'
        };

        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            var validateError = ValidateInput();
            if (!string.IsNullOrEmpty(validateError))
            {
                MessageBox.Show(validateError);
                return;
            }

            var studentInfo = new StudentInfo
            {
                FamilyName = FamilyTextBox.Text,
                Name = NameTextBox.Text,
                Group = GroupTextBox.Text
            };

            _testForm = new TestForm();

            Hide();

            var testResult = _testForm.StartTest();

            var testResultForm = new TestResultForm();
            testResultForm.ShowTestResult(studentInfo, testResult);
            Close();
        }

        private string ValidateInput()
        {
            var family = FamilyTextBox.Text;
            var name = NameTextBox.Text;
            var group = GroupTextBox.Text;

            if (string.IsNullOrWhiteSpace(family))
                return "Поле 'Фамилия' не может быть пустым";
            if (!family.ToLower().Any(f => _russianSymbols.Contains(f)))
                return "Поле 'Фамилия' содержит недопустимые символы (допускается только русский алфавит)";
            if (string.IsNullOrWhiteSpace(name))
                return "Поле 'Имя' не может быть пустым";
            if (!family.ToLower().Any(f => _russianSymbols.Contains(f)))
                return "Поле 'Имя' содержит недопустимые символы (допускается только русский алфавит)";
            if (string.IsNullOrWhiteSpace(group))
                return "Поле 'Группа' не может быть пустым";

            return "";
        }
    }
}
