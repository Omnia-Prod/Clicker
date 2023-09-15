using Entities;
using UnityEngine;

public class GameState
{
    public Player _player { get; set; }
    public Door _door { get; set; }
    
    public void Loot(int gold, int magicStone)
    {
        _player.Gold += gold;
        _player.MagicStone += magicStone;
    }

    public void Start()
    {
        this._player = new Player();
        this._door = new Door();
    }
}