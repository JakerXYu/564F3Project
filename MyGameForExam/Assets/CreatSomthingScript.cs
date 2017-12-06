using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CreatSomthingScript : MonoBehaviour {
    [SerializeField] InputField Xinshoujihao;
    [SerializeField] InputField XinMiMa;
    [SerializeField] InputField YanZhengMa;
    [SerializeField] GameObject AnothorPlane;
    [SerializeField] GameObject ThisPlane;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void StartToZhuce() {

    }
    public void GoBack() {
        ThisPlane.SetActive(true);
        AnothorPlane .SetActive(false);

    }
}
