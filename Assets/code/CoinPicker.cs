using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPicker : MonoBehaviour
{
    private AudioSource coinPickSound;
    private float coinpoints = 10f;
    private ScoreManager scoremanager;

    void Start()
    {
        coinPickSound = GameObject.Find("CoinPickSound").GetComponent<AudioSource>();
        scoremanager = FindObjectOfType<ScoreManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Runner")
        {
            gameObject.SetActive(false);
            if (coinPickSound.isPlaying)
            {

                coinPickSound.Stop();

            }
            coinPickSound.Play();
            scoremanager.score += coinpoints;
        }
    }

}