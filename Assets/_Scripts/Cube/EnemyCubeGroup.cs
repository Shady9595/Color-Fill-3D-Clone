//Shady
using UnityEngine;
using Sirenix.OdinInspector;

[HideMonoScript]
public class EnemyCubeGroup : MonoBehaviour
{
    [Title("ENEMY CUBE GROUP", null, titleAlignment: TitleAlignments.Centered)]
    [SerializeField] EnemyCube[] Cubes = null;
    [DisplayAsString]
    [SerializeField] int Detected = 0;

    private void Start() => Cubes = GetComponentsInChildren<EnemyCube>();

    public void Restart()
    {
        Detected = 0;
        gameObject.SetActive(true);
        for(int i=0 ; i<Cubes.Length ; i++)
            Cubes[i].gameObject.SetActive(true);
    }//Restart() end

    public void CubeDestroyed()
    {
        Detected++;
        if(Detected == Cubes.Length)
        {
            AudioManager.Instance?.PlaySFX(SFX.Impact);
            gameObject.SetActive(false);
        }//if end
    }//class end

}//class end