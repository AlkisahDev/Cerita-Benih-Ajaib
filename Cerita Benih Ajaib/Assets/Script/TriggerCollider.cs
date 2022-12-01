using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCollider : MonoBehaviour
{
    public Transform target;
    public float snap;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Vector2 pos = new Vector2(Mathf.Round(target.position.x / snap) * snap,
                Mathf.Round(target.position.y / snap) * snap);
            other.transform.position = pos;
        }
    }
}
