using System;

namespace _1
{
  class Program
  {
    static void Main(string[] args)
    {
      // C#
      SByte a = 0;
      Byte b = 0;
      Int16 c = 0;
      Int32 d = 0;
      Int64 e = 0;
      string s = "Microsoft .NET Framework 2.0 Application Development Foundation";
      string[] sa = s.Split(' ');
      // С#
      Array.Sort(sa);
      // C#
      s = string.Join(" ", sa);
      Console.WriteLine(s);


      Exception ex = new Exception();
      // C#
      object[] types = { a, b, c, d, e, s, ex };
      // C#
      foreach (object o in types)
      {
        string type;
        if (o.GetType().IsValueType) type = "Value type";
        else
          type = "Reference Type";
        Console.WriteLine("{0}: {1}", o.GetType(), type);
      }
    

    }
  }
}



