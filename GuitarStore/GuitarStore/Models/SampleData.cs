using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuitarStore.Models
{
    public class SampleData
    {
        public static void Initialize(GuitarStoreContext context)
        {
            if (!context.Guitars.Any())
            {
                context.Guitars.AddRange(
                    new Guitar
                    {
                        Name = "Ibanez GRG 140 SB",
                        Producer = "Ibanez",
                        Type= "Electric Guitar",
                        Price = 7000
                    },
                    new Guitar
                    {
                        Name = "Cort AD810",
                        Producer = "Cort",
                        Type= "Acoustic guitar",
                        Price = 3000
                    },
                    new Guitar
                    {
                        Name = "Yamaha TRBX-174",
                        Producer = "Yamaha",
                        Type= "Bass guitar",
                        Price = 7500
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
