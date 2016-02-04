using UnityEngine;
using System.Collections;

public class SpaceController : MonoBehaviour {
    //Public instance variables
    public float speed = 5f;
    //Private Instace Variables
    private Vector2 _currentPosition;
    Transform _transform;
	// Use this for initialization
	void Start () {
        //Make a reference with transform component
	    this._transform=gameObject.GetComponent<Transform>();
        //Reset the space sprite to the top
        this.Reset();
	}
	
	// Update is called once per frame
	void Update () {
        this._currentPosition = this._transform.position;
        this._currentPosition -= new Vector2(this.speed,0);
        this._transform.position = this._currentPosition;
        if (this._currentPosition.x <= -480)
        {
            this.Reset();
        }
	}
    void Reset()
    {
        this._transform.position = new Vector2(480f, 0);
    }
}
