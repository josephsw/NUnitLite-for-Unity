using System;
using UnityEngine;

namespace NUnitLite.Unity
{
	[TestDriver]
	public class TestDriverSimple
	{
		public TestDriverSimple()
		{
			new NUnitLiteUnityTestRunner().RunWithNUnitStreamUI();
		}
	}
	
	[TestDriver]
	public class TestDriverCategory
	{
		public TestDriverCategory(String category)
		{
			new NUnitLiteUnityTestRunner().RunWithNUnitStreamUI(category);
		}
	}

	[TestDriver]
	public class TestDriverNUnit2Report
	{
		public TestDriverNUnit2Report()
		{
			new NUnitLiteUnityTestRunner().RunWithTextUI();
		}
	}
	
	[TestDriver]
	public class TestDriverCategoryNUnit2Report
	{
		public TestDriverCategoryNUnit2Report(String reportFileName, String category)
		{
			new NUnitLiteUnityTestRunner().RunWithTextUI(reportFileName, category);
		}
	}
}
