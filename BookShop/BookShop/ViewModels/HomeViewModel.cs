using BookShop.Models;

namespace BookShop.ViewModels
{
    public class HomeViewModel
    {
        public HomeViewModel(IEnumerable<Pie> piesOfTheWeek)
        {
            PiesOfTheWeek = piesOfTheWeek;
        }

        public IEnumerable<Pie> PiesOfTheWeek { get; }
    }
}
