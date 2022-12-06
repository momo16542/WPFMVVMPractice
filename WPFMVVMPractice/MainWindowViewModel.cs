using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFMVVMPractice
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string TextBoxText
        {
            get => _textBoxText;
            set
            {
                _textBoxText = value;
                OnPropertyChanged();
            }
        }

        private string _textBoxText;

        public ICommand BtnCommand
        {
            get => _btnCommand;
            set
            {
                _btnCommand = value;
                OnPropertyChanged();
            }
        }

        private ICommand _btnCommand;

        public MainWindowViewModel()
        {
            BtnCommand = new TsCommand(BtnExecute);
            TextBoxText = no.ToString();
        }

        private int no = 0;
        private void BtnExecute()
        {
            no++;
            TextBoxText = no.ToString();
        }
    }
}
