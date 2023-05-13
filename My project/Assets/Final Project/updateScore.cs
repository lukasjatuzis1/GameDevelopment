using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class updateScore : MonoBehaviour
{
    public int score = 0;
    public TMP_Text text;
    public GameObject[] ScoreObejct;

    private string scoreText;

    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Enemy")
        {
            score--;
            Debug.Log("Score:" + score);
            scoreText = "Score:" + score;
            text.text = scoreText;
        }
        else if(collision.gameObject.name == "Final")
        {
            if(score < 0)
            {
                text.text = "Score" + score + " Better Luck Next Time";
            }
            else if(score < 5)
            {
                text.text = "Score" + score + " Not Bad... For a Newbie";
            }
            else if (score < 9)
            {
                text.text = "Score" + score + " Good Work";
            }
            else if (score < 12)
            {
                text.text = "Score" + score + " Excellent!";
            }
            else
            {
                text.text = "Score" + score + " Perfection!";
            }
        }
        else
        {
            for (int i = 0; i < ScoreObejct.Length; i++)
            {
                if (collision.gameObject.name == ScoreObejct[i].name)
                {
                    score++;
                    Debug.Log("Score:" + score);
                    scoreText = "Score:" + score;
                    text.text = scoreText;
                    ScoreObejct[i].SetActive(false);
                    
                }
            }
        }


    }
}
