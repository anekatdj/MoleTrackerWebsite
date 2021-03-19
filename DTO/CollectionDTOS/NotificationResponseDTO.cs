using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.CollectionDTOS
{
    //Todo denne skal lige laves til en ordentlig datatype
    public enum Noticationtype
    {
        NotType1 = 1,
        NotType2 = 2,
        NotType3 = 3
    }

    public class NotificationResponseDTO
    {
        public string CollectionName { get; set; }
        public Noticationtype Type { get; set; }
        public string Message { get; set; }
    }
}
