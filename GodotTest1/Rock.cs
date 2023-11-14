using Godot;
using System;
using System.Resources;

public partial class Rock : Area2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		InputPickable = true;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
	}

	public override void _MouseEnter()
	{
		Random rand = new Random();
		int screenX = (int)GetViewportRect().Size.X;
		int screenY = (int)GetViewportRect().Size.Y;

		base._MouseEnter();
		//Rock moves a random value within 100 pixels
		MoveLocalX(rand.Next(-100, 100));
		MoveLocalY(rand.Next(-100, 100));

		GD.Print(Position);

		if (Position.X > screenX || Position.X < new Vector2(0,0).X || Position.Y > screenY || Position.Y < new Vector2(0, 0).Y) {//we don't want Rock to go offscreen
			GD.Print("teleported");
			Position = new Vector2(rand.Next(0, screenX), rand.Next(0, screenY));
		}
	}
}
