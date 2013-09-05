using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CTBJ.WCF.Server
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IService1”。
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        string Greeting(string name);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        Person changeSex(Person person);

        // TODO: 在此添加您的服务操作
    }

    // 使用下面示例中说明的数据协定将复合类型添加到服务操作

    [DataContract]
    public class Person
    {
        string name = string.Empty;
        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        string gender = string.Empty;
        [DataMember]
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public override string ToString()
        {
            return string.Format("the gender of {0} is {1}", this.name, this.gender);
        }

    }



    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
