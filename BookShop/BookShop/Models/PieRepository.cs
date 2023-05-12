using Microsoft.EntityFrameworkCore;

namespace BookShop.Models
{
    public class PieRepository:IPieRepository
    {
        private readonly YvanPieShopDbContext _yvanPieShopDbContext;

        public PieRepository(YvanPieShopDbContext yvanPieShopDbContext)
        {
            _yvanPieShopDbContext = yvanPieShopDbContext;
        }

        public IEnumerable<Pie> AllPies
        {
            get { return _yvanPieShopDbContext.Pies.Include(c => c.Category); }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get { return _yvanPieShopDbContext.Pies.Include(c => c.Category).Where(p => p.IsPieOfTheWeek); }
        }
        public Pie? GetPieById(int pieId)
        {
            return _yvanPieShopDbContext.Pies.FirstOrDefault(p => p.PieId == pieId);
        }

        public IEnumerable<Pie> SearchPies(string searchQuery)
        {
            return _yvanPieShopDbContext.Pies.Where(P => P.Name.Contains(searchQuery));
        }
    }
}
