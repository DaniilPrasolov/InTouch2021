using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InTouch2021
{
	public class RatingInformation
	{
		public float[] WeightAnswersForSite;
		public float[] WeightAnswersForStand;
		public float koefCount = 6;

		public float[] WeightForSecondRule;

		public float[] WeightForThirdRuleStand;
		public float[] WeightForThirdRuleSite;
		public float[] WeightForThirdRuleAll;


		public float RuleOne()
		{
			float koefStand, koefSite;
			koefSite = koefStand = 0;

			for(int i = 0; i < WeightAnswersForSite.Length; i++)
			{
				koefSite += WeightAnswersForSite[i];
			}

			for (int i = 0; i < WeightAnswersForStand.Length; i++)
			{
				koefStand += WeightAnswersForStand[i];
			}

			float value = (koefStand + koefSite)/(2*koefCount) * 100 * 0.3f;

			return value;
		}

		public float RuleSecond()
		{
			float value = 0;
			float T = 0;
			float C = 75;

			for(int i = 0; i < WeightForSecondRule.Length; i++)
			{
				T += WeightForSecondRule[i];
			}

			value = T/15 * C * 0.3f;

			return value;
		}

		public float RuleThird()
		{
			float koefStand, koefSite, koefAll;
			koefSite = koefStand = koefAll = 0;
			float value = 0;

			for (int i = 0; i < WeightForThirdRuleSite.Length; i++)
			{
				koefSite += WeightForThirdRuleSite[i];
			}

			for (int i = 0; i < WeightForThirdRuleStand.Length; i++)
			{
				koefStand += WeightForThirdRuleStand[i];
			}

			for (int i = 0; i < WeightForThirdRuleAll.Length; i++)
			{
				koefAll += WeightForThirdRuleAll[i];
			}

			value = ((koefStand + koefSite) / 2 * koefAll) * 100 * 0.4f;

			return value;
		}
	}
}
