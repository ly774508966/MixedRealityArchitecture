using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {
	public GameObject model;
	public GameObject model1;
	public GameObject model2;
	public GameObject model3;
	public GameObject model4;
	public GameObject model5;
	// Use this for initialization
	IEnumerator Start () {
		yield return new WaitForSeconds(0.5f);
		model.SetActive (true);
		yield return new WaitForSeconds(0.5f);
		model1.SetActive (true);
		yield return new WaitForSeconds(0.5f);
		model2.SetActive (true);
		yield return new WaitForSeconds(0.5f);
		model3.SetActive (true);
		yield return new WaitForSeconds(0.5f);
		model4.SetActive (true);
		yield return new WaitForSeconds(0.5f);
		model5.SetActive (true);
		this.GetComponentInParent<Canvas>().enabled=false;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate (new Vector3(0,0,-5));

	}
}
