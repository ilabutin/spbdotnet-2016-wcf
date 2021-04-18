using System;
using System.Runtime.Serialization;

namespace WCFContract
{
  public enum State
  {
    Running,
    Stopped
  }

  [DataContract]
  public class ServerState
  {
    [DataMember]
    public DateTime Time { get; set; }
    [DataMember]
    public State State { get; set; }

    public override string ToString()
    {
      return string.Format("ServerState({0} at {1})", State, Time);
    }
  }

  [DataContract]
  public class RunningServerState : ServerState
  {
    [DataMember]
    public string Message { get; set; }

    public override string ToString()
    {
      return string.Format("RunningServerState({0} at {1}, '{2}')", State, Time, Message);
    }
  }
}
