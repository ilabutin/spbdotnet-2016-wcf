using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WCFServer
{
  [ServiceContract]
  public interface IService
  {
    [OperationContract]
    void SetServerState(State newState);
    [OperationContract]
    ServerState GetServerState();
  }
}
