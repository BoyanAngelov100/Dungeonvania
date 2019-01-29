 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneStay : MonoBehaviour {

    int startingSceneIndex;

    private void Awake()
    {
        int numSceneStay = FindObjectsOfType<SceneStay>().Length;
        if (numSceneStay > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    // Use this for initialization
    void Start () {
        startingSceneIndex = SceneManager.GetActiveScene().buildIndex;
	}
	
	// Update is called once per frame
	void Update () {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex != startingSceneIndex)
        {
            Destroy(gameObject);
        }
	}
}
