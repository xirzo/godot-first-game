using Godot;

namespace firstgame.scripts;

public partial class PlayerMovement : CharacterBody2D {
	[Export] private AnimatedSprite2D _animatedSprite;

	private Vector2 _direction;
	public float Speed { get; } = 100;

	public override void _PhysicsProcess(double delta) {
		UpdateInput();

		var velocity = Velocity;

		if (_direction.X > 0) _animatedSprite.FlipH = false;
		if (_direction.X < 0) _animatedSprite.FlipH = true;

		if (_direction is { X: 0, Y: 0 })
			_animatedSprite.Play("idle");
		else
			_animatedSprite.Play("walk");

		if (_direction != Vector2.Zero) {
			velocity.X = _direction.X * Speed;
			velocity.Y = _direction.Y * Speed;
		}

		else {
			velocity.X = Mathf.MoveToward(Velocity.X, 0, Speed);
			velocity.Y = Mathf.MoveToward(Velocity.Y, 0, Speed);
		}

		Velocity = velocity;
		MoveAndSlide();
	}


	private void UpdateInput() {
		_direction = Input.GetVector("Move Left", "Move Right", "Move Up", "Move Down");
	}
}
