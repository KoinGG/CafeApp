using Avalonia.Controls;
using MsBox.Avalonia;
using MsBox.Avalonia.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeApp.Sourses
{
    public class ErrorMessage
    {
        //public static void ShowErrorMessage(Window window, string errorText, string errorTitle = "Ошибка")
        public static void ShowErrorMessage(string errorText, string errorTitle = "Ошибка")
        {
            MessageBoxManager.GetMessageBoxStandard($"{errorTitle}", $"{errorText}", ButtonEnum.Ok, Icon.Warning).ShowAsync();
        }
    }
}
