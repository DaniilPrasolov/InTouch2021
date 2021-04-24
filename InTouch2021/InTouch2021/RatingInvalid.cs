using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InTouch2021
{
	public class RatingInvalid
	{
		public float[] WeightAnswersForOne;
		public float[] WeightAnswersForSecond;
		public float[] WeightAnswersForThird;
		public static float CH = 0;


		public float RuleOne()
		{
			float T, C;
			C = 75;
			T = 0;

			for (int i = 0; i < WeightAnswersForOne.Length; i++)
			{
				T += WeightAnswersForOne[i];
			}


			float value =  T/5 *C * 0.3f;

			return value;
		}

		public float RuleSecond()
		{
			float T, C;
			C = 75;
			T = 0;

			for (int i = 0; i < WeightAnswersForSecond.Length; i++)
			{
				T += WeightAnswersForSecond[i];
			}


			float value = T / 6 * C * 0.4f;

			return value;
		}

		public float RuleThird()
		{
			float T = 0;

			for (int i = 0; i < WeightAnswersForThird.Length; i++)
			{
				T += WeightAnswersForThird[i];
			}


			float value = T / 6 * CH * 0.3f;

			return value;
		}
	}
}
