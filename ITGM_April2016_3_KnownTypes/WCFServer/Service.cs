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
      var state = new ServerState();
      if (GlobalServerState.CurrentState == State.Running)
      {
        state = new RunningServerState { Message = "I'm running now." };
      }

      state.State = GlobalServerState.CurrentState;
      state.Time = DateTime.Now;

      Console.WriteLine("Returning {0}", state);
      return state;
    }
  }
}
