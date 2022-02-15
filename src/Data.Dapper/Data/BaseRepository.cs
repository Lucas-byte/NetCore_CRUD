using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Dapper.Data
{
    public abstract class BaseRepository<T> where T : BaseEntity
    {
        public string ConnectionString { get; private set; }

        public BaseRepository()
        {
            ConnectionString = "Server=localhost;Port=3306;Database=dbAPI;Uid=root;Pwd=MyNewPass";
        }
    }
}
