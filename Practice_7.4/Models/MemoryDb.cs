using System;
using System.Collections.Generic;

namespace Practice_7._4.Models
{
    public static class MemoryDb
    {
        public static List<Musician> Musicians { get; set; } = new()
        {
            new Musician { Id = Guid.NewGuid(), Name = "Чайковский", Country = "Россия", Year = 1893, MostFamousWork = "Лебединое озеро" },
            new Musician { Id = Guid.NewGuid(), Name = "Глинка", Country = "Россия", Year = 1804, MostFamousWork = "опера «Руслан и Людмила»" },
            new Musician { Id = Guid.NewGuid(), Name = "Шостакович", Country = "Россия", Year = 1906, MostFamousWork = "Симфоняи №5" },
            new Musician { Id = Guid.NewGuid(), Name = "Моцарт", Country = "Австрия", Year = 1756, MostFamousWork = "Реквием по мечте" },
        };
    }
}
