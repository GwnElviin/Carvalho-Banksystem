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


namespace CarvalhoBanks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        service service = new service();
        bankingSystem bank = new bankingSystem();

        string _accountName;
        string _bankBalance;

        public MainWindow()
        {
            InitializeComponent();
            buttonsDisabled();
        }

       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            _accountName = accountName.Text;
            _bankBalance = accountBalance.Text;
            service.loginBank(_accountName, _bankBalance);
            accountLoggedIn();
            bankLog.Text = "logged in the bank \rDo you want to withdraw(1), deposit(2), sendmoney(3) or checkbalance(4) choose one";

        }


        private void accountLoggedIn()
        {
            accountName.IsEnabled = false;
            accountBalance.IsEnabled = false;
            buttonsEnable();
        }

        private void accountLogOut()
        {
            accountName.IsEnabled = true;
            accountBalance.IsEnabled = true;

            accountBalance.Text = "";
            accountName.Text = "";
            bankLog.Text = "";
            buttonsDisabled();
        }

        private void buttonsDisabled()
        {
            withdrawButton.IsEnabled = false;
            depositButton.IsEnabled = false;
            sendButton.IsEnabled = false;
            checkButton.IsEnabled = false;
            senderAccountName.IsEnabled = false;
            inputAmount.IsEnabled = false;
        }

        private void buttonsEnable()
        {
            withdrawButton.IsEnabled = true;
            depositButton.IsEnabled = true;
            sendButton.IsEnabled = true;
            checkButton.IsEnabled = true;
            senderAccountName.IsEnabled = true;
            inputAmount.IsEnabled = true;
        }

        private void withdrawButton_Click(object sender, RoutedEventArgs e)
        {
            bankLog.Text = "insert the amount you want to withdraw";
            string amountOut = inputAmount.Text;
            bankLog.Text = bank.withdraw(ref _bankBalance, _accountName, amountOut);
        }

        private void depositButton_Click(object sender, RoutedEventArgs e)
        {
            bankLog.Text = "insert the amount you want to deposit";
            string amountIn = inputAmount.Text;
            bankLog.Text = bank.deposit(ref _bankBalance, _accountName, amountIn);
        }

        private void sendButton_Click(object sender, RoutedEventArgs e)
        {
            bankLog.Text = "insert the amount you want to send and to whom";
            string amountOut = inputAmount.Text;
            string accountReceiveName = senderAccountName.Text;
            bankLog.Text = bank.send( ref _bankBalance, _accountName, amountOut, accountReceiveName);
        }

        private void checkButton_Click(object sender, RoutedEventArgs e)
        {
            bankLog.Text = "insert the amount you want to withdraw";
            bankLog.Text = bank.checkBalance();
        }

        private void TextBox_TextChangedg(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            accountLogOut();
        }
    }
}
