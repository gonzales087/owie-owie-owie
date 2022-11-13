using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconScript : MonoBehaviour
{
    public int iconNumber;
    public GameObject highlights;

    CheckUser checkUser;
    public GameObject checkU;

    void Start() {
        checkUser = checkU.GetComponent<CheckUser>();
    }

    void Update() {
        if(checkUser.userAvatar == iconNumber) {
            highlights.SetActive(true);
        } else {
            highlights.SetActive(false);
        }
    }
}
