using UnityEngine;
using System.Collections.Generic;

public class ModelsTemplates
{
    public List<float> LineAngles;
    public List<Vector3> LineVectors;

    public List<float> CircleAngles;
    public List<Vector3> CircleVectors;

    public List<float> VerticalLineAngels;
    public List<Vector3> VerticalLineVectors;

    public List<List<Vector3>> allModels;
    public List<string> allModelNames;

    public ModelsTemplates()
    {

        LineAngles = new List<float> { 0.675796f, 0.6252628f, 0.5588315f, 0.5757331f, 0.6708556f, -0.02797646f, 1.689918f, 1.09593f, 3.265727f, 3.351469f, 6.31671f, 13.49544f, 32.51214f, 66.80853f, 12.07325f, 11.86812f, 5.038357f, 2.639972f, 0.826142f, 0.8724523f, 0.651921f, 0.6205508f, 0.5341251f, 0.3769049f, 0.6608641f, 0.9835745f };
        LineVectors = new List<Vector3> { new Vector3(0.3f, 0.0f, -0.2f), new Vector3(0.8f, 0.0f, 0.0f), new Vector3(0.8f, 0.0f, 0.0f), new Vector3(0.5f, 0.0f, 0.0f), new Vector3(0.9f, 0.0f, 0.0f), new Vector3(0.5f, 0.0f, 0.0f), new Vector3(0.8f, 0.0f, 0.0f), new Vector3(0.5f, 0.0f, 0.0f), new Vector3(0.6f, 0.0f, 0.0f), new Vector3(0.4f, 0.0f, 0.0f), new Vector3(0.4f, 0.0f, 0.0f), new Vector3(0.5f, 0.0f, 0.0f), new Vector3(0.6f, 0.0f, 0.0f), new Vector3(0.3f, 0.0f, 0.0f), new Vector3(0.5f, 0.0f, 0.0f), new Vector3(0.4f, 0.0f, 0.0f), new Vector3(0.7f, 0.0f, 0.0f), new Vector3(0.5f, 0.0f, 0.0f), new Vector3(0.5f, 0.0f, 0.0f), new Vector3(0.3f, 0.0f, 0.0f), new Vector3(0.3f, 0.0f, 0.0f), new Vector3(0.3f, 0.0f, 0.0f), new Vector3(0.3f, 0.0f, 0.0f), new Vector3(0.3f, 0.0f, 0.0f), new Vector3(0.3f, 0.0f, 0.0f), new Vector3(0.3f, 0.0f, 0.0f), new Vector3(0.2f, 0.0f, 0.2f) };

        CircleAngles = new List<float> { 20.7857f, 9.458684f, 11.80408f, 12.84299f, 15.22226f, 8.214847f, 17.43767f, 13.55442f, 7.678795f, 15.90648f, 16.18133f, 23.39494f, 10.31666f, 15.57501f, 13.32035f, 19.52355f, 16.0733f, 15.29805f, 10.89488f, 17.71209f, 10.72503f, 15.78802f, 8.783958f, -8.683332f, -9.81464f, 15.28768f };
        CircleVectors = new List<Vector3> { new Vector3(1.0f, -0.2f, 0.0f), new Vector3(0.5f, -0.1f, 0.0f), new Vector3(0.8f, -0.1f, 0.0f), new Vector3(0.9f, 0.1f, 0.0f), new Vector3(0.9f, 0.6f, 0.0f), new Vector3(0.2f, 0.6f, 0.0f), new Vector3(0.0f, 1.2f, 0.0f), new Vector3(-0.4f, 0.8f, 0.0f), new Vector3(-0.3f, 0.4f, 0.0f), new Vector3(-0.5f, 0.6f, 0.0f), new Vector3(-0.6f, 0.5f, 0.0f), new Vector3(-0.9f, 0.5f, 0.0f), new Vector3(-0.4f, 0.1f, 0.0f), new Vector3(-0.6f, 0.0f, 0.0f), new Vector3(-0.6f, 0.0f, 0.0f), new Vector3(-0.8f, -0.3f, 0.0f), new Vector3(-0.6f, -0.4f, 0.0f), new Vector3(-0.5f, -0.6f, 0.0f), new Vector3(-0.2f, -0.5f, 0.0f), new Vector3(-0.2f, -0.9f, 0.0f), new Vector3(0.0f, -0.6f, 0.0f), new Vector3(0.2f, -0.8f, 0.0f), new Vector3(0.3f, -0.4f, 0.0f), new Vector3(0.2f, -0.1f, 0.4f), new Vector3(0.4f, -0.3f, 0.0f), new Vector3(0.7f, -0.1f, -0.4f) };

        VerticalLineAngels = new List<float> { -1.691654f, -2.921412f, -4.382399f, -2.052331f, -4.631935f, -2.445206f, -6.23228f, -9.528028f, -7.450639f, -12.99587f, -14.6086f, -32.40837f, -16.59005f, -8.295146f, -12.6595f, -9.085256f, -6.139066f, -3.96393f, -3.756766f, -1.900737f, -2.567198f, -0.8194832f, -0.3189811f, -0.6434618f, -0.1735894f };
        VerticalLineVectors = new List<Vector3> { new Vector3(0.0f, -0.4f, 0.0f), new Vector3(0.1f, -0.4f, 0.0f), new Vector3(0.1f, -0.3f, 0.0f), new Vector3(0.0f, -0.3f, 0.0f), new Vector3(0.1f, -0.3f, 0.0f), new Vector3(0.0f, -0.2f, 0.0f), new Vector3(0.0f, -0.3f, 0.0f), new Vector3(0.0f, -0.3f, 0.0f), new Vector3(0.0f, -0.2f, 0.0f), new Vector3(0.0f, -0.3f, 0.0f), new Vector3(0.0f, -0.3f, 0.0f), new Vector3(0.0f, -0.5f, 0.0f), new Vector3(0.0f, -0.3f, 0.0f), new Vector3(0.0f, -0.2f, 0.0f), new Vector3(0.0f, -0.5f, 0.0f), new Vector3(-0.1f, -0.5f, 0.0f), new Vector3(-0.1f, -0.5f, 0.0f), new Vector3(-0.1f, -0.4f, 0.0f), new Vector3(-0.1f, -0.4f, 0.0f), new Vector3(0.0f, -0.5f, 0.0f), new Vector3(-0.1f, -0.5f, 0.0f), new Vector3(0.0f, -0.2f, 0.0f), new Vector3(0.0f, -0.3f, 0.0f), new Vector3(0.0f, -0.2f, 0.0f), new Vector3(0.0f, -0.2f, 0.0f) };

        allModels= new List<List<Vector3>> {LineVectors, CircleVectors, VerticalLineVectors};
        allModelNames = new List<string> { "Horizontal Line", "Circle", "Vertical Line"};
    }
}