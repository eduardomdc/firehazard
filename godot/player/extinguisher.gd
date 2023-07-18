extends Node2D

@onready var particles = $GPUParticles2D

func _ready():
	particles.emitting = false

func fire():
	if not particles.emitting:
		particles.emitting = true

func stop_firing():
	particles.emitting = false
