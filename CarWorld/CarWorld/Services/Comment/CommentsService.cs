namespace CarWorld.Services.Comment
{
    using System;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;

    using CarWorld.Data;
    using CarWorld.Models;
    using CarWorld.ViewModels.CarViewModels;
    
    public class CommentsService : ICommentsService
    {
        private readonly ApplicationDbContext context;

        public CommentsService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void CheckCommentTypeAndAddToDb(CarCommentViewModel input)
        {
            var car = this.context.Cars
                .Include(c => c.MainComments)
                    .ThenInclude(mc => mc.SubComments)
                .FirstOrDefault(c => c.Id == input.CarId);
            
            if (input.MainCommentId == 0)
            {
                car.MainComments.Add(new MainComment()
                {
                    Message = input.Message,
                    CreatedOn = DateTime.UtcNow,
                    AddedByUserId = input.UserId,
                });
            }
            else
            {
                var mainComment = this.context.MainComments
                    .Include(c => c.SubComments)
                    .FirstOrDefault(mc => mc.Id == input.MainCommentId);

                var subComment = new SubComment
                {
                    MainCommentId = input.MainCommentId,
                    Message = input.Message,
                    CreatedOn = DateTime.UtcNow,
                    AddedByUserId = input.UserId
                };

                mainComment.SubComments.Add(subComment);
            }
            this.context.SaveChanges();
        }
    }
}
