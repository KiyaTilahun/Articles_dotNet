using System.Linq;
using System.Reflection;
using System.Text;
using WebApplication1.Models;
using System.Linq.Dynamic.Core;
using System;

namespace WebApplication1.Extensions
{
    public static class RepositoryCategoryExtensions
    {
        public static IQueryable<Category> Search(this IQueryable<Category> categories,
            string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return categories;
            var lowerCaseTerm = searchTerm.Trim().ToLower();
            return categories.Where(e => e.Name.ToLower().Contains(lowerCaseTerm));
        }

        public static IQueryable<Category> Sort(this IQueryable<Category> categories, string
            orderByQueryString)
        {
     
            if (string.IsNullOrWhiteSpace(orderByQueryString))
                return categories.OrderBy(c => c.Name);

            var orderParams = orderByQueryString.Trim().Split(',');
            var propertyInfos = typeof(Category).GetProperties(BindingFlags.Public |
                                                               BindingFlags.Instance);
            var orderQueryBuilder = new StringBuilder();

            foreach (var param in orderParams)
            {
                if (string.IsNullOrWhiteSpace(param))
                    continue;

                var propertyFromQueryName = param.Trim().Split(' ')[0];

                var objectProperty = propertyInfos.FirstOrDefault(pi =>
                    pi.Name.Equals(propertyFromQueryName, StringComparison.InvariantCultureIgnoreCase));

                if (objectProperty == null)
                {
                    continue;
                }

                var direction = param.Trim().EndsWith(" desc", StringComparison.OrdinalIgnoreCase) ? "descending" : "ascending";

                orderQueryBuilder.Append($"{objectProperty.Name} {direction}, ");
            }

            var orderQuery = orderQueryBuilder.ToString().TrimEnd(',', ' ');

            if (string.IsNullOrWhiteSpace(orderQuery))
                return categories.OrderBy(c => c.Name);

            return categories.OrderBy(orderQuery);
        }
    }
}