﻿using Newtonsoft.Json;
using DotNetPivotalTrackerApi.Enums;
using DotNetPivotalTrackerApi.Models.Stories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPivotalTrackerApi.Models.Attachments
{
    public class PivotalAttachment
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public int UploaderId { get; set; }
    }
}
