using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Fireball : MonoBehaviour
{
    int Score;
    public TMP_Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Your score is: " + Score;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            Score += 100;
        }
    }
}
