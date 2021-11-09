using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverController : MonoBehaviour
{
	private bool Pushed = false;
	private bool isLeft = false;

	public GameObject Lever;
	
	
	
	private Animator animator;

	// Use this for initialization
	void Start()
	{
		
		animator = Lever.gameObject.GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update()
	{
		
		
		
		
	}
	public void ButtonClicked()
    {
		animator = Lever.gameObject.GetComponent<Animator>(); //Buttonで呼び出すときは必要なのかも

		animator.SetTrigger("LeverPushed");
		if (isLeft)
		{
			isLeft = false;

			//Add some behavior here.
		} else {
			isLeft = true;

			//Add some behavior here.
        }
		

		
	}
}
