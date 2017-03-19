using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class NetworkingStalking : NetworkManager {

public Text ip;
public InputField serverIp;
public Text message;
public InputField messageInput;
private GameObject[] serverObjects;
private Panchette panchette;

    //Display ip address of the device
	void Start ()
    {
		var ipaddress = Network.player.ipAddress;
		ip.text = "Server IP address: " +ipaddress;

		networkAddress = ipaddress;
	}

    //start server
	public void MyStartHost()
    {
		StartServer();
		panchette = GameObject.FindObjectOfType<Panchette>();
	}

    //start client and disable all objects tagged as server
	public void MyStartClient()
    {
		networkAddress = serverIp.text;
		StartClient();
		serverObjects = GameObject.FindGameObjectsWithTag("Server");

		foreach (GameObject clientObject in serverObjects)
        {
			clientObject.SetActive(false);
		}
	}

    
	public void SentMessage (string message)
    {
	    short myMsgType = 444;

	    NetworkWriter writer = new NetworkWriter();
	    writer.StartMessage(myMsgType);
	    writer.Write("message");
        writer.FinishMessage();
	}

}
