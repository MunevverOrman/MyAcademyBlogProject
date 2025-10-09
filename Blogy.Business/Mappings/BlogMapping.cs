using AutoMapper;
using Blogy.Business.DTOs.BlogDtos;
using Blogy.Entity.Entities;

public class BlogMapping : Profile
{
    public BlogMapping()
    {
        CreateMap<Blog, ResultBlogDto>().ReverseMap();
        CreateMap<Blog, UpdateBlogDto>().ReverseMap();
        CreateMap<Blog, CreateBlogDto>().ReverseMap();
    }
}
