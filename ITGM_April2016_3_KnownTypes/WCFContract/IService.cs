using System.ServiceModel;

namespace WCFContract
{
  [ServiceContract]
  [UseCustomResolver]
  public interface IService
  {
    [OperationContract]
    void SetServerState(State newState);

    [OperationContract]
    ServerState GetServerState();
  }
}
