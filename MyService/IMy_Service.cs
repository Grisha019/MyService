using System;
using System.ServiceModel;

using System.ServiceModel;


namespace WCFMyServiceLibrary
{

    [ServiceContract]
    public interface IMyService
    {
        // Сложение
        [OperationContract]
        double GetSum(double i, double j);
        // Умножение
        [OperationContract]
        double GetMult(double i, double j);

        [OperationContract]
        string SayHi();
    }
}