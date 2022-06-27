using System;
using System.Threading;
using System.Threading.Tasks;

namespace SomeProject
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      #region threads
      // Thread thread = new Thread(new ThreadStart(DoWork));
      // thread.Start();
      //
      // Thread thread2 = new Thread(new ParameterizedThreadStart(DoWork2));
      // thread2.Start(int.MaxValue);
      //
      //
      // int j = 0;
      // for (int i = 0; i < Int32.MaxValue; i++)
      // {
      //   j++;
      //
      //   if (j % 10000 == 0)
      //   {
      //     Console.WriteLine("Main");
      //   }
      // }
      #endregion


      DoWorkAsync();
      int j = 0;
      for (int i = 0; i < 10; i++)
      {
        j++;
        Console.WriteLine("Main");
      }
    }

    static async Task DoWorkAsync()
    {
      await Task.Run((() => DoWork()));
      Console.WriteLine("Do work async!");
    }
    
    static void DoWork()
    {
      int j = 0;
      for (int i = 0; i < 10; i++)
      {
        j++;
        Console.WriteLine("Do Work");
      }
    }
    static void DoWork2(object max)
    {
      int j = 0;
      for (int i = 0; i < (int)max; i++)
      {
        j++;
        
        if (j % 10000 == 0)
        {
          Console.WriteLine("Do Work2");
        }
      }
    }
  }
}