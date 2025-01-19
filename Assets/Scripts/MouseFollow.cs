using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollow : MonoBehaviour
{
    public float distance = 10.0f;
    public Vector3 offset = Vector3.zero;

    /*
    private void Start()
    {
        Cursor.visible = false;
    }*/
    private void Update()
    {
        if (Camera.main == null)
            return;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector3 newPosition = ray.GetPoint(distance);
        transform.position = newPosition + offset;
    }
}
