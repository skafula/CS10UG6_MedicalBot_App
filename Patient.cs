using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Bot_App
{
    public class Patient
    {
        string name;
        int age;
        string gender;
        string medicalHistory;
        string symptomCode;
        string prescription;

        public string GetName() 
        { 
            return name; 
        }
        public bool SetName(string name, out string errorMessage)
        {
            if (name != null && name.Length > 2)
            {
                this.name = name;
                errorMessage = "";
                return true;
            }
            else
            {
                errorMessage = "The name must have at least two character";
                return false;
            }
        }

        public int GetAge()
        {
            return age;
        }
        public bool SetAge(int age, out string errorMessage)
        {
            if (age > 0 && age < 100)
            {
                this.age = age;
                errorMessage = "";
                return true;
            }
            else
            {
                errorMessage = "Age must be over 0 and under 100";
                return false;
            }
        }

        public string GetGender()
        {
            return gender;
        }
        public bool SetGender(string gender, out string errorMessage)
        {
            if (gender == "Male" || gender == "Female" || gender == "Other")
            {
                this.gender = gender;
                errorMessage = "";
                return true;
            }
            else
            {
                errorMessage = "Gender must be 'Male', 'Female' or 'Other'";
                return false;
            }
        }

        public string GetMedicalHistory()
        {
            return medicalHistory;
        }
        public void SetMedicalHistory(string medicalHistory)
        {
            this.medicalHistory = medicalHistory;
        }

        public bool SetSymptomCode(string symptomCode, out string errorMessage)
        {
            if (symptomCode == "S1" || symptomCode == "S2" || symptomCode == "S3")
            {
                this.symptomCode = symptomCode;
                errorMessage = "";
                return true;
            }
            else
            {
                errorMessage = "The code must be 'S1', 'S2' or 'S3'";
                return false;
            }
        }

        public string GetSymptoms()
        {
            switch (this.symptomCode)
            {
                case "S1":
                    return "Headache";

                case "S2":
                    return "Skin rashes";

                case "S3":
                    return "Dizziness";

                default:
                    return "Unknown";
            }
        }

        public string GetPrescription()
        {
            return prescription;
        }
        public void SetPrescription(string prescription)
        {
            this.prescription = prescription;
        }
    }
}
