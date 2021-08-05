using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUpDown : MonoBehaviour
{
    public float speed = 2f;
    public float height = 5f;
    public bool sideways = false;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!sideways)
        {
            float newY = Mathf.Sin(Time.time * speed) * height + pos.y;
            transform.position = new Vector3(transform.position.x, newY, transform.position.z);
        }
        else
        {
            float newX = Mathf.Sin(Time.time * speed) * height + pos.x;
            transform.position = new Vector3(newX, transform.position.y, transform.position.z);
        }
    }
}
