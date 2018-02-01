using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ReadText : MonoBehaviour 
{
    private CharacterDialog myDialog;

    private void Start() 
	{
        string s = File.ReadAllText("Assets/file1.txt",System.Text.Encoding.UTF8);
        print(s);
        s= s.Replace("/n", "");
        myDialog = JsonUtility.FromJson<CharacterDialog>(s);

        print(myDialog.dialog);
	}
}
