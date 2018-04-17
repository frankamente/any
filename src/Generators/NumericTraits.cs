using System;
using System.Numerics;
using System.Text;
using Generic.Math;

namespace TddEbook.TddToolkit.Generators
{
  public static class NumericTraits
  {
    public static NumericTraits<int> Integer()
    {
      return new NumericTraits<int>(int.MaxValue, bi => (int) bi);
    }

    public static NumericTraits<long> Long()
    {
      return new NumericTraits<long>(long.MaxValue, bi => (long) bi);
    }

    public static NumericTraits<uint> UnsignedInteger()
    {
      return new NumericTraits<uint>(uint.MaxValue, bi => (uint) bi);
    }

    public static NumericTraits<ulong> UnsignedLong()
    {
      return new NumericTraits<ulong>(ulong.MaxValue, bi => (ulong) bi);
    }
  }
  public class NumericTraits<T>
  {
    private readonly Func<BigInteger, T> _cast;

    public NumericTraits(BigInteger maxValue, Func<BigInteger, T> cast)
    {
      _cast = cast;
      Max = maxValue;
      MaxValueString = Max.ToString();
      MaxPossibleDigitsCount = MaxValueString.Length;
    }


    private BigInteger Max { get; }
    private int MaxPossibleDigitsCount { get; }
    private string MaxValueString { get; }

    public T GenerateWithExactNumberOfDigits(int digitsCount, Random randomGenerator)
    {
      if (digitsCount > MaxPossibleDigitsCount)
      {
        throw new ArgumentOutOfRangeException(nameof(digitsCount), digitsCount,
          $"expected at most {MaxPossibleDigitsCount}");
      }
      var bytes = GetRandomDigits(digitsCount, randomGenerator);
      var bigInteger = NarrowDownToSpecificNumericTypeRange(bytes);
      return _cast.Invoke(bigInteger);
    }

    public static T ConvertValue<T, U>(U value) where U : IConvertible
    {
      return (T)Convert.ChangeType(value, typeof(T));
    }

    private static string GetRandomDigits(int digitsCount, Random randomGenerator)
    {
      var str = "";
      str += randomGenerator.Next(1, 9);
      var builder = new StringBuilder();
      builder.Append(str);
      for (int i = 1; i < digitsCount; i++)
      {
        builder.Append(randomGenerator.Next(0, 9));
      }
      str = builder.ToString();
      return str;
    }

    private static BigInteger MinimumValueWithSpecifiedDigits(int length)
    {
      var result = "1";
      var builder = new StringBuilder();
      builder.Append(result);
      for (int i = 1; i < length; ++i)
      {
        builder.Append(@"0");
      }
      result = builder.ToString();
      return BigInteger.Parse(result);
    }

    private BigInteger NarrowDownToSpecificNumericTypeRange(string number)
    {
      var bigInteger = BigInteger.Parse(number);
      var min = MinimumValueWithSpecifiedDigits(number.Length);
      var narrowDownToSpecificNumericTypeRange = bigInteger % (Max - min) + min;
      return narrowDownToSpecificNumericTypeRange;
    }
  }
}