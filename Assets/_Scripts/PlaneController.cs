using UnityEngine;
using System.Collections;

public class PlaneController : MonoBehaviour {

  
    private float _playerInput;
    private Transform _transform;
    private Vector2 _currentPosition;

    
    public float speed = 4f;

   
    void Start () {
        this._transform = gameObject.GetComponent<Transform>();
    }
    
    
    void Update () {

        this._currentPosition = this._transform.position;
        this._playerInput = Input.GetAxis("Horizontal");

        if (this._playerInput > 0)
        {
            this._currentPosition += new Vector2(this.speed, 0);
        }

        if (this._playerInput < 0)
        {
            this._currentPosition -= new Vector2(this.speed, 0);
        }
        this.CheckBounds();

        this._transform.position = this._currentPosition;        
    }

    private void CheckBounds()
    {
        if (this._currentPosition.x < -290)
        {
            this._currentPosition.x = -290;
        }
        if (this._currentPosition.x > 290)
        {
            this._currentPosition.x = 290;
        }
    }

}
