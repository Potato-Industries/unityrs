# unityrs

portable unity engine reverse shell (or unity engine game backdoor)

- multi-platform (Mono or IL2CPP)
- supports C# !!

https://medium.com/@Bank_Security/undetectable-c-c-reverse-shells-fab4c0ec4f15

**Setup**

https://unity3d.com/get-unity/download

- kali supports the linux editor appimage binary

**Proof of concept**

1. Import unityrs_dev.unitypackage to your unity project.
2. Edit domain/ip:port in the poc.cs file. 
3. Build to your target platform. (Linux, Windows)
4. Setup listener. (nc -lvp 8080)
5. Download/upload & execute your game!

<img width="579" alt="Screenshot 2019-11-28 at 04 34 35" src="https://user-images.githubusercontent.com/56988989/69777495-70007200-1198-11ea-846f-01f30e4b6592.png">

**Findings**

- bypasses AV (assuming you sign the binaries!)

<img width="1319" alt="Screenshot 2019-11-28 at 04 44 52" src="https://user-images.githubusercontent.com/56988989/69777829-db970f00-1199-11ea-86b0-61eabb8b8f32.png">

<img width="916" alt="Screenshot 2019-11-28 at 04 08 51" src="https://user-images.githubusercontent.com/56988989/69776595-ce2b5600-1194-11ea-88c9-29e3c0f39dad.png">

**Compile**

<img width="628" alt="Screenshot 2019-11-28 at 04 35 50" src="https://user-images.githubusercontent.com/56988989/69777531-99210280-1198-11ea-9997-dc060ce5450a.png">
<img width="1315" alt="Screenshot 2019-11-28 at 04 35 35" src="https://user-images.githubusercontent.com/56988989/69777532-99210280-1198-11ea-89e2-b623d851b96b.png">


**Limitations**

- total size 50MB. 

Enjoy~
