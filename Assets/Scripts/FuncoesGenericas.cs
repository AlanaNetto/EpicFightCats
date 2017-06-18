using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FuncoesGenericas : MonoBehaviour {
    public static FuncoesGenericas instance;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);   
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void ChangeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

}
