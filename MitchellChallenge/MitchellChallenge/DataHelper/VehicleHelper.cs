using MitchellChallenge.Data;
using MitchellChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MitchellChallenge.DataHelper
{
    public class VehicleHelper
    {
        private VehicleDBEntities db = new VehicleDBEntities();

        //Get List of vehicles:
        public List<VehicleModel> GetAllVehicles()
        {
            List<VehicleModel> vehicleList = new List<VehicleModel>();
            var list = (from b in db.Vehicles select b).ToList();
            foreach (var vehicle in list)
            {
                VehicleModel model = new VehicleModel();
                model.Id = vehicle.Id;
                model.Year = (int)vehicle.Year;
                model.Make=vehicle.Make;
                model.Model = vehicle.Model;
                vehicleList.Add(model);
            }
            return vehicleList;
        }

        //Add a new vehicle:
        public bool AddVehicle(VehicleModel vehicle)
        {
            try
            {
                var vehiclenew = new Vehicle
                {
                    Make = vehicle.Make,
                    Model = vehicle.Model,
                    Year = vehicle.Year

                };
                db.Vehicles.Add(vehiclenew);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //Delete a vehicle:
        public bool DeleteVehicle(int id)
        {
            try
            {
                var vehicleToRemove = (from v in db.Vehicles
                                       where v.Id == id
                                       select v).FirstOrDefault();
                db.Vehicles.Remove(vehicleToRemove);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //Edit a vehicle detail:
        public bool UpdateVehicle(VehicleModel model)
        {
            try { 
            if (model != null)
            {
                var vehicleToUpdate = (from v in db.Vehicles
                                       where v.Id == model.Id
                                       select v).FirstOrDefault();

                vehicleToUpdate.Make = model.Make;
                vehicleToUpdate.Model = model.Model;
                vehicleToUpdate.Year = model.Year;

                db.SaveChanges();
                return true;
            }
            }
            catch (Exception ex) {
                return false;
            }
            return false;
        }

        public VehicleModel GetById(int id)
        {
            
            var vehicleToUpdate = (from v in db.Vehicles
                                   where v.Id == id
                                   select v).FirstOrDefault();
            VehicleModel model = new VehicleModel();
            if (vehicleToUpdate != null)
            {
                model.Id = vehicleToUpdate.Id;
                model.Year = (int)vehicleToUpdate.Year;
                model.Make = vehicleToUpdate.Make;
                model.Model = vehicleToUpdate.Model;
            }
            return model;
        }


    }
}