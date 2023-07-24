﻿using API.Repository.Classes;

namespace API.Services;

public class BlogPostServices : IBlogPostServices
{
    private readonly IBlogPostRepository _blogPostRepository;

    public BlogPostServices(IBlogPostRepository blogPostRepository)
    {
        _blogPostRepository = blogPostRepository;
    }

    public async Task<DbMessenger> Create(BlogPostModel post)
    {
        post.CreatedAt = DateTime.Now;
        post.UpdatedAt = DateTime.Now;

        return await _blogPostRepository.NewPost(post);
    }
}
