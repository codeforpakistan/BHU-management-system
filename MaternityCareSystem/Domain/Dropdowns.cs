using MaternityCareSystem.Areas.PN.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaternityCareSystem.Domain
{
    public class Dropdowns
    {
        public static List<SelectListItem> Genders
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                    new SelectListItem(){Value="Male",Text="Male"},
                    new SelectListItem(){ Value="Female",Text="Female"}
                    ,new SelectListItem(){ Value="Other",Text="Other"}
                };
                return _lst;
            }
        }
        public static List<SelectListItem> Relation
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){ Value="Father",Text="Father"}
                    ,new SelectListItem(){ Value="Mother",Text="Mother"}
                    ,new SelectListItem(){ Value="Husband",Text="Husband"}
                    ,new SelectListItem(){ Value="Wife",Text="Wife"}
                    ,new SelectListItem(){ Value="Sibling",Text="Sibling"}
                    ,new SelectListItem(){ Value="Self",Text="Self"}
                    ,new SelectListItem(){ Value="Other",Text="Other"}

                };
                return _lst;
            }
        }
        public static List<SelectListItem> Appearance
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){Value="Pale",Text="Pale"}
                    ,new SelectListItem(){ Value="Joundice",Text="Joundice"}
                    ,new SelectListItem(){ Value="Normal",Text="Normal"}
                    ,new SelectListItem(){ Value="Strong",Text="Strong"}
                    ,new SelectListItem(){ Value="Weak",Text="Weak"}

                };
                return _lst;
            }
        }
        public static List<SelectListItem> Lungs
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){Value="Clear",Text="Clear"}
                    ,new SelectListItem(){ Value="Rhonchi",Text="Rhonchi"}
                    ,new SelectListItem(){ Value="Rattles",Text="Rattles"}
                    ,new SelectListItem(){ Value="Wheezes",Text="Wheezes"}
                    ,new SelectListItem(){ Value="Weak",Text="Weak"}

                };
                return _lst;
            }
        }
        public static List<SelectListItem> LungsRespiration
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){Value="Normal",Text="Normal"}
                    ,new SelectListItem(){ Value="Abnormal",Text="Abnormal"}


                };
                return _lst;
            }
        }
        public static List<SelectListItem> MurmurRate
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){ Value="Grade 1",Text="Grade 1"}
                    ,new SelectListItem(){ Value="Grade 2",Text="Grade 2"}
                    ,new SelectListItem(){ Value="Grade 3",Text="Grade 3"}
                    ,new SelectListItem(){ Value="Grade 4",Text="Grade 4"}
                    ,new SelectListItem(){ Value="LSB",Text="LSB"}
                    ,new SelectListItem(){ Value="RSB",Text="RSB"}
                    ,new SelectListItem(){ Value="Apex",Text="Apex"}


                };
                return _lst;
            }
        }
        public static List<SelectListItem> Mass
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){Value="RUQ",Text="RUQ"}
                    ,new SelectListItem(){Value="LUQ",Text="LUQ"}
                    ,new SelectListItem(){Value="RLQ",Text="RLQ"}
                    ,new SelectListItem(){Value="LLQ",Text="LLQ"}
                };
                return _lst;
            }
        }
        public static List<SelectListItem> LungsGynae
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){Value="Clear",Text="Clear"}
                    ,new SelectListItem(){ Value="Abnormal",Text="Abnormal"}
                    ,new SelectListItem(){ Value="Inc RR",Text="Inc RR"}
                    ,new SelectListItem(){ Value="Dec Breath Sounds",Text="Dec Breath Sounds"}

                };
                return _lst;
            }
        }
        public static List<SelectListItem> Abdomen
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){Value="Soft",Text="Soft"}
                    ,new SelectListItem(){ Value="Rigid",Text="Rigid"}
                    ,new SelectListItem(){ Value="Tender",Text="Tender"}
                    ,new SelectListItem(){ Value="Non Tender",Text="Non Tender"}
                    ,new SelectListItem(){ Value="BS+",Text="BS+"}
                    ,new SelectListItem(){ Value="BS-",Text="BS-"}

                };
                return _lst;
            }
        }
        public static List<SelectListItem> Hernia
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){Value="Reducible",Text="Reducible"}
                    ,new SelectListItem(){ Value="Non Reducible",Text="Non Reducible"}
                   

                };
                return _lst;
            }
        }
        public static List<SelectListItem> BloodGroup
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){Value="A+",Text="A+"}
                    ,new SelectListItem(){ Value="A-",Text="A-"}
                    ,new SelectListItem(){ Value="B+",Text="B+"}
                    ,new SelectListItem(){ Value="B-",Text="B-"}
                    ,new SelectListItem(){ Value="O+",Text="O+"}
                    ,new SelectListItem(){ Value="O-",Text="O-"}
                     ,new SelectListItem(){ Value="AB+",Text="AB+"}
                    ,new SelectListItem(){ Value="AB-",Text="AB-"}

                };
                return _lst;
            }
        }
        public static List<SelectListItem> Protien
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){ Value="Nill",Text="Nill"}
                    ,new SelectListItem(){Value="Protien",Text="Protien"}
                    ,new SelectListItem(){ Value="TRACE",Text="TRACE"}
                    ,new SelectListItem(){ Value="+",Text="+"}
                    ,new SelectListItem(){ Value="++",Text="++"}
                    ,new SelectListItem(){ Value="+++",Text="++"}
                    ,new SelectListItem(){ Value="++++",Text="++++"}

                };
                return _lst;
            }
        }
        public static List<SelectListItem> Glucose
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){ Value="Nill",Text="Nill"}
                    ,new SelectListItem(){Value="Glucose",Text="Glucose"}
                    ,new SelectListItem(){ Value="TRACE",Text="TRACE"}
                    ,new SelectListItem(){ Value="+",Text="+"}
                    ,new SelectListItem(){ Value="++",Text="++"}
                    ,new SelectListItem(){ Value="+++",Text="++"}
                    ,new SelectListItem(){ Value="++++",Text="++++"}

                };
                return _lst;
            }
        }
        public static List<SelectListItem> WBC
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){ Value="Nill",Text="Nill"}
                    ,new SelectListItem(){Value="WBC",Text="WBC"}
                    ,new SelectListItem(){ Value="TRACE",Text="TRACE"}
                    ,new SelectListItem(){ Value="Small",Text="Small"}
                    ,new SelectListItem(){ Value="Moderate",Text="Moderate"}
                    ,new SelectListItem(){ Value="Large",Text="Large"}

                };
                return _lst;
            }
        }
        public static List<SelectListItem> Keytone
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){ Value="Nill",Text="Nill"}
                    ,new SelectListItem(){Value="Ketone",Text="Ketone"}
                    ,new SelectListItem(){ Value="TRACE",Text="TRACE"}
                    ,new SelectListItem(){ Value="Small",Text="Small"}
                    ,new SelectListItem(){ Value="Moderate",Text="Moderate"}
                    ,new SelectListItem(){ Value="Large",Text="Large"}
                    ,new SelectListItem(){ Value="Large+",Text="Large+"}

                };
                return _lst;
            }
        }
        public static List<SelectListItem> Blood
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){ Value="Nill",Text="Nill"}
                    ,new SelectListItem(){Value="Blood",Text="Blood"}
                    ,new SelectListItem(){ Value="TRACE",Text="TRACE"}
                    ,new SelectListItem(){ Value="Small",Text="Small"}
                    ,new SelectListItem(){ Value="Moderate",Text="Moderate"}
                    ,new SelectListItem(){ Value="Large",Text="Large"}


                };
                return _lst;
            }
        }
        public static List<SelectListItem> DeliveryCondition
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){Value="Normal",Text="Normal"}
                    ,new SelectListItem(){ Value="Abnormal",Text="Abnormal"}
                    ,new SelectListItem(){ Value="SVD",Text="SVD"}
                    ,new SelectListItem(){ Value="C-Section",Text="C-Section"}
                };
                return _lst;
            }
        }
        public static List<SelectListItem> DeliveryTerm
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){Value="Term",Text="Term"}
                    ,new SelectListItem(){ Value="Preterm",Text="Preterm"}
                    ,new SelectListItem(){ Value="Posterm",Text="Posterm"}
                   
                };
                return _lst;
            }
        }
        public static List<SelectListItem> InfantCondition
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){Value="Normal",Text="Normal"}
                    ,new SelectListItem(){ Value="Abnormal",Text="Abnormal"}
                    ,new SelectListItem(){ Value="Other",Text="Other"}
                };
                return _lst;
            }
        }
        public static List<SelectListItem> Feeding
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){ Value="Feeding",Text="Feeding"}
                    ,new SelectListItem(){ Value="Not Feeding Well",Text="Not Feeding Well"}
                };
                return _lst;
            }
        }
        public static List<SelectListItem> Head
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){ Value="Normal",Text="Normal"}
                    ,new SelectListItem(){ Value="Abnormal",Text="Abnormal"}
                };
                return _lst;
            }
        }
        public static List<SelectListItem> AntFontanelle
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){ Value="Bulging",Text="Bulging"}
                     ,new SelectListItem(){ Value="Soft",Text="Soft"}
                     ,new SelectListItem(){ Value="Open",Text="Open"}
                     ,new SelectListItem(){ Value="Closed",Text="Close"}
                };
                return _lst;
            }
        }
        public static List<SelectListItem> PostFontanelle
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {

                      new SelectListItem(){ Value="Open",Text="Open"}
                     ,new SelectListItem(){ Value="Closed",Text="Closed"}
                  
                };
                return _lst;
            }
        }
        public static List<SelectListItem> Satures
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){ Value="Normal",Text="Normal"}
                     ,new SelectListItem(){ Value="Wide",Text="Wide"}
                     ,new SelectListItem(){ Value="Overlapping",Text="Overlapping"}
                };
                return _lst;
            }
        }
        public static List<SelectListItem> EyePupil
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){ Value="Reactive",Text="Reactive"}
                     ,new SelectListItem(){ Value="Non Reactive",Text="Non Reactive"}
                     ,new SelectListItem(){ Value="Equal",Text="Equal"}
                     ,new SelectListItem(){ Value="Unequal",Text="Unequal"}
                };
                return _lst;
            }
        }
        public static List<SelectListItem> EyeSclera
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){ Value="Clear",Text="Clear"}
                     ,new SelectListItem(){ Value="iCteric",Text="iCteric"}
                     ,new SelectListItem(){ Value="White",Text="White"}
                     ,new SelectListItem(){ Value="Red",Text="Red"}
                };
                return _lst;
            }
        }
        public static List<SelectListItem> Conjuctiva
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){ Value="Normal",Text="Normal"}
                     ,new SelectListItem(){ Value="Red",Text="Red"}

                };
                return _lst;
            }
        }
        public static List<SelectListItem> EyeDischargeLeft
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){ Value="White",Text="White"}
                     ,new SelectListItem(){ Value="Purulent",Text="Purulent"}
                     ,new SelectListItem(){ Value="Other",Text="Other"}

                };
                return _lst;
            }
        }
        public static List<SelectListItem> EyeDischargeRight
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){ Value="White",Text="White"}
                     ,new SelectListItem(){ Value="Purulent",Text="Purulent"}
                     ,new SelectListItem(){ Value="Other",Text="Other"}

                };
                return _lst;
            }
        }
        public static List<SelectListItem> Neck
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){ Value="Normal",Text="Normal"}
                     ,new SelectListItem(){ Value="Abnormal",Text="Abnormal"}

                };
                return _lst;
            }
        }
        public static List<SelectListItem> LymphNode
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){ Value="1+",Text="1+"}
                     ,new SelectListItem(){ Value="2+",Text="2+"}
                     ,new SelectListItem(){ Value="2+",Text="3+"}
                     ,new SelectListItem(){ Value="4+",Text="4+"}

                };
                return _lst;
            }
        }
        public static List<SelectListItem> NeckLeft
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){ Value="Firm",Text="Firm"}
                     ,new SelectListItem(){ Value="Tender",Text="Tender"}
                     ,new SelectListItem(){ Value="Non Tender",Text="Non Tender"}
                     ,new SelectListItem(){ Value="Mobile",Text="Mobile"}
                     ,new SelectListItem(){ Value="Non Mobile",Text="Non Mobile"}
                     ,new SelectListItem(){ Value="Other",Text="Other"}

                };
                return _lst;
            }
        }
        public static List<SelectListItem> NeckRight
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){ Value="Firm",Text="Firm"}
                     ,new SelectListItem(){ Value="Tender",Text="Tender"}
                     ,new SelectListItem(){ Value="Non Tender",Text="Non Tender"}
                     ,new SelectListItem(){ Value="Mobile",Text="Mobile"}
                     ,new SelectListItem(){ Value="Non Mobile",Text="Non Mobile"}
                     ,new SelectListItem(){ Value="Other",Text="Other"}

                };
                return _lst;
            }
        }
        public static List<SelectListItem> WoundDischarge
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){ Value="No Discharge",Text="No Discharge"}
                     ,new SelectListItem(){ Value="Discharge Serous",Text="Discharge Serous"}
                     ,new SelectListItem(){ Value="Discharge Bloody",Text="Discharge Bloody"}
                     ,new SelectListItem(){ Value="Discharge Purulent",Text="Discharge Purulent"}
                     ,new SelectListItem(){ Value="Other",Text="Other"}

                };
                return _lst;
            }
        }
        public static List<SelectListItem> Suck
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){ Value="Normal",Text="Normal"}
                     ,new SelectListItem(){ Value="Abnormal",Text="Abnormal"}
                };
                return _lst;
            }
        }
        public static List<SelectListItem> Mouth
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){ Value="Normal",Text="Normal"}
                     ,new SelectListItem(){ Value="Cleft Clip",Text="Cleft Clip"}
                     ,new SelectListItem(){ Value="Cleft Palate",Text="Cleft Palate"}
                     ,new SelectListItem(){ Value="Thrush",Text="Thrush"}
                     ,new SelectListItem(){ Value="Moucus",Text="Moucus"}
              
                };
                return _lst;
            }
        }
        public static List<SelectListItem> MouthGums
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){ Value="Red",Text="Red"}
                     ,new SelectListItem(){ Value="White",Text="White"}
                     ,new SelectListItem(){ Value="Infected",Text="Infected"}
                };
                return _lst;
            }
        }
        public static List<SelectListItem> Throat
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){ Value="Pharynx",Text="Pharynx"}
                     ,new SelectListItem(){ Value="Normal",Text="Normal"}
                     ,new SelectListItem(){ Value="Erythema",Text="Erythema"}
                     ,new SelectListItem(){ Value="Purulent Discharge",Text="Purulent Discharge"}
                    

                };
                return _lst;
            }
        }
        public static List<SelectListItem> Nose
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){Value="Normal",Text="Normal"}
                     ,new SelectListItem(){Value="Clear",Text="Clear"}
                     ,new SelectListItem(){Value="Obstruction",Text="Obstruction"}

                };
                return _lst;
            }
        }
        public static List<SelectListItem> NoseDischarge
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){Value="Serous",Text="Serous"}
                     ,new SelectListItem(){Value="Mucous",Text="Mucous"}
                     ,new SelectListItem(){Value="Purulent",Text="Purulent"}
                     //,new SelectListItem(){Value="Other",Text="Other"}

                };
                return _lst;
            }
        }
        public static List<SelectListItem> EarPene
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){Value="Normal",Text="Normal"}
                     ,new SelectListItem(){Value="Abnormal",Text="Abnormal"}
                };
                return _lst;
            }
        }
        public static List<SelectListItem> EarCanal
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){Value="Normal",Text="Normal"}
                     ,new SelectListItem(){Value="Inflamed",Text="Inflamed"}
                };
                return _lst;
            }
        }
        public static List<SelectListItem> EarDischarge
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){Value="Clear",Text="Clear"}
                    ,new SelectListItem(){Value="Purulent",Text="Purulent"}
                    ,new SelectListItem(){Value="Other",Text="Other"}
                };
                return _lst;
            }
        }
        public static List<SelectListItem> DischargeType
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){Value="Clear",Text="Clear"}
                    ,new SelectListItem(){Value="Bloody",Text="Bloody"}
                    ,new SelectListItem(){Value="Purulent",Text="Purulent"}
                };
                return _lst;
            }
        }
        public static List<SelectListItem> UrinationDifficulty
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){Value="Burning",Text="Burning"}
                    ,new SelectListItem(){Value="Unable to Urinate",Text="Unable to Urinate"}
                    ,new SelectListItem(){Value="Frequency",Text="Frequency"}
                    ,new SelectListItem(){Value="Urgency",Text="Urgency"}
                };
                return _lst;
            }
        }
        public static List<SelectListItem> PainAbdomen
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){Value="Abdomen",Text="Abdomen"}
                    ,new SelectListItem(){Value="Genital",Text="Genital"}
                    ,new SelectListItem(){Value="Breast",Text="Breast"}
                };
                return _lst;
            }
        }
        public static List<SelectListItem> Uterus
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){Value="NL",Text="NL"}
                    ,new SelectListItem(){Value="enlarged",Text="enlarged"}
                    ,new SelectListItem(){Value="Mass",Text="Mass"}
                    ,new SelectListItem(){Value="nodule",Text="nodule"}
                };
                return _lst;
            }
        }
        public static List<SelectListItem> Heent
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){Value="Normal",Text="Normal"}
                    ,new SelectListItem(){Value="Abnormal",Text="Abnormal"}
                    ,new SelectListItem(){Value="Other",Text="Other"}
                };
                return _lst;
            }
        }
        public static List<SelectListItem> Thyroid
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){Value="Palpable",Text="Normal"}
                    ,new SelectListItem(){Value="Not Palpable",Text="Abnormal"}
                    ,new SelectListItem(){Value="Mass",Text="Mass"}
                    ,new SelectListItem(){Value="No Mass",Text="No Mass"}
                };
                return _lst;
            }
        }
        public static List<SelectListItem> AdnexaLeft
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){Value="Tender",Text="Normal"}
                    ,new SelectListItem(){Value="No Tender",Text="Abnormal"}
                };
                return _lst;
            }
        }
        public static List<SelectListItem> AdnexaRight
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){Value="Tender",Text="Normal"}
                    ,new SelectListItem(){Value="No Tender",Text="Abnormal"}
                };
                return _lst;
            }
        }
        public static List<SelectListItem> Tender
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){Value="RUQ",Text="RUQ"}
                    ,new SelectListItem(){Value="LUQ",Text="LUQ"}
                    ,new SelectListItem(){Value="RLQ",Text="RLQ"}
                    ,new SelectListItem(){Value="LLQ",Text="LLQ"}
                    ,new SelectListItem(){Value="Firm",Text="Firm"}
                    ,new SelectListItem(){Value="Rigid",Text="Rigid"}
                };
                return _lst;
            }
        }
        public static List<SelectListItem> MassQuality
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){Value="Firm",Text="Firm"}
                    ,new SelectListItem(){Value="Tender",Text="Tender"}
                    ,new SelectListItem(){Value="No Tender",Text="No Tende"}
                    ,new SelectListItem(){Value="Mobile",Text="Mobile"}
                    ,new SelectListItem(){Value="Non Mobile",Text="Non Mobile"}
                    ,new SelectListItem(){Value="Other",Text="Other"}
                };
                return _lst;
            }
        }
        public static List<SelectListItem> HeartRate
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){Value="Normal",Text="Normal"}
                    ,new SelectListItem(){Value="Increased",Text="Increased"}
                    ,new SelectListItem(){Value="Decreased",Text="Decreased"}
                };
                return _lst;
            }
        }
        public static List<SelectListItem> HeartPedal
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){Value="Normal",Text="Normal"}
                    ,new SelectListItem(){Value="Abnormal",Text="Abnormal"}
                   
                };
                return _lst;
            }
        }
        public static List<SelectListItem> HeartRythm
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){Value="Regular",Text="Regular"}
                    ,new SelectListItem(){Value="Irregular",Text="Irregular"}
                };
                return _lst;
            }
        }
        public static List<SelectListItem> Tonsils
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){Value="Normal",Text="Normal"}
                    ,new SelectListItem(){Value="enlarged-1+",Text="enlarged-1+"}
                    ,new SelectListItem(){Value="enlarged-2+",Text="enlarged-2+"}
                    ,new SelectListItem(){Value="enlarged-3+",Text="enlarged-3+"}
                    ,new SelectListItem(){Value="enlarged-4+",Text="enlarged-4+"}
                    ,new SelectListItem(){Value="Obstruction",Text="Obstruction"}
                };
                return _lst;
            }
        }
        public static List<SelectListItem> CheckupOf
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){Value="Mother",Text="Mother"}
                    ,new SelectListItem(){Value="Gynae",Text="Gynae"}
                    ,new SelectListItem(){Value="Infant",Text="Infant"}
                    ,new SelectListItem(){Value="Paeds",Text="Paeds"}
                };
                return _lst;
            }
        }
        public static List<SelectListItem> VaginalExamination
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){Value="No Discharge",Text="No Discharge"}
                     ,new SelectListItem(){Value="Yellow Discharge",Text="Yellow Discharge"}
                     ,new SelectListItem(){Value="White Discharge",Text="White Discharge"}
                     ,new SelectListItem(){Value="Green Discharge",Text="Green Discharge"}
                     ,new SelectListItem(){Value="Mass",Text="Mass"}
                     ,new SelectListItem(){Value="Bleeding",Text="Bleeding"}
                     ,new SelectListItem(){Value="Other",Text="Other"}

                };
                return _lst;
            }
        }
        public static List<SelectListItem> VisitNumber
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){Value="<12 Weeks",Text="<12 Weeks"}
                     ,new SelectListItem(){Value="20 Weeks",Text="20 Weeks"}
                     ,new SelectListItem(){Value="26 Weeks",Text="26 Weeks"}
                     ,new SelectListItem(){Value="30 weeks",Text="30 weeks"}
                     ,new SelectListItem(){Value="34 Weeks",Text="34 weeks"}
                     ,new SelectListItem(){Value="36 weeks",Text="36 weeks"}
                     ,new SelectListItem(){Value="38 weeks",Text="38 weeks"}
                     ,new SelectListItem(){Value="40 weeks",Text="40 weeks"}

                };
                return _lst;
            }
        }
        public static List<SelectListItem> TMDischarge
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){Value="Clear",Text="Clear"}
                    ,new SelectListItem(){Value="Purulent",Text="Purulent"}
                    ,new SelectListItem(){Value="None",Text="None"}
                };
                return _lst;
            }
        }
        public static List<SelectListItem> BreastDischarge
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){Value="Discharge Milk",Text="Discharge Milk"}
                    ,new SelectListItem(){Value="Pus",Text="Pus"}
                    ,new SelectListItem(){Value="Purulent",Text="Purulent"}
                };
                return _lst;
            }
        }
        public static List<SelectListItem> FetalPosition
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                     new SelectListItem(){Value="Vertex",Text="Vertex"}
                    ,new SelectListItem(){Value="Breach",Text="Breach"}
                    ,new SelectListItem(){Value="Traverse",Text="Traverse"}
                };
                return _lst;
            }
        }
        public static List<SelectListItem> Edema
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){Value="None",Text="None"}
                     ,new SelectListItem(){Value="1+",Text="1+"}
                     ,new SelectListItem(){Value="2+",Text="2+"}
                     ,new SelectListItem(){Value="3+",Text="3+"}
                     ,new SelectListItem(){Value="4+",Text="4+"}
                   

                };
                return _lst;
            }
        }
        public static List<SelectListItem> FundalHeight
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){Value="AGA",Text="AGA"}
                     ,new SelectListItem(){Value="SGA",Text="SGA"}
                     ,new SelectListItem(){Value="LGA",Text="LGA"}


                };
                return _lst;
            }
        }
        public static List<SelectListItem> LeftRight
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){Value="Left",Text="Left"}
                     ,new SelectListItem(){Value="Right",Text="Right"}
                     ,new SelectListItem(){Value="Both",Text="Both"}


                };
                return _lst;
            }
        }
       
        #region Ultrasound
        public static List<SelectListItem> Placenta
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){Value="Ant",Text="Ant"}
                     ,new SelectListItem(){Value="Post",Text="Post"}
                     ,new SelectListItem(){Value="Fundal",Text="Fundal"}
                     ,new SelectListItem(){Value="Previa",Text="Previa"}
                     ,new SelectListItem(){Value="Low Lying",Text="Low Lying"}


                };
                return _lst;
            }
        }
        public static List<SelectListItem> Grade
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){Value="0",Text="0"}
                     ,new SelectListItem(){Value="1",Text="1"}
                     ,new SelectListItem(){Value="2",Text="2"}
                     ,new SelectListItem(){Value="3",Text="3"}
                };
                return _lst;
            }
        }
        public static List<SelectListItem> Cord
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){Value="2 Vessel",Text="2 Vessel"}
                     ,new SelectListItem(){Value="3 Vessel",Text="3 Vessel"}
                };
                return _lst;
            }
        }
        public static List<SelectListItem> AmnioticFluidVolume
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){Value="Normal",Text="Normal"}
                     ,new SelectListItem(){Value="High Normal",Text="High Normal"}
                     ,new SelectListItem(){Value="Increased",Text="Increased"}
                     ,new SelectListItem(){Value="Decreased",Text="Decreased"}
                };
                return _lst;
            }
        }

        public static List<SelectListItem> NoOfFetuses
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){Value="0",Text="0"}
                     ,new SelectListItem(){Value="1",Text="1"}
                     ,new SelectListItem(){Value="2",Text="2"}
                     ,new SelectListItem(){Value="3",Text="3"}
                     ,new SelectListItem(){Value="4",Text="4"}
                     ,new SelectListItem(){Value="5",Text="5"}
                };
                return _lst;
            }
        }

        public static List<SelectListItem> LungsU
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){Value="Normal",Text="Normal"}
                     ,new SelectListItem(){Value="Abnormal",Text="Abnormal"}
                    
                };
                return _lst;
            }
        }
        public static List<SelectListItem> Position
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){Value="Cephalic",Text="Cephalic"}
                     ,new SelectListItem(){Value="Breech",Text="Breech"}
                     ,new SelectListItem(){Value="Transverse",Text="Transverse"}
                     ,new SelectListItem(){Value="Variable",Text="Variable"}

                };
                return _lst;
            }
        }
        public static List<SelectListItem> FBS
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){Value="Normal",Text="Normal"}
                     ,new SelectListItem(){Value="Abnormal",Text="Abnormal"}
                     ,new SelectListItem(){Value="Not Seen",Text="Not Seen"}

                };
                return _lst;
            }
        }
        #endregion
        #region Umbilicus
        public static List<SelectListItem> UmbClean
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){Value="Clean",Text="Clean"}
                     ,new SelectListItem(){Value="Dry",Text="Dry"}
                     ,new SelectListItem(){Value="No Discharge",Text="No Discharge"}

                };
                return _lst;
            }
        }
        public static List<SelectListItem> UmbDischarge
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){Value="White",Text="White"}
                     ,new SelectListItem(){Value="Red",Text="Red"}
                     ,new SelectListItem(){Value="Purulent",Text="Purulent"}
                     ,new SelectListItem(){Value="Foul Smelling",Text="Foul Smelling"}
                     ,new SelectListItem(){Value="Blood",Text="Blood"}


                };
                return _lst;
            }
        }
        #endregion
        #region Gent
        public static List<SelectListItem> NormalAbnormal
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){Value="Normal",Text="Normal"}
                     ,new SelectListItem(){Value="Abnormal",Text="Abnormal"}
                    

                };
                return _lst;
            }
        }
        public static List<SelectListItem> GentPenie
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){Value="Normal",Text="Normal"}
                     ,new SelectListItem(){Value="Abnormal",Text="Abnormal"}
                     ,new SelectListItem(){Value="Circumsized",Text="Circumsized"}
                     ,new SelectListItem(){Value="Not Circumsized",Text="Not Circumsized"}


                };
                return _lst;
            }
        }
        public static List<SelectListItem> GentDischarge
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){Value="White",Text="White"}
                     ,new SelectListItem(){Value="Red",Text="Red"}
                     ,new SelectListItem(){Value="Purulent",Text="Purulent"}


                };
                return _lst;
            }
        }
        public static List<SelectListItem> GentDischargeFemale
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){Value="White",Text="White"}
                     ,new SelectListItem(){Value="Red",Text="Red"}
                     ,new SelectListItem(){Value="Purulent",Text="Purulent"}
                     ,new SelectListItem(){Value="Foul Smelling",Text="Foul Smelling"}


                };
                return _lst;
            }
        }
        public static List<SelectListItem> GentLabia
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){Value="Swollen",Text="Swollen"}
                     ,new SelectListItem(){Value="Red",Text="Red"}
                     ,new SelectListItem(){Value="Inflammed",Text="Inflammed"}
                     ,new SelectListItem(){Value="Fused",Text="Fused"}


                };
                return _lst;
            }
        }
        public static List<SelectListItem> GentUrethra
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){Value="Normal",Text="Normal"}
                     ,new SelectListItem(){Value="Inflammed",Text="Inflammed"}
                };
                return _lst;
            }
        }
        public static List<SelectListItem> GentMass
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){Value="Left",Text="Left"}
                     ,new SelectListItem(){Value="Right",Text="Right"}
                     ,new SelectListItem(){Value="Firm",Text="Firm"}
                     ,new SelectListItem(){Value="Tender",Text="Tender"}
                     ,new SelectListItem(){Value="Mobile",Text="Mobile"}
                };
                return _lst;
            }
        }
        public static List<SelectListItem> GentMale
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){Value="Normal Testies",Text="Normal Testies"}
                     ,new SelectListItem(){Value="Abnormal Testies",Text="Abnormal Testies"}
                     
                };
                return _lst;
            }
        }
        #endregion
        #region Musc
        public static List<SelectListItem> MuscSymmetry
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){Value="Symmetry",Text="Symmetry"}
                     ,new SelectListItem(){Value="Asymmetry",Text="Asymmetry"}
                };
                return _lst;
            }
        }
        public static List<SelectListItem> NeuroReflex
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){Value="Left Normal",Text="Left Normal"}
                     ,new SelectListItem(){Value="Right Abnormal",Text="Right Abnormal"}
                };
                return _lst;
            }
        }
        public static List<SelectListItem> Hip
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){Value="Click",Text="Click"}
                     ,new SelectListItem(){Value="Clunk",Text="Clunk"}
                     ,new SelectListItem(){Value="Decrease Mobility",Text="Decrease Mobility"}
                     ,new SelectListItem(){Value="Dysplasia",Text="Dysplasia"}
                };
                return _lst;
            }
        }
        public static List<SelectListItem> Skin
        {
            get
            {
                List<SelectListItem> _lst = new List<SelectListItem>() {
                      new SelectListItem(){Value="Normal",Text="Normal"}
                     ,new SelectListItem(){Value="Pale",Text="Pale"}
                     ,new SelectListItem(){Value="Joundice",Text="Joundice"}
                     ,new SelectListItem(){Value="Bruise",Text="Bruise"}
                };
                return _lst;
            }
        }
        #endregion

        public static List<SelectListItem> PatientDropDown
        {
            get
            {
                var lst = new List<SelectListItem>();
                OutParamModel model = new OutParamModel();
                using (var pt = new StepOneBL())
                {
                    lst = (from p in pt.PtDropDown(out model) select new SelectListItem() { Value = p.PatientId.ToString(), Text = p.PatientName }).ToList();
                }
                return lst;
            }
        }
        public static List<SelectListItem> SpecializaionDDL
        {
            get
            {
                var lst = new List<SelectListItem>();
                OutParamModel model = new OutParamModel();
                using (var pt = new SpecBL())
                {
                    lst = (from p in pt.SpecDDL(out model) select new SelectListItem() { Value = p.SpecializationId.ToString(), Text = p.Name }).ToList();
                }
                return lst;
            }
        }
        //public static List<SelectListItem> VisitsDropDown
        //{
        //    get
        //    {
        //        var lst = new List<SelectListItem>();
        //        OutParamModel model = new OutParamModel();
        //        using (var pt = new PhysicalExamBL())
        //        {
        //            lst = (from p in pt.VisitDropDown(out model) select new SelectListItem() { Value = p.PreNatalVisitId.ToString(), Text = p.VisitTitle }).ToList();
        //        }
        //        return lst;
        //    }
        //}
        //public static List<SelectListItem> CheckupDropDown
        //{
        //    get
        //    {
        //        var lst = new List<SelectListItem>();
        //        OutParamModel model = new OutParamModel();
        //        using (var pt = new PhysicalExamBL())
        //        {
        //            lst = (from p in pt.CheckupOfDropDown(out model) select new SelectListItem() { Value = p.PatientCheckUpId.ToString(), Text = p.CheckupTitle }).ToList();
        //        }
        //        return lst;
        //    }
        //}
    }
}