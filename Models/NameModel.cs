using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    public partial class NameModel : ObservableObject
    {
        [ObservableProperty]
        public string _Name;

        [RelayCommand]
        private void Save()
        {

        }
    }
}
