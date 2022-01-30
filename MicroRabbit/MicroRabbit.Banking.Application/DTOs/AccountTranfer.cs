using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Application.DTOs
{
    public class AccountTranfer
    {
        public int ToAccount { get; set; }
        public int FromAccount { get; set; }
        public decimal TranferAmount { get; set; }
    }
}
