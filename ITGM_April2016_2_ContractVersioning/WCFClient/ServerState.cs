using System;
using System.Runtime.Serialization;

namespace WCFServer
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
    private int state;

    public State State
    {
      get { return (State)state; }
      set { state = (int)value; }
    }

    public override string ToString()
    {
      return string.Format("ServerState({0} at {1})", State, Time);
    }
  }
}
