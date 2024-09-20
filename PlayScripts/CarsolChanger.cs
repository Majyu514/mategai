using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarsolChanger : MonoBehaviour
{

    public Texture2D handCursor;
    public Texture2D fist;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.SetCursor(handCursor, Vector2.zero, CursorMode.Auto);
        if (Input.GetMouseButtonDown(0))
        {
            Cursor.SetCursor(fist, Vector2.zero, CursorMode.Auto);
            Debug.Log("‰Ÿ‚³‚ê‚½");
        }
    }
}
