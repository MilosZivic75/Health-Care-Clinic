﻿using Grpc.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Integration.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrgentMedicines.Protos;
using Newtonsoft.Json;
using Integration.Interface.Service;
using RestSharp;

namespace Integration_API.Controller
{
    [Route("hospital/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class UrgentMedicinesController : ControllerBase
    {
        private readonly IMedicineService _medicineService;

        public UrgentMedicinesController(IMedicineService medicineService)
        {
            _medicineService = medicineService;
        }

        [HttpPost]
        public async Task<IActionResult> UrgentMedicineRequest([FromBody] Medicine medicine)
        {
            Channel channel = new Channel("localhost:8787", ChannelCredentials.Insecure);
            NetGrpcService.NetGrpcServiceClient client = new NetGrpcService.NetGrpcServiceClient(channel);

            MessageResponseProto response = await client.transferAsync(new MessageProto() { Message = "HOSPITAL REQUEST: ", MedicineName = medicine.Name, MedicineQuantity = medicine.Quantity });
            Console.WriteLine(response.Response + " | " + response.Status);
            if (response.Status == "STATUS OK")
            {
                var restClient = new RestClient("http://localhost:52844");
                var request = new RestRequest("api/medicine/add");
                request.AddQueryParameter("medicineName", medicine.Name);
                request.AddQueryParameter("quantity", medicine.Quantity.ToString());
                IRestResponse restResponse = restClient.Post(request);
            }

            return Ok(response.Response);
        }
    }
}
