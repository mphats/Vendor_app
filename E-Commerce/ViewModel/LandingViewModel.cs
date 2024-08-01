using E_Commerce.Model;
using E_Commerce.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace E_Commerce.ViewModel
{
    public class LandingViewModel: BaseViewModel
    {
    
        public List<string> Sections => new List<string> { "Trending", "Popular", "Buy", "Rent" };
        public List<Property> Properties => PropertyRepository.AllProperties();
        public Property SelectedProperty { get; set; }
        public ICommand PropertySelected => new Command(obj =>
        {
            if(SelectedProperty != null)
            {
                Application.Current.MainPage.Navigation.PushAsync(new DetailsPage(SelectedProperty));
                SelectedProperty = null;
            }
        });
    }
}
