using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_Application_with_Database
{
    public class Card
    {
        public int CardId { get; set; }
        public string CardName { get; set; }
        public string CardContent { get; set; }
        public string TaskAppointee { get; set; }
        public string CardSize { get; set; }

        public string BoardColumn { get; set; }
    }
}
