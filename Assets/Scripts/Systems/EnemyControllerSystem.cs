using Leopotam.Ecs;
using UnityEngine;

sealed class EnemyControllerSystem : IEcsRunSystem
{
    private readonly EcsWorld _world = null;
    private readonly EcsFilter<EnemyComponent> enemys = null;

    private readonly EcsFilter<PlayerMoveComponent> playerEntity = null;
    
    public void Run()
    {
        PlayerMoveComponent player = new PlayerMoveComponent();
        foreach (var playerIndx in playerEntity)
            player = playerEntity.Get1(playerIndx);

        foreach (var enemy in enemys)
        {
            ref var enemyComponent = ref enemys.Get1(enemy);
            SetDistance(enemyComponent, player.transform.position);
        }
        
    }

    private void SetDistance(EnemyComponent enemy, Vector3 playerPosition)
    {
        enemy.agent.SetDestination(playerPosition);
    }
}