extends CharacterBody2D


const move_speed = 400.0

func _physics_process(_delta):
	var direction = Input.get_vector("move_left", "move_right", "move_up", "move_down")
	if direction:
		velocity = direction * move_speed
	else:
		velocity = Vector2.ZERO
	
	move_and_slide()
	
	look_at(get_global_mouse_position())