using Godot;
using System;
//using TestNamespace;

public partial class ButtonScript : Button
{
	[Signal]
	public delegate void ButtonReallyPressedEventHandler();	

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Pressed += _OnButtonPressed;
	}

	public void _OnButtonPressed()
	{
		GD.Print("Hello World!");
		Game.Instance.GameScore ++;
		EmitSignal(SignalName.ButtonReallyPressed);
	}

}
