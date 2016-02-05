using UnityEngine;
using System.Collections;

public class MonsterController : MonoBehaviour {


    //Public instance variables

    public float minHorizontalSpeed = 5f;
    public float maxHorizontalSpeed = 10f;
    public float minVerticalSpeed = -2f;
    public float maxVerticalSpeed = 2f;


    //Private Instace Variables
    private Vector2 _currentPosition;
    private Transform _transform;
    private float _horizontalSpeed;
    private float _verticalDrift;


    // Use this for initialization
    void Start()
    {
        //Make a reference with transform component
        this._transform = gameObject.GetComponent<Transform>();
        //Reset the FireBall sprite to the top
        this.Reset();
    }

    // Update is called once per frame
    void Update()
    {
        this._currentPosition = this._transform.position;
        this._currentPosition -= new Vector2(this._horizontalSpeed, this._verticalDrift);
        this._transform.position = this._currentPosition;
       /* if (this._currentPosition.x <= -300)
        {
            this.Reset();
        }*/
    }
    void Reset()
    {
        this._horizontalSpeed = Random.Range(this.minHorizontalSpeed, this.maxHorizontalSpeed);
        this._verticalDrift = Random.Range(this.minVerticalSpeed, this.maxVerticalSpeed);
        float yPosition = Random.Range(-160f, 160f);
        this._transform.position = new Vector2(320f, yPosition);
    }
}

