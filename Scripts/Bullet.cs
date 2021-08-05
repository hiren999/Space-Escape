using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 20f;
    public int damage = 10;
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitinfo){
        Debug.Log(hitinfo.name);
        Enemy enemy1 = hitinfo.GetComponent<Enemy>();
        if(enemy1 != null){
            enemy1.TakeDamage(10);
        }
        if (hitinfo.name != "Player"){
            Destroy(gameObject);
        }
        
    }
}
