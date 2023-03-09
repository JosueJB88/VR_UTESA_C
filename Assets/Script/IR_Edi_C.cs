using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IR_Edi_C : MonoBehaviour
{

    public Button BTNpr;
    // Start is called before the first frame update
   void Start()
	{
		BTNpr.onClick.AddListener(LVpreservativos);
	}

	void LVpreservativos()
	{

		SceneManager.LoadScene("VR_EDI_C");

	}
}

