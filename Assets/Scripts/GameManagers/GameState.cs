using Entities;

public class GameState
{
    private Player _player;
    private Door _door;
    
    public void Loot(int gold, int magicStone)
    {
        _player.Gold += gold;
        _player.MagicStone += magicStone;
    }
}