using System;
using System.ServiceModel;

namespace WCFContract
{
  public class ServiceProxy : ClientBase<IService>, IService, IDisposable
  {
    public ServiceProxy(string userName)
    {
      ClientCredentials.UserName.UserName = userName;
    }

    public void SetServerState(State newState)
    {
      Channel.SetServerState(newState);
    }

    public ServerState GetServerState()
    {
      return Channel.GetServerState();
    }

    public void SendLargeBuffer(byte[] buffer)
    {
      Channel.SendLargeBuffer(buffer);
    }

    public void Dispose()
    {
      try
      {
        if (State == CommunicationState.Faulted)
        {
          Abort();
        }
        else
        {
          Close();
        }
      }
      catch (Exception)
      {
      }
    }
  }
}
