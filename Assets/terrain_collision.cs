using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class terrain_collision : MonoBehaviour {

    [SerializeField] ParticleSystem exp;
    AudioSource exp_sound;

    // Use this for initialization
    void Start () {
        exp_sound = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.name == "Gunship")
        {
            exp.Play();
            if (!exp_sound.isPlaying)
            {
                exp_sound.Play();
            }
            Invoke("restart", 1f);
        }
    }

    void restart()
    {
        SceneManager.LoadScene(1);
    }
}
