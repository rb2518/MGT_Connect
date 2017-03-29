using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class SecondSelectionModel
    {
        //static SelectListItem yes = new SelectListItem
        //{
        //    Text = "YES",
        //    Value = "YES"
        //};
        //static SelectListItem no = new SelectListItem
        //{
        //    Text = "NO",
        //    Value = "NO"
        //};

        //Work Head
        [Display(Name = "Is clamping between center")]
        public drpdownlist clampCenter { get; set; }
        public string clampCenterRes { get; set; }


        //Is clamping with the help of chuck, shoe or face driver ?
        [Display(Name = "Is clamping with the help of chuck, shoe or face driver")]
        public drpdownlist isClamping { get; set; }
        public string isClampingRes { get; set; }
        //Wheel Head
        [Display(Name = "Wheel Spindle Dia.(mm)")]
        public drpdownlist wheelSpindle { get; set; }
        public string wheelSpindleRes { get; set; }

        [Display(Name = "Wheel Motor Power(kW)")]
        public drpdownlist wheelMotorPower { get; set; }
        public string wheelMotorPowerRes { get; set; }


        //public static class LenControlc
        //{
        //    [Display(Name = "Is there any length control required ?")]
        //    public static string Lenctrl = "0";
        //    public static IEnumerable<SelectListItem> items = new[]
        //        {
        //            yes,
        //            no
        //        };
        //}
        //Tail Stock
        [Display(Name = "Center[MT]")]
        public drpdownlist centerMT { get; set; }
        public string centerMTRes { get; set; }

        [Display(Name = "Stroke(mm)")]
        public drpdownlist stroke { get; set; }
        public string strokeRes { get; set; }
        //public static class FaceGrinding
        //{
        //    [Display(Name = "Is there any face grinding required ?")]
        //    public static string add = "0";
        //    public static IEnumerable<SelectListItem> items = new[]
        //        {
        //            yes,
        //            no
        //        };
        //}
        [Display(Name = "Action")]
        public drpdownlist action { get; set; }
        public string actionRes { get; set; }

        [Display(Name = "Micro Taper")]
        public drpdownlist microTaper { get; set; }
        public string microTaperRes { get; set; }
        //public static class RadGrinding
        //{
        //    [Display(Name = "Is there any radius grinding required ?")]
        //    public static string add = "0";
        //    public static IEnumerable<SelectListItem> items = new[]
        //        {
        //            yes,
        //            no
        //        };
        //}
        //[Display(Name = "Is there any radius grinding required ?")]

        [Display(Name = "Pump")]
        public drpdownlist pump { get; set; }
        public string pumpRes { get; set; }

        //Flagging
        [Display(Name = "Type")]
        public drpdownlist type { get; set; }
        public string typeRes { get; set; }

        //Balance Unit
        [Display(Name = "Type")]
        public drpdownlist typeB { get; set; }
        public string typeBres { get; set; }

        //Coolant Tank
        [Display(Name = "Make")]
        public drpdownlist make { get; set; }
        public string makeRes { get; set; }
        //public static class idod
        //{
        //    [Display(Name = "ID/OD")]
        //    public static string add = "0";
        //    public static IEnumerable<SelectListItem> items = new[]
        //        {
        //            new SelectListItem{Value="ID",Text="ID"},
        //            new SelectListItem{Value="OD",Text="OD"}
        //        };
        //}
        [Display(Name = "Capacity(LPM)")]
        public drpdownlist capacity { get; set; }
        public string capacityRes { get; set; }

       /* [Display(Name = "Pump")]
        public drpdownlist pump { get; set; }
        p0ublic string pumpRes { get; set; }*/


        [Display(Name = "Chiller Unit Required")]
        public drpdownlist chillerUnitRequired { get; set; }
        public string chillerUnitRequiredRes { get; set; }
        //public static class PeripheralSpeed
        //{
        //    [Display(Name = "Peripheral Speed (in MPS)")]
        //    public static string add = "0";
        //    public static IEnumerable<SelectListItem> items = new[]
        //        {
        //            new SelectListItem{Value="33",Text="33"},
        //            new SelectListItem{Value="45",Text="45"},
        //            new SelectListItem{Value="50",Text="50"},
        //            new SelectListItem{Value="60",Text="60"}
        //        };
        //}
        [Display(Name = "Chiller Unit Make")]
        public drpdownlist chillerUnitMake { get; set; }
        public string chillerUnitRes { get; set; }

        [Display(Name = "Chiller Flow(KCal/hr)")]
        public drpdownlist chillerFlow { get; set; }
        public string chillerFlowRes { get; set; }

        //Glass Scale
        [Display(Name = "Is glass scale on X axis")]
        public drpdownlist glassScaleOnXAxis { get; set; }
        public string glassScaleOnAxisRes { get; set; }

        [Display(Name = "Is glass scale on Z axis (in mm)")]
        public drpdownlist glassScaleOnZAxis { get; set; }
        public string glassSacleOnZAxisRes { get; set; }

        //Guaging System
        [Display(Name = "Make")]
        public drpdownlist gsMake { get; set; }

        public string gsMakeRes { get; set; }

        [Display(Name = "Daimeter")]
        public drpdownlist gsDaimeter { get; set; }

        public string dsDaimeterRes { get; set; }

        [Display(Name = "Machine")]
        public drpdownlist machine { get; set; }
        public string machineRes { get; set; }

        [Display(Name = "Slide Stroke(in mm)")]
        public drpdownlist gsSlideStroke { get; set; }
        public string gsSlideStrokeRes { get; set; }

        [Display(Name = "Amplifier")]
        public drpdownlist gsAmplier { get; set; }
        public string gsAmplifierRes { get; set; }
        [Display(Name = "Number of Gauges")]
        public drpdownlist noGauges { get; set; }
        public string noGaugesRes { get; set; }
        //[Display(Name = "Do you require any automation in handling components ?")]
        //public drpdownlist automation { get; set; }
        //public string automationRes { get; set; }
        //[Display(Name = "Upload attachment")]
        //  public String FileName { get; set; }
        //public String FilePath { get; set; }

        


    }
    
}