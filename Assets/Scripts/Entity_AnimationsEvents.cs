using UnityEngine;

public class Entity_AnimationsEvents : MonoBehaviour
{
    private Entity entity;

    private void Awake()
    {
        entity = GetComponentInParent<Entity>();
    }

    public void DamageTargets() => entity.DamageTargets();
    private void DisableMovementAndJump() => entity.EnableMovement(false);
    private void EnableMovementAndJump() => entity.EnableMovement(true);

    private void DisableAttack() => entity.EnableAttack(false);
    private void EnableAttack() => entity.EnableAttack(true);

}
