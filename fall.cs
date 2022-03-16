using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class fall : MonoBehaviour
{
    public Transform player;
    public Text win;
    public Text lose;
    void Update()
    {
        if(player.position.y<0f){
            if(win.enabled==false){
                lose.enabled=true;
                Invoke("restart",1.5f);
            }
            
        }
    }
    void restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }   
}
