using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public CharacterStats characterDefinition_Template; // defaults stats
    public CharacterStats characterDefinition;          // current stats

    private void Awake()
    {
        if (characterDefinition_Template != null)
        {
            characterDefinition = Instantiate(characterDefinition_Template);
        }
    }

    public void TakeDamage(int amount)
    {
        characterDefinition.TakeDamage(amount);
    }

    public float GetHealth()
    {
        return characterDefinition.CurrentHealth;
    }

    public float GetDamage()
    {
        return characterDefinition.Damage;
    }
    
    public float GetMoveSpeed()
    {
        return characterDefinition.MoveSpeed;
    }
}
