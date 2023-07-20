using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp5.Models;
using System.Collections.ObjectModel;

namespace MauiApp5.ViewModels
{
    public partial class MainPageVM : ObservableObject
    {
        public MainPageVM()
        {
            Lista = new();
        }

        [RelayCommand]
        private void Menos(Item item)
        {
            var indice = Lista.IndexOf(item);
            item.Cantidad -= 1;
            Lista[indice] = item;
        }

        [RelayCommand]
        private void Mas(Item item)
        {
            var indice = Lista.IndexOf(item);
            item.Cantidad += 1;
            Lista[indice] = item;

        }

        [RelayCommand]
        private void Agregar()
        {
            Lista.Add(new Item
            {
                Id = Lista.Count,
                Cantidad = 0
            });
        }

        [ObservableProperty] ObservableCollection<Item> lista;

    }
}
