using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InTouch2021
{
	public class RatingService
	{
		public float[] WeightAnswersForOne;
		public float[] WeightAnswersForSecond_1;
		public float[] WeightAnswersForSecond_2;
		public static float CH = 0;

		public float RuleOne()
		{
			float koefC, koefT;
			koefT = 0;
			koefC = 75;

			for (int i = 0; i < WeightAnswersForOne.Length; i++)
			{
				koefT += WeightAnswersForOne[i];
			}

			float value = koefT/6 * koefC * 0.5f;

			return value;
		}

		public float RuleSecond()
		{
			float value = 0;
			float Y = 0;

			for (int i = 0; i < WeightAnswersForSecond_1.Length; i++)
			{
				Y += WeightAnswersForSecond_1[i];
			}

			value =  Y/2 * CH * 0.5f;

			return value;
		}

		
	}
}

