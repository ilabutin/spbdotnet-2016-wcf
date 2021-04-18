using System;
using System.Runtime.Serialization;

namespace WCFServer
{
  public enum State
  {
    Running,
    Stopped,
    Booting
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

    [DataMember]
    public string Message { get; set; }

    public override string ToString()
    {
      return string.Format("ServerState({0} at {1}, Msg={2})", State, Time, Message);
    }
  }
}
