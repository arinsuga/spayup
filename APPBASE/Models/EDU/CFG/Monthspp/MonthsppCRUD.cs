﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Globalization;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using APPBASE.Helpers;
using APPBASE.Models;
using APPBASE.Svcbiz;

namespace APPBASE.Models
{
    [Table("EDU01CFG_MONTHSPP")]
    public partial class Monthspp : CRUD
    {
        public Byte? DTA_STS { get; set; }
        public string MONTHSPP_CODE { get; set; }
        public string MONTHSPP_SHORTDESC { get; set; }
        public string MONTHSPP_DESC { get; set; }
        //Nomor bulan sebenarnya (cth:1=Januari;2=Februari)
        public Byte? MONTHSPP_NUM { get; set; }
        //Nomor bulan sesuai Tahun Ajaran (cth:1-6=Juli-Desember;7-12=Januari-Juni)
        public Byte? MONTHSPP_SEQNO { get; set; }
    } //End public partial class Monthspp : CRUD
} //End namespace APPBASE.Models
