using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderControl : MonoBehaviour
{
    public PolygonCollider2D stand;
    public PolygonCollider2D slide;

    PlayerMovement player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<PlayerMovement>();
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (player.crouches == true){
            slide.enabled = true;
            stand.enabled = false;
        
        }else{
            slide.enabled = false;
            stand.enabled = true;
        }
    }
}
