using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Lab11.Models;

namespace Lab11.Controllers
{
    public class TripController : Controller
    {

        /********************************
        * TODO - HOMEWORK
        * *******************************/

        public RedirectToActionResult Index() => RedirectToAction("Index", "Home");

        [HttpGet]
        public ViewResult Add(string id = "")
        {
            var vm = new TripViewModel();

            if (id.ToLower() == "page2")
            {
                vm.PageNumber = 2;

                /********************************
                * TODO - HOMEWORK
                * *******************************/

                return View("Add2", vm);
            }
            else 
            {
                vm.PageNumber = 1;


                /********************************
                * TODO - HOMEWORK
                * *******************************/

                return View("Add1", vm);
            }      
        }

        [HttpPost]
        public IActionResult Add(TripViewModel vm)
        {
            if (vm.PageNumber == 1)
            {
                if (ModelState.IsValid) // only page 1 has required data
                {
                    // Store data in TempData 
                    TempData[nameof(Trip.DestinationId)] = vm.Trip.DestinationId;
                    TempData[nameof(Trip.StartDate)] = vm.Trip.StartDate;
                    TempData[nameof(Trip.EndDate)] = vm.Trip.EndDate;

                    // only store accommodation if user has selected an item from the drop-down
                    if (vm.Trip.AccommodationId > 0)
                        TempData[nameof(Trip.AccommodationId)] = vm.Trip.AccommodationId;

                    return RedirectToAction("Add", new { id = "Page2" });
                }
                else
                {
                    /********************************
                    * TODO - HOMEWORK
                    * *******************************/


                    return View("Add1", vm);
                }
            }
            else if (vm.PageNumber == 2)
            {
                // get saved data from TempData 
                vm.Trip = new Trip { 
                    DestinationId = (int)TempData[nameof(Trip.DestinationId)],
                    StartDate = (DateTime)TempData[nameof(Trip.StartDate)],
                    EndDate = (DateTime)TempData[nameof(Trip.EndDate)]
                };
                // only get accommodation if there's something in TempData
                if (TempData.Keys.Contains(nameof(Trip.AccommodationId)))
                    vm.Trip.AccommodationId = (int)TempData[nameof(Trip.AccommodationId)];

                // add selected activities from page
                foreach (int activityId in vm.SelectedActivities)
                {
                    if (vm.Trip.TripActivities == null) vm.Trip.TripActivities = new List<TripActivity>();
                    vm.Trip.TripActivities.Add(new TripActivity { ActivityId = activityId });
                }


                /********************************
                * TODO - HOMEWORK
                * *******************************/

                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }

        public RedirectToActionResult Cancel()
        {
            TempData.Clear();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public RedirectToActionResult Delete(int id)
        {

            /********************************
            * TODO - HOMEWORK
            * *******************************/

            return RedirectToAction("Index", "Home");
        }
    }
}