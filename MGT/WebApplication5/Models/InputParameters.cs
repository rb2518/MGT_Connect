using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebApplication5.Models
{
    public class InputParameters
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
        public String CustomerName { get; set; }
        public String ComponentName { get; set; }
        [Display(Name ="Opp Id")]
        public String OppId { get; set; }

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
        [Display(Name = "Is there any length control required ?")]
        public drpdownlist LenControl { get; set; }
        public string LenControlRes { get; set; }

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
        [Display(Name = "Is there any face grinding required ?")]
        public drpdownlist FaceGrinding { get; set; }
        public string FaceGrindingRes { get; set; }
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
        [Display(Name = "Is there any radius grinding required ?")]
        public drpdownlist RadGrinding { get; set; }
        public string RadGrindingRes { get; set; }
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
        [Display(Name = "ID/OD")]
        public drpdownlist idod { get; set; }
        public string idodRes { get; set; }



        [Display(Name = "Max Job Length (in mm)")]
        public int MaxJobLen { get; set; }
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
        [Display(Name = "Peripheral Speed (in MPS)")]
        public drpdownlist PeripheralSpeed { get; set; }
        public string PeripheralSpeedRes { get; set; }


        [Display(Name = "Max Wheel Width (in mm)")]
        public int MaxWheelWidth { get; set; }
        [Display(Name = "Max Grinding Diameter (in mm)")]
        public int MaxGrindingDia { get; set; }
        [Display(Name = "Max Component Dia (in mm)")]
        public int MaxCompDia { get; set; }
        [Display(Name = "Max Job Weight (in kg)")]
        public int MaxJobWeight { get; set; }
        [Display(Name = "Minimum tolerance of ground diameter(in micron)")]
        public int Mintol { get; set; }
        [Display(Name = "Roughness required(Ra)")]
        public int Roughness { get; set; }
        [Display(Name = "What is the maximum length variation ? (in mm)")]
        public int MaxLenVar { get; set; }
        [Display(Name = "Do you require any automation in handling components ?")]
        public drpdownlist automation { get; set; }
        public string automationRes { get; set; }
        [Display(Name = "Upload attachment")]
        public String FileName { get; set; }
        public String  FilePath { get; set; }
        
        public void init()
        {
            SelectListItem[] yn = new SelectListItem[2];
            SelectListItem yes = new SelectListItem
            {
                Text = "YES",
                Value = "1"
            };
            SelectListItem no = new SelectListItem
            {
                Text = "NO",
                Value = "0"
            };
            SelectListItem[] idods = { new SelectListItem { Text="ID",Value="0"},new SelectListItem { Text="OD",Value="1"} };
            SelectListItem[] peripheralspeeds = { new SelectListItem { Text = "33", Value = "33" }, new SelectListItem { Text = "45", Value = "45" }, new SelectListItem { Text = "50", Value = "50" }, new SelectListItem { Text = "60", Value = "60" } };
            
            yn[0] = yes;
            yn[1] = no;
            this.LenControl = new drpdownlist();
            this.LenControl.items = new SelectList(yn, "Value", "Text", "NO");
            //this.LenControl.Id = "LenControlRes";
            this.FaceGrinding = new drpdownlist();
            this.FaceGrinding.items = new SelectList(yn, "Value", "Text", "NO");
            //this.FaceGrinding.Id = "FaceGrindingRes";
            this.RadGrinding = new drpdownlist();
            this.RadGrinding.items = new SelectList(yn, "Value", "Text", "NO");
            //this.RadGrinding.Id = "RadGrindingRes";
            this.automation = new drpdownlist();
            this.automation.items = new SelectList(yn, "Value", "Text", "NO");
            //this.automation.Id = "automationRes";
            this.idod = new drpdownlist();
            this.idod.items = new SelectList(idods, "Value", "Text", "ID");
            //this.idod.Id = "idodRes";
            this.PeripheralSpeed = new drpdownlist();
            this.PeripheralSpeed.items = new SelectList(peripheralspeeds, "Value", "Text", "33");
            //this.PeripheralSpeed.Id = "PeripheralSpeedRes";
            
        }
        

    }
    public class drpdownlist
    {
        public int Id { get; set; }
        public SelectList items { get; set; }
    }
}
