﻿using NUnit.Framework;
using TddEbook.TddToolkit;
using TddEbook.TddToolkit.Generators;
using TddEbook.TddToolkit.TypeResolution.FakeChainElements;
using TddEbook.TddToolkitSpecification.Fixtures;
using TddEbook.TypeReflection;

namespace TddEbook.TddToolkitSpecification
{
  public class SpecialCasesResolutionsSpecification
  {
    [Test]
    public void ShouldCreateResolutionCapableOfGeneratingArrays()
    {
      //GIVEN
      var resolution = new SpecialCasesOfResolutions<RecursiveInterface[]>(new CollectionGenerator(new GenericMethodProxyCalls())).CreateResolutionOfArray();
      
      //WHEN

      //THEN
      Assert.True(resolution.Applies());
      Assert.NotNull(resolution.Apply(Any.Instance<IInstanceGenerator>()));
      Assert.AreEqual(3, resolution.Apply(Any.Instance<IInstanceGenerator>()).Length);

    }

  }
}