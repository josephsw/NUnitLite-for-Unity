﻿using UnityEngine;
using UnityEditor;
using System;
using System.Collections;
using System.Reflection;

namespace NUnitLite.Unity
{
	public static class NUnitLiteMenuItem
	{

		#region inner classes, enum, and structs
		#endregion
	
		#region constants
		#endregion
	
		#region properties
		#endregion
	
		#region public methods
		[MenuItem("NUnitLite/Run Unit Tests #&t")]
		public static void RunTestsWithConsoleView()
		{
			ClearConsole();
			Debug.Log("Running unit test.");
			new TestDriverSimple();
		}
		
		[MenuItem("NUnitLite/Run Category Unit Tests #&t")]
		public static void RunTestsWithConsoleViewCategory()
		{
			ClearConsole();
			String category = "Cat2";
			Debug.Log("Running category unit test for: " + category);
			new TestDriverCategory(category);
		}

		[MenuItem("NUnitLite/Run Unit Tests (with report NUnit2 format.")]
		public static void RunTestsWithNUnit2Report()
		{
			new TestDriverNUnit2Report();
		}
		
		[MenuItem("NUnitLite/Run Category Unit Tests (with report NUnit2 format.")]
		public static void RunCategoryTestsWithNUnit2Report()
		{
			String category = "Cat2";
			Debug.Log("Running category NUnit2 test for: " + category);
			new TestDriverCategoryNUnit2Report(null, category);
		}

		/*[MenuItem("NUnitLite/Run Unit Tests (with report NUnit3 format.")]
		public static void RunTestsWithNUnit3Report()
		{
			Debug.ClearDeveloperConsole();

		}*/

		#endregion
	
		#region override unity methods
		#endregion

		#region methods
		static void ClearConsole()
		{
			Assembly sceneViewAssembly = Assembly.GetAssembly(typeof(SceneView));
			Type type = sceneViewAssembly.GetType("UnityEditorInternal.LogEntries");
			MethodInfo method = type.GetMethod("Clear");
			method.Invoke(new UnityEngine.Object(), null);
		}
		#endregion
	}
}