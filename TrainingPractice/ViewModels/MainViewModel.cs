using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Identity.Client;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using TrainingPractice.Models;

namespace TrainingPractice.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    YpContext db = new YpContext();
    [ObservableProperty] List<Event> events;

    [ObservableProperty] string eventName;

    public MainViewModel()
    {
        events = db.Events.ToList();
    }

}
