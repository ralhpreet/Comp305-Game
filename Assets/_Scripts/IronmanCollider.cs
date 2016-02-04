using UnityEngine;
using System.Collections;

public class IronmanCollider : MonoBehaviour {
    //Private Instance Variables
    private AudioSource[] _audioSources;
    private AudioSource _fireBallSound;
    private AudioSource _heartSound;

	// Use this for initialization
	void Start () {
        //Initialize the audioSources array
        this._audioSources = gameObject.GetComponents<AudioSource>();
        this._fireBallSound = this._audioSources[1];
        this._heartSound = this._audioSources[2];
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnTriggerEnter2D(Collider2D ogo)
    {
        if (ogo.gameObject.CompareTag("FireBall"))
        {
            this._fireBallSound.Play();
        }
        if (ogo.gameObject.CompareTag("Heart"))
        {
            this._heartSound.Play();
        }
    }
}
