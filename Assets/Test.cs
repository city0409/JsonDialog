using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Test : MonoBehaviour 
{
    private CharacterDialog myDialog;

	private void Awake() 
	{
        myDialog = new global::CharacterDialog() { name = "Lucy", dialog = "hey,what's up!" };
        string myDialogJson = JsonUtility.ToJson(myDialog);
        FileStream f = new FileStream("Assets/file1.txt", FileMode.CreateNew, FileAccess.ReadWrite, FileShare.ReadWrite);

        var bytes = System.Text.Encoding.UTF8.GetBytes(myDialogJson);
        f.Write(bytes, 0, bytes.Length);
	}
}
