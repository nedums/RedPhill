using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace ReadifyTest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(Namespace = "http://KnockKnock.readify.net")]
    public interface IRedPill
    {
        
        [OperationContract]
        string ReverseWords(string word);


        [OperationContract]
        Guid WhatIsYourToken();

        [OperationContract]
        long FibonacciNumber(long n);

        [OperationContract]
        TriangleType WhatShapeIsThis(int a, int b, int c);


        // TODO: Add your service operations here
    }
    [DataContractAttribute(Name = "TriangleType", Namespace = "http://KnockKnock.readify.net")]
    public enum TriangleType : int
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Error = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Equilateral = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Isosceles = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Scalene = 3,
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
   // [DataContract]
    //public delegate Red.TriangleType TriangleType;

    /*[DataContract]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://example.org/")]
    public enum TriangleType {
        [System.Xml.Serialization.XmlEnumAttribute("Error")]
        Error, 
        Equilateral, 
        Isosceles, 
        Scalene };*/

    
}
