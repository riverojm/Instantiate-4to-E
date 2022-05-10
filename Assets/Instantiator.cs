using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public Text txtUserCloneAmount;
    public GameObject objectToClone;
    public int CloneAmounts;
    

    public void MultiInstantiate()
    {
        CloneAmounts = int.Parse(txtUserCloneAmount.text);
        int counter = 0;
        while (counter < CloneAmounts)
        {
            Instantiate(objectToClone);
            counter++;
        }
    }
}
