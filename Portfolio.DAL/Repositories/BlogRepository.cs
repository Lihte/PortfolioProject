using Portfolio.Domain.Interfaces;
using Portfolio.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.DAL.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly PortfolioDbContext _context;

        public BlogRepository(PortfolioDbContext context)
        {
            if (context == null)
                throw new ArgumentNullException("PortfolioDbContext is null");

            _context = context;
        }

        public void Add(Post entity)
        {
            throw new NotImplementedException();
        }

        public Post Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetAll()
        {
            throw new NotImplementedException();
        }

        public Post Update(Post entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Post entity)
        {
            throw new NotImplementedException();
        }
    }
}
