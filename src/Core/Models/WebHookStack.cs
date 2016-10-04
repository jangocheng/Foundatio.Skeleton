﻿using System;
using GoodProspect.Core.Collections;

namespace GoodProspect.Core.Models
{
    public class WebHookStack {
        public string Id { get; set; }
        public string Url { get { return String.Concat(Settings.Current.BaseURL, "/stack/", Id); } }
        public string Title { get; set; }
        public string Description { get; set; }

        public TagSet Tags { get; set; }
        public string RequestPath { get; set; }
        public string Type { get; set; }
        public string TargetMethod { get; set; }
        public string OrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public int TotalOccurrences { get; set; }
        public DateTime FirstOccurrence { get; set; }
        public DateTime LastOccurrence { get; set; }
        public DateTime? DateFixed { get; set; }
        public string FixedInVersion { get; set; }
        public bool IsRegression { get; set; }
        public bool IsCritical { get; set; }
    }
}