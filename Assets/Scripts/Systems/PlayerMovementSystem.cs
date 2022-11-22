using Leopotam.Ecs;
using UnityEngine;

sealed class PlayerMovementSystem : IEcsRunSystem
{
    private readonly EcsWorld _world = null;
    private readonly EcsFilter<PlayerMoveComponent> movableEntitysFilter = null;

    private InputController _inputController;
    
    public PlayerMovementSystem(InputController inputController)
    {
        _inputController = inputController;
    }
    
    public void Move()
    {
        Vector2 direction = _inputController.Move.StickMoving.ReadValue<Vector2>();
        foreach (var player in movableEntitysFilter)
        {
            ref var playerMoveComponent = ref movableEntitysFilter.Get1(player);
            DirectionRun(direction, playerMoveComponent);
        }
    }
    
    private void DirectionRun(Vector2 joystickDirection, PlayerMoveComponent moveComponent)
    { 
         Vector3 playerMoveDirection = new Vector3(joystickDirection.x, 0.0f, joystickDirection.y); 
         moveComponent.rigidbody.velocity = playerMoveDirection * moveComponent.speed  * Time.deltaTime;
    }

    public void Run()
    {
        Move();
    }
}