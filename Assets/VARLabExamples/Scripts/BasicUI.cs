using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicUI : MonoBehaviour
{
    [SerializeField] private PlayerCharacter player;
    private void OnGUI()
    {
        int posX = 10;
        int posY = 10;
        int width = 100;
        int height = 30;
        int buffer = 10;

        
        int health = player.GetHealth();

        for (int i = 0; i < health; i++)
        {
            Texture2D image = Resources.Load<Texture2D>("Icons/health");
            GUI.Box(new Rect(posX, posY, width, height), image);
            posX += width + buffer;
        }
    }
}
