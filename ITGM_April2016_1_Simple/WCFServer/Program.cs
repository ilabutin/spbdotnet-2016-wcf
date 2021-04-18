using System;
using System.ServiceModel;
using WCFContract;

namespace WCFServer
{
  class Program
  {
    static void Main(string[] args)
    {
      using (ServiceHost host = new ServiceHost(typeof(Service)))
      {
        GlobalServerState.CurrentState = State.Stopped;
        host.Open();

        Console.WriteLine("Service started");
        Console.ReadLine();
      }
    }
  }
}
