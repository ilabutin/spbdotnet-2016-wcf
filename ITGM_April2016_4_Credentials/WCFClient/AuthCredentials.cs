using System;
using System.ServiceModel.Configuration;
using System.ServiceModel.Description;

namespace WCFClient
{
  public class AuthCredentials : ClientCredentialsElement
  {
    public override Type BehaviorType
    {
      get { return typeof(ClientCredentials); }
    }

    protected override object CreateBehavior()
    {
      var credentials = (ClientCredentials)base.CreateBehavior();

      if (credentials == null)
      {
        return null;
      }

      credentials.UserName.UserName = CredentialStorage.UserName ?? string.Empty;

      ApplyConfiguration(credentials);

      return credentials;
    }
  }
}
