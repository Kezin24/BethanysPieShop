namespace BethanysPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Pie> AllPies =>
            new List<Pie>
            {
            new Pie
            {
                PieId = 1,
                Name = "Strawberry Pie",
                ShortDescription = "Our famous Strawberry pies!",
                LongDescription = "Delicious Strawberry pie made with fresh Strawberry and cinnamon.",
                Allergyinformation = "Contains gluten",
                Price = 12.95,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/fruitpies/strawberrypie.jpg",
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/fruitpies/strawberrypiesmall.jpg",
                IsPieOftheWeek = true,
                InStock = true,
                CategoryId = 1,
                Category = _categoryRepository.AllCategories.First(c => c.CategoryId == 1)
            },
            new Pie
            {
                PieId = 2,
                Name = "Blueberry Cheese Cake",
                ShortDescription = "Cheesy and fruity!",
                LongDescription = "Rich cheesecake topped with fresh blueberries.",
                Allergyinformation = "Contains dairy, gluten",
                Price = 15.95,
                ImageUrl = "\\Images\\pies\\blueberry1.jpg",
                ImageThumbnailUrl = "\\Images\\pies\\blueberry1.jpg",
                IsPieOftheWeek = false,
                InStock = true,
                CategoryId = 1,
                Category = _categoryRepository.AllCategories.First(c => c.CategoryId == 1)
            },
            new Pie {
                PieId = 3,
                Name="Cheese cake",
                Price=18.95,
                ShortDescription="Lorem Ipsum",
                LongDescription="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/cheesecake.jpg",
                InStock=true,
                IsPieOftheWeek=false,
                ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/cheesecakesmall.jpg",
                CategoryId = 3,
                Category = _categoryRepository.AllCategories.First(c => c.CategoryId == 3)
            },

            new Pie
            {
                PieId = 4,
                Name="Rhubarb Pie",
                Price=15.95,
                ShortDescription="Lorem Ipsum",
                LongDescription="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/fruitpies/rhubarbpie.jpg",
                InStock=true,
                IsPieOftheWeek = true,
                ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/fruitpies/rhubarbpiesmall.jpg",
                CategoryId = 3,
                Category = _categoryRepository.AllCategories.First(c => c.CategoryId == 3)
            },
            new Pie
            {
                PieId = 5,
                Name = "Pumpkin Pie",
                ShortDescription = "Perfect for the holidays",
                LongDescription = "Traditional pumpkin pie with spices.",
                Allergyinformation = "Contains gluten, eggs",
                Price = 10.95,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/seasonal/pumpkinpie.jpg",
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/seasonal/pumpkinpiesmall.jpg",
                IsPieOftheWeek = true,
                InStock = false,
                CategoryId = 3,
                Category = _categoryRepository.AllCategories.First(c => c.CategoryId == 3)
            }
            };

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return AllPies.Where(p => p.IsPieOftheWeek);
            }
        }

        public Pie? GetPieById(int pieId) =>
            AllPies.FirstOrDefault(p => p.PieId == pieId);

        public IEnumerable<Pie> SearchPies(string searchQuery)
        {
            throw new NotImplementedException();
        }
    }
}
