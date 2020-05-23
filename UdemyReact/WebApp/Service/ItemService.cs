using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Service
{
    public class ItemService : IItemService
    {
        public void ExecuteItem()
        {
            Debug.WriteLine("Item Service Executed");
        }
    }
}
