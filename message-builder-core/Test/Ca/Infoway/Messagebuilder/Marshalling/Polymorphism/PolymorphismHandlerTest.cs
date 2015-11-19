using Ca.Infoway.Messagebuilder.Datatype;
using Ca.Infoway.Messagebuilder.Marshalling.Polymorphism;
using NUnit.Framework;

namespace Ca.Infoway.Messagebuilder.Marshalling.Polymorphism
{
	[TestFixture]
	public class PolymorphismHandlerTest
	{
		private PolymorphismHandler handler = new PolymorphismHandler();

		[Test]
		public virtual void TestValidTypeSwitching()
		{
			Assert.IsTrue(this.handler.IsValidTypeChange(StandardDataType.TS, StandardDataType.SXCM_TS));
			Assert.IsTrue(this.handler.IsValidTypeChange(StandardDataType.TS, StandardDataType.PIVL_TS));
			Assert.IsTrue(this.handler.IsValidTypeChange(StandardDataType.TS, StandardDataType.IVL_TS));
			Assert.IsTrue(this.handler.IsValidTypeChange(StandardDataType.TS, StandardDataType.EIVL_TS));
			Assert.IsTrue(this.handler.IsValidTypeChange(StandardDataType.TS, StandardDataType.SXCM_TS));
			Assert.IsTrue(this.handler.IsValidTypeChange(StandardDataType.SXCM_TS, StandardDataType.PIVL_TS));
			Assert.IsTrue(this.handler.IsValidTypeChange(StandardDataType.SXCM_TS, StandardDataType.IVL_TS));
			Assert.IsTrue(this.handler.IsValidTypeChange(StandardDataType.SXCM_TS, StandardDataType.EIVL_TS));
			Assert.IsTrue(this.handler.IsValidTypeChange(StandardDataType.CD, StandardDataType.CE));
			Assert.IsTrue(this.handler.IsValidTypeChange(StandardDataType.CD, StandardDataType.BXIT_CD));
			Assert.IsTrue(this.handler.IsValidTypeChange(StandardDataType.CD, StandardDataType.SXCM_CD));
			Assert.IsTrue(this.handler.IsValidTypeChange(StandardDataType.CD, StandardDataType.CV));
			Assert.IsTrue(this.handler.IsValidTypeChange(StandardDataType.CD, StandardDataType.HXIT_CE));
			Assert.IsTrue(this.handler.IsValidTypeChange(StandardDataType.CD, StandardDataType.CS));
			Assert.IsTrue(this.handler.IsValidTypeChange(StandardDataType.CD, StandardDataType.CO));
			Assert.IsTrue(this.handler.IsValidTypeChange(StandardDataType.CE, StandardDataType.CV));
			Assert.IsTrue(this.handler.IsValidTypeChange(StandardDataType.CE, StandardDataType.HXIT_CE));
			Assert.IsTrue(this.handler.IsValidTypeChange(StandardDataType.CE, StandardDataType.CS));
			Assert.IsTrue(this.handler.IsValidTypeChange(StandardDataType.CE, StandardDataType.CO));
			Assert.IsTrue(this.handler.IsValidTypeChange(StandardDataType.CV, StandardDataType.CS));
			Assert.IsTrue(this.handler.IsValidTypeChange(StandardDataType.CV, StandardDataType.CO));
			Assert.IsTrue(this.handler.IsValidTypeChange(StandardDataType.EN, StandardDataType.PN));
			Assert.IsTrue(this.handler.IsValidTypeChange(StandardDataType.EN, StandardDataType.ON));
			Assert.IsTrue(this.handler.IsValidTypeChange(StandardDataType.EN, StandardDataType.TN));
			Assert.IsTrue(this.handler.IsValidTypeChange(StandardDataType.TS, StandardDataType.TS));
			Assert.IsTrue(this.handler.IsValidTypeChange(StandardDataType.AD, StandardDataType.AD));
		}

		[Test]
		public virtual void TestValidTypeNameSwitching()
		{
			Assert.IsTrue(this.handler.IsValidTypeChange("TS", "IVL<TS>"));
			Assert.IsTrue(this.handler.IsValidTypeChange("SXCM<TS>", "EIVL<TS>"));
			Assert.IsTrue(this.handler.IsValidTypeChange("CD", "CS"));
			Assert.IsTrue(this.handler.IsValidTypeChange("CE", "CV"));
			Assert.IsTrue(this.handler.IsValidTypeChange("CV", "CO"));
			Assert.IsTrue(this.handler.IsValidTypeChange("EN", "PN"));
		}

		[Test]
		public virtual void TestInvalidTypeSwitching()
		{
			Assert.IsFalse(this.handler.IsValidTypeChange(StandardDataType.SXCM_TS, StandardDataType.TS));
			Assert.IsFalse(this.handler.IsValidTypeChange(StandardDataType.IVL_TS, StandardDataType.SXCM_TS));
			Assert.IsFalse(this.handler.IsValidTypeChange(StandardDataType.CE, StandardDataType.CD));
			Assert.IsFalse(this.handler.IsValidTypeChange(StandardDataType.CS, StandardDataType.CV));
			Assert.IsFalse(this.handler.IsValidTypeChange(StandardDataType.ON, StandardDataType.PN));
			Assert.IsFalse(this.handler.IsValidTypeChange(StandardDataType.PN, StandardDataType.EN));
		}

		[Test]
		public virtual void TestInvalidTypeNameSwitching()
		{
			Assert.IsFalse(this.handler.IsValidTypeChange("TS", "IVL_TS"));
			Assert.IsFalse(this.handler.IsValidTypeChange("SXCM_TS", "EIVL_TS"));
			Assert.IsFalse(this.handler.IsValidTypeChange("CS", "CD"));
			Assert.IsFalse(this.handler.IsValidTypeChange("PN", "EN"));
		}
	}
}