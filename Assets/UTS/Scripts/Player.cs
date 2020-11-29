using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class Player : MonoBehaviour {

    CharacterController chara;

	void Start () {
        chara = GetComponent<CharacterController>();
	}
	
	void Update () {
        Move();
	}

    void Move()
    {
        float motionX = Input.GetAxis("Horizontal") * Time.deltaTime;
        float motionZ = Input.GetAxis("Vertical") * Time.deltaTime; ;

        Vector3 motion = new Vector3(motionX, 0f, motionZ);

        chara.Move(motion);
    }

    
}
