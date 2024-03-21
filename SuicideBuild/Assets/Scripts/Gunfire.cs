using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunfire : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject muzzleFX;
    public Transform muzzlePoint;
    public GameObject bulletImpactDecal;

    public float FXduration = .2f;
    GameObject flashInstance;
    bool canFire = true;
    public bool isHeld;
    public AudioClip equip;
    public AudioClip fire;
    public AudioSource source;

    public bool debugMode;

    public void Start()
    {
        canFire = true;
    }

    private void Update()
    {
        //Remove Later, just for testing outside of VR
        if (debugMode && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Test Firing Gun");
            Fire();
        }
        if (debugMode && Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("Test Grabbing Gun");
            Select(!isHeld);
        }

        if (!isHeld) 
            canFire = false;
    }

    public void Select(bool state)
    {
        isHeld = state;
        canFire = state;

        if (state)
            PlayEquipSound();
    }

    public void Fire()
    {
        if (canFire)
        {

            PlayFireSound();
            Debug.Log("Firing Gun");

            var randomRot = Quaternion.Euler(muzzlePoint.rotation.eulerAngles.x, muzzlePoint.rotation.eulerAngles.y, Random.Range(0f, 359f));
            flashInstance = Instantiate(muzzleFX, muzzlePoint.position, randomRot);
            Instantiate(bulletPrefab, muzzlePoint.position, muzzlePoint.rotation);
            StartCoroutine(FireFX(FXduration));

            RaycastHit hit;
            if (Physics.Raycast(muzzlePoint.position, transform.forward, out hit, 100f))
            {
                var impact = Instantiate(bulletImpactDecal, hit.point, Quaternion.LookRotation(-hit.normal));
                Destroy(impact, 1f);
            }
        }
    }

    void PlayEquipSound()
    {
        var p = source.pitch;
        source.pitch = p + Random.Range(-2f, 2f);
        source.PlayOneShot(equip);
        source.pitch = p;
    }

    void PlayFireSound()
    {
        var p = source.pitch;
        source.pitch = p + Random.Range(-2f, 3f);
        source.PlayOneShot(fire, GetComponent<VolumeIn>().currentVolume);
        Debug.Log(GetComponent<VolumeIn>().currentVolume);
        source.pitch = p;
    }

    IEnumerator FireFX(float duration)
    {
        canFire = false;
        yield return new WaitForSeconds(duration);
        if(flashInstance != null)
            foreach(ParticleSystem p in flashInstance.GetComponentsInChildren<ParticleSystem>())
            {
                p.Stop();
            }

        canFire = true;
        Destroy(flashInstance);
    }
}
