using System;
using DisplayManager;
using TMPro;
using UnityEngine;
using Entities;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;


public class Manager : MonoBehaviour
{
    public GameState _gameState { get; set; }

    public DoorDisplay DoorDisplay;
    public PlayerDisplay PlayerDisplay;
    
    public Button Door;
    public void Start()
    {
        _gameState = new GameState();
        _gameState.Start();
        
        DoorDisplay.Ent = _gameState._door;
        PlayerDisplay.Ent = _gameState._player;
        
        DoorDisplay.Display();
        PlayerDisplay.Display();
        
        Door.onClick.AddListener(OnPlayerClick);
    }
    
    public void OnPlayerClick()
    {
        _gameState._player.AttackPhysic(_gameState._door);
    }
}


