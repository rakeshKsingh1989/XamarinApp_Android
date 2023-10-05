using MobileAppXamarinForms.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MobileAppXamarinForms.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}