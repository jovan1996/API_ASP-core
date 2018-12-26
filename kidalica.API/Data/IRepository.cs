using kidalica.API.Dtos;
using kidalica.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kidalica.API.Data
{
    public interface IRepository
    {
        //Posts
        Task<IEnumerable<Post>> GetAllPostWithNoImagesAsync();
        Task<IEnumerable<PostDto>> GetHomePosts();
        Task<IEnumerable<Post>> GetPaginationPosts(int startFrom);
        Task<Category> GetPostByIdAsync(int postId);
        Task<IEnumerable<CategoryWithPostsDto>> GetPostByCategoryIdAsync(int categoryId);
        void PutPostAsync(Post post);
        void PostPostAsync(Post post);
        void DeletePostAsync(int postId);
        // koristimo kada dohvatamo preko ID-ja, ovim vraca Bad request, odnosno 404, ukoliko ne postoji u bazi
        Task<bool> HasPostAsync(int postId);

        //Categories
        Task <IEnumerable<Category>> GetAllCategoriesAsync();
        Task<Category> GetCategorieByIdAsync(int categoryId);
        void PutCategoryAsync(Category category);
        void PostCategoryAsync(Category category);
        void DeleteCategoryAsync(int categoryId); 
        Task<bool> HasCategoryAsync(int categoryId); 
   
    }
}
