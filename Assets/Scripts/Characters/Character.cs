using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public CharacterStats CharacterDefinition_Template; // defaults stats
    public CharacterStats CharacterDefinition;          // current stats

    private void Awake()
    {
        if (CharacterDefinition_Template != null)
        {
            CharacterDefinition = Instantiate(CharacterDefinition_Template);
        }
    }

    public void TakeDamage(int amount)
    {
        CharacterDefinition.TakeDamage(amount);
    }

    public float GetHealth()
    {
        return CharacterDefinition.CurrentHealth;
    }

    public float GetDamage()
    {
        return CharacterDefinition.Damage;
    }
    
    public float GetMoveSpeed()
    {
        return CharacterDefinition.MoveSpeed;
    }
}
