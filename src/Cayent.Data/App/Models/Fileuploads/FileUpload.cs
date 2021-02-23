﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cayent.Common.Extensions;

namespace Cayent.Data.App.Models.Fileuploads
{
    public class FileUpload
    {
        public string FileUploadId { get; set; }
        public string Url { get; set; }
        public string FileName { get; set; }
        public string ContentDisposition { get; set; }
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
        public long Length { get; set; }

        DateTime _dateCreated;
        public DateTime DateCreated
        {
            get => _dateCreated;
            set => _dateCreated = value.Truncate().AsUtc();
        }
    }
}
