using MauiApp5.ViewModels;

namespace MauiApp5
{
    public partial class MainPage : ContentPage
    {
        private readonly MainPageVM vm;
        public MainPage()
        {
            InitializeComponent();
            vm = new();
            BindingContext = vm;
        }
    }
}