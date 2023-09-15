using Entities;
using TMPro;

namespace DisplayManager
{
    public class PlayerDisplay: EntityDisplay<Player>
    {
        public TMP_Text TMoneyGold;
        public TMP_Text TMoneyMagicStone;
        
        public new void Display()
        {
            thpPhysic.text = Ent.HpPhysic.ToString();
            thpMagic.text = Ent.HpMagic.ToString();

            TMoneyGold.text = Ent.Gold.ToString();
            TMoneyMagicStone.text = Ent.MagicStone.ToString();
        }
    }
}