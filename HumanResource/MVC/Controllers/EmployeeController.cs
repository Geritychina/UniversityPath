using ApplicationService.DTOs;
using MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index(string searchEmp="")
        {
            List<EmployeeVM> employeeVM = new List<EmployeeVM>();
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                foreach (var item in service.GetEmployees(searchEmp))
                {
                    employeeVM.Add(new EmployeeVM(item));
                }
            }
            return View(employeeVM);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            EmployeeVM employeeVM = new EmployeeVM();
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                var employeeDto = service.GetEmployeeByID(id);
                employeeVM = new EmployeeVM(employeeDto);
            }
            return View(employeeVM);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                ViewBag.Positions = new SelectList(service.GetPositions(""), "Id", "TypePosition");
            }

            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                ViewBag.Contracts = new SelectList(service.GetContracts(""),"Id","TypeContract");
            }
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeVM employeeVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (SOAPService.Service1Client service = new SOAPService.Service1Client())
                    {
                        EmployeeDTO employeeDTO = new EmployeeDTO
                        {
                            Name = employeeVM.Name,
                            Birthday = employeeVM.Birthday,
                            City = employeeVM.City,
                            PositionTitle = employeeVM.PositionTitle,
                            Department = employeeVM.Department,
                            PositionId = employeeVM.PositionId,
                            ContractId = employeeVM.ContractId,

                            Position = new PositionDTO
                            {
                                Id = employeeVM.PositionId
                            },
                            Contract = new ContractDTO
                            {
                                Id = employeeVM.ContractId
                            }
                        };
                        service.PostEmployee(employeeDTO);
                    }
                }
                return RedirectToAction("Index");
            }

            catch
            {
                ViewBag.Positions = Utils.LoadDataUtilities.LoadPositionData();
                ViewBag.Contracts = Utils.LoadDataUtilities.LoadContractData();
                return View();
            }
        }


        //Get Edit Employee
        public ActionResult Edit(int id)
        {
            EmployeeVM employeeVM = new EmployeeVM();
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                var employeeDTO = service.GetEmployeeByID(id);
                employeeVM = new EmployeeVM(employeeDTO);
            }


            ViewBag.Positions = Utils.LoadDataUtilities.LoadPositionData();
            ViewBag.Contracts = Utils.LoadDataUtilities.LoadContractData();
            return View(employeeVM);

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EmployeeVM employeeVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (SOAPService.Service1Client service = new SOAPService.Service1Client())
                    {
                        EmployeeDTO employeeDTO = new EmployeeDTO
                        {
                           Id = employeeVM.Id,
                            Name = employeeVM.Name,
                            Birthday = employeeVM.Birthday,
                            City = employeeVM.City,
                            PositionTitle = employeeVM.PositionTitle,
                            Department = employeeVM.Department,
                            PositionId = employeeVM.PositionId,
                            ContractId = employeeVM.ContractId

                        };
                        service.PutEmployee(employeeDTO);
                    }
                    return RedirectToAction("Index");
                }
                ViewBag.Positions = Utils.LoadDataUtilities.LoadPositionData();
                ViewBag.Contracts = Utils.LoadDataUtilities.LoadContractData();
                return View();
            }
            catch
            {
                ViewBag.Positions = Utils.LoadDataUtilities.LoadPositionData();
                ViewBag.Contracts = Utils.LoadDataUtilities.LoadContractData();
                return View();
            }

        }





        public ActionResult Delete(int id)
        {
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                service.DeleteEmployee(id);
            }
            return RedirectToAction("Index");
        }


    }
}