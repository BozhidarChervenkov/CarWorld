namespace CarWorld.Services.CarShows
{
    using System.Linq;
    using System.Collections.Generic;

    using CarWorld.Data;
    using CarWorld.ViewModels.CarShowsViewModels;
    using CarWorld.Models;
    using System.Threading.Tasks;

    public class CarShowsService : ICarShowsService
    {
        private readonly ApplicationDbContext context;

        public CarShowsService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<ShowViewModel> AllShows()
        {
            var shows = this.context.Shows
                .Where(s => s.IsDeleted == false)
                .Select(s => new ShowViewModel
                {
                    Id = s.Id,
                    Title = s.Title,
                    Description = s.Description,
                    Picture = s.ShowPictures.FirstOrDefault().Url,
                    CreatedOn = s.CreatedOn
                })
                .ToList();

            return shows;
        }

        public ShowByIdViewModel ShowById(int id)
        {
            var viewModel = this.context.Shows
                .Where(s => s.Id == id)
                .Select(s => new ShowByIdViewModel
                {
                    Id = s.Id,
                    Title = s.Title,
                    Description = s.Description,
                    ShowPictures = s.ShowPictures,
                    Videos = s.Videos
                })
                .FirstOrDefault();

            return viewModel;
        }

        public void AddShow(AddShowInputModel input, string userId)
        {
            var show = new Show()
            {
                Id = input.Id,
                Title = input.Title,
                Description = input.Description,
                CreatedOn = System.DateTime.Now,
                ShowPictures = input.ShowPictures,
                Videos = input.Videos
            };

            this.context.Shows.Add(show);
            this.context.SaveChanges();
        }

        public async Task<bool> DeleteShow(int id)
        {
            var show = this.context.Shows
                .FirstOrDefault(s => s.Id == id);

            if (show == null)
            {
                return false;
            }
            else
            {
                show.IsDeleted = true;
                await this.context.SaveChangesAsync();

                return true;
            }
        }

        public List<string> EmbeddedVideoCodes(ShowByIdViewModel viewModel)
        {
            List<string> embeddedVideoCodes = new List<string>();

            foreach (var video in viewModel.Videos)
            {
                var path = video.UrlPath;

                int position = path.IndexOf("=") + 1;
                var embeddedCode = path.Substring(position, 11);

                embeddedVideoCodes.Add(embeddedCode);
            }

            return embeddedVideoCodes;
        }
    }
}
