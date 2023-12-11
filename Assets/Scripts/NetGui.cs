using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class NetGui : MonoBehaviour
{

    NetworkManager nm;
    // Start is called before the first frame update
    void Start()
    {
        nm = GetComponent<NetworkManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartCl()
    {
        nm.StartClient();
    }

    public void StartSr()
    {
        nm.StartServer();
    }

    public void StartHs()
    {
        nm.StartHost();
    }

    public void ShDvn()
    {
        nm.Shutdown();
    }


}
