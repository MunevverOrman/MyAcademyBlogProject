using AutoMapper;
using Blogy.Business.DTOs.CommentDtos;
using Blogy.Entity.Entities;

namespace Blogy.Business.Mappings
{
    public class CommentMapping:Profile
    {
        public CommentMapping()
        {
            CreateMap<Comment,ResultCommentDto>().ReverseMap();
            CreateMap<Comment,CreateCommentDto>().ReverseMap();
            CreateMap<Comment,UpdateCommentDto>().ReverseMap();

        }

    }
}
