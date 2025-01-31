using ApplicationService.DTOs;
using MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class ContractController : Controller
    {
        // GET: Contract
        public ActionResult Index(string searchContr="")
        {
            List<ContractVM> contractVM = new List<ContractVM>();
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                foreach (var item in service.GetContracts(searchContr))
                {
                    contractVM.Add(new ContractVM(item));
                }
            }
            return View(contractVM);
        }

        // GET: Contract/Details/5
        public ActionResult Details(int id)
        {
            ContractVM contractVM = new ContractVM();
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                var contractDto = service.GetContractByID(id);
                contractVM = new ContractVM(contractDto);
            }
            return View(contractVM);
        }

        // GET: Contract/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contract/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ContractVM contractVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (SOAPService.Service1Client service = new SOAPService.Service1Client())
                    {
                        ContractDTO contractDTO = new ContractDTO
                        {
                           NameContractor = contractVM.NameContractor,
                           TypeContract = contractVM.TypeContract,
                           DateContract = contractVM.DateContract,
                           Adress = contractVM.Adress
                        };
                        service.PostContract(contractDTO);
                    }
                    return RedirectToAction("Index");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        //Get Edit Contract
        public ActionResult Edit(int id)
        {
            ContractVM contractVM = new ContractVM();
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                var contractDTO = service.GetContractByID(id);
                contractVM = new ContractVM(contractDTO);
            }
            return View(contractVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit (ContractVM contractVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (SOAPService.Service1Client service = new SOAPService.Service1Client())
                    {
                        ContractDTO contractDTO = new ContractDTO
                        {
                            Id = contractVM.Id,
                            NameContractor = contractVM.NameContractor,
                            TypeContract = contractVM.TypeContract,
                            DateContract = contractVM.DateContract,
                            Adress = contractVM.Adress
                        };
                        service.PutContract(contractDTO);
                    }
                    return RedirectToAction("Index");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }






        public ActionResult Delete(int id)
        {
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                service.DeleteContract(id);
            }
            return RedirectToAction("Index");
        }



    }
}