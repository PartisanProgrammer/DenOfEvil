using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    private bool openable = false;

    public Texture2D lockedTexture;
    public Texture2D unLockedTexture;
    
    // Update is called once per frame
    void Update()
    {
        while (!openable)
        {
            
        }
    }
    void OnMouseEnter()
    {
        if (!openable)
        {
            Cursor.SetCursor(lockedTexture, new Vector2(), CursorMode.Auto);
        }
        if (openable)
        {
            Cursor.SetCursor(unLockedTexture, new Vector2(), CursorMode.Auto);
        }
    }
}
