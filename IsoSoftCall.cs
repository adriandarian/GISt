using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class IsoSoftCall : MonoBehaviour {

    float time;

	// Use this for initialization
	void Start () {
       
    }

    // Update is called once per frame
    void Update ()
    {

    }

    public void call()
    {
        ServicePointManager.ServerCertificateValidationCallback = MyRemoteCertificateValidationCallback;
        var client = new WebClient { Credentials = new NetworkCredential("ou\\piapihack2018", "Go $ave energy, 2018!") };
        var response = client.DownloadString("https://ucd-piwebapi.ou.ad3.ucdavis.edu/piwebapi/streams/F1AbEbgZy4oKQ9kiBiZJTW7eugwl7C6TEsQ5RGlhJiQlqSuWwRt_Yb6VgR1YAj8G1RUyETgVVRJTC1BRlxDRUZTXFVDREFWSVNcQlVJTERJTkdTXFJNSSBCUkVXRVJZLCBXSU5FUlksIEFORCBGT09EIFBJTE9UIEZBQ0lMSVRZXEVMRUNUUklDSVRZfERFTUFORA/value");
        response = response.Substring(response.IndexOf("Value") + 7);
        response = response.Substring(0, 5);
        GameObject.Find("efficencyTxt").GetComponent<Text>().text = "Efficiency: " + response + "%";
        GameObject.Find("efficencyTxt").transform.parent.gameObject.GetComponent<Image>().color = new Color(1 - float.Parse(response) / 100f, float.Parse(response) / 100f, 0);

    }

    public bool MyRemoteCertificateValidationCallback(System.Object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
    {
        bool isOk = true;
        // If there are errors in the certificate chain, look at each error to determine the cause.
        if (sslPolicyErrors != SslPolicyErrors.None)
        {
            for (int i = 0; i < chain.ChainStatus.Length; i++)
            {
                if (chain.ChainStatus[i].Status != X509ChainStatusFlags.RevocationStatusUnknown)
                {
                    chain.ChainPolicy.RevocationFlag = X509RevocationFlag.EntireChain;
                    chain.ChainPolicy.RevocationMode = X509RevocationMode.Online;
                    chain.ChainPolicy.UrlRetrievalTimeout = new System.TimeSpan(0, 1, 0);
                    chain.ChainPolicy.VerificationFlags = X509VerificationFlags.AllFlags;
                    bool chainIsValid = chain.Build((X509Certificate2)certificate);
                    if (!chainIsValid)
                    {
                        isOk = false;
                    }
                }
            }
        }
        return isOk;
    }
}
