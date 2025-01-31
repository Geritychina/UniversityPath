using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    
    public class Service1 : IService1
    {
        public int CalculateDays(int day, int month, int year)
        {
            DateTime dt = new DateTime(year, month, day);
            int datetodays = DateTime.Now.Subtract(dt).Days;
            return datetodays;
        }

        public string GetData(string value)
        {
            return string.Format("You entered: {0}", value);
        }


        public string GetVignette(string value)
        {
            ClassLibrary1.Class1 service = new ClassLibrary1.Class1();
            return service.Sample(value);

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

    }
}
