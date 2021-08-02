using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour
{
    public int score;
    [SerializeField] Text scoreText;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bonus")
        {
        Destroy(other.gameObject);
        score ++;
         }

        if(other.gameObject.tag == "Enemy")
        {
            PlayerPrefs.SetInt("Score", score);
            SceneManager.LoadScene(2);
        }
    }


    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }
}
