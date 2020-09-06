using DualBug.ViewModels;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.DualScreen;

namespace DualBug.Views
{
    public partial class ItemsPage : ContentPage
    {
        private readonly ItemsViewModel _viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ItemsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            _viewModel.OnAppearing();
            Debug.WriteLine(DualScreenInfo.Current.SpanMode);
        }
    }
}