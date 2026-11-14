using UnityEngine;

public class RotateTarget : MonoBehaviour
{
    [Range(50f,500f)][SerializeField] private float maxRandom = 100;

    private float[] randomNums = new float[3];
    private void Start() => AddRandomValues(randomNums);
    private void Update() => transform.Rotate(new Vector3(randomNums[0], randomNums[1], randomNums[2]) * Time.deltaTime);

    private float[] AddRandomValues(float[] nums)
    {
        int length = nums.Length;
        for (int i = 0; i < length; i++)
            nums[i] = Random.Range(0, maxRandom);
        return nums;
    }
}
