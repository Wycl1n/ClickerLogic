using System;
using ClickerGameClass.Game_Classes;

namespace ClickerGameClass
{
    class Game
    {
        private decimal _score = 0;
        private decimal globalMulty = 1;
        private decimal clickMulty = 1;
        private decimal clickBonus = 1;
        private decimal income = 0;
        public ClickUpgrade[] clickUpgrades =
            { new ClickUpgrade("Basic click upgrade", "Some details of this shit", 10, 0, 1) };
        public IncomeUpgrade[] incomeUpgrades =
            { new IncomeUpgrade("Basic income upgrade", "Some details", 10, 1) };
        public decimal score 
        { 
            get => this._score;
            set
            {
                if (value >= 0)
                    this._score = value;
            }
        }

        /*public Update()
        {

        }*/

        public void Click()
        {
            score += clickBonus*clickMulty * globalMulty;
        }
        public void UpgradeClick(ClickUpgrade upgrade)
        {
            if (score >= upgrade.price)
            {
                clickMulty += upgrade.clickMulty;
                clickBonus += upgrade.clickBonus;
                score -= upgrade.price;
                upgrade.isBought = true;
            }
            else { }
        }
        public void UpgradeIncome(IncomeUpgrade upgrade)
        {
            if (score >= upgrade.price)
            {
                income += upgrade.incomeBonus;
                score -= upgrade.price;
                upgrade.price = (decimal)((double)upgrade.price*(Math.E/2));
                upgrade.quantity++;
            }
            else { }
        }
    }
}
