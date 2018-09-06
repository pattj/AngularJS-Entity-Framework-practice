﻿using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace GeneralKnowledge.Test.App.Models
{


    public class TestData
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public string Asset_Id { get; set; }
        public string File_Name { get; set; }
        public string Mime_Type { get; set; }
    }

    public sealed class AssetMap : ClassMap<TestData>
    {
        public AssetMap()
        {
            Map(m => m.Asset_Id);
            Map(m => m.File_Name);
            Map(m => m.Mime_Type);
        }
    }



}

