 var speed : float = 8.0;
 var jumpspeed : float = 20.5;
 var gravity : float = 30.0;
 var moveDirection : Vector3 = Vector3.zero; 

 function Update(){
	var controller : CharacterController =  GetComponent.<CharacterController>();
	if (controller.isGrounded){
		moveDirection = Vector3 (0,0,Input.GetAxis("Horizontal")+3);
		moveDirection = transform.TransformDirection(moveDirection);
		moveDirection *= speed;

		if(Input.GetButtonDown("Jump")){
			moveDirection.y += jumpspeed;
		}
	}
	else{
		if(Input.GetButtonDown("Jump")){
			moveDirection.y += jumpspeed;
		}
	} 

	moveDirection.y -= gravity * Time.deltaTime;

	controller.Move( moveDirection * Time.deltaTime);
 }