
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerNotebookInput : MonoBehaviour, NotebookInput.INotebookActions
{
    [SerializeField] private NotebookUI notebookUI;
    NotebookInput InputActions;

    void Start()
    {
        InputActions = new();
        InputActions.Notebook.SetCallbacks(this);
        InputActions.Enable();
    }    

    public void OnOpenClose(InputAction.CallbackContext context)
    {
        notebookUI.gameObject.SetActive(!notebookUI.gameObject.activeSelf);
    }

    public void OnCyclePages(InputAction.CallbackContext context)
    {
        notebookUI.PageIndex += context.ReadValue<int>();
    }
}
