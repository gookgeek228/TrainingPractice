using System;
using System.Collections.Generic;
using System.Linq;
using Avalonia.Media.Imaging;
using CommunityToolkit.Mvvm.ComponentModel;
using TrainingPractice.Models;

namespace TrainingPractice.ViewModels
{
	public partial class AuthViewModel : ViewModelBase
	{
        YpContext db = new YpContext();

        [ObservableProperty] string login;
        [ObservableProperty] string password;
        [ObservableProperty] string message = "";
        [ObservableProperty] private string captchaText;
        [ObservableProperty] private Bitmap captchaImage;
        [ObservableProperty] private string userInput;
        [ObservableProperty] private string resultMessage;

        public void Authorization()
        {
            if (db.Users.FirstOrDefault(x => x.Email == login && x.Password == password && x.IdRole == 2) != null)
            {
                Message = "Участник";
            }
            else if (db.Users.FirstOrDefault(x => x.Email == login && x.Password == password && x.IdRole == 3) != null)
            {
                Message = "Модератор";
            }
            else if (db.Users.FirstOrDefault(x => x.Email == login && x.Password == password && x.IdRole == 4) != null)
            {
                Message = "Организатор";
            }
            else if (db.Users.FirstOrDefault(x => x.Email == login && x.Password == password && x.IdRole == 5) != null)
            {
                Message = "Жюри";
            }
            else
            {
                Message = "Ошибка авторизации! Неверный логин или пароль!";
            }
        }
    }
}