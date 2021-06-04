using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.Model
{
    public interface IEntity
    {
       
        Guid Id { get; set; }       
    }
}
