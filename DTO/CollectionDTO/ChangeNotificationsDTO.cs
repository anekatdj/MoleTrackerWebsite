﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.CollectionDTO
{
    public class ChangeNotificationsDTO
    {
        public int CollectionID { get; set; }
        public TimeSpan NotificationTimeInterval { get; set; }
    }
}
