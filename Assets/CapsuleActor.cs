using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CapsuleActor : MonoBehaviour
{
	CatmullRomSpline _curve;
	float _tCapsule = 0f;

	void Start()
	{
		_curve 			= gameObject.GetComponent<CatmullRomSpline>();
	}

	public void MoveUpdate()
	{
		_tCapsule 		+= 0.1f*Time.deltaTime; _tCapsule = _tCapsule>1.0f ? 0 : _tCapsule;
		gameObject.transform.position = _curve.GetSplinePosition(_tCapsule);
	}

	/*
	void Update()
	{
		_tCapsule 		+= 0.1f*Time.deltaTime; _tCapsule = _tCapsule>1.0f ? 0 : _tCapsule;
		gameObject.transform.position = _curve.GetSplinePosition(_tCapsule);
	}
	*/
}
