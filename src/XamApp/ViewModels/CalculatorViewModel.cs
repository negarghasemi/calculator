using Acr.UserDialogs;
using Bit.ViewModel;
using System;
using System.Threading.Tasks;

namespace XamApp.ViewModels
{
    public class CalculatorViewModel : BitViewModelBase
    {
        public string Number1 { get; set; }

        public string Number2 { get; set; }
        public string Answer { get; set; }
        public BitDelegateCommand DoSumCommand { get; set; }
        public BitDelegateCommand DoSubtractionCommand { get; set; }
        public BitDelegateCommand DoMultiplicationCommand { get; set; }
        public BitDelegateCommand DoDivisionCommand { get; set; }
        public IUserDialogs UserDialogs { get; set; }

        public CalculatorViewModel()
        {
            DoSumCommand = new BitDelegateCommand(DoSum);
            DoSubtractionCommand = new BitDelegateCommand(DoSubtraction);
            DoMultiplicationCommand = new BitDelegateCommand(DoMultiplication);
            DoDivisionCommand = new BitDelegateCommand(DoDivision);
        }

        private async Task DoDivision()
        {
            if(Number2 == null || Number1 == null)
                await UserDialogs.AlertAsync("Fill Number1 and Number2!", "اخطار");
            else
            {
                Answer = (Convert.ToInt32(Number1) / Convert.ToInt32(Number2)).ToString();
            }

            

        }

        private async Task DoMultiplication()
        {
            if (Number2 == null || Number1 == null)
                await UserDialogs.AlertAsync("Fill Number1 and Number2!", "اخطار");
            else
            {
                Answer = (Convert.ToInt32(Number1) * Convert.ToInt32(Number2)).ToString();
            }

        }

        private async Task DoSubtraction()
        {
            if (Number2 == null || Number1 == null)
                await UserDialogs.AlertAsync("Fill Number1 and Number2!", "اخطار");
            else
            {
                Answer = (Convert.ToInt32(Number1) - Convert.ToInt32(Number2)).ToString();
            }
        }

        private async Task DoSum()
        {
            if (Number2 == null || Number1 == null)
                await UserDialogs.AlertAsync("Fill Number1 and Number2!", "اخطار");
            else
            {
                Answer = (Convert.ToInt32(Number1) + Convert.ToInt32(Number2)).ToString();
            }
            
        }
    }
}
