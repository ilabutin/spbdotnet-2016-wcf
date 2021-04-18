using System;
using System.ServiceModel;
using WCFContract;
using WCFServer.InternalService;

namespace WCFServer
{
  [ServiceBehavior(
    ConcurrencyMode = ConcurrencyMode.Multiple,
    InstanceContextMode = InstanceContextMode.Single)]
  class Service : IService
  {
    public void SetServerState(State newState)
    {
      Console.WriteLine("Setting server state to {0}", newState);
      GlobalServerState.CurrentState = newState;
    }

    public ServerState GetServerState()
    {
      var state = new ServerState
      {
        State = GlobalServerState.CurrentState,
        Time = DateTime.Now
      };

//      var p = new InternalProxy();
//      p.DoSomething();
//
//      GC.Collect();
//      GC.WaitForPendingFinalizers();

      Console.WriteLine("Returning {0}", state);
      return state;
    }

    public void SendLargeBuffer(byte[] buffer)
    {
      Console.WriteLine("Received buffer[{0}]", buffer.Length);
    }
  }
}
