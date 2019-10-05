using UnityEngine;
using System.Collections;

public class OceanController : MonoBehaviour {

	
	private Transform _transform;
	private Vector2 _currentPosition;

	
	public float speed = 5f;

	
	void Start () {
		
		this._transform = gameObject.GetComponent<Transform>();

		
		this.Reset();
	}
	
	
	void Update () {
		this._currentPosition = this._transform.position;
		this._currentPosition -= new Vector2(0, speed);
		this._transform.position = this._currentPosition;

		if (this._currentPosition.y <= -480) { Reset();}
	}

	void Reset() {
		this._transform.position = new Vector2(0, 480f);
	}
}
