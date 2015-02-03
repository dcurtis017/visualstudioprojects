using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VisualCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double operand;
        private string operation;

        public MainWindow()
        {
            reset();
            InitializeComponent();
        }

        private void reset()
        {
            operand = 0.0;
            operation = "";
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;
            string buttonName = clickedButton.Name;
            string[] actionButtonNames = {"btnMultiply", "btnDivide", "btnAdd","btnSubtract"};
            if (actionButtonNames.Contains(buttonName))
            {
                operand = Double.Parse(txtResult.Text);
                operation = buttonName;
                txtResult.Text = "0";
            }
            else if( buttonName == "btnCalculate")
            {
                txtResult.Text = calculateResult().ToString();
            }
            else if(buttonName == "btnClear")
            {
                reset();
                txtResult.Text = "0";
            }
            else
            {
                txtResult.Text += clickedButton.Content.ToString();
            }
        }

        private double calculateResult()
        {
            if(operation == "btnAdd")
            {
                return operand + Double.Parse(txtResult.Text);
            }
            else if(operation == "btnSubtract")
            {
                return operand - Double.Parse(txtResult.Text);
            }
            else if(operation == "btnMultiply")
            {
                return operand * Double.Parse(txtResult.Text);
            }
            else
            {
                return operand / Double.Parse(txtResult.Text);
            }
        }
    }
}
