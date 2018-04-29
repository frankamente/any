using TddEbook.TddToolkit.TypeResolution.CustomCollections;
using TddEbook.TypeReflection;

namespace TddEbook.TddToolkit.Generators
{
  public class GeneratorByPickingFromSpecifiedSetOfValues<T> : InlineGenerator<T>
  {
    private static readonly ArrayElementPicking _arrayElementPicking = new ArrayElementPicking();
    private readonly T[] _possibleValues;


    public GeneratorByPickingFromSpecifiedSetOfValues(T[] possibleValues)
    {
      _possibleValues = possibleValues;
    }

    public T GenerateInstance(InstanceGenerator instanceGenerator)
    {
      var latestArraysWithPossibleValues = _arrayElementPicking.For<T>();
      if (!latestArraysWithPossibleValues.Contain(_possibleValues))
      {
        latestArraysWithPossibleValues.Add(_possibleValues);
      }

      return latestArraysWithPossibleValues.PickNextElementFrom(_possibleValues);
    }

  }
}