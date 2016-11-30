using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MainCamera : MonoBehaviour
{
	CatmullRomSpline _curve;
	Transform _tr;
	GameObject _cube, _capsule;
	CatmullRomSpline _curveCube, _curveCapsule;
	float _tCube, _tCapsule, _tCamera;

	CubeActor _cubeActor;
	CapsuleActor _capsuleActor;

	void Start()
	{
		_tr	 			= transform;
		_tCamera 		= 0f;
		_curve 			= gameObject.GetComponent<CatmullRomSpline>();

		_cubeActor		= GameObject.Find("Cube").GetComponent<CubeActor>();
		_capsuleActor 	= GameObject.Find("Capsule").GetComponent<CapsuleActor>();

	}
		
	void Update()
	{
		_cubeActor.MoveUpdate();

		_capsuleActor.MoveUpdate();

		_tCamera 		+= 0.1f*Time.deltaTime; _tCamera = _tCamera>1.0f ? 0 : _tCamera;
		_tr.position 	= _curve.GetSplinePosition(_tCamera);
		_tr.LookAt(Vector3.zero);
	}
}
