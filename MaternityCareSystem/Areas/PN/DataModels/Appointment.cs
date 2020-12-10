using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaternityCareSystem.Areas.PN.DataModels
{
    public partial class Appointment
    {
        public int AppointmentId { get; set; }
        public System.DateTime StartDateTime { get; set; }
        public string Detail { get; set; }
        public bool Status { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }

    }
}