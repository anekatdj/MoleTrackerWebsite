using System;
using APIWebServiesConnector;
using DataClasses.Domain.Collections;
using DataClasses.Domain.Login;
using DataClasses.Domain.MISC;
using DataClasses.DTO;
using PW_DataAccessLayer.Interfaces;

namespace PW_DataAccessLayer
{
    public class ViewCollectionDatabaseManager : IViewCollectionDatabaseManager
    {
        private PatientInfoDTO patientInfoDTO;

        private CollectionDTO collectionDTO;

        private Collection collection;

        private IAPIService API;

        public ViewCollectionDatabaseManager()
        {
            //API = new ApiService(APIWebServiesConnector.APIStringFabrics.APIStringFabric.GetDeveloperAPIString());

            API = new StubApiService();
        }

        public Collection GetCollection() //PatientInfo patientInfo
        {
            try
            {
                collectionDTO = API.GetObject<CollectionDTO, PatientInfoDTO>("CollectionRequest", patientInfoDTO);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            collection.CollectionID = collectionDTO.CollectionID;
            collection.CollectionName = collectionDTO.CollectionName;
            //foreach (var picture in collectionDTO.PictureList)
            //{
            //    collection.PictureList.Add(picture);
            //}

            //collection.Location = collectionDTO.Location;

            return collection;
        }

        public PatientData GetPatientData(PatientInfo patientInfoDomain)
        {
            PatientDataDTO patientDataDTO = new PatientDataDTO();
            PatientInfoRequestDTO patientInfoRequestDTO = new PatientInfoRequestDTO() { PatientID = patientInfoDomain.PatientID };
            try
            {
                patientDataDTO = API.GetObject<PatientDataDTO, PatientInfoRequestDTO>("GetPatientData", patientInfoRequestDTO);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            PatientData patientDataDomain = DTOConverter.PatientDataToDomain(patientDataDTO);

            return patientDataDomain;
        }

    }
}