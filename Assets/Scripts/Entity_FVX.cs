using System.Collections;
using UnityEngine;

public class Entity_FVX : MonoBehaviour
{
    private Material originalMat;
    private SpriteRenderer sr;

    [SerializeField] private Material onDamageVfxMat;
    [SerializeField] private float onDamageVfxDuration = 0.15f;
    private Coroutine onDamageVfxCo;

    private void Awake()
    {
        sr = GetComponentInChildren<SpriteRenderer>();
        originalMat = sr.material;
    }

    public void PlayOnDamageVfx()
    {
        if(onDamageVfxCo != null)
        {
            StopCoroutine(onDamageVfxCo);
        }
        onDamageVfxCo = StartCoroutine(OnDamageVfxCo());
    }

    private IEnumerator OnDamageVfxCo()
    {
        sr.material = onDamageVfxMat;
        yield return new WaitForSeconds(onDamageVfxDuration);
        sr.material = originalMat;
    }
}
