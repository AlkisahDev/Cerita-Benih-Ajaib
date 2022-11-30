using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapFollow : MonoBehaviour
{
    public Transform target;
    public float snap;

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = new Vector2(Mathf.Round(target.position.x / snap) * snap, 
            Mathf.Round(target.position.y / snap) * snap);
        transform.position = pos;
    }
}
