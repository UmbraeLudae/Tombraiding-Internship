
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [SerializeField] private Conversation conversation;
    private bool played = false;
    void OnTriggerEnter()
    {
        if (played) return;
        DialogueUI.ShowConversation(conversation);
        played = true;
    }
}
