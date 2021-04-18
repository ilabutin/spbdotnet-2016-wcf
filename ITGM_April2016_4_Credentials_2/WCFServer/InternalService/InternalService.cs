using System;
using System.ServiceModel;

namespace WCFServer.InternalService
{
  [ServiceBehavior(
    InstanceContextMode = InstanceContextMode.PerCall,
    ConcurrencyMode = ConcurrencyMode.Multiple)]
  public class InternalService : IInternalContract
  {
    public void DoSomething()
    {
      Console.WriteLine("Did something");
    }
  }
}
