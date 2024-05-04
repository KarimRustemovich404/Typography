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

        #region ������
        /// <summary>
        /// ����� ��� ��������� ���������� ���� � outputTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputChangedText(object sender, EventArgs e)
        {
            outputTextBox.Text = inputTextBox.Text;
        }

        /// <summary>
        ///  �����, ������� ������� ������ �������
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string RemoveUnnecessarySpaces(string input)
        {
            return Regex.Replace(input, @"\s+", " ");
        }

        /// <summary>
        ///  �����, ������� ������� ������� �� � ����� ������ 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string RemoveSpacesNearHyphen(string input)
        {
            string ruleOfReplacing = @"(\s+)(\-|\s-)(\s+)";
            return Regex.Replace(input, ruleOfReplacing, "$2");
        }

        /// <summary>
        /// ����� ��� ���������� �����, ����� ������� ������ 
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
