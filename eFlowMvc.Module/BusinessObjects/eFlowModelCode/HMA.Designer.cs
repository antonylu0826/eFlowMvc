﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace eFlowApi.Module.BusinessObjects.eFlowModel
{

    public partial class HMA : FormBase
    {
        VacationType fVacationType;
        public VacationType VacationType
        {
            get { return fVacationType; }
            set { SetPropertyValue<VacationType>(nameof(VacationType), ref fVacationType, value); }
        }
        string fStartDate;
        public string StartDate
        {
            get { return fStartDate; }
            set { SetPropertyValue<string>(nameof(StartDate), ref fStartDate, value); }
        }
        string fStartTime;
        public string StartTime
        {
            get { return fStartTime; }
            set { SetPropertyValue<string>(nameof(StartTime), ref fStartTime, value); }
        }
        string fEndDate;
        public string EndDate
        {
            get { return fEndDate; }
            set { SetPropertyValue<string>(nameof(EndDate), ref fEndDate, value); }
        }
        string fEndTime;
        public string EndTime
        {
            get { return fEndTime; }
            set { SetPropertyValue<string>(nameof(EndTime), ref fEndTime, value); }
        }
    }

}