using MitchellChallenge.DataHelper;
using MitchellChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MitchellChallenge.BusinessLogic
{
    public class VehicleBusiness : IVehicleBusiness
    {
        private VehicleHelper dataHelper= new VehicleHelper();


        public List<VehicleModel> GetAllVehicles()
        {
            return dataHelper.GetAllVehicles();
        }


        public bool CreateVehicle(VehicleModel model)
        {
           return dataHelper.AddVehicle(model);
           
        }


        public bool DeleteVehicle(int id)
        {
           return dataHelper.DeleteVehicle(id);
        }


        public bool UpdateModel(VehicleModel model)
        {
            return dataHelper.UpdateVehicle(model);
        }

        public VehicleModel GetByID(int id)
        {
            return dataHelper.GetById(id);
        }
    }
}