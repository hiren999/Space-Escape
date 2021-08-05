using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.UI;
 
 public class menuMovement : MonoBehaviour {
 
     public Vector3 vector;
     public Vector3 StartPos;
     
     public int moveModifier;
     
     // Use this for initialization
     void Start ()
     {
         StartPos = transform.position;
     }
     
     // Update is called once per frame
     void Update ()
     {
         Vector3 vector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
         vector.z = 0;
         gameObject.transform.position = vector;
         
 
         transform.position = new Vector3(StartPos.x + (vector.x * moveModifier), StartPos.y + (vector.y * moveModifier), 0);
         
     }
}