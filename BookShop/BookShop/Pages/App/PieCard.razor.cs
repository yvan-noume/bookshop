using BookShop.Models;
using Microsoft.AspNetCore.Components;

namespace BookShop.Pages.App
{
    public partial class PieCard
    {
        [Parameter]
        public Pie? Pie { get; set; }
    }
}
