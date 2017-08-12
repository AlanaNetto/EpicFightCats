using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public float velocidade;
    public static CameraController instance;
	// Use this for initialization
	void Awake () {
        if (!instance)
            instance = this;
        else
            Destroy(this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		if( velocidade > 0)
        {
            this.gameObject.transform.Translate(Vector2.up * Time.deltaTime * velocidade);
        }
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Camera Limit")
        {
            setSpeed(0);
        }
    }

    public void setSpeed(float v)
    {
        this.velocidade = v;
    }
}
