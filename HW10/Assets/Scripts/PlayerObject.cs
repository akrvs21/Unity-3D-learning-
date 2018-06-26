using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerObject : NetworkBehaviour {

	// Use this for initialization
	void Start () {
        if(isLocalPlayer == false)
        {
            return;
        }

        CmdSpawnMyUnit();
       // Instantiate(PlayerUnitPrefab);


    }
    public GameObject PlayerUnitPrefab;
	// Update is called once per frame
	void Update () {
        if (isLocalPlayer == false)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            CmdSpawnMyUnit();
        } 
    }
    GameObject myPlayerUnit;

    [Command]
    void CmdSpawnMyUnit()
    {
        GameObject go = Instantiate(PlayerUnitPrefab);
        myPlayerUnit = go;
        //go.GetComponent<NetworkIdentity>().AssignClientAuthority(connectionToClient);
        NetworkServer.SpawnWithClientAuthority(go, connectionToClient);
    }

    [Command]
    void CmdMoveUnitUp()
    {
        if(myPlayerUnit == null)
        {
            return;
        }
        myPlayerUnit.transform.Translate(0, 1, 0);
    }
}
