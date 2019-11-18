using Cook_Share.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cook_Share.Data
{
    public class DBObjects
    {
        public static void Initial(DataContext content)
        {
            if (!content.Categories.Any())
            {
                content.Categories.AddRange(
                        new Category { Name = "Первое блюдо"},
                        new Category { Name = "Второе блюдо"},
                        new Category { Name = "Десерт"}
                    );
            }
            content.SaveChanges();
        }
    }
}
