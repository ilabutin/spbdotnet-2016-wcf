using System;
using System.ServiceModel;
using WCFContract;

namespace WCFServer
{
  [ServiceBehavior(
    ConcurrencyMode = ConcurrencyMode.Multiple,
    InstanceContextMode = InstanceContextMode.PerCall)]
  class Service : IService
  {
    public void SetServerState(State newState)
    {
      Console.WriteLine("Setting server state to {0}", newState);
      GlobalServerState.CurrentState = newState;
    }

    public ServerState GetServerState()
    {
      ServerState state = new ServerState
      {
        State = GlobalServerState.CurrentState,
        Time = DateTime.Now
      };
      Console.WriteLine("Returning {0}", state);
      return state;
    }
  }
}
