using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class BaseEF
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
