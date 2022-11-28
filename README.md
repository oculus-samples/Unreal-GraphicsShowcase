# Unreal Graphics Showcase for Meta Quest

<img src="graphicsShowcase.png">

Tone mapping is an important artistic tool for developers. Graphics Showcase features a Vulkan subpass-based tone mapping solution that is much more performant than traditional techniques.

Graphics Showcase is also available on [AppLab](https://www.oculus.com/experiences/quest/5543894545665788) as a playable apk.

**Engine**<br>
This project depends on the [Oculus fork of UE5](https://github.com/Oculus-VR/UnrealEngine/tree/oculus-5.0) as it requires engine changes not yet upstreamed to Epic. Follow [Epic's instructions](https://www.unrealengine.com/en-US/ue-on-github
) to get access to the engine repo.

**Setup**<br>
- Download the UE5 branch of Oculus fork linked above.
- Download this repo.
- Open command prompt and navigate to your UE5 directory. 
- Run: "GenerateProjectFiles.bat \<Full path to GraphicsShowcase.uproject\> -Game"
  - For example: "GenerateProjectFiles.bat D:\Unreal-GraphicsShowcase\GraphicsShowcase.uproject -Game"
- Open UE5.sln in the engine directory.
- You should see GraphicsShowcase listed in the solution explorer. Right click and set this as your startup project.


**Controls**
- B - Cycle through effects (Day / Night cycle, Sepia LUT, Reddish LUT)
- A - Toggle tonemap subpass (off / on)
- Right Trigger - Toggle FFR (off / high)
- Right Grip - Toggle MSAA (1/2/4)
- Right Stick Click - Toggle headlock mode on/off for profiling


**License**<br>
The Meta SDK License applies to this project and supporting material.

**More Info**<br>
Original blog post when this project was released for UE4.<br>
[Vulkan Subpasses in UE4 for Performant Tone Mapping on Quest](
https://developer.oculus.com/blog/graphics-showcase-using-vulkan-subpasses-in-ue4-for-performant-tone-mapping-on-quest/)