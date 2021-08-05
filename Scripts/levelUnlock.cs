using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelUnlock : MonoBehaviour
{
    // Start is called before the first frame update
    public Button[] lvlButtons;
    public int levelAt;
   
    void Start(){
        levelAt = PlayerPrefs.GetInt("levelAt", 1);
        for (int i = 0; i < lvlButtons.Length; i++){
                if (i+ 1 > levelAt){
                    lvlButtons[i].interactable = false;
                }
            }
        
    }

    void Update(){
        if (Input.GetKeyDown(KeyCode.U)){
            PlayerPrefs.SetInt("levelAt", 5);
            levelAt = 5;
            for (int i = 0; i < lvlButtons.Length; i++){
                lvlButtons[i].interactable = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.Y)){
            PlayerPrefs.SetInt("levelAt", 1);
            //PlayerPrefs.DeleteAll();
            levelAt = 1;
            for (int i = 0; i < lvlButtons.Length; i++){
                if (i+ 1 > levelAt){
                    lvlButtons[i].interactable = false;
                }
            }
        }
    }

    
}
