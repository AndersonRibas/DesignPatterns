﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder {
   /// <summary>
   /// The 'Director' class
   /// </summary>
   public class VehicleCreator {
      private readonly IVehicleBuilder objBuilder;

      public VehicleCreator(IVehicleBuilder builder) {
         objBuilder = builder;
      }

      public void CreateVehicle() {
         objBuilder.SetModel();
         objBuilder.SetEngine();
         objBuilder.SetBody();
         objBuilder.SetTransmission();
         objBuilder.SetAccessories();
      }

      public Vehicle GetVehicle() {
         return objBuilder.GetVehicle();
      }
   }
}
