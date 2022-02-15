using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Core.Entities
{
    [Description("usuarios")]
    public class UserEntity : BaseEntity
    {
        [Description("Nome")]
        public string Name { get; set; }
        
        [Description("Email")]
        public string Email { get; set; }

        [Description("Senha")]
        public string Password { get; set; }

        [Description("DataAniversario")]
        public DateTime BrithDate { get; set; }

        [Description("DataDelecao")]
        public DateTime? DeletionDate { get; set; }
    }
}
