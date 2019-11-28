# unityrs

portable unity engine reverse shell (or unity engine game backdoor)

- multi-platform (mono or il2cpp)
- supports C# !! (https://medium.com/@Bank_Security/undetectable-c-c-reverse-shells-fab4c0ec4f15)

**Setup**

https://unity3d.com/get-unity/download

- kali supports the linux editor appimage binary

**Proof of concept**

1. Import unityrs_dev.unitypackage to your unity project.
2. Edit script domain/ip:port in the poc.cs file. 
3. Build to your target platform.
4. Setup listener. (nc -lvp 8080)
5. Download/upload & execute your game!

**Findings**

- bypasses AV (assuming you sign the binaries!)

<img width="916" alt="Screenshot 2019-11-28 at 04 08 51" src="https://user-images.githubusercontent.com/56988989/69776595-ce2b5600-1194-11ea-88c9-29e3c0f39dad.png">



**Limitations**

- total size 50MB. 

Enjoy~
