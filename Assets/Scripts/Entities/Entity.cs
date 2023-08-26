using System;
using TMPro;
using Unity.Mathematics;

public abstract class Entity
{
    public String Name { get; set; }
    public float HpPhysic { get; set; }
    public float HpMagic { get; set; }
    public float DefPhysic { get; set; }
    public float DefMagic { get; set; }

    public float AtkPhysic { get; set; }
    public float AtkMagic { get; set; }

    protected GameState GameState;
    
    public void AttackMagic(Entity target)
    {
        float rawDamageDealt = 1f * this.AtkMagic;
        target.TakeDamage(rawDamageDealt, DamageType.Magic);
    }

    public void AttackPhysic(Entity target)
    {
        float rawDamageDealt = 1f * this.AtkPhysic;
        target.TakeDamage(rawDamageDealt, DamageType.Physic);
    }

    public void TakeDamage(float rawDamage, DamageType type)
    {
        float damageTaken;
        if (type == DamageType.Magic)
        {
            damageTaken = math.max(rawDamage - this.DefMagic, 0);

            this.HpMagic -= damageTaken;
        }
        else
        {
            damageTaken = math.max(rawDamage - this.DefPhysic, 0);
            this.HpPhysic -= damageTaken;
        }

        if (this.HpMagic <= 0 && this.HpPhysic <= 0)
        {
            this.onDefeated();
        }
    }

    protected abstract void onDefeated();
    
    public enum DamageType
    {
        Physic,
        Magic
    }

}