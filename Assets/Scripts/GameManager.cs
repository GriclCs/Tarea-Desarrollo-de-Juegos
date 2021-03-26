using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject inputGOTarget;
    public Text inputScoreText;
    public GameObject inputWin;
    private int score=0;
    private bool win=false;
 
    void Start()
    {
        InvokeRepeating("SpawnAparecer",1f,1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (win==true){
            CancelInvoke("SpawnAparecer");
        }
    }

    void SpawnAparecer(){
        float randomX = Random.Range(-9.66f,9.66f);
        float randomY = Random.Range(-3.3f,-1.55f);
    Vector3 position = new Vector3 (randomX,randomY,0);
    Instantiate (inputGOTarget,position,Quaternion.identity);

    }
    public void IncrementScore(){
        score ++;
        inputScoreText.text = score.ToString();
        if(score>=10){
            inputWin.SetActive(true);
        }
    }
}
