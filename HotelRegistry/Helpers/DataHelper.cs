using HotelRegistry.Models;
using System.Linq;

namespace HotelRegistry.Helpers
{
	public static class DataHelper
	{
		public static void Initialize(HotelContext context)
		{
			if (!context.Hotels.Any())
			{
				context.Hotels.AddRange(
					new Hotel { Name = "Привал", Address = "Россия, Удмуртская Республика, Ижевск, Майская улица, 35А" },
					new Hotel { Name = "ДерябинЪ", Address = "Россия, Удмуртская Республика, Ижевск, Красногеройская улица, 107" },
					new Hotel { Name = "Бобровая долина", Address = "Россия, Удмуртская Республика, Ижевск, улица Свердлова, 4" },
					new Hotel { Name = "Тетрис", Address = "Россия, Удмуртская Республика, Ижевск, улица Карла Маркса, 250" }
					);

				context.SaveChanges();
			}
		}
	}
}
