using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

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

    /// <summary>
    /// Returns a string that represents the current object.
    /// </summary>
    /// <returns>
    /// A string that represents the current object.
    /// </returns>
    public override string ToString()
    {
      return string.Format("ServerState({0} at {1})", State, Time);
    }
  }
}
