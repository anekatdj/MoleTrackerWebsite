using System;
using APIWebServiesConnector;
using DataClasses.Domain;
using DataClasses.DTO.CollectionDTOS;
using DataClasses.DTO.LoginDTOS;
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
            API = new ApiService(APIWebServiesConnector.APIStringFabrics.APIStringFabric.GetDeveloperAPIString());

            //API = new StubApiService();
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

    }
}