using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMotor : MonoBehaviour {

	public bool isMouseEnabled;

	private Vector3 velocity = Vector3.zero;
	
	private Rigidbody rb;

	private void Start() {
		rb = GetComponent<Rigidbody>();
	}

	private void FixedUpdate() {
		PerformMovement();
	}

	public void Move(Vector3 _velocity) {
		velocity = _velocity;
	}

	private void PerformMovement() {
		if (isMouseEnabled == false) {
			if (velocity != Vector3.zero) {
				rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
			}
		} else {
			Vector3 pos = new Vector3();
			Camera cam = Camera.main;

			Vector2 mousePos = new Vector2 {
				x = Input.mousePosition.x,
				y = cam.pixelHeight - Input.mousePosition.y
			};

			pos = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, cam.nearClipPlane));

			float _mul = 81.75f;
			rb.position = (new Vector3(pos.x * _mul, 0f, -pos.z * _mul));
		}
	}
}
