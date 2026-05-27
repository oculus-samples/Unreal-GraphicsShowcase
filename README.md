# Graphics Showcase

<img src="graphicsShowcase.png">

Tone mapping is a key artistic tool for developers. Graphics Showcase uses a Vulkan subpass-based tone mapping solution that performs much better than traditional methods.

You can also play Graphics Showcase on the [Horizon Store](https://www.meta.com/experiences/graphics-showcase/5543894545665788/) as an APK.

## Clone the Project

Install Git Large File Support (LFS) before cloning. This project uses Git LFS to manage large local assets.
See [Git LFS installation options](https://github.com/git-lfs/git-lfs/wiki/Installation) for instructions.

```sh
git lfs install
```

**Note:** Direct download of this project is not supported.

## Setup

1. [Get access to the Unreal source code](https://www.unrealengine.com/en-US/ue-on-github).
2. [Clone the `oculus-5.6` branch of the Oculus fork](https://github.com/Oculus-VR/UnrealEngine/tree/oculus-5.6).
3. Clone this repository.
4. Open a command prompt and navigate to your UE5 directory.
5. Run:
   ```
   GenerateProjectFiles.bat <Full path to GraphicsShowcase.uproject> -Game
   ```
   Example:
   ```
   GenerateProjectFiles.bat D:\Unreal-GraphicsShowcase\GraphicsShowcase.uproject -Game
   ```
6. Open `GraphicsShowcase.sln` in the project directory.
7. Ensure GraphicsShowcase is the startup project (bold in Solution Explorer). If not, right-click it and select "Set as Startup Project."

## Controls

- **B** – Cycle effects (Day/Night cycle, Sepia LUT, Reddish LUT)
- **A** – Toggle tonemap subpass (off/on)
- **Right Trigger** – Toggle FFR (off/high)
- **Right Grip** – Toggle MSAA (1/2/4)
- **Right Stick Click** – Toggle headlock mode on/off for profiling

## License

This codebase serves as a reference and template for multiplayer VR games. All code and assets follow the license found [here](./LICENSE), unless otherwise noted.

## Contribution

See the [CONTRIBUTING](./CONTRIBUTING.md) file for contribution guidelines.

# More Info

Original blog post for the UE4 release:
[Vulkan Subpasses in UE4 for Performant Tone Mapping on Quest](https://developers.meta.com/horizon/blog/graphics-showcase-using-vulkan-subpasses-in-ue4-for-performant-tone-mapping-on-quest/)

# Updates

## 22 December 2025 Update

The project was updated to use OpenXR backend.

## 04 December 2025 Update

The project was updated to UE5.6.

## 20 December 2023 Update

The project was updated to UE5.3.

## Agent-ready development

This sample is configured for AI coding agents.

For the best experience in VS Code or Cursor, install the Meta Horizon extension:

https://marketplace.visualstudio.com/items?itemName=meta.meta-vr-dev

This repository also includes agent instructions and MCP configuration for Meta Quest Agentic Tools:

https://github.com/meta-quest/agentic-tools

Suggested first prompt:

```text
Read AGENTS.md, detect what type of Meta Quest sample this is, enable the hzdb MCP server if available, and explain how to build, run, and debug this sample on a Quest device.
```
