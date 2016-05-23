using MitchellChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitchellChallenge.BusinessLogic
{
    public interface IVehicleBusiness
    {
        List<VehicleModel> GetAllVehicles();

        bool CreateVehicle(VehicleModel model);

        bool DeleteVehicle(int id);

        bool UpdateModel(VehicleModel model);

        VehicleModel GetByID(int id);
    }
}
