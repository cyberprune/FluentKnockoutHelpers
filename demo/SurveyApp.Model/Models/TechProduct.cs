﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SurveyApp.Model.Models
{
    public abstract class TechProduct
    {
        public int TechProductId { get; set; }
    }

    #region Computer
    public abstract class Computer : TechProduct
    {
        [Range(1,8000, ErrorMessage = ">8000?! This message will need to change in the future maybe...")]
        public int Mhz { get; set; }
        public int GigsOfRam { get; set; }
        public bool HasSsd { get; set; }
    }

    public class Desktop : Computer
    {
        public int NumberOfMonitors { get; set; }
    }

    public class Laptop : Computer
    {
        public double ScreenSize { get; set; }
    }
    #endregion


    #region Digital Camera
    public abstract class DigitalCamera : TechProduct
    {
        public double MegaPixels { get; set; }
    }

    public class PointAndShoot : DigitalCamera
    {
        public double XZoom { get; set; }
    }

    public class Slr : DigitalCamera
    {
        public int NumberOfLenses { get; set; }
    }
    #endregion

}
