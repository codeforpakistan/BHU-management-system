using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MaternityCareSystem.Areas.PN.DataModels
{
    public class Ultrasound
    {
        public int UltrasoundId { get; set; }
        public Nullable<int> PatientId { get; set; }
        public string PatientName { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0: dd-MM-yyyy}")]
        public Nullable<System.DateTime> Date { get; set; }
        [Required(ErrorMessage = "Last Menstrual Period is required")]
        public string LastMenstrualPeriod { get; set; }
        [DisplayFormat(DataFormatString = "{0: dd-MM-yyyy}")]
        public Nullable<System.DateTime> EDD { get; set; }
        public string EGA { get; set; }
        public string Placenta { get; set; }
        public string Grade { get; set; }
        public string Cord { get; set; }
        public string AmnioticFluidVolume { get; set; }
        public string AFI { get; set; }
        public string Gender { get; set; }
        public string NoOfFetuses { get; set; }
        public string Position { get; set; }
        public bool Breathing { get; set; }
        public bool Movement { get; set; }
        public string Face { get; set; }
        public string Brain { get; set; }
        public string Spine { get; set; }
        public string Lungs { get; set; }
        public bool HeartChamber { get; set; }
        public string HeartCondition { get; set; }
        public string HeartRate { get; set; }
        public string Stomach { get; set; }
        public string CordInsertion { get; set; }
        public string ExtLeftArms { get; set; }
        public string ExtRightArms { get; set; }
        public string ExtLeftLegs { get; set; }
        public string ExtRightLegs { get; set; }
        public string CRL { get; set; }
        public string CRLEGA { get; set; }
        public string FemurLength { get; set; }
        public string FemurLengthEGA { get; set; }
        public string BPD { get; set; }
        public string BPDEGA { get; set; }
        public string HeadCircumference { get; set; }
        public string HeadCircumferenceEGA { get; set; }
        public string AbdCircumference { get; set; }
        public string AbdEGA { get; set; }
        public string EFetalWeight { get; set; }
        public string ThirdFermurLength { get; set; }
        public string ThirdBPD { get; set; }
        public string ThirdEGA { get; set; }
        public string ThirdEstimatedFetalWeight { get; set; }
        public string Comments { get; set; }
    }
}