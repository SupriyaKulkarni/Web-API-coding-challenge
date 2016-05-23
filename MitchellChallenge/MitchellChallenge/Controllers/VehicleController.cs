using MitchellChallenge.Models;
using MitchellChallenge.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

//This is the controller class file
namespace MitchellChallenge.Controllers
{
    public class VehicleController : ApiController
    {
        private IVehicleBusiness vehicleB;

        //Constructor Injection
        public VehicleController()
        {
            this.vehicleB = new VehicleBusiness();
        }

        //api/vehicle/get
        public List<VehicleModel> Get()
        {
            return vehicleB.GetAllVehicles();
        }

        //api/vehicle/create
        [AcceptVerbs("GET", "POST")]
        public bool Create(VehicleModel model)
        {
            
                return vehicleB.CreateVehicle(model);
         }

        //api/vehicle/update
        [AcceptVerbs("GET", "POST")]
        public bool Update(VehicleModel model)
        {
            return  vehicleB.UpdateModel(model);
          
        }

        //api/vehicle/Delete/5
        [AcceptVerbs("GET", "POST","DELETE")]
        public bool Delete(int id)
        {
           return vehicleB.DeleteVehicle(id);
        }


        //api/vehicle/GetById/5
        [AcceptVerbs("GET")]
        public VehicleModel GetById(int id)
        {
            return vehicleB.GetByID(id);
        }
    }
}
