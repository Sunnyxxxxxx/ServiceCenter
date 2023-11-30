using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCenter.model;

internal class Appointment
{
    public string Id { get; set; }
    public string Notes { get; set; }
    public DateTime dataTime { get; set; }
}
