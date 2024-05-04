using System.Drawing.Text;
using System.Text.RegularExpressions;

namespace Typography
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();

            this.Controls.Add(inputTextBox);
            this.Controls.Add(outputTextBox);

            inputTextBox.TextChanged += InputChangedText;
        }

        #region Методы
        /// <summary>
        /// Метод для изменения текстового поля в outputTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputChangedText(object sender, EventArgs e)
        {
            outputTextBox.Text = inputTextBox.Text;
        }

        /// <summary>
        ///  Метод, который убирает лишние пробелы
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string RemoveUnnecessarySpaces(string input)
        {
            return Regex.Replace(input, @"\s+", " ");
        }

        /// <summary>
        ///  Метод, который убирает пробелы до и после дефиса 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string RemoveSpacesNearHyphen(string input)
        {
            string ruleOfReplacing = @"(\s+)(\-|\s-)(\s+)";
            return Regex.Replace(input, ruleOfReplacing, "$2");
        }

        /// <summary>
        /// Метод для обновления формы, после нажатия кнопки 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Refresh(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            outputTextBox.Text = RemoveUnnecessarySpaces(input);
            outputTextBox.Text = RemoveSpacesNearHyphen(input);
        }
        #endregion

    }
}
