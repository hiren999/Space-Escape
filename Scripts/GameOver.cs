using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameOver : MonoBehaviour
{
    private Scene scene;
    public Text attemptCounter;
    static int attempts=1;
    
    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
        
        AttemptText();


    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            attempts = 1;
            SceneManager.LoadScene(0);
        }
    }

    

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Obstacle")
        {

            //Time.timeScale = 0;         // Camera stops to indicate game over, we can add a restart button maybe?
            SceneManager.LoadScene(scene.name);    // this makes the level restart all over again
            
            
        }

        if (other.tag == "Endgame")
        {
            attempts = 1;
            //SceneManager.LoadScene("Level2");
        }
        if (other.tag == "Endgame2")
        {
            attempts = 1;
            //SceneManager.LoadScene("Level3");
        }
        if (other.tag == "Endgame3")
        {
            attempts = 1;
            //SceneManager.LoadScene("Level4");
        }
        if (other.tag == "Endgame4")
        {
            attempts = 1;
            //SceneManager.LoadScene("Level5");
        }

        if (other.tag == "Endgame5" && GameObject.Find("enemy")==null)
        {
            attempts = 1;
            SceneManager.LoadScene("WinScreen");
        }
        else if (other.tag == "Endgame5" && GameObject.Find("enemy") != null)
        {
            SceneManager.LoadScene("Level5");
        }
    }

    void AttemptText()
    {
        attemptCounter.text = "Attempts: " + attempts.ToString();

        if (scene.isLoaded)
        {
            attempts++;
        }
    }

}
