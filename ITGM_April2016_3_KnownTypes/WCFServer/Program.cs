using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using WCFContract;

namespace WCFServer
{
  class Program
  {
    static void Main(string[] args)
    {
      using (ServiceHost host = new ServiceHost(typeof(Service)))
      {
//        foreach (var endpoint in host.Description.Endpoints)
//        {
//          foreach (OperationDescription operation in endpoint.Contract.Operations)
//          {
//            DataContractSerializerOperationBehavior behavior = operation.Behaviors.Find<DataContractSerializerOperationBehavior>();
//            behavior.DataContractResolver = new CustomResolver();
//          }
//        }


        GlobalServerState.CurrentState = State.Stopped;
        host.Open();

        Console.WriteLine("Service started");
        Console.ReadLine();
      }
    }
  }
}
