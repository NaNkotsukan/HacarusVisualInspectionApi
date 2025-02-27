﻿using System;
using System.Collections.Generic;

namespace HacarusVisualInspectionApi.Models
{

    public class PredictData
    {
        public List<string> item_ids { get; set; }
        public string model_version { get; set; }
    }

    public class PredictResponse: Response
    {
        public PredictData data { get; set; }
    }
}
