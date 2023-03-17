
using System.Collections;
using TMPro;
using UnityEngine;

public class DialogueUI : MonoBehaviour
{
    private static DialogueUI instance;
    void Start()
    {
        gameObject.SetActive(false);
        instance = this;
    }

    private Coroutine activeConversationRoutine;
    private const int CHARS_PER_SECOND = 40;
    private const float LINE_DELAY = 1.5f;
    [SerializeField] private TMP_Text text;

    public static void ShowConversation(Conversation conversation)
    {
        instance?.StartConversationRoutine(conversation);
    }

    private void StartConversationRoutine(Conversation conversation)
    {
        if (activeConversationRoutine != null) StopCoroutine(activeConversationRoutine);
        gameObject.SetActive(false);
        if (conversation == null) return;
        if (conversation.pageUnlock != null) NotebookUI.AddPage(conversation.pageUnlock);
        gameObject.SetActive(true);
        activeConversationRoutine = StartCoroutine(ShowConversationRoutine(conversation));
    }

    private IEnumerator ShowConversationRoutine(Conversation conversation)
    {
        var charDelay = new WaitForSeconds(1f / CHARS_PER_SECOND);
        var lineDelay = new WaitForSeconds(LINE_DELAY);
        foreach (var line in conversation.tmpLines)
        {
            text.text = line;
            text.maxVisibleCharacters = 1;
            var visibleChars = text.GetTextInfo(line).characterCount;
            for (int i = 0; i < visibleChars; i++)
            {
                text.maxVisibleCharacters++;
                yield return charDelay;
            }
            yield return lineDelay;
        }
        gameObject.SetActive(false);
    }

}
