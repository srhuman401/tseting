using Godot;
using System;
using System.Data;

public partial class Game : Node
{
    [Signal]
    public delegate void ScoreChangedEventHandler(int newScore);
    public static Game Instance {get; private set;}
    public bool IsGameActive = false;
    private int _gameScore = 0;
    public int GameScore
    {
        get => _gameScore;
        set
        {
            _gameScore = value;
            EmitSignal(SignalName.ScoreChanged, _gameScore);
        }
    }

    public override void _Ready()
    {
        //base._Ready();
        Instance = this;

        GameScore = 0;
    }
}