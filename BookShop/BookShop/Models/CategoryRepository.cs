namespace BookShop.Models
{
    public class CategoryRepository:ICategoryRepository
    {
        private readonly YvanPieShopDbContext _YvanPieShopDbContext;

        public CategoryRepository(YvanPieShopDbContext yvanPieShopDbContext)
        {
            _YvanPieShopDbContext = yvanPieShopDbContext;
        }

        public IEnumerable<Category> AllCategories
        {
            get { return _YvanPieShopDbContext.Categories.OrderBy(p => p.CategoryName); }
        }
    }
}
