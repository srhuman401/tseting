using Godot;
using System;

public partial class ScoreDisplay : Label
{
	public override void _Ready()
	{
		//base._Ready();
		Game.Instance.ScoreChanged += _OnScoreChanged;
		_OnScoreChanged(Game.Instance.GameScore);
	}

	public void _OnScoreChanged(int newScore)
	{
		Text = newScore.ToString();
	}
}
