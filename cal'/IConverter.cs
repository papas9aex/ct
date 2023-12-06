namespace kt7;

interface IConverter
{
      U Convert<T, U>(T value);
}

class StringToIntConverter : IConverter
{
      public U Convert<T, U>(T value)
      {
            if (typeof(T) == typeof(string) && typeof(U) == typeof(int))
            {
                  return (U)(object)int.Parse(value as string);
            }
            throw new ArgumentException("Conversion not supported.");
      }
}

class ObjectToStringConverter : IConverter
{
      public U Convert<T, U>(T value)
      {
            return (U)(object)value.ToString();
      }
}
