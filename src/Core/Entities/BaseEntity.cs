using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Core.Entities
{
    [Serializable]
    public class BaseEntity
    {
        [Description("Codigo")]
        public int Id { get; set; }

        [Description("DataCriacao")]
        public DateTime CreationDate { get; set; }
    }
}
