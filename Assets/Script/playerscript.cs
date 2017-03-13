using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour {
	Vector3 m_Position;
	private LineRenderer mouseLine;
	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
		LineSetting ();
		if (Input.GetMouseButton (0)) {
			m_Position = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			m_Position.z = 0;
			gameObject.transform.position = m_Position;
		} else if (Input.GetMouseButtonUp (0)) {
			gameObject.transform.position = Vector2.zero;
		}
	}

	void LineSetting()
	{
		mouseLine = GetComponent<LineRenderer> ();
		mouseLine.startColor = Color.red;
		mouseLine.startWidth = 0.1f;
		mouseLine.SetPosition(0, Vector2.zero);//0 : start position & 1 : end position
		mouseLine.SetPosition(1, gameObject.transform.position);
		mouseLine.useWorldSpace = true;
	}
}