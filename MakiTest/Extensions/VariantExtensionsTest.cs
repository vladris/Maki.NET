using Maki;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MakiTest
{
	[TestClass]
	public class VariantExtensionsTest
	{
		class T1 { }

		class T2 { }

		[TestMethod]
		public void TestApplyToVariant2T1()
		{
			var variant = Variant<int, int>.Make1(5);
		
			variant.Apply(
				_ => { },
				_ => Assert.Fail());
			
			var variantT = new Variant<T1, T2>(new T1());

			int result = variantT.Apply(
				item => 42,
				item => 0);
			Assert.AreEqual(42, result);

			var variantResult = variantT.Map(
				item => 42,
				item => 0);
			Assert.AreEqual(0, variantResult.Index);
			Assert.AreEqual(42, variantResult.Get<int>());
		}

		[TestMethod]
		public void TestApplyToVariant2T2()
		{
			var variant = Variant<int, int>.Make2(5);
		
			variant.Apply(
				_ => Assert.Fail(),
				_ => { });
			
			var variantT = new Variant<T1, T2>(new T2());

			int result = variantT.Apply(
				item => 0,
				item => 42);
			Assert.AreEqual(42, result);

			var variantResult = variantT.Map(
				item => 0,
				item => 42);
			Assert.AreEqual(1, variantResult.Index);
			Assert.AreEqual(42, variantResult.Get<int>());
		}

		class T3 { }

		[TestMethod]
		public void TestApplyToVariant3T1()
		{
			var variant = Variant<int, int, int>.Make1(5);
		
			variant.Apply(
				_ => { },
				_ => Assert.Fail(),
				_ => Assert.Fail());
			
			var variantT = new Variant<T1, T2, T3>(new T1());

			int result = variantT.Apply(
				item => 42,
				item => 0,
				item => 0);
			Assert.AreEqual(42, result);

			var variantResult = variantT.Map(
				item => 42,
				item => 0,
				item => 0);
			Assert.AreEqual(0, variantResult.Index);
			Assert.AreEqual(42, variantResult.Get<int>());
		}

		[TestMethod]
		public void TestApplyToVariant3T2()
		{
			var variant = Variant<int, int, int>.Make2(5);
		
			variant.Apply(
				_ => Assert.Fail(),
				_ => { },
				_ => Assert.Fail());
			
			var variantT = new Variant<T1, T2, T3>(new T2());

			int result = variantT.Apply(
				item => 0,
				item => 42,
				item => 0);
			Assert.AreEqual(42, result);

			var variantResult = variantT.Map(
				item => 0,
				item => 42,
				item => 0);
			Assert.AreEqual(1, variantResult.Index);
			Assert.AreEqual(42, variantResult.Get<int>());
		}

		[TestMethod]
		public void TestApplyToVariant3T3()
		{
			var variant = Variant<int, int, int>.Make3(5);
		
			variant.Apply(
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => { });
			
			var variantT = new Variant<T1, T2, T3>(new T3());

			int result = variantT.Apply(
				item => 0,
				item => 0,
				item => 42);
			Assert.AreEqual(42, result);

			var variantResult = variantT.Map(
				item => 0,
				item => 0,
				item => 42);
			Assert.AreEqual(2, variantResult.Index);
			Assert.AreEqual(42, variantResult.Get<int>());
		}

		class T4 { }

		[TestMethod]
		public void TestApplyToVariant4T1()
		{
			var variant = Variant<int, int, int, int>.Make1(5);
		
			variant.Apply(
				_ => { },
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => Assert.Fail());
			
			var variantT = new Variant<T1, T2, T3, T4>(new T1());

			int result = variantT.Apply(
				item => 42,
				item => 0,
				item => 0,
				item => 0);
			Assert.AreEqual(42, result);

			var variantResult = variantT.Map(
				item => 42,
				item => 0,
				item => 0,
				item => 0);
			Assert.AreEqual(0, variantResult.Index);
			Assert.AreEqual(42, variantResult.Get<int>());
		}

		[TestMethod]
		public void TestApplyToVariant4T2()
		{
			var variant = Variant<int, int, int, int>.Make2(5);
		
			variant.Apply(
				_ => Assert.Fail(),
				_ => { },
				_ => Assert.Fail(),
				_ => Assert.Fail());
			
			var variantT = new Variant<T1, T2, T3, T4>(new T2());

			int result = variantT.Apply(
				item => 0,
				item => 42,
				item => 0,
				item => 0);
			Assert.AreEqual(42, result);

			var variantResult = variantT.Map(
				item => 0,
				item => 42,
				item => 0,
				item => 0);
			Assert.AreEqual(1, variantResult.Index);
			Assert.AreEqual(42, variantResult.Get<int>());
		}

		[TestMethod]
		public void TestApplyToVariant4T3()
		{
			var variant = Variant<int, int, int, int>.Make3(5);
		
			variant.Apply(
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => { },
				_ => Assert.Fail());
			
			var variantT = new Variant<T1, T2, T3, T4>(new T3());

			int result = variantT.Apply(
				item => 0,
				item => 0,
				item => 42,
				item => 0);
			Assert.AreEqual(42, result);

			var variantResult = variantT.Map(
				item => 0,
				item => 0,
				item => 42,
				item => 0);
			Assert.AreEqual(2, variantResult.Index);
			Assert.AreEqual(42, variantResult.Get<int>());
		}

		[TestMethod]
		public void TestApplyToVariant4T4()
		{
			var variant = Variant<int, int, int, int>.Make4(5);
		
			variant.Apply(
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => { });
			
			var variantT = new Variant<T1, T2, T3, T4>(new T4());

			int result = variantT.Apply(
				item => 0,
				item => 0,
				item => 0,
				item => 42);
			Assert.AreEqual(42, result);

			var variantResult = variantT.Map(
				item => 0,
				item => 0,
				item => 0,
				item => 42);
			Assert.AreEqual(3, variantResult.Index);
			Assert.AreEqual(42, variantResult.Get<int>());
		}

		class T5 { }

		[TestMethod]
		public void TestApplyToVariant5T1()
		{
			var variant = Variant<int, int, int, int, int>.Make1(5);
		
			variant.Apply(
				_ => { },
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => Assert.Fail());
			
			var variantT = new Variant<T1, T2, T3, T4, T5>(new T1());

			int result = variantT.Apply(
				item => 42,
				item => 0,
				item => 0,
				item => 0,
				item => 0);
			Assert.AreEqual(42, result);

			var variantResult = variantT.Map(
				item => 42,
				item => 0,
				item => 0,
				item => 0,
				item => 0);
			Assert.AreEqual(0, variantResult.Index);
			Assert.AreEqual(42, variantResult.Get<int>());
		}

		[TestMethod]
		public void TestApplyToVariant5T2()
		{
			var variant = Variant<int, int, int, int, int>.Make2(5);
		
			variant.Apply(
				_ => Assert.Fail(),
				_ => { },
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => Assert.Fail());
			
			var variantT = new Variant<T1, T2, T3, T4, T5>(new T2());

			int result = variantT.Apply(
				item => 0,
				item => 42,
				item => 0,
				item => 0,
				item => 0);
			Assert.AreEqual(42, result);

			var variantResult = variantT.Map(
				item => 0,
				item => 42,
				item => 0,
				item => 0,
				item => 0);
			Assert.AreEqual(1, variantResult.Index);
			Assert.AreEqual(42, variantResult.Get<int>());
		}

		[TestMethod]
		public void TestApplyToVariant5T3()
		{
			var variant = Variant<int, int, int, int, int>.Make3(5);
		
			variant.Apply(
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => { },
				_ => Assert.Fail(),
				_ => Assert.Fail());
			
			var variantT = new Variant<T1, T2, T3, T4, T5>(new T3());

			int result = variantT.Apply(
				item => 0,
				item => 0,
				item => 42,
				item => 0,
				item => 0);
			Assert.AreEqual(42, result);

			var variantResult = variantT.Map(
				item => 0,
				item => 0,
				item => 42,
				item => 0,
				item => 0);
			Assert.AreEqual(2, variantResult.Index);
			Assert.AreEqual(42, variantResult.Get<int>());
		}

		[TestMethod]
		public void TestApplyToVariant5T4()
		{
			var variant = Variant<int, int, int, int, int>.Make4(5);
		
			variant.Apply(
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => { },
				_ => Assert.Fail());
			
			var variantT = new Variant<T1, T2, T3, T4, T5>(new T4());

			int result = variantT.Apply(
				item => 0,
				item => 0,
				item => 0,
				item => 42,
				item => 0);
			Assert.AreEqual(42, result);

			var variantResult = variantT.Map(
				item => 0,
				item => 0,
				item => 0,
				item => 42,
				item => 0);
			Assert.AreEqual(3, variantResult.Index);
			Assert.AreEqual(42, variantResult.Get<int>());
		}

		[TestMethod]
		public void TestApplyToVariant5T5()
		{
			var variant = Variant<int, int, int, int, int>.Make5(5);
		
			variant.Apply(
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => { });
			
			var variantT = new Variant<T1, T2, T3, T4, T5>(new T5());

			int result = variantT.Apply(
				item => 0,
				item => 0,
				item => 0,
				item => 0,
				item => 42);
			Assert.AreEqual(42, result);

			var variantResult = variantT.Map(
				item => 0,
				item => 0,
				item => 0,
				item => 0,
				item => 42);
			Assert.AreEqual(4, variantResult.Index);
			Assert.AreEqual(42, variantResult.Get<int>());
		}

		class T6 { }

		[TestMethod]
		public void TestApplyToVariant6T1()
		{
			var variant = Variant<int, int, int, int, int, int>.Make1(5);
		
			variant.Apply(
				_ => { },
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => Assert.Fail());
			
			var variantT = new Variant<T1, T2, T3, T4, T5, T6>(new T1());

			int result = variantT.Apply(
				item => 42,
				item => 0,
				item => 0,
				item => 0,
				item => 0,
				item => 0);
			Assert.AreEqual(42, result);

			var variantResult = variantT.Map(
				item => 42,
				item => 0,
				item => 0,
				item => 0,
				item => 0,
				item => 0);
			Assert.AreEqual(0, variantResult.Index);
			Assert.AreEqual(42, variantResult.Get<int>());
		}

		[TestMethod]
		public void TestApplyToVariant6T2()
		{
			var variant = Variant<int, int, int, int, int, int>.Make2(5);
		
			variant.Apply(
				_ => Assert.Fail(),
				_ => { },
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => Assert.Fail());
			
			var variantT = new Variant<T1, T2, T3, T4, T5, T6>(new T2());

			int result = variantT.Apply(
				item => 0,
				item => 42,
				item => 0,
				item => 0,
				item => 0,
				item => 0);
			Assert.AreEqual(42, result);

			var variantResult = variantT.Map(
				item => 0,
				item => 42,
				item => 0,
				item => 0,
				item => 0,
				item => 0);
			Assert.AreEqual(1, variantResult.Index);
			Assert.AreEqual(42, variantResult.Get<int>());
		}

		[TestMethod]
		public void TestApplyToVariant6T3()
		{
			var variant = Variant<int, int, int, int, int, int>.Make3(5);
		
			variant.Apply(
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => { },
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => Assert.Fail());
			
			var variantT = new Variant<T1, T2, T3, T4, T5, T6>(new T3());

			int result = variantT.Apply(
				item => 0,
				item => 0,
				item => 42,
				item => 0,
				item => 0,
				item => 0);
			Assert.AreEqual(42, result);

			var variantResult = variantT.Map(
				item => 0,
				item => 0,
				item => 42,
				item => 0,
				item => 0,
				item => 0);
			Assert.AreEqual(2, variantResult.Index);
			Assert.AreEqual(42, variantResult.Get<int>());
		}

		[TestMethod]
		public void TestApplyToVariant6T4()
		{
			var variant = Variant<int, int, int, int, int, int>.Make4(5);
		
			variant.Apply(
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => { },
				_ => Assert.Fail(),
				_ => Assert.Fail());
			
			var variantT = new Variant<T1, T2, T3, T4, T5, T6>(new T4());

			int result = variantT.Apply(
				item => 0,
				item => 0,
				item => 0,
				item => 42,
				item => 0,
				item => 0);
			Assert.AreEqual(42, result);

			var variantResult = variantT.Map(
				item => 0,
				item => 0,
				item => 0,
				item => 42,
				item => 0,
				item => 0);
			Assert.AreEqual(3, variantResult.Index);
			Assert.AreEqual(42, variantResult.Get<int>());
		}

		[TestMethod]
		public void TestApplyToVariant6T5()
		{
			var variant = Variant<int, int, int, int, int, int>.Make5(5);
		
			variant.Apply(
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => { },
				_ => Assert.Fail());
			
			var variantT = new Variant<T1, T2, T3, T4, T5, T6>(new T5());

			int result = variantT.Apply(
				item => 0,
				item => 0,
				item => 0,
				item => 0,
				item => 42,
				item => 0);
			Assert.AreEqual(42, result);

			var variantResult = variantT.Map(
				item => 0,
				item => 0,
				item => 0,
				item => 0,
				item => 42,
				item => 0);
			Assert.AreEqual(4, variantResult.Index);
			Assert.AreEqual(42, variantResult.Get<int>());
		}

		[TestMethod]
		public void TestApplyToVariant6T6()
		{
			var variant = Variant<int, int, int, int, int, int>.Make6(5);
		
			variant.Apply(
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => { });
			
			var variantT = new Variant<T1, T2, T3, T4, T5, T6>(new T6());

			int result = variantT.Apply(
				item => 0,
				item => 0,
				item => 0,
				item => 0,
				item => 0,
				item => 42);
			Assert.AreEqual(42, result);

			var variantResult = variantT.Map(
				item => 0,
				item => 0,
				item => 0,
				item => 0,
				item => 0,
				item => 42);
			Assert.AreEqual(5, variantResult.Index);
			Assert.AreEqual(42, variantResult.Get<int>());
		}

		class T7 { }

		[TestMethod]
		public void TestApplyToVariant7T1()
		{
			var variant = Variant<int, int, int, int, int, int, int>.Make1(5);
		
			variant.Apply(
				_ => { },
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => Assert.Fail());
			
			var variantT = new Variant<T1, T2, T3, T4, T5, T6, T7>(new T1());

			int result = variantT.Apply(
				item => 42,
				item => 0,
				item => 0,
				item => 0,
				item => 0,
				item => 0,
				item => 0);
			Assert.AreEqual(42, result);

			var variantResult = variantT.Map(
				item => 42,
				item => 0,
				item => 0,
				item => 0,
				item => 0,
				item => 0,
				item => 0);
			Assert.AreEqual(0, variantResult.Index);
			Assert.AreEqual(42, variantResult.Get<int>());
		}

		[TestMethod]
		public void TestApplyToVariant7T2()
		{
			var variant = Variant<int, int, int, int, int, int, int>.Make2(5);
		
			variant.Apply(
				_ => Assert.Fail(),
				_ => { },
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => Assert.Fail());
			
			var variantT = new Variant<T1, T2, T3, T4, T5, T6, T7>(new T2());

			int result = variantT.Apply(
				item => 0,
				item => 42,
				item => 0,
				item => 0,
				item => 0,
				item => 0,
				item => 0);
			Assert.AreEqual(42, result);

			var variantResult = variantT.Map(
				item => 0,
				item => 42,
				item => 0,
				item => 0,
				item => 0,
				item => 0,
				item => 0);
			Assert.AreEqual(1, variantResult.Index);
			Assert.AreEqual(42, variantResult.Get<int>());
		}

		[TestMethod]
		public void TestApplyToVariant7T3()
		{
			var variant = Variant<int, int, int, int, int, int, int>.Make3(5);
		
			variant.Apply(
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => { },
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => Assert.Fail());
			
			var variantT = new Variant<T1, T2, T3, T4, T5, T6, T7>(new T3());

			int result = variantT.Apply(
				item => 0,
				item => 0,
				item => 42,
				item => 0,
				item => 0,
				item => 0,
				item => 0);
			Assert.AreEqual(42, result);

			var variantResult = variantT.Map(
				item => 0,
				item => 0,
				item => 42,
				item => 0,
				item => 0,
				item => 0,
				item => 0);
			Assert.AreEqual(2, variantResult.Index);
			Assert.AreEqual(42, variantResult.Get<int>());
		}

		[TestMethod]
		public void TestApplyToVariant7T4()
		{
			var variant = Variant<int, int, int, int, int, int, int>.Make4(5);
		
			variant.Apply(
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => { },
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => Assert.Fail());
			
			var variantT = new Variant<T1, T2, T3, T4, T5, T6, T7>(new T4());

			int result = variantT.Apply(
				item => 0,
				item => 0,
				item => 0,
				item => 42,
				item => 0,
				item => 0,
				item => 0);
			Assert.AreEqual(42, result);

			var variantResult = variantT.Map(
				item => 0,
				item => 0,
				item => 0,
				item => 42,
				item => 0,
				item => 0,
				item => 0);
			Assert.AreEqual(3, variantResult.Index);
			Assert.AreEqual(42, variantResult.Get<int>());
		}

		[TestMethod]
		public void TestApplyToVariant7T5()
		{
			var variant = Variant<int, int, int, int, int, int, int>.Make5(5);
		
			variant.Apply(
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => { },
				_ => Assert.Fail(),
				_ => Assert.Fail());
			
			var variantT = new Variant<T1, T2, T3, T4, T5, T6, T7>(new T5());

			int result = variantT.Apply(
				item => 0,
				item => 0,
				item => 0,
				item => 0,
				item => 42,
				item => 0,
				item => 0);
			Assert.AreEqual(42, result);

			var variantResult = variantT.Map(
				item => 0,
				item => 0,
				item => 0,
				item => 0,
				item => 42,
				item => 0,
				item => 0);
			Assert.AreEqual(4, variantResult.Index);
			Assert.AreEqual(42, variantResult.Get<int>());
		}

		[TestMethod]
		public void TestApplyToVariant7T6()
		{
			var variant = Variant<int, int, int, int, int, int, int>.Make6(5);
		
			variant.Apply(
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => { },
				_ => Assert.Fail());
			
			var variantT = new Variant<T1, T2, T3, T4, T5, T6, T7>(new T6());

			int result = variantT.Apply(
				item => 0,
				item => 0,
				item => 0,
				item => 0,
				item => 0,
				item => 42,
				item => 0);
			Assert.AreEqual(42, result);

			var variantResult = variantT.Map(
				item => 0,
				item => 0,
				item => 0,
				item => 0,
				item => 0,
				item => 42,
				item => 0);
			Assert.AreEqual(5, variantResult.Index);
			Assert.AreEqual(42, variantResult.Get<int>());
		}

		[TestMethod]
		public void TestApplyToVariant7T7()
		{
			var variant = Variant<int, int, int, int, int, int, int>.Make7(5);
		
			variant.Apply(
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => Assert.Fail(),
				_ => { });
			
			var variantT = new Variant<T1, T2, T3, T4, T5, T6, T7>(new T7());

			int result = variantT.Apply(
				item => 0,
				item => 0,
				item => 0,
				item => 0,
				item => 0,
				item => 0,
				item => 42);
			Assert.AreEqual(42, result);

			var variantResult = variantT.Map(
				item => 0,
				item => 0,
				item => 0,
				item => 0,
				item => 0,
				item => 0,
				item => 42);
			Assert.AreEqual(6, variantResult.Index);
			Assert.AreEqual(42, variantResult.Get<int>());
		}

	}
}