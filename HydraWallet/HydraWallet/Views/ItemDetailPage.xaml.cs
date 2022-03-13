using HydraWallet.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace HydraWallet.Views
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