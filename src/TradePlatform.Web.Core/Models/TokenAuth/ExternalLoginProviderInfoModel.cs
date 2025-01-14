﻿using Abp.AutoMapper;
using TradePlatform.Authentication.External;

namespace TradePlatform.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
