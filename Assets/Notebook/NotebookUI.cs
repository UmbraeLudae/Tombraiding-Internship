
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class NotebookUI : MonoBehaviour
{
    private int pageIndex;
    public int PageIndex
    {
        get => pageIndex; set
        {
            pageIndex = value;
            UpdatePage();
        }
    }
    private PuzzleNote ActivePage => pageIndex >= 0 && pageIndex < Pages.Count ? Pages.Values[pageIndex] : null;

    private static SortedList<int, PuzzleNote> Pages = new();
    [SerializeField] private TMP_Text text;
    [SerializeField] private Button nextPage;
    [SerializeField] private Button previousPage;

    public static void AddPage(PuzzleNote note) => Pages[note.pageNuber] = note;

    void OnEnable()
    {        
        PageIndex = 0;
    }    

    public void NextPage()
    {
        if (text.pageToDisplay < text.textInfo.pageCount)
            text.pageToDisplay++;
        else if (PageIndex < Pages.Count) PageIndex++;
        UpdatePage();
    }

    public void PreviousPage()
    {
        if (text.pageToDisplay > 1)
            text.pageToDisplay--;
        else if (PageIndex > 0) PageIndex--;
        UpdatePage();
    }

    private void UpdatePage()
    {
        text.text = ActivePage?.tmpNoteText;
        var pages = text.GetTextInfo(ActivePage?.tmpNoteText).pageCount;
        nextPage.gameObject.SetActive((pageIndex < Pages.Count - 1) || (text.pageToDisplay < pages));
        previousPage.gameObject.SetActive(pageIndex > 0 || text.pageToDisplay > 1);
    }
}