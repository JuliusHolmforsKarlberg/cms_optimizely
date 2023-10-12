using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using EPiServer.Web;

namespace Nackademin2023v2.Business.Initialization
{
    [InitializableModule]
    [ModuleDependency(typeof(InitializationModule))]
    public class CategoryInitialization : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            CreateCategories();
        }

        private void CreateCategories()
        {
            var categoryRepository = ServiceLocator.Current.GetInstance<CategoryRepository>();
            var root = categoryRepository.GetRoot();

            if (categoryRepository.Get("Film genres (en)") == null)
            {
                var systemCategory = new Category(root, "Film genres (en)")
                {
                    Available = true,
                    Description = "Film genres (en)",
                    Selectable = false
                };

                categoryRepository.Save(systemCategory);

                var heading = categoryRepository.Get("Film genres (en)");

                var genres = new List<string>()
                {
                    "Horror", "Comedy", "Thriller", "Mystery", "Fantasy", "Action", "Drama", "Sci-Fi"
                };

                foreach (var genre in genres)
                {
                    if (categoryRepository.Get(genre) == null)
                    {
                        var category = new Category(heading, genre)
                        {
                            Available = true,
                            Description = genre,
                            Selectable = true
                        };

                        categoryRepository.Save(category);
                    }
                }
            }

            if (categoryRepository.Get("Film genres (sv)") == null)
            {
                var systemCategory = new Category(root, "Film genres (sv)")
                {
                    Available = true,
                    Description = "Film genres (sv)",
                    Selectable = false
                };

                categoryRepository.Save(systemCategory);

                var heading = categoryRepository.Get("Film genres (sv)");

                var genres = new List<string>()
                {
                    "Horror", "Komedi", "Thriller", "Mystery", "Fantasy", "Action", "Drama", "Sci-Fi"
                };

                foreach (var genre in genres)
                {
                    if (categoryRepository.Get(genre) == null)
                    {
                        var category = new Category(heading, genre)
                        {
                            Available = true,
                            Description = genre,
                            Selectable = true
                        };

                        categoryRepository.Save(category);
                    }
                }
            }
        }

        public void Uninitialize(InitializationEngine context)
        {

        }
    }
}
