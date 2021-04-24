using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InTouch2021
{
	public class AverageValue
	{
		RatingInformation information = new RatingInformation();
		RatingInvalid Invalid = new RatingInvalid();
		RatingService service = new RatingService();
		public static int NumberUser = 0;

		float SumInf = 0;
		float SumInval= 0;
		float SumServ = 0;

		public float AverageInformation()
		{
			SumInf += (information.RuleOne() + information.RuleSecond() + information.RuleThird());
			return SumInf / NumberUser;
		}
		public float AverageInvalid()
		{
			SumInval += (Invalid.RuleOne() + Invalid.RuleSecond() + Invalid.RuleThird());
			return SumInval / NumberUser;
		}
		public float AverageService()
		{
			SumServ += (service.RuleOne() + service.RuleSecond());
			return SumServ / NumberUser;
		}
	}
}
