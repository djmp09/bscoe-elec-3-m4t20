using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main : MonoBehaviour {

	void Awake(){
		DontDestroyOnLoad(gameObject);
	}

	void Start () {
		
	}

	void LoadGameScene(){
		SceneManager.LoadScene(1);
	}

	void Update () {
		if (Input.anyKeyDown && SceneManager.GetActiveScene().buildIndex == 0){
            SceneManager.LoadScene(1);
		}
	}
}
