using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using WebApplication5.Models;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace WebApplication5.Controllers
{
    
    public class AccountController : Controller
    {
        public bool isLogin()
        {
            if (Session["id"]==null)
                return false;
            else
                return true;
        }
        public void logout()
        {
            Session["id"] = null;
        }
        public ActionResult Index()
        {
            if(!isLogin())
            {
                return Redirect("~");
            }
            return Redirect("~/Account/Machine_Selection");
        }
        public ActionResult Machine_Selection()
        {
            InputParameters ip = new InputParameters();
            ip.init();
            
            return View(ip);
        }

        
        public ActionResult Machine_Selection_Result()
        {
            MachineParametersContext mp = new MachineParametersContext();
            
            return Content("Here");
        }
        [HttpPost]
        public ActionResult Machine_Selection_Result(InputParameters ip)
        {
            MachineParametersContext mp = new MachineParametersContext();
            int stepOne = 0;
            if (ip.LenControl.Id == 1 || ip.FaceGrinding.Id == 1 || ip.RadGrinding.Id == 1)
                stepOne = 1;

            List<MachineResultModel> res = new List<MachineResultModel>();
            List<int> result;
            //result = mp.machine_param_values.Where((m => m.machine_param_names_id.Equals(1) && m.param_value.Equals(stepOne)) || (m.machine_param_names_id.Equals(2) && m.param_value.Equals(ip.idod.Id)) || (m => m.machine_param_names_id.Equals(1) && m.param_value.Equals(stepOne)))
            result = mp.machine_param_values.Where(m=>m.machine_param_names_id.Equals(1) && m.param_value.Equals(stepOne)).Select(m=>m.machines_id).ToList();
            result=result.Intersect(mp.machine_param_values.Where(m => m.machine_param_names_id.Equals(2) && m.param_value.Equals(ip.idod.Id)).Select(m => m.machines_id).ToList()).ToList();

            result = result.Intersect(mp.machine_param_values.Where(m=>m.machine_param_names_id.Equals(3) && m.param_value >= ip.MaxJobLen).Select(m => m.machines_id).ToList()).ToList();
            result = result.Intersect(mp.machine_param_values.Where(m => m.machine_param_names_id.Equals(4) && m.param_value.Equals(ip.PeripheralSpeed.Id)).Select(m => m.machines_id).ToList()).ToList();
            result = result.Intersect(mp.machine_param_values.Where(m => m.machine_param_names_id.Equals(5) && m.param_value >= ip.MaxWheelWidth).Select(m => m.machines_id).ToList()).ToList();
            result = result.Intersect(mp.machine_param_values.Where(m => m.machine_param_names_id.Equals(6) && m.param_value >= ip.MaxGrindingDia).Select(m => m.machines_id).ToList()).ToList();
            result = result.Intersect(mp.machine_param_values.Where(m => m.machine_param_names_id.Equals(7) && m.param_value >= ip.MaxCompDia).Select(m => m.machines_id).ToList()).ToList();
            //result = mp.machine_param_values.Where(m => m.id > 0 && (m.machine_param_names_id.Equals(2) && m.param_value == ip.idod.Id )).Select(m => m.machines_id).ToList();
            //result = result.Distinct().ToList();
            if (result.Contains(2)) { result = result.Except((new int[] { 3, 4, 9 }).ToList()).ToList(); }
            if (result.Contains(3)) { result = result.Except((new int[] { 4, 9 }).ToList()).ToList(); }
            if (result.Contains(5)) { result = result.Except((new int[] { 6, 7, 9 }).ToList()).ToList(); }
            if (result.Contains(6)) { result = result.Except((new int[] { 7, 9 }).ToList()).ToList(); }
            if (result.Contains(11)) { result = result.Except((new int[] { 12, 13, 9 }).ToList()).ToList(); }
            if (result.Contains(12)) { result = result.Except((new int[] { 13, 9 }).ToList()).ToList(); }
            String sample = "";
            int count = 0;
            foreach (var machine_id in result)
            {
                MachineResultModel mr = new MachineResultModel();
                mr.Id = machine_id;
                mr.MachineName = mp.machines.Where(m => m.id == machine_id).Select(m => m.name).First();
                mr.StraightorAngular = "Straight";
                if (stepOne == 1)
                    mr.StraightorAngular = "Angular";
                mr.PeripheralSpeed=mp.machine_param_values.Where(m => m.machines_id == machine_id && m.machine_param_names_id==4).Select(m => m.param_value).First().ToString();
                count++;
                sample += "<tr data-machine_id=\""+mr.Id+"\"><td> "+count.ToString()+" </td><td class=\"content_text\">"+mr.MachineName+"</td><td>"+mr.StraightorAngular+"</td><td class=\"content_text\">"+mr.PeripheralSpeed+"</td><td><button class=\"btn btn-mini btn-primary basic_machine_select_final_btn\" type=\"button\">Select</button></td></tr>";
                //.Add(mr);
            }


            //System.Runtime.Serialization.Json.DataContractJsonSerializer serializer = new System.Runtime.Serialization.Json.DataContractJsonSerializer(res.GetType());
            //MemoryStream ms = new MemoryStream();
            //serializer.WriteObject(ms, res);
            //String resultjson=Encoding.Default.GetString(ms.ToArray());
            return Content(sample,"text/html");

            
            
        }
        public ActionResult SecondSelection()
        {
            return View();
        }
    }
}