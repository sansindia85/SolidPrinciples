﻿using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace ArdalisRating
{
    public class PolicySerializer
    {
        public Policy GetPolicyFromJsonString(string policyJson)
        {
            return JsonConvert.DeserializeObject<Policy>(policyJson,
                new StringEnumConverter());
        }
    }
}
