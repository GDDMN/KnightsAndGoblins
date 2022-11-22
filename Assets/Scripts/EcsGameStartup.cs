using UnityEngine;
using Leopotam.Ecs;
using Voody.UniLeo;

public class EcsGameStartup : MonoBehaviour
{
    private EcsWorld world;
    private EcsSystems systems;
    private InputController inputController;

    private void Awake()
    {
        world = new EcsWorld();
        systems = new EcsSystems(world);

        systems.ConvertScene();

        inputController = new InputController();
        
        AddInjections();
        AddSystems();
        AddOneFrames();
        
        systems.Init();
    }

    private void LateUpdate()
    {
        systems.Run();
    }


    private void AddSystems()
    {
        systems.Add(new PlayerMovementSystem(inputController));
        systems.Add(new EnemyControllerSystem());
    }
    
    private void AddInjections()
    {}
    
    private void AddOneFrames()
    {}

    private void OnEnable()
    {
        inputController.Enable();
    }

    private void OnDisable()
    {
        inputController.Disable();
    }

    private void OnDestroy()
    {
        systems.Destroy();
        systems = null;
        world.Destroy();
        world = null;
    }
}
