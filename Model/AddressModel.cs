using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Model
{
    class AddressModel
    {
        public string Name { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public int CipCode { get; set; }
        public string City { get; set; } = string.Empty;
    }
}