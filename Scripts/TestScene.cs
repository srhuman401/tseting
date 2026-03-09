using Godot;
using System;

public partial class TestScene : Control
{

	private ButtonScript _button;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_button = GetNode<ButtonScript>("Button");
		_button.ButtonReallyPressed += _OnButtonPressed;
	}

	public void _OnButtonPressed()
	{
		GD.Print("Button was really pressed");
	}
}
