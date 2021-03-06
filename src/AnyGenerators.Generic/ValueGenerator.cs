using System;
using System.Linq;
using AutoFixture;
using TypeResolution.Interfaces;

namespace TddXt.AnyGenerators.Generic
{
  [Serializable]
  public class ValueGenerator : IValueGenerator
  {
    private readonly Fixture _generator;

    public ValueGenerator(Fixture generator)
    {
      _generator = generator;
    }

    public T ValueOtherThan<T>(params T[] omittedValues)
    {
      omittedValues = omittedValues ?? Array.Empty<T>();
      T currentValue;
      do
      {
        currentValue = Value<T>();
      } while (omittedValues.Contains(currentValue));

      return currentValue;
    }

    public T Value<T>()
    {
      //todo get back to it later
      return _generator.Create<T>();
    }

    public T Value<T>(T seed)
    {
      return _generator.Create(seed);
    }
  }
}