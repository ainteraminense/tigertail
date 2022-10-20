using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    private int _health;

    public int GetHealth()
    {
        return _health;
    }

    private void Start()
    {
        _health = 3;
    }
    public void Hurt()
    {
        _health--;
    }
}
