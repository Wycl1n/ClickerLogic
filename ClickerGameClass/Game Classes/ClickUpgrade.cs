namespace ClickerGameClass.Game_Classes
{
    public class ClickUpgrade : Upgrade
    {
        public decimal clickMulty = 0;
        public decimal clickBonus = 0;
        public bool isBought = false;
        public ClickUpgrade(string name, string details, decimal price, decimal clickMulty, decimal clickBonus)
        {
            this.name = name;
            this.details = details;
            this.price = price;
            this.clickMulty = clickMulty;
            this.clickBonus = clickBonus;
        }
    }
}
