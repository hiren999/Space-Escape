using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour
{
    public int nextScene;
    // Start is called before the first frame update
    void Start()
    {
        nextScene = SceneManager.GetActiveScene().buildIndex + 1;
    }

    public void OnTriggerEnter2D(Collider2D other){

        if (other.gameObject.tag == "Player"){
            if (SceneManager.GetActiveScene().buildIndex != 5){
                SceneManager.LoadScene(nextScene);

                if (nextScene > PlayerPrefs.GetInt("levelAt")){
                    PlayerPrefs.SetInt("levelAt", nextScene);
                }
                
            }

                
            
            
        }

    }
    
}
