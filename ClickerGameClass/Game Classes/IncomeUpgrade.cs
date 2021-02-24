using System;
using System.Collections.Generic;
using System.Text;

namespace ClickerGameClass.Game_Classes
{
    public class IncomeUpgrade : Upgrade
    {
        public decimal incomeBonus = 0;
        public decimal quantity = 0;

        public IncomeUpgrade(string name, string details, decimal price, decimal incomeBonus)
        {
            this.name = name;
            this.details = details;
            this.price = price;
            this.incomeBonus = incomeBonus;
        }
    }
}
