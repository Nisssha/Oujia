using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panchette : MonoBehaviour {

private Vector3 letterPosition;
private Vector3 startPosition;
private Vector3 currentPosition;
private float secondsForOneLength = 5f; 
private char[] answer;
private float startTime;
int i = 0;

    public InputField input;
    public GameObject a, b, c, d, e, f ,g, h, iletter, j, k, l, m;
    public GameObject n, o, p, r, s, t, v, u, w, q, z, x, y;
    public GameObject n1, n2, n3, n4, n5, n6, n7, n8, n9, n0;
    public GameObject yes, no, goodbye;


void Start ()
    {
	startPosition = transform.position; 
	currentPosition = startPosition;
	letterPosition = currentPosition;
    }

void Update () {

        //handling situation where panchette reached goal position
        //sets new letter, adds to the i in the letter array and sets start position as current position
	if (letterPosition == currentPosition && answer.Length >i)
                                            {
											SetNextLetter(); 
											i++;
											startPosition = currentPosition;
											}

    //moving the letter smoothly from start position to goal (current letter) position
	if (letterPosition != currentPosition)
        {
		transform.position = Vector3.Lerp(startPosition, letterPosition,     Mathf.SmoothStep(0f,1f, (Time.time-startTime)/secondsForOneLength));
		currentPosition = transform.position;
	    }
}

    //set i to 0, and transform string answer into char array
public void SetAnswer ()
    {
	i = 0;
	answer = input.text.ToCharArray();
	input.text = "";
    }

    //setting goal position according to char in an array
public void SetNextLetter ()
    {
	    if(answer[i] == 'a'){letterPosition = a.transform.position;}
	    else if(answer[i] == 'b'){ letterPosition = b.transform.position; }
	    else if(answer[i] == 'c'){ letterPosition = c.transform.position; }
	    else if(answer[i] == 'd'){ letterPosition = d.transform.position; }
	    else if(answer[i] == 'e'){ letterPosition = e.transform.position; }
	    else if(answer[i] == 'f') { letterPosition = f.transform.position; }
	    else if(answer[i] == 'g') { letterPosition = g.transform.position; }
	    else if(answer[i] == 'h') { letterPosition = h.transform.position; }
	    else if(answer[i] == 'i') { letterPosition = iletter.transform.position; }
	    else if(answer[i] == 'j') { letterPosition = j.transform.position; }
	    else if(answer[i] == 'k') { letterPosition = k.transform.position; }
	    else if(answer[i] == 'l') { letterPosition = l.transform.position; }
	    else if(answer[i] == 'm') { letterPosition = m.transform.position; }
	    else if(answer[i] == 'n') { letterPosition = n.transform.position; }
	    else if(answer[i] == 'o') { letterPosition = o.transform.position; }
	    else if(answer[i] == 'p') { letterPosition = p.transform.position; }
	    else if(answer[i] == 'q') { letterPosition = q.transform.position; }
	    else if(answer[i] == 'r') { letterPosition = r.transform.position; }
	    else if(answer[i] == 's') { letterPosition = s.transform.position; }
	    else if(answer[i] == 't') { letterPosition = t.transform.position; }
	    else if(answer[i] == 'u') { letterPosition = u.transform.position; }
	    else if(answer[i] == 'v') { letterPosition = v.transform.position; }
	    else if(answer[i] == 'w') { letterPosition = w.transform.position; }
	    else if(answer[i] == 'x') { letterPosition = x.transform.position; }
	    else if(answer[i] == 'y') { letterPosition = y.transform.position; }
	    else if(answer[i] == 'z') { letterPosition = z.transform.position; }


        else if (answer[i] == 'A') { letterPosition = a.transform.position; }
        else if (answer[i] == 'B') { letterPosition = b.transform.position; }
        else if (answer[i] == 'C') { letterPosition = c.transform.position; }
        else if (answer[i] == 'D') { letterPosition = d.transform.position; }
        else if (answer[i] == 'E') { letterPosition = e.transform.position; }
        else if (answer[i] == 'F') { letterPosition = f.transform.position; }
        else if (answer[i] == 'G') { letterPosition = g.transform.position; }
        else if (answer[i] == 'H') { letterPosition = h.transform.position; }
        else if (answer[i] == 'I') { letterPosition = iletter.transform.position; }
        else if (answer[i] == 'J') { letterPosition = j.transform.position; }
        else if (answer[i] == 'K') { letterPosition = k.transform.position; }
        else if (answer[i] == 'L') { letterPosition = l.transform.position; }
        else if (answer[i] == 'M') { letterPosition = m.transform.position; }
        else if (answer[i] == 'N') { letterPosition = n.transform.position; }
        else if (answer[i] == 'O') { letterPosition = o.transform.position; }
        else if (answer[i] == 'P') { letterPosition = p.transform.position; }
        else if (answer[i] == 'Q') { letterPosition = q.transform.position; }
        else if (answer[i] == 'R') { letterPosition = r.transform.position; }
        else if (answer[i] == 'S') { letterPosition = s.transform.position; }
        else if (answer[i] == 'T') { letterPosition = t.transform.position; }
        else if (answer[i] == 'U') { letterPosition = u.transform.position; }
        else if (answer[i] == 'V') { letterPosition = v.transform.position; }
        else if (answer[i] == 'W') { letterPosition = w.transform.position; }
        else if (answer[i] == 'X') { letterPosition = x.transform.position; }
        else if (answer[i] == 'Y') { letterPosition = y.transform.position; }
        else if (answer[i] == 'Z') { letterPosition = z.transform.position; }


        else if(answer[i] == '1'){ letterPosition = n1.transform.position; }
	    else if(answer[i] == '2'){ letterPosition = n2.transform.position; }
	    else if(answer[i] == '3'){ letterPosition = n3.transform.position; }
	    else if(answer[i] == '4'){ letterPosition = n4.transform.position; }
	    else if(answer[i] == '5'){ letterPosition = n5.transform.position; }
	    else if(answer[i] == '6'){ letterPosition = n6.transform.position; }
	    else if(answer[i] == '7'){ letterPosition = n7.transform.position; }
	    else if(answer[i] == '8'){ letterPosition = n8.transform.position; }
	    else if(answer[i] == '9'){ letterPosition = n9.transform.position; }
	    else if(answer[i] == '0'){ letterPosition = n0.transform.position; }
	    else if(answer[i] == '+'){ letterPosition = yes.transform.position; }   //yes
	    else if(answer[i] == '-'){ letterPosition = no.transform.position; }		//no
	    else if(answer[i] == '/'){ letterPosition = goodbye.transform.position; }	//good bye

	    else if(answer[i] == ' '){letterPosition = currentPosition;}

        //setting start time of the movement
        startTime = Time.time;
    }
}




