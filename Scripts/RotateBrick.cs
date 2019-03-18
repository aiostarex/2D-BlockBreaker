using UnityEngine;
using System.Collections;

public class RotateBrick : MonoBehaviour {

	public int rotateType;
	public bool isRotatable=true;

	public bool AutoRandomize;
	private float rotateRandomizeVal;
	public int randomMinimal;
	public int randomMaximal;



	// Use this for initialization
	void Start () {

		RandomizationTest();
	}
	
	// Update is called once per frame
	void Update () {
	
		RotateFunction();
			
	}

	void RandomizationTest()
	{
		if(AutoRandomize == true)
		{
			rotateRandomizeVal = Random.Range(0,500);
		}
		
		if(AutoRandomize == false)
		{
			rotateRandomizeVal = Random.Range(randomMinimal,randomMaximal);
		}
	}


	void RotateFunction()
	{
		
		if(isRotatable==true)
		{
			
			this.transform.Rotate(new Vector3(0,0,rotateRandomizeVal));
			
		}
		
		if(isRotatable==false)
		{
			this.transform.Rotate(new Vector3(0,0,0));
			
		}
	}
}
