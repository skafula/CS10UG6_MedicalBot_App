using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Bot_App
{
    public class MedicalBot
    {
        const string botName = "Bob";

        public void PrescribeMedication(Patient patient)
        {
            switch (patient.GetSymptoms())
            {
                case "Headache":
                    string medicineName = "ibuprofen";
                    patient.SetPrescription(GetDosage(medicineName) + " " + medicineName);
                    break;
                case "Skin rashes":
                    medicineName = "diphenhydramine";
                    patient.SetPrescription(GetDosage(medicineName) + " " + medicineName);
                    break;
                case "Dizziness":
                    if (patient.GetMedicalHistory().Contains("diabetes"))
                    {
                        medicineName = "metformin";
                        patient.SetPrescription(GetDosage(medicineName) + " " + medicineName);
                        break;
                    }
                    else
                    {
                        medicineName = "dimenhydrinate";
                        patient.SetPrescription(GetDosage(medicineName) + " " + medicineName);
                        break;
                    }
            }
            string GetDosage(string medicineName)
            {
                int patientAge = patient.GetAge();
                switch (medicineName)
                {
                    case "ibuprofen":
                        if (patientAge < 18)
                        {
                            return "400mg";
                        }
                        else
                        {
                            return "800mg";
                        }
                    case "diphenhydramine":
                        if (patientAge < 18)
                        {
                            return "50mg";
                        }
                        else
                        {
                            return "300mg";
                        }
                    case "dimenhydrinate":
                        if (patient.GetAge() < 18)
                        {
                            return "50mg";
                        }
                        else
                        {
                            return "400mg";
                        }
                    default:
                        return "500mg";
                }
            }
        }

        public static string GetBotName()
        {
            return botName;
        }
    }
}
