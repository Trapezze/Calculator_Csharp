using System;
using System.Windows.Forms;

namespace AdvancedCalculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(number1TextBox.Text);
                double num2 = double.Parse(number2TextBox.Text);
                string operation = operationComboBox.SelectedItem.ToString();

                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        result = num1 / num2;
                        break;
                    // Дополнительные операции
                    case "^":
                        result = Math.Pow(num1, num2);
                        break;
                    case "sqrt":
                        result = Math.Sqrt(num1);
                        break;
                    // Добавьте свои операции по мере необходимости
                    default:
                        MessageBox.Show("Неподдерживаемая операция");
                        break;
                }

                resultLabel.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Проверьте правильность введенных чисел");
            }
        }
    }
}