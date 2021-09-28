using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oven : MonoBehaviour
{
    public Sprite OvenSpriteOff;
    public Sprite OvenSpriteOn;

    private SpriteRenderer _spriteR;
    private bool isOvenOn;

    public bool IsOvenOn { get => isOvenOn; }

    private void Awake()
    {
        _spriteR = gameObject.GetComponent<SpriteRenderer>();
        if (_spriteR != null && OvenSpriteOff != null )
        {
            _spriteR.sprite = OvenSpriteOff;
        }
    }

    public void Use()
    {
        if (isOvenOn)
        {
            isOvenOn = false;
            _spriteR.sprite = OvenSpriteOff;
        }
        else
        {
            isOvenOn = true;
            _spriteR.sprite = OvenSpriteOn;
        }
        
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))  // тест
        {
            Use();
        }
    }
}
