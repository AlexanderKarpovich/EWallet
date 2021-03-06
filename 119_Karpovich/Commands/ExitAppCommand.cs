using System.Diagnostics;
using System.Windows;

namespace _119_Karpovich.Commands
{
    /// <summary>
    /// Команда выхода из приложения.
    /// </summary>
    internal class ExitAppCommand : CommandBase
    {
        /// <summary>
        /// Инициализирует команду выхода из приложения.
        /// </summary>
        public ExitAppCommand() { }

        /// <inheritdoc cref="CommandBase.Execute(object)"/>
        public override void Execute(object parameter)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?",
                    "Подтверждение", 
                        MessageBoxButton.YesNo, 
                            MessageBoxImage.Question) == MessageBoxResult.Yes)
                Process.GetCurrentProcess().Kill();
        }
    }
}
