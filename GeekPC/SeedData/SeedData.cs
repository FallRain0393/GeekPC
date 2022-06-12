using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GeekPC.Data;
using System;
using System.Linq;

namespace GeekPC.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GeekPCItemContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<GeekPCItemContext>>()))
            {
                // Look for any items.
                if (context.Item.Any())
                {
                    return;   // DB has been seeded
                }

                context.Item.AddRange(
                    new Item
                    {
                        Name = "Leopold FC 750R PD Ash Yellow",
                        Category = "Клавиатуры",
                        Description = "Leopold — производитель, который ставит качество и надежность выше всего остального — именно поэтому вы, скорее всего, даже и не слышали о нем. Эта компания не вливает тонны средств в маркетинг, а просто делает качественные клавиатуры из премиальных материалов, которые при этом стоят адекватных денег. Клавиатуры отлично собраны и подойдут как заядлым геймерам, так и тем, кто печатает много и долго.",
                        Descr = "Механическая, клавиш - 65, PS/2, USB, черная",
                        Price = 12990,
                        DatePublication = DateTime.Parse("1989-2-12"),
                        

                    },

                    new Item
                    {
                        Name = "Leopold FC 650mds PD Gray",
                        Category = "Клавиатуры",
                        Description = "Leopold — производитель, который ставит качество и надежность выше всего остального — именно поэтому вы, скорее всего, даже и не слышали о нем. Эта компания не вливает тонны средств в маркетинг, а просто делает качественные клавиатуры из премиальных материалов, которые при этом стоят адекватных денег. Клавиатуры отлично собраны и подойдут как заядлым геймерам, так и тем, кто печатает много и долго.",
                        Descr = "Механическая, клавиш - 65, PS/2, USB, черная",
                        Price = 9990,
                        DatePublication = DateTime.Parse("1989-2-12"),                       

                    },

                    new Item
                    {
                        Name = "Logitech G Pro X Superlight",
                        Category = "Мыши",
                        Description = "Представляем вашему вниманию PRO X SUPERLIGHT — самую легкую и быструю мышь из всех моделей серии PRO. Благодаря поддержке LIGHTSPEED она поможет вам устранить все препятствия на своем пути, поэтому можно сосредоточиться на главном — победе в состязании.",
                        Descr = "25400 dpi, USB Type-A, кнопки - 5, черная",
                        Price = 9990,
                        DatePublication = DateTime.Parse("1989-2-12"),                        

                    },

                    new Item
                    {
                        Name = "Varmilo Koi Daisy",
                        Category = "Коврики",
                        Description = "Коврик на рабочий стол Varmilo Koi Daisy с прошитыми краями. Размер – 90х40x0.3 см.",
                        Descr = "Коврик на рабочий стол с прошитыми краями. 90х40x0.3 см.",
                        Price = 1990,
                        DatePublication = DateTime.Parse("1989-2-12"),                       

                    }
                );
                context.SaveChanges();
            }
        }
    }
}
