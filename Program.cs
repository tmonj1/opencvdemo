using System;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace opencvdemo
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(Environment.CurrentDirectory);
      using (var capture = new VideoCapture(@"input.mov"))
      {
        var img = new Mat();
        capture.Read(img);
        BitmapConverter.ToBitmap(img).Save(@"converted.jpg");
      }
    }
  }
}
