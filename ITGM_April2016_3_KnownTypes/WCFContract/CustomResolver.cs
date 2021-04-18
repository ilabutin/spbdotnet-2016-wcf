using System;
using System.Runtime.Serialization;
using System.Xml;

namespace WCFContract
{
  public class CustomResolver : DataContractResolver
  {
    public override bool TryResolveType(
      Type type,
      Type declaredType,
      DataContractResolver knownTypeResolver,
      out XmlDictionaryString typeName,
      out XmlDictionaryString typeNamespace)
    {
      if (!knownTypeResolver.TryResolveType(
        type, declaredType, null, out typeName, out typeNamespace))
      {
        if (string.IsNullOrEmpty(type.FullName) ||
          string.IsNullOrEmpty(type.Assembly.FullName))
        {
          return false;
        }
        var xmlDictionary = new XmlDictionary();
        typeName = xmlDictionary.Add(XmlConvert.EncodeName(type.FullName));
        typeNamespace = xmlDictionary.Add(XmlConvert.EncodeName(type.Assembly.FullName));
      }
      return true;
    }

    public override Type ResolveName(
      string typeName,
      string typeNamespace,
      Type declaredType,
      DataContractResolver knownTypeResolver)
    {
      Type result = knownTypeResolver.ResolveName(
        typeName, typeNamespace, declaredType, knownTypeResolver);

      if (result != null)
      {
        return result;
      }

      result = Type.GetType(
          XmlConvert.DecodeName(typeName) + ", " + XmlConvert.DecodeName(typeNamespace));

      return result;
    }
  }
}
