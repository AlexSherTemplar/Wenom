using UnityEngine;
using System.Collections;

public class Step : MonoBehaviour {
	
    private float speed = 6.0F;
	public float speedStep = 6.0f;
	public float speedShift = 9.0f;
    public float gravity = 20.0F;
	public float speedRotate = 4;

    private Vector3 moveDirection = Vector3.zero;
	
	// Анимации
	public AnimationClip a_Idle;
	public float a_IdleSpeed = 1;
	
	public AnimationClip a_Walk;
	public float a_WalkSpeed = 1;
	
	public AnimationClip a_Run;
	public float a_RunSpeed = 1;
	
	private string s_anim;
	
	private CharacterController controller;
	
	void Start () {
		/*GetComponent<Animation>()[a_Idle.name].speed = a_IdleSpeed;
		GetComponent<Animation>()[a_Walk.name].speed = a_WalkSpeed;
		GetComponent<Animation>()[a_Run.name].speed = a_RunSpeed;
		
		GetComponent<Animation>()[a_Idle.name].wrapMode = WrapMode.Loop;
		GetComponent<Animation>()[a_Walk.name].wrapMode = WrapMode.Loop;
		GetComponent<Animation>()[a_Run.name].wrapMode = WrapMode.Loop;
		
		s_anim = a_Idle.name;*/
		
		controller = GetComponent<CharacterController>();
	}
	
    void Update() {
		//GetComponent<Animation>().CrossFade(s_anim);
		
        if (controller.isGrounded) {
            moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;

			 transform.Rotate(0f, Input.GetAxis("Horizontal") * speed/2, 0f);

			if (Input.GetKey(KeyCode.LeftShift))
				speed = speedShift;
			else speed = speedStep;
			
			// Анимация ходьбы
			if(Input.GetAxis("Vertical") > 0) {
				if(speed == speedShift) {
					//s_anim = a_Run.name;
					//GetComponent<Animation>()[a_Run.name].speed = a_RunSpeed;
				} else {
					//s_anim = a_Walk.name;
					//GetComponent<Animation>()[a_Walk.name].speed = a_WalkSpeed;
				}
			} else 
			if(Input.GetAxis("Vertical") < 0) {
				if(speed == speedShift) {
					//s_anim = a_Run.name;
					//GetComponent<Animation>()[a_Run.name].speed = a_RunSpeed * -1;
				} else {
					//s_anim = a_Walk.name;
					//GetComponent<Animation>()[a_Walk.name].speed = a_WalkSpeed * -1;
				}
			} //else
			//if(Input.GetAxis("Vertical") == 0) 
				//s_anim = a_Idle.name;
			
			// Поворот

			//transform.Rotate(Vector3.down * speedRotate * Input.GetAxis("Horizontal") * -1, Space.World);
        }
		
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}