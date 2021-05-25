﻿using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.DataAccessLayerInterfaces;
using DataClasses.Domain;

namespace BusinessLogicLayer.BusinessLogicLayerInterfaces
{
    public interface ILoadPatientsController
    {

        public ILoadPatientsDatabaseManager LoadPatientsDatabaseManager { get; set; }
        List<PatientInfoDomain> LoadPatientList();
    }
}