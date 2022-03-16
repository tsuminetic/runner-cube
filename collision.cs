using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class collision : MonoBehaviour
{
    public playermovement move;
    public Transform player;
    public Text win;
    public Text lose;
    private void OnCollisionEnter(Collision col) {
        if (col.collider.tag=="obstacle"){
            move.enabled=false;
            lose.enabled=true;
            Invoke("restart",1.5f);
        } 
    }
    void restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }    
}
