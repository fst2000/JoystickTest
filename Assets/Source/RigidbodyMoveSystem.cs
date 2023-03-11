using UnityEngine;
public class RigidBodyMoveSystem : IMoveSystem
{
    Rigidbody rigidbody;
    Transform transform;
    public RigidBodyMoveSystem(GameObject gameObject)
    {
        this.rigidbody = gameObject.AddComponent<Rigidbody>();
        rigidbody.freezeRotation = true;
    }
    public void Move(IController controller,float moveSpeed)
    {
        Vector2 input = controller.Input();
        Vector3 direction = new Vector3(input.x,0,input.y);
        rigidbody.velocity = direction * moveSpeed;
    }
}