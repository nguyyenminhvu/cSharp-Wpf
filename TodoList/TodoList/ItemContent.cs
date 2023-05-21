using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    public class ItemContent
    {
        public ItemContent() { }    
        public int Id { get; set; }
        public string Contents { get; set; }

        public ItemContent(int id, string contents)
        {
            Id = id;
            Contents = contents;
        }

    }
}
