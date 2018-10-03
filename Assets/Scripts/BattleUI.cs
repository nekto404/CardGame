using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleUI : MonoBehaviour {

    public QueueUI QueueUI;
    public static BattleUI Instance;

    private int queueCount;
    
    public int GetQueueCount()
    {
        return queueCount;
    }

    public void InitQueueUI()
    {
        queueCount = QueueUI.GetImagesCount();
    }

    public void UpdateQueue(List<Character> characters)
    {
        QueueUI.Update(characters);
    }

    public void UpdateQueue(List<TurnData> turns)
    {
        var characters = new List<Character>();
        foreach (var turn in turns)
        {
            characters.Add(turn.Character);
        }
        QueueUI.Update(characters);
    }

    void Start () {
        if (Instance)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
            InitQueueUI();
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}


}
