using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class wintext : MonoBehaviour
{
    public Transform player;
    public Text win;
    public Text lose;

    void Update() {
        if(player.position.z>322){
            if (lose.enabled==false){
                win.enabled=true;
            }   
        }     
    }
    void restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }  
}
