using MyCinemaApp.Models;
using MyCinemaApp.Services;

namespace MyCinemaApp.Views
{
    public partial class RegisterPage : ContentPage
    {
        private DatabaseService dbService;

        public RegisterPage()
        {
            InitializeComponent();
            dbService = new DatabaseService();
        }

        private async void OnRegisterButtonClicked(object sender, EventArgs e)
        {
            var user = new User
            {
                Username = UsernameEntry.Text,
                Email = EmailEntry.Text,
                Password = PasswordEntry.Text  // Здесь лучше использовать хэширование
            };

            if (string.IsNullOrWhiteSpace(user.Username) || string.IsNullOrWhiteSpace(user.Email) || string.IsNullOrWhiteSpace(user.Password))
            {
                await DisplayAlert("Ошибка", "Заполните все поля", "Ок");
                return;
            }

            var result = await dbService.RegisterUser(user);
            if (result)
            {
                await DisplayAlert("Успех", "Регистрация завершена", "Ок");
            }
            else
            {
                await DisplayAlert("Ошибка", "Не удалось зарегистрироваться", "Ок");
            }
        }
    }
}