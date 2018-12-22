using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Dapper;
using kidalica.API.Dtos;
using kidalica.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace kidalica.API.Data
{
    public class DbRepository : IRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _config;
        public DbRepository(DataContext context, IMapper mapper, IConfiguration conf)
        {
            _context = context;
            _mapper = mapper;
            _config = conf;
        }
  
        //categories
        public void DeleteCategoryAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void DeletePostAsync(int postId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            return await (from p in _context.Category
                                         orderby p.Name select new Category
                                         {
                                           Id = p.Id,
                                           Name = p.Name
                                         }).ToListAsync();

            
          }

        public Task<IEnumerable<Post>> GetAllPostWithNoImagesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetCategorieByIdAsync(int categoryId)
        {
            throw new NotImplementedException();
        }
        // end of categories
        

        //  posts
        public async Task<IEnumerable<PostDto>> GetHomePosts()
        {
            return await (from e in _context.Post
                    select new PostDto
                    {
                        Categories = (from p in e.PostCategory
                                      select new Category
                                      {
                                          Id = p.IdCategoryNavigation.Id,
                                          Name = p.IdCategoryNavigation.Name
                                      }).ToList(),
                        Heading = e.Heading,
                        Autor = new AutorDto
                        {
                            Name=e.IdAutorNavigation.Name,
                            Id = e.IdAutor
                        },
                        CreatedAt=e.CreatedAt,
                        Description=e.Description,
                        
                        Src = e.IdAutor1.Src,
                        Id = e.Id,
                        Title=e.Title
                    }).ToListAsync();                  
        }





        public Task<IEnumerable<Post>> GetPaginationPosts(int startFrom)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CategoryWithPostsDto>> GetPostByCategoryIdAsync(int categoryId)
        {
               return await (from c in _context.Category
                             where c.Id == categoryId
                             select new CategoryWithPostsDto
                             {
                                 Id = c.Id,
                                 Name = c.Name,
                                 Posts = (from e in c.PostCategory select new PostDto
                                 {
                                     Heading = e.IdPostNavigation.Heading,
                                    Autor= new AutorDto
                                    {
                                        Name= e.IdPostNavigation.IdAutorNavigation.Name,
                                        Id=e.IdPostNavigation.IdAutor
                                    },
                                     CreatedAt = e.IdPostNavigation.CreatedAt,
                                     Description = e.IdPostNavigation.Description,                        
                                     Src = e.IdPostNavigation.IdAutor1.Src,
                                     Id = e.IdPost,
                                     Title = e.IdPostNavigation.Title
                                 }).ToList()
                             }).ToListAsync();

            //throw new NotImplementedException();
                      
        }

        public Task<Category> GetPostByIdAsync(int postId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> HasCategoryAsync(int categoryId)
        {
            return await _context.Category.AnyAsync(x => x.Id == categoryId);
        }

        public async Task<bool> HasPostAsync(int categoryId)
        {
          
          throw new NotImplementedException();
        }

        public void PostCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public void PostPostAsync(Post post)
        {
            throw new NotImplementedException();
        }

        public void PutCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public void PutPostAsync(Post post)
        {
            throw new NotImplementedException();
        }
        // end of posts
    }
}
