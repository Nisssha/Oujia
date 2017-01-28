using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panchette : MonoBehaviour {

private Vector3 letterPosition;
private Vector3 startPosition;
private float secondsForOneLength = 10f;
private string[] answer;
//	public float speed;
//	public float step;
//	string letter;

//	private Transform startMarker;
//    private Vector3 endMarker;
//    public float speed = 1.0F;
//    private float startTime;
//    private float journeyLength;
//
//    void Start() {
//
//    	startMarker = transform;
//		endMarker = new Vector3(-241f, -10f, 0f);
//        startTime = Time.time;
//        journeyLength = Vector3.Distance(startMarker.position, endMarker);
//    }
//    void Update() {
//        float distCovered = (Time.time - startTime) * speed;
//        float fracJourney = distCovered / journeyLength;
//        transform.position = Vector3.Lerp(startMarker.position, endMarker, fracJourney);
//    }
//
//

void Start () {
	startPosition = transform.position; 
	Debug.Log(startPosition);
//	letter = "a";
	MovePanchette("a");
}


void Update () {
//	MovePanchette("a");
for (int i = 0; i < answer.Length; i++){
if (answer[i] != ""){
	if (letterPosition != startPosition){
		transform.position = Vector3.Lerp(startPosition, letterPosition,     Mathf.SmoothStep(0f,1f, Time.time/secondsForOneLength));
		Debug.Log (transform.position);
	}
}
}
}



public void MovePanchette (string letter) { //for single letter, do for array later

	if(letter == "a"){letterPosition = new Vector3 (-7.38f, -0.08f, 90f);}
//	else if(letter == "b"){letterPosition = new Vector3 (-6.15f, -0.65f, 90f);}
//	else if(letter == "c"){letterPosition = new Vector3 (-5.07f, 1.05f, 90f);}
//	else if(letter == "d"){letterPosition = new Vector3 (-3.9f, 1.42f, 90f);}
//	else if(letter == "e"){letterPosition = new Vector3 (-2.73f, 1.64f, 90f);}
//	else if(letter == "f"){letterPosition = new Vector3 (-1.62f, 1.7f, 90f);}
//	else if(letter == "g"){letterPosition = new Vector3 (-0.45f, 1.82f, 90f);}
//	else if(letter == "h"){letterPosition = new Vector3 (0.94f, 1.76f, 90f);}
//	else if(letter == "i"){letterPosition = new Vector3 (1.96f, 1.67f, 90f);}
//	else if(letter == "j"){letterPosition = new Vector3 (2.82f, 1.48f, 90f);}
//	else if(letter == "k"){letterPosition = new Vector3 (4.14f, 1.26f, 90f);}
//	else if(letter == "l"){letterPosition = new Vector3 (5.46f, 0.83f, 90f);}
//	else if(letter == "m"){letterPosition = new Vector3 (6.54f, 0.31f, 90f);}
//	else if(letter == "n"){letterPosition = new Vector3 (-7.26f, -1.85f, 90f);}
//	else if(letter == "o"){letterPosition = new Vector3 (-6.21f, -1.23f, 90f);}
//	else if(letter == "p"){letterPosition = new Vector3 (-5.2f, -0.74f, 90f);}
//	else if(letter == "q"){letterPosition = new Vector3 (-4.09f, -0.34f, 90f);}
//	else if(letter == "r"){letterPosition = new Vector3 (-2.89f, -0.06f, 90f);}
//	else if(letter == "s"){letterPosition = new Vector3 (-1.6f, 0.25f, 90f);}
//	else if(letter == "t"){letterPosition = new Vector3 (-0.52f, 0.25f, 90f);}
//	else if(letter == "u"){letterPosition = new Vector3 (0.74f, 0.25f, 90f);}
//	else if(letter == "v"){letterPosition = new Vector3 (2f, 0.25f, 90f);}
//	else if(letter == "w"){letterPosition = new Vector3 (3.33f, -0.15f, 90f);}
//	else if(letter == "x"){letterPosition = new Vector3 (4.6f, -0.61f, 90f);}
//	else if(letter == "y"){letterPosition = new Vector3 (5.65f, -1.1f, 90f);}
//	else if(letter == "z"){letterPosition = new Vector3 (6.82f, -1.72f, 90f);}
//	else if(letter == "1"){letterPosition = new Vector3 (-5.35f, -2.67f, 90f);}
//	else if(letter == "2"){letterPosition = new Vector3 (-4.46f, -2.67f, 90f);}
//	else if(letter == "3"){letterPosition = new Vector3 (-3.35f, -2.67f, 90f);}
//	else if(letter == "4"){letterPosition = new Vector3 (-2.18f, -2.67f, 90f);}
//	else if(letter == "5"){letterPosition = new Vector3 (-1.01f, -2.67f, 90f);}
//	else if(letter == "6"){letterPosition = new Vector3 (0.19f, -2.67f, 90f);}
//	else if(letter == "7"){letterPosition = new Vector3 (1.27f, -2.67f, 90f);}
//	else if(letter == "8"){letterPosition = new Vector3 (2.41f, -2.67f, 90f);}
//	else if(letter == "9"){letterPosition = new Vector3 (3.55f, -2.67f, 90f);}
//	else if(letter == "0"){letterPosition = new Vector3 (4.75f, -2.67f, 90f);}
//	else if(letter == "+"){letterPosition = new Vector3 (-5.29f, 3.84f, 90f);}   //yes
//	else if(letter == "-"){letterPosition = new Vector3 (4.73f, 3.84f, 90f);}		//no
//	else if(letter == "/"){letterPosition = new Vector3 (-0.22f, -4.05f, 90f);}	//good bye

}
}



