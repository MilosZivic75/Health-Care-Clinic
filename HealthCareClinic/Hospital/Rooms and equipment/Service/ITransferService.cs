﻿using ClinicCore.Service;
using Hospital.Rooms_and_equipment.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Rooms_and_equipment.Service
{
    public interface ITransferService: IService<Transfer>
    {
        public void RemoveById(int id);
        public List<Transfer> GetRoomTransfers(int id);
        public List<DateTime> checkFreeTransfers(Transfer transfer);
        public bool CheckIfTransferCancellable(int id);
    }
}
