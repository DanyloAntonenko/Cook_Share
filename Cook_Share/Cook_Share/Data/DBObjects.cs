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
                        new Category { Name = "Первые блюда"},
                        new Category { Name = "Вторые блюда"},
                        new Category { Name = "Алкогольные напитки" },
                        new Category { Name = "Блюда из овощей" },
                        new Category { Name = "Мясные блюда" },
                        new Category { Name = "Холодные закуски" },
                        new Category { Name = "Сладости" },
                        new Category { Name = "Рыбные блюда" },
                        new Category { Name = "Морепродукты" },
                        new Category { Name = "Хлебо-булочные изделия" },
                        new Category { Name = "Закуси" }, 
                        new Category { Name = "Десерты" }, 
                        new Category { Name = "Мучные изделия" }
                    );
            }
            content.SaveChanges();
        }
    }
}
