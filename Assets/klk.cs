using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class klk : MonoBehaviour
{
    public static GameObject LocalPlayerInstance;
    public PhotonView pw;

    void Awake()
    {
        // #Important
        // used in GameManager.cs: we keep track of the localPlayer instance to prevent instantiation when levels are synchronized
        if (pw.IsMine)
        {
            klk.LocalPlayerInstance = this.gameObject;
        }
        // #Critical
        // we flag as don't destroy on load so that instance survives level synchronization, thus giving a seamless experience when levels load.
        DontDestroyOnLoad(this.gameObject);

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, 5) * Time.deltaTime);
        }
        
        
    }

}
