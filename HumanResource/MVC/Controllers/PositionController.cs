using ApplicationService.DTOs;
using MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace MVC.Controllers
{
    public class PositionController : Controller
    {
        // GET: Position
        
        public  ActionResult Index(string searchPos="")
        {
            
            List<PositionVM> positionsVM = new List<PositionVM>();
            using(SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                foreach (var item in service.GetPositions(searchPos))
                {
                    positionsVM.Add(new PositionVM(item));
                }
            }

           

            return View(positionsVM);
        }

        // GET: Position/Details/5
       public ActionResult Details(int id)
        {
            PositionVM positionVM = new PositionVM();
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                var positionDto = service.GetPositionByID(id);
                positionVM = new PositionVM(positionDto);
            }
            return View(positionVM);
        }

        // GET: Position/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Position/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PositionVM positionVM) 
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (SOAPService.Service1Client service = new SOAPService.Service1Client())
                    {
                        PositionDTO positionDTO = new PositionDTO
                        {
                            TypePosition = positionVM.TypePosition,
                            Name = positionVM.Name,
                            Department = positionVM.Departament
                            
                        };
                        service.PostPosition(positionDTO);
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

        //Get Edit Position
        public ActionResult Edit(int id)
        {
            PositionVM positionVM = new PositionVM();
            using(SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                var positionDTO = service.GetPositionByID(id);
                positionVM = new PositionVM(positionDTO);
            }
            return View(positionVM);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PositionVM positionVm)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using(SOAPService.Service1Client service = new SOAPService.Service1Client())
                    {
                        PositionDTO positionDTO = new PositionDTO
                        {
                            Id = positionVm.Id,
                            TypePosition = positionVm.TypePosition,
                            Name = positionVm.Name,
                            Department = positionVm.Departament

                        };
                        service.PutPosition(positionDTO);
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
                service.DeletePosition(id);
            }
            return RedirectToAction("Index");

        }



    }


}