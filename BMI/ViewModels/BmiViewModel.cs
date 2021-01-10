using System;
using System.Windows.Input;

namespace BMI.ViewModels
{
    internal class BmiViewModel : NotifyPropertyBase
    {
        public double height;

        public double Height
        {
            get { return height; }
            set { SetProperty(ref height, value); }
        }

        public double weight;

        public double Weight
        {
            get { return weight; }
            set { SetProperty(ref weight, value); }
        }

        public double result;

        public double Result
        {
            get { return result; }
            set { SetProperty(ref result, value); }
        }

        private ICommand submitCommand;

        public ICommand SubmitCommand
        {
            get
            {
                if (submitCommand == null)
                {
                    submitCommand = new RelayCommand((x) =>
                    this.Result = Math.Round(Weight / Math.Pow((Height / 100), 2), 2)
                    ); ;
                }
                return submitCommand;
            }
        }
    }
}