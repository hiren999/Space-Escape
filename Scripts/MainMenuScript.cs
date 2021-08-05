using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{   
    public int levelAt;
    
    void Start(){
        PlayerPrefs.SetInt("levelAt", 1);
    }

    public void playGame(){
        SceneManager.LoadScene(PlayerPrefs.GetInt("levelAt"));
    }

    public void quitGame(){
        Debug.Log("Quit game");
        Application.Quit();
    }

    public void levelOne(){
        SceneManager.LoadScene("Level1");
    }

    public void levelTwo(){
        SceneManager.LoadScene("Level2");
    }

    public void levelThree(){
        SceneManager.LoadScene("Level3");
    }

    public void levelFour(){
        SceneManager.LoadScene("Level4");
    }

    public void levelFive(){
        SceneManager.LoadScene("Level5");
    }

    public void main(){
        SceneManager.LoadScene(0);
    }

    void Update(){
        

        
    }
}
