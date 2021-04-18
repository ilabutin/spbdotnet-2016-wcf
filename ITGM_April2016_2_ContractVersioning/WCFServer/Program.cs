using System;
using System.ServiceModel;

namespace WCFServer
{
  class Program
  {
    static void Main(string[] args)
    {
      using (ServiceHost host = new ServiceHost(typeof(Service)))
      {
        GlobalServerState.CurrentState = State.Booting;
        host.Open();

        Console.WriteLine("Service started");
        Console.ReadLine();
      }
    }
  }
}
