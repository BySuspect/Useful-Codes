public class GIFScript : MonoBehaviour
{
    public Texture2D[] frames;   // Array of frames to be played as GIF
    public float frameRate = 24f;   // Frame rate at which the GIF should be played
    public bool loop = true;   // Whether the GIF should loop or stop after playing once

    private Material material;   // Material used to display the frames
    private int currentFrame = 0;   // Index of the current frame being displayed

    private void Start()
    {
        // Create a render texture to render the frames onto
        RenderTexture renderTexture = new RenderTexture(frames[0].width, frames[0].height, 24, RenderTextureFormat.ARGB32);

        // Create a material using a transparent cutout shader and assign the render texture as its main texture
        material = new Material(Shader.Find("Unlit/Transparent Cutout"));
        material.SetFloat("_Cutoff", 0.5f);
        material.mainTexture = renderTexture;

        // Assign the material to the renderer of the object
        GetComponent<Renderer>().material = material;

        float frameTime = 1f / frameRate;   // Time duration of each frame
        int totalFrames = frames.Length;   // Total number of frames in the GIF

        // Render each frame onto the render texture
        for (int i = 0; i < totalFrames; i++)
        {
            Graphics.SetRenderTarget(renderTexture);
            Graphics.Blit(frames[i], renderTexture);
        }

        if (loop)
        {
            // If looping is enabled, invoke the "NextFrame" method repeatedly with the specified frame time
            InvokeRepeating("NextFrame", frameTime, frameTime);
        }
        else
        {
            // If looping is disabled, invoke the "StopAnimation" method after the GIF duration
            Invoke("StopAnimation", frameTime * totalFrames);
        }
    }

    private void Update()
    {
        // If looping is disabled and all frames have been played, stop the animation
        if (!loop && currentFrame >= frames.Length)
        {
            StopAnimation();
        }
    }

    private void NextFrame()
    {
        currentFrame++;

        // If the end of the GIF is reached and looping is enabled, restart from the first frame
        if (currentFrame >= frames.Length)
        {
            if (loop)
            {
                currentFrame = 0;
            }
            else
            {
                return;   // If looping is disabled, exit the method
            }
        }

        // Update the main texture of the material to the current frame
        material.mainTexture = frames[currentFrame];
    }

    private void StopAnimation()
    {
        // Cancel the invocation of the "NextFrame" method
        CancelInvoke("NextFrame");
    }
}
