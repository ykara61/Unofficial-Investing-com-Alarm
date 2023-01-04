#  1.Objective

The aim of this repository is to retrieve real-time currency values from the **Investing.com** website and create an application that generates alerts based on this data.

<p>
    <img src="/Images/BothWindow.png" alt>
</p>

# 2. Why .NET/.NET Core for OBDII Interface

At this point in time, The .NET Core are widely adoped by a large community of enterprise developers. It paves way for use programming language like C# for making currency value alarm application. The enterprise developers can integrate this functionality into Console Application, Windows Application and Xamarin mobile applications etc.

# 3. Investing.com Website Currency Alarm (Unofficial)


## 3a. Development Environment
- Windows 10
- Visual Studio 2022 with latest updates

## 3b. Runtime Requirements
- .NET Runtime [(.NET 6)](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- Windows OS
- Suitable **investing.com** website link

## First Run

* Using the application is straightforward. On the first run, the combo box will be empty, meaning there are no linked instruments (currencies). To add the first instrument, click the "Add" button. A new form will appear where you can add a new instrument by entering a title and link.

<p>
    <img src="/Images/FirstRunAddNew.png" alt>
</p>


## Running The APP

When connection between pc and ELM327 has been succeed. You can run the executable file in debug directory. There are several start option in the application.
These options are:

<p>
    <img src="/Images/ELM327_NET6_CONSOLE_MAIN.png" alt>
</p>

- **Get available PIDs** - It scans vehicle OBDII port and gives you all available PID values names(*such as MonitorStatus,FreezeDTC, CalcEngineLoad, EngineCoolantTemp, EngineRPM, VehicleSpeed, IntakeAirTemperature etc.*) that is active in the vehicle CAN-BUS. You can also see all OBDII PID values in [this wikipedia page](https://en.wikipedia.org/wiki/OBD-II_PIDs). All known PID values stored in "Resources" folder as json file in the solution.
- **Get Current Vehicle Data** - This option writes some significant real time vehicle data that contains *Engine rpm, Vehicle Speed* and *Fuel level*. These values will be printed until user terminates the console application.
- **Free Mode (Pre-Configured)** -  This option gives to availability to send any data you want to send to the Elm 327. All possible commands that is available in the web [Link](https://www.sparkfun.com/datasheets/Widgets/ELM327_AT_Commands.pdf)

<p>
    <img src="/Images/ELM327_ALL_MODES.png" alt>
    <em>Options Screenshots</em>
</p>

The complete .NET project source for the publisher is available under the Dotnetcoresamples folder in this repository.

Run the application using 'dotnet run' and you should see messages consumed by the dotnetcore

