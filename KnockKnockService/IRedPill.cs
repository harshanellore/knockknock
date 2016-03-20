using System;
using System.ServiceModel;

namespace KnockKnockService
{
    [ServiceContract(Namespace = "http://KnockKnock.readify.net")]
    public interface IRedPill
    {
        [OperationContract]
        Guid WhatIsYourToken();

        [OperationContract]
        long FibonacciNumber(long n);

        [OperationContract]
        string ReverseWords(string s);

        [OperationContract]
        TriangleType WhatShapeIsThis(int a, int b, int c);
    }
}
