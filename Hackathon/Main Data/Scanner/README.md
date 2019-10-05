# Webcam Barcode Reader

The sample demonstrates how to implement a simple C# barcode reader on Windows using [Touchless SDK][1] and [Dynamsoft Barcode Reader SDK][2] (DBR).
* **Touchless** is a free and open-source dotnet library for webcam.
* **Dynamsoft Barcode Reader** is a commercial dotnet library for reading barcode. 

![Windows barcode reader with webcam](http://www.codepool.biz/wp-content/uploads/2016/09/csharp-barcode-reader-webcam.PNG)

## Getting Started
1. Download [touchless][3].
2. Import the Project to **Visual Studio 2015**.
3. Add **DBR** to project via **Nuget**.

    ![install DBR via nuget](http://www.codepool.biz/wp-content/uploads/2016/09/nuget-install-dbr.PNG)
4. Add **TouchlessLib.dll** to reference.
5. Add **WebCamLib.dll** to project. Copy the dll to output directory when building the project.

    ![copy WebCamLib.dll](http://www.codepool.biz/wp-content/uploads/2016/09/webcamlib.PNG)
6. Build and run the project.

## Blog
[WinForm Barcode Reader with Webcam and C#][4]

[1]:http://touchless.codeplex.com/
[2]:http://www.dynamsoft.com/Products/Dynamic-Barcode-Reader.aspx
[3]:http://touchless.codeplex.com/releases/view/17986
[4]:http://www.codepool.biz/winform-barcode-reader-webcam-csharp.html
