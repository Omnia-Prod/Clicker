namespace Entities
{
    public class Player : Entity
    {

        public int Gold { get; set; }
        public int MagicStone { get; set; }

        protected override void onDefeated()
        {
            throw new System.NotImplementedException();
        }
    }
}