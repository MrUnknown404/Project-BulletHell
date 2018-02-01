using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMotor : MonoBehaviour {

	public bool isMouseEnabled = true;

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
			Vector3 p = new Vector3();
			Camera c = Camera.main;

			Vector2 mousePos = new Vector2 {
				x = Input.mousePosition.x,
				y = c.pixelHeight - Input.mousePosition.y
			};

			p = c.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, c.nearClipPlane));

			float _mul = 81.75f;
			rb.MovePosition(new Vector3(p.x * _mul, 0f, -p.z * _mul));
		}
	}
}
