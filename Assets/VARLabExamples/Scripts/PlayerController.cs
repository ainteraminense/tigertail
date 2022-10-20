using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private PlayerCharacter player;
    public void PlayerControllerHurt()
    {
        player.Hurt();
    }
}
