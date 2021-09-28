using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Stats", menuName = "Character/Stats", order = 1)]
public class CharacterStats : ScriptableObject
{
    [SerializeField] private float _maxHealth;
    [SerializeField] private float _currentHealth;
    [SerializeField] private float _PercentageOfDamage; // from max health
    [SerializeField] private float _moveSpeed;

    public event Action OnDeathEffect;
    public event Action OnDamageEffect;

    public float MaxHealth { get => _maxHealth; set => _maxHealth = value; }
    public float CurrentHealth
    {
        get => _currentHealth;
        set
        {
            if (value <= MaxHealth)
            {
                _currentHealth = value;
            }
            else
            {
                _currentHealth = MaxHealth;
            }
        }
    }

    public float MoveSpeed { get => _moveSpeed;}

    public float Damage 
    {
        get
        {
            var calcDamage = _maxHealth * _PercentageOfDamage / 100.0f;
            return calcDamage; 
        }
    }

    public void TakeDamage(int amount)
    {
        _currentHealth -= amount;
        OnDamage();

        if (_currentHealth <= 0)
        {
            OnDeath();
        }
    }

    private void OnDamage()
    {
        OnDamageEffect?.Invoke();
    }
    
    private void OnDeath()
    {
        OnDeathEffect?.Invoke();
    }
}
