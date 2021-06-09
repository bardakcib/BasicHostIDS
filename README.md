# A Basic Host IDS
# Intrusion Detection System using MD5 Checksum and FileSystemWatcher

![](https://github.com/bardakcib/resources/blob/main/badges/built-with-love.svg)
![](https://github.com/bardakcib/resources/blob/main/badges/made-with-c-sharp.svg)
![](https://github.com/bardakcib/resources/blob/main/badges/vs.svg)
![](https://github.com/bardakcib/resources/blob/main/badges/csharp.svg)


## Specifications

* C# - .NET Framework 4.6.1
* WindowsForms Applications
* Md5 (System.Security.Cryptography)
* DataGridView
* FileSystemWatcher
* Not a commercial project. Just For Fun & Training


![](https://github.com/bardakcib/BasicHostIDS/blob/main/resources/HostIDS.gif)


## Main Screen
![](https://github.com/bardakcib/BasicHostIDS/blob/main/resources/MainPage.PNG)


In this project I have designed a basic IDS (Intrusion Detection System) which will recognize any modification to a file. We assume that the files can be modified by an attacker. The file can be in binary or text format.

The application may ask user to provide a folder name for scanning.

if any of the files of the target folder has been modified, application will give an alert like "changed" for the modified ones.
