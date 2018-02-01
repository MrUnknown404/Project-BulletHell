using UnityEngine;

public class GUIMoveToCamera : MonoBehaviour {
	
	private Camera cam;

	private void Start() {
		cam = GameObject.Find("Main Camera").GetComponent<Camera>();
	}

	private void Update() {
		transform.LookAt(transform.position + cam.transform.rotation * Vector3.back, cam.transform.rotation * Vector3.up);
	}
}
