using Avalonia.Controls;
using Avalonia.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace Notepade.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!";

        public int TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            sender += e.Key.ToString();
            return 0;
        }
    }


}
