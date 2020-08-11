# PowerBI REST API Sample

This sample project demonstrates how to use PowerBI with the .NET Core API as a data source.

## Running this sample
Open `./src/release` and find the folder with your operating system.
Start / Run `src.exe`. The webserver should bind to port: 5000-5001.

Open the PowerBI file in `./src/release/WeatherData.pbix` and click on "Update". Each time you request updated data from the PBI report the values should change.



## Manual project setup
Open the API source folder `./src` and run the following command:

```bash
dotnet build
dotnet run
```
If you need to complie the application for a different target plattform run this command:
```bash
dotnet publish --self-contained -o ./release/yourfolder -c release -r win7-x64
```
