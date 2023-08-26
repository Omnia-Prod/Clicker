namespace Entities
{
    public class Door : Entity
    {
        public int LootGold { get; set; }
        public int LootMagicStone { get; set; }
        
        protected override void onDefeated()
        {
            GameState.Loot(this.LootGold, this.LootMagicStone);
        }
    }
}