using System;
using System.Collections.Generic;
using System.Text;

namespace KnowledgeServicesBank
{
    public class Bank
    {
        public string Name { get; }

        public List<Account> Accounts { get; set; }

        public Bank(string name)
        {
            Name = name;
        }
    }
}
