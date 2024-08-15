using HotChocolate;
using HotChocolate.Types;
using GraphQLApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

public class Query
{
    [UseDbContext(typeof(JwtreactconsumeContext))]
    public IQueryable<Category> GetCategories([ScopedService] JwtreactconsumeContext context)
    {
        return context.Categories.Include(c => c.Products);
    }

    [UseDbContext(typeof(JwtreactconsumeContext))]
    public IQueryable<Product> GetProducts([ScopedService] JwtreactconsumeContext context)
    {
        return context.Products.Include(p => p.Category);
    }

    [UseDbContext(typeof(JwtreactconsumeContext))]
    public Category GetCategoryById([ScopedService] JwtreactconsumeContext context, int id)
    {
        return context.Categories.Include(c => c.Products)
                                 .FirstOrDefault(c => c.Categoryid == id);
    }

    [UseDbContext(typeof(JwtreactconsumeContext))]
    public Product GetProductById([ScopedService] JwtreactconsumeContext context, int id)
    {
        return context.Products.Include(p => p.Category)
                               .FirstOrDefault(p => p.Productid == id);
    }
}
