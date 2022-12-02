using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCColliderKS : MonoBehaviour
{
    [SerializeField] GameObject conScene5A;
    [SerializeField] GameObject conScene5B;
    [SerializeField] GameObject conScene5C;
    [SerializeField] GameObject conScene5D;
    [SerializeField] GameObject conSceneEndPD;
    public GameObject NoteButtonPD;

    [SerializeField] GameObject npcPD;
    [SerializeField] GameObject npcKF;
    [SerializeField] GameObject npcKS;

    private void Start()
    {
        conScene5A.SetActive(false);
        conScene5B.SetActive(false);
        conScene5C.SetActive(false);
        conScene5D.SetActive(false);
        conSceneEndPD.SetActive(false);
        NoteButtonPD.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            conScene5A.SetActive(true);
            conScene5B.SetActive(true);
            conScene5C.SetActive(true);
            conScene5D.SetActive(true);
            conSceneEndPD.SetActive(true);
            NoteButtonPD.SetActive(true);

            npcPD.SetActive(false);
            npcKF.SetActive(false);
            npcKS.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            conScene5A.SetActive(false);
            conScene5B.SetActive(false);
            conScene5C.SetActive(false);
            conScene5D.SetActive(false);
            conSceneEndPD.SetActive(false);
            NoteButtonPD.SetActive(false);

            npcPD.SetActive(false);
            npcKF.SetActive(false);
            npcKS.SetActive(false);
        }
    }
}
