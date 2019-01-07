using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace myapp
{
  class Program
  {
    static void Main(string[] args)
    {
      Figure c = new Circle();
      
    }
  }

  public abstract class Figure
  {
    protected abstract int GetArea();
  }

  public class Circle : Figure
  {
    protected override int GetArea()
    {
      throw new NotImplementedException();
    }
  }
}
