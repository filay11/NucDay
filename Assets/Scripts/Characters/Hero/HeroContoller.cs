using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroContoller : MonoBehaviour
{
    private CharacterStats _characterStats;

    private void Awake()
    {
        var character = GetComponent<Character>();
        if (character != null)
        {
            _characterStats = character.CharacterDefinition;
        }
    }

    void Update()   // упростить апдейт
    {
        transform.Translate(Input.GetAxis("Horizontal") * _characterStats.MoveSpeed * Vector2.right * Time.deltaTime);
    }
}
