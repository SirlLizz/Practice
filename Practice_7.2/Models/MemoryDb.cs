using System;
using System.Collections.Generic;

namespace Practice_7._2.Models
{
    public static class MemoryDb
    {
        public static List<Animal> Animals { get; set; } = new()
        {
            new Animal { Id = Guid.NewGuid(), Name = "Нерпа", Habitat = "Россия", Diet="Рыба", Population = 15000},
            new Animal { Id = Guid.NewGuid(), Name = "Кабарга", Habitat = "Россия", Diet = "Лишайники", Population = 25000 },
            new Animal { Id = Guid.NewGuid(), Name = "Ирбис", Habitat = "Россия", Diet = "Копытные", Population = 5000 },
            new Animal { Id = Guid.NewGuid(), Name = "Бурозубка маленькая", Habitat = "Россия", Diet = "Насекомые", Population = 500000 },
        };
   }
}
