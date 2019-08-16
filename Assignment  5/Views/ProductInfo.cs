using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__5.Views
{
    enum ProductInfoField
    {
        PRODUCTID,
        COST,
        CONDITION,
        PLATFORM,
        MANUFACTURER,
        OS,
        MODEL,
        MEMORY,
        CPU_BRAND,
        CPU_TYPE,
        LCD,
        CPU_NUM,
        CPU_SPEED,
        HDD,
        GPU_TYPE,
        WEB_CAM,
        NUM_OF_FIELDS
    }
    public class ProductInfo
    {
        public string ProductID { get; set; }
        public string Cost { get; set; }
        public string Condition { get; set; }
        public string Platform { get; set; }
        public string OS { get; set; }
        public string manufactuer { get; set; }
        public string Model { get; set; }
        public string Memory { get; set; }
        public string CPUBrand { get; set; }
        public string CPUType { get; set; }
        public string LCD { get; set; }
        public string CPUNumber { get; set; }
        public string CPUSpeed { get; set; }
        public string HDD { get; set; }
        public string GPUType { get; set; }
        public string WebCam { get; set; }
    }

}

