# unityrs

portable unity engine reverse shell (or unity engine game backdoor)

- multi-platform (mono or il2cpp)
- supports C# library

**Setup**

https://unity3d.com/get-unity/download

- kali supports the linux editor appimage binary

**Proof of concept**

1. Load example project from repo.
2. Edit script domain/ip:port (poc1.cs, poc2.cs as an example).
3. Build to your target platform.
4. Setup listener.
5. Download/upload & execute.

**Findings**

- bypasses AV (assuming you sign the binaries!)

<img width="916" alt="Screenshot 2019-11-28 at 04 08 51" src="https://user-images.githubusercontent.com/56988989/69776595-ce2b5600-1194-11ea-88c9-29e3c0f39dad.png">



**Limitations**

- total size 50MB. 

Enjoy~
