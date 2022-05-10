using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public Text txtUserCloneAmount;
    public GameObject objectToClone;
    public int CloneAmounts;
    GameObject Clon;
    

    public void MultiInstantiate()
    {
        CloneAmounts = int.Parse(txtUserCloneAmount.text);
        for(int i = 0; i<CloneAmounts;i++)
        {
            Clon = Instantiate(objectToClone);
            Destroy(Clon, 1);
        }
    }
}
