using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_collision : MonoBehaviour {

    [SerializeField] ParticleSystem exp;
    [SerializeField] GameObject turret;
    AudioSource exp_sound;

    void Start () {
        exp_sound = GetComponent<AudioSource>();
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
            }
            Destroy(turret, 1f);
        }
    }
}
