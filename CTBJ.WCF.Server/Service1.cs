using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CTBJ.WCF.Server
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“Service1”。
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", "Hello world");
        }


        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }


        public string Greeting(string name)
        {
            return string.Format("Tomson greeting to you : {0}", name);
        }


        public Person changeSex(Person person)
        {
            if (person.Gender=="男")
            {
                person.Gender = "女";
            }
            else
            {
                person.Gender = "男";
            }
            return person;
        }
    }
}
