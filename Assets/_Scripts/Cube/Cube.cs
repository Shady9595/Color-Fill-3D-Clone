//Shady
using UnityEngine;
using DG.Tweening;
using Sirenix.OdinInspector;

[HideMonoScript]
public class Cube : MonoBehaviour
{
    [Title("CUBE", null, titleAlignment: TitleAlignments.Centered)]
    [DisplayAsString]
    public bool IsFilled  = false;
    [DisplayAsString]
    public bool CanHarm = false;

    public void ResetCube()
    {   
        IsFilled = false;
        CanHarm  = false;
        transform.localPosition = Vector3.zero;
        gameObject.SetActive(false);
    }//ResetCube() end  

    public void Init(Vector3 pos, bool isFilled = false)
    {
        transform.position = pos;
        IsFilled = isFilled;
        gameObject.SetActive(true);
    }//Init() end

    public void FillCube()
    {
        if(!gameObject.activeSelf || IsFilled)
            return;
        IsFilled = true;
        GridManager.Instance.ChangeValue(transform.position.x, transform.position.z);
        transform.DOMoveY((transform.position.y + 0.5f), 0.15f);
    }//FilCube() end

}//class end