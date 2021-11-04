﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Integration.ApiKeys.Model;
using Integration_API.DTO;

namespace Integration_API.Adapter
{
    public class ApiKeyAdapter
    {
        public static ApiKey ApiKeyDtoToApiKey(ApiKeyDTO dto)
        {
            ApiKey apiKey = new ApiKey();
            apiKey.Name = dto.Name;
            apiKey.Key = dto.Key;
            apiKey.BaseUrl = dto.BaseUrl;

            return apiKey;
        }

        public static ApiKeyDTO ApiKeyToApiKeyDto(ApiKey apiKey)
        {
            ApiKeyDTO dto = new ApiKeyDTO();
            dto.Name = apiKey.Name;
            dto.Key = apiKey.Key;
            dto.BaseUrl = apiKey.BaseUrl;

            return dto;
        }
    }
}
