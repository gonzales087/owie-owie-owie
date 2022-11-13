using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckUser : MonoBehaviour
{
    private string input;
    Modules modules;
    public GameObject module;
    string username = "";
    public GameObject createUser;
    public int userAvatar;


    void Start(){
        modules = module.GetComponent<Modules>();
    }

    public void CheckUserButton() {
        if(username == ""){
            createUser.SetActive(true);
        }
        else{
            modules.LoadModules();
        }


    }

    public void ChooseAvatar(int num) {
        userAvatar = num;
    }

    public void ReadStringInput(string s)
    {
        input = s;
        Debug.Log(input);
    }

    public void ProceedToModules() {
        Debug.Log("Avatar Num: " + userAvatar);
        Debug.Log("User Name: " + input);
        
        modules.LoadModules();
    }
}
