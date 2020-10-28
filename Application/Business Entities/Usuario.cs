using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Entities
{
    public class Usuario
    {
        private string userName;
        private int userId;
        private int wins;
        private int losses;

        public string UserName { get => userName; set => userName = value; }
        public int UserId { get => userId; set => userId = value; }
        public int Wins { get => wins; set => wins = value; }
        public int Losses { get => losses; set => losses = value; }

    }
}
