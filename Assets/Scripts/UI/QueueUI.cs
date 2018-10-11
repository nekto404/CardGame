using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QueueUI : MonoBehaviour {

    public List<Image> Images;

    public int GetImagesCount()
    {
        return Images.Count;
    }

	public void Update(List<Character> characters)
    {
        var i = 0;
        foreach (var img in Images)
        {
            img.sprite = characters[i].Icon;
            i++;
        }
	}
}
