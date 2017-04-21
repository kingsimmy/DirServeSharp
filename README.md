# DirServeSharp
.Net Core webserver for serving static files in a specified directory. This uses the [Kestrel](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/servers/#kestrel) web server developed by Microsoft.

It can be built as a self contained application so that it .Net Core is bundled up with the deployment and then it can run on a computer without having to install .Net Core.

To run:<br>
`DirServeSharp.CommandLine.exe <directory to serve>`

e.g. 
`C:\Software\DirServe>DirServeSharp.CommandLine.exe "C:\web"`

To build for Windows 10:<br>
`dotnet publish -c Release -r win10-x64`

e.g.
`C:\src\DirServeSharp\DirServeSharp.CommandLine>dotnet publish -c Release -r win10-x64`
