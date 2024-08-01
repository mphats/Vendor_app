using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model
{
    public class PropertyRepository
    {
        public static List<Property> AllProperties() => new List<Property> {  
            new Property{
            Address = "Machinjiri, Blantyre", Price = 250000,
            DefaultImage = "r2.jpg",
            Images = new List<string>
            {
				"r4.jpg"
            }
            },

			new Property{
			Address = "Likhula, Blantyre", Price = 200000,
			DefaultImage = "r3,jpg",
			Images = new List<string>
			{
				"r6.jpg",
				"r8.jpg"
			}
			},
			new Property{
			Address = "Lunzu, Blantyre", Price = 300000,
			DefaultImage = "r4.jpg",
			Images = new List<string>
			{
				"r9.jpg"
			}
			},
			new Property{
			Address = "Mbayani, Blantyre", Price = 500000,
			DefaultImage = "r5.jpg",
			Images = new List<string>
			{
				"r8.jpg"
			}
			},
			new Property{
			Address = "Chilomoni, Blantyre", Price = 550000,
			DefaultImage = "r6.jpg",
			Images = new List<string>
			{
				"r7.jpg"
			}
			}
		};
    }
}
