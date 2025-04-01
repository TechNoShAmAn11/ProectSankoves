using Microsoft.Maui.Controls;
using MyCinemaApp.Views;

namespace MauiApp1
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Регистрация маршрутов
            Routing.RegisterRoute(nameof(RegisterPage), typeof(RegisterPage));
        }
    }
}