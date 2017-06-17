using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DataBindingandMVVMDemo
{
    //Step 2
    class MainWindowViewModel:ViewModelBase
    {
        //Step 5 - Define properties

        #region properties
        private string numberOne;
        public string NumberOne
        {
            get
            {
                return numberOne;
            }
            set
            {
                if(numberOne != value)
                {
                    numberOne = value;
                    int a,b;
                    try { a = Int32.Parse(numberOne); }
                    catch { a = 0; }
                    try { b = Int32.Parse(numberTwo); }
                    catch { b = 0; }
                    Result = (a + b).ToString();
                    RaisePropertyChangedEvent("NumberOne");
                }
            }
        }
        private string numberTwo;
        public string NumberTwo
        {
            get
            {
                return numberTwo;
            }
            set
            {
                if(numberTwo != value)
                {
                    numberTwo = value;
                    int a,b;
                    try { a = Int32.Parse(numberOne); }
                    catch { a = 0; }
                    try { b = Int32.Parse(numberTwo); }
                    catch { b = 0; }
                    Result = (a + b).ToString();
                    RaisePropertyChangedEvent("NumberTwo");
                }
            }
        }
        private string result;
        public string Result
        {
            get
            {
                return result;
            }
            set
            {
                if(result != value)
                {
                    result = value;
                }
                RaisePropertyChangedEvent("Result");
            }
        }
        #endregion
        
        //Step 6 - Add command to button
        //add reference to GalaSoft.MvvmLight (already added in this solution)
        private string message;
        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                if(message != value)
                {
                    message = value;
                }
                RaisePropertyChangedEvent("Message");
            }
        }

        private RelayCommand<string> clearCommand;
        public RelayCommand<string> ClearCommand
        {
            get { return clearCommand ?? (clearCommand = new RelayCommand<string>(clearFun)); }
        }

        private void clearFun(string Message)
        {
            NumberOne = "";
            NumberTwo = "";
            Result = "";
            MessageBox.Show(Message);
        }
        public MainWindowViewModel()
        {
            Message = "TextBox Cleared";
        }

        //Step 7 - Putting view and viewModel in View and ViewModel folder respectively. (Will be using ViewModel Folder which is created after importing GalaSoft MVVM Light). 
    }
}
