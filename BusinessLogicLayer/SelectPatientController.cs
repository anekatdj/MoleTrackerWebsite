using System;
using System.Collections.Generic;
using System.Text;
using BusinessLogicLayer.BusinessLogicLayerInterfaces;
using DataAccessLayer.DataAccessLayerInterfaces;
using DataAccessLayer;
using DataClasses.Domain;

namespace BusinessLogicLayer
{
    public class SelectPatientController : ISelectPatientController
    {
        public ISelectPatientDatabaseManager SelectPatientDatabaseManager { get; set; }

        public PatientInfoDomain SelectedPatient { get; set; }
        public string DateOfBirth { get; set; }

        public bool BirthDataCalcFailed { get; set; }

        public SelectPatientController()
        {
            SelectPatientDatabaseManager = new SelectPatientDatabaseManager();
            
            SelectedPatient = new PatientInfoDomain();
        }
        public PatientDataDomain GetPatientData(PatientInfoDomain patientInfoDomain)
        {
            return SelectPatientDatabaseManager.GetPatientData(patientInfoDomain);
        }

        public void HandlePatientInfo()
        {
            DateOfBirth = "";

            var CPRArray = SelectedPatient.CPR.ToCharArray();

            string date = "";

            string month = "";

            string year = "";

            try
            {

                for (int i = 0; i < 2; i++)
                {
                    date = date + CPRArray[i];
                }
                for (int i = 2; i < 4; i++)
                {
                    month = month + CPRArray[i];
                }
                for (int i = 4; i < 6; i++)
                {
                    year = year + CPRArray[i];
                }

                if (CPRArray[10] == '1' || CPRArray[10] == '3' || CPRArray[10] == '5' || CPRArray[10] == '7' || CPRArray[10] == '9')
                {
                    SelectedPatient.Gender = "Mand";
                }
                else if (CPRArray[10] == '0' || CPRArray[10] == '2' || CPRArray[10] == '4' || CPRArray[10] == '6' || CPRArray[10] == '8')
                {
                    SelectedPatient.Gender = "Kvinde";
                }


                month = GetMonthOfBirth(month);
                year = GetYearOfBirth(year);

                DateOfBirth = date + ". " + month + " " + year;

            }
            catch (Exception e)
            {
                BirthDataCalcFailed = true;
            }

        }


        private string GetYearOfBirth(string year)
        {
            int yearNo = Convert.ToInt16(year);

            var currentYear = DateTime.Now.Year.ToString();
            var currentYearArray = currentYear.ToCharArray();

            var currentYear2 = "";

            for (int i = 2; i < 4; i++)
            {
                currentYear2 = currentYear2 + currentYearArray[i];
            }

            int currentYearNo = Convert.ToInt16(currentYear2);

            if (yearNo > currentYearNo)
            {
                year = "19" + year;
            }
            else if (yearNo <= currentYearNo)
            {
                year = "20" + year;
            }
            return year;
        }

        private string GetMonthOfBirth(string month)
        {

            if (month == "01")
            {
                month = "januar";
            }
            else if (month == "02")
            {
                month = "februar";
            }
            else if (month == "03")
            {
                month = "marts";
            }
            else if (month == "04")
            {
                month = "april";
            }
            else if (month == "05")
            {
                month = "maj";
            }
            else if (month == "06")
            {
                month = "juni";
            }
            else if (month == "07")
            {
                month = "juli";
            }
            else if (month == "08")
            {
                month = "august";
            }
            else if (month == "09")
            {
                month = "september";
            }
            else if (month == "10")
            {
                month = "oktober";
            }
            else if (month == "11")
            {
                month = "november";
            }
            else if (month == "12")
            {
                month = "december";
            }

            return month;
        }
    }
}
