using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Utils
{
    public class LoadDataUtilities
    {
        public static SelectList LoadPositionData()
        {
            using(SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                return new  SelectList(service.GetPositions(""), "Id", "TypePosition");
            }
        }

        public static SelectList LoadContractData()
        {
            using (SOAPService.Service1Client service =  new SOAPService.Service1Client())
            {
                return new SelectList(service.GetContracts(""), "Id", "TypeContract");
            }
        }
    }
}