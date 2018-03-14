using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemy_collision : MonoBehaviour {

    [SerializeField] ParticleSystem exp;
    [SerializeField] GameObject turret;
    [SerializeField] Text scoreText;
    [SerializeField] int health;
    [SerializeField] Text health_left;

    private int score;
    AudioSource exp_sound;

    void Start () {
        exp_sound = GetComponent<AudioSource>();
        scoreText.text = "Score: " + control.Global.score.ToString();
        health_left.text = "";
        health = 30;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnParticleCollision(GameObject other)
    {
        if(other.name == "Bullet")
        {
            exp.Play();
            if (!exp_sound.isPlaying) {
                exp_sound.Play();
                control.Global.score += 10;
                scoreText.text = "Score: " + control.Global.score.ToString();
            }
            health -= 10;
            health_left.text = "Health: " + health;
            if (health < 1)
            { 
                health_left.text = "";
                Destroy(turret, 1f);
            }
            
        }
    }
}
