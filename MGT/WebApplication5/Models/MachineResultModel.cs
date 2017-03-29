using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class MachineResultModel
    {
        public int Id { get; set; }
        public string MachineName { get; set; }
        public string StraightorAngular { get; set; }
        public string PeripheralSpeed { get; set; }
    }
}