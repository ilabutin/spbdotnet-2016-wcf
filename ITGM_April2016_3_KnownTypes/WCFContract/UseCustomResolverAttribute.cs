using System;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace WCFContract
{
  public class UseCustomResolverAttribute : Attribute, IContractBehavior
  {
    public void ApplyDispatchBehavior(
      ContractDescription contractDescription,
      ServiceEndpoint endpoint,
      DispatchRuntime dispatchRuntime)
    {
      foreach (var operation in endpoint.Contract.Operations)
      {
        var behavior =
          operation.Behaviors.Find<DataContractSerializerOperationBehavior>();
        behavior.DataContractResolver = new CustomResolver();
      }
    }

    public void ApplyClientBehavior(
      ContractDescription contractDescription,
      ServiceEndpoint endpoint,
      ClientRuntime clientRuntime)
    {
      foreach (var operation in endpoint.Contract.Operations)
      {
        var behavior =
          operation.Behaviors.Find<DataContractSerializerOperationBehavior>();
        behavior.DataContractResolver = new CustomResolver();
      }
    }

    public void AddBindingParameters(
      ContractDescription contractDescription,
      ServiceEndpoint endpoint,
      BindingParameterCollection bindingParameters)
    {
    }

    public void Validate(
      ContractDescription contractDescription,
      ServiceEndpoint endpoint)
    {
    }
  }
}
